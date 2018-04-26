using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;

namespace PSS
{
    public partial class Simulation : Form
    {
        //Process list table
        TableLayoutPanel tlp;

        //Speed of the simulation
        private int speed;

        //Booleans of the simulation states
        private bool pauseSimulation, stopSimulation, atClosing;
        private Scheduler scheduler;

        private Dictionary<int, ProcessSimulationRow> processes;

        public Simulation(Scheduler sch, int speed)
        {
            scheduler = sch;

            if (speed <= 0 || speed > 1000)
            {
                throw new ArgumentException("Parameter must be between 1 and 500", "Simulation Speed");
            }

            this.speed = speed;
            processes = new Dictionary<int, ProcessSimulationRow>();

            InitializeComponent();
        }

        private void Simulation_Load(object sender, EventArgs e)
        {
            labelUtil.Text = "-";
            labelTurnaround.Text = "-";
            labelCurrTime.Text = "-";
            labelCompletion.Text = "-";
            labelrQueue.Text = "";

            //Add rows to ProcessViewPanel
            for (int i = 0; i < scheduler.ProcessCount; i++)
            {
                AddProcessToProcessViewPanel(scheduler.ProcessAt(i));
            }

        }

        /// <summary>
        /// Adds process to the Process View Panel
        /// </summary>
        /// <param name="process">The process</param>
        private void AddProcessToProcessViewPanel(PCB process)
        {
            ProcessSimulationRow psp = new ProcessSimulationRow(process.PID, process.Process.Name, process.State)
            {
                Height = 30,
                //FlowLayout is tricky
                //Element width is determined by an element which has a width explicitly
                //In our case this is the Header or 'table'
                Anchor = (AnchorStyles.Left | AnchorStyles.Right)
            };
            processes.Add(process.PID, psp);
            processViewPanel.Controls.Add(psp);
        }

        private void buttonStartSim_Click(object sender, EventArgs e)
        {
            scheduler.Reset();

            buttonStartSim.Enabled = false;
            buttonStopSim.Enabled = true;
            buttonPauseSim.Enabled = true;

            StartSimulation();

        }

        private void buttonPauseSim_Click(object sender, EventArgs e)
        {
            if (pauseSimulation)
            {
                buttonPauseSim.Text = "Pause";
                StartSimulation();
            }
            else
            {
                buttonPauseSim.Text = "Resume";
                PauseSimualtion();
            }
        }

        private void buttonStopSim_Click(object sender, EventArgs e)
        {
            StopSimulation();
        }

        private async void  StartSimulation()
        {
            pauseSimulation = false;
            stopSimulation = false;
            atClosing = false;
            while (true)
            {

                //If we have a paused simulation it breaks immidiately
                if (pauseSimulation)
                {
                    break;
                }

                bool done = false;

                //When we stop the simulation we need to update the UI
                if (stopSimulation)
                {
                    scheduler.Reset();
                }
                //We don't want to take the first step (start the simulation) when we reseted it
                else
                {
                    done = scheduler.Step();
                }

                //This is required because of the nature of async
                //If we update the UI after closing we get a sneaky little NullReferenceException
                if (!atClosing)
                {
                    // Update UI
                    //TODO This doesn't work
                    labelUtil.Text = (Math.Round((double)scheduler.Worktime / scheduler.ElapsedTime, 2) * 100).ToString() + "%";
                    //TODO This doesn't work
                    labelTurnaround.Text = scheduler.Turnaround.ToString();
                    labelCurrTime.Text = scheduler.ElapsedTime.ToString();

                    //Sets dynamic parameters of processes in the list
                    foreach (KeyValuePair<int, ProcessSimulationRow> elem in processes)
                    {
                        PCB pcb = scheduler.GetProcessByID(elem.Key);
                        elem.Value.UpdateData(pcb.State, pcb.Process.Progress, pcb.Process.IOProgress);
                    }

                    //Updates the Ready Queue label
                    string readyQueueString = "";
                    foreach (PCB process in scheduler.ReadyQueue)
                    {
                        readyQueueString += "P#";
                        readyQueueString += process.PID.ToString();
                        readyQueueString += " ";
                    }
                    labelrQueue.Text = readyQueueString;
                }

                //When we updated the UI we don't want to update once more so we break it
                if (stopSimulation)
                {
                    break;
                }

                //If the simulation is done we break it
                if (done)
                {
                    break;
                }
                //Speed is x tick / sec
                await Task.Delay(1000/speed);
            }

            //If this isn't a paused state (i.e. stop) we have to update the control buttons as well
            //On pause mode we update it differently
            if (!pauseSimulation)
            {
                buttonStartSim.Enabled = true;
                buttonStopSim.Enabled = false;
                buttonPauseSim.Enabled = false;
            }
        }

        private void PauseSimualtion()
        {
            pauseSimulation = true;
        }

        private void buttonAddProcess_Click(object sender, EventArgs e)
        {
            // Open a new dialog for adding a process to the list
            ProcessDialog newProcessDialog = new ProcessDialog();
            DialogResult dialogResult = newProcessDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                AddProcessToProcessViewPanel(scheduler.AddAndEncapsulateProcess(newProcessDialog.GetProcess()));
            }
            newProcessDialog.Dispose();
        }

        private void processViewPanel_SizeChanged(object sender, EventArgs e)
        {
            processHeadTable.Width = processViewPanel.ClientSize.Width;
        }

        private void StopSimulation()
        {
            stopSimulation = true;
        }

        private void Simulation_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Set the state to closing
            atClosing = true;

            //Stop the simulation (and reset it)
            StopSimulation();

            //If we added new processes to the list we need to push them back to the main menu as well
            BindingList<Process> processes = new BindingList<Process>();
            scheduler.ProcessList.ForEach(x => processes.Add(x.Process));
            ((MainMenu)Owner).ImportNewProcesses(processes);
            
            //Shows the main menu
            Owner.Show();
        }
    }
}
