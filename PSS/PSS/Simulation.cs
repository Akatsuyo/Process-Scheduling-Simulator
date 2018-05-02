using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;

namespace PSS
{
    public partial class Simulation : Form
    {
        private Scheduler scheduler;

        // Speed of the simulation
        private int speed;

        private bool running, formClosed;

        private Dictionary<int, ProcessSimulationRow> processes;

        public Simulation(Scheduler sch, int speed)
        {
            scheduler = sch;

            if (speed < 1 || speed > 1000)
            {
                throw new ArgumentException("Parameter must be between 1 and 1000", "Simulation Speed");
            }
            this.speed = speed;

            running = false;
            formClosed = false;

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

            // Add rows to ProcessViewPanel
            for (int i = 0; i < scheduler.ProcessCount; i++)
            {
                AddProcessToView(scheduler.ProcessAt(i));
            }

        }

        /// <summary>
        /// Adds process to the Process View Panel
        /// </summary>
        /// <param name="pcb">The pcb</param>
        private void AddProcessToView(PCB pcb)
        {
            ProcessSimulationRow psr = new ProcessSimulationRow(pcb)
            {
                Height = 30,
                //FlowLayout is tricky
                //Element width is determined by an element which has a width explicitly
                //In our case this is the Header or 'table'
                Anchor = (AnchorStyles.Left | AnchorStyles.Right)
            };

            processes.Add(pcb.PID, psr);

            processViewPanel.Controls.Add(psr);
        }

        // --------------- Buttons --------------- //

        private async void buttonStartSim_Click(object sender, EventArgs e)
        {
            if (running)
            {
                buttonStartSim.Text = "Resume";
                running = false;
            }
            else
            {
                buttonStartSim.Text = "Pause";
                buttonStopSim.Enabled = true;
                running = true;
                scheduler.Reset();

                await Simulate();
            }
            
        }

        private void buttonStopSim_Click(object sender, EventArgs e)
        {
            StopSimulation();
        }

        private void buttonAddProcess_Click(object sender, EventArgs e)
        {
            // Open a new dialog for adding a process to the list
            ProcessDialog newProcessDialog = new ProcessDialog();
            DialogResult dialogResult = newProcessDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                AddProcessToView(scheduler.AddAndEncapsulateProcess(newProcessDialog.GetProcess()));
            }
            newProcessDialog.Dispose();
        }

        // --------------------------------------- //


        private async Task Simulate()
        {
            // Simulation loop
            while (running)
            {
                // Stop simulation when done
                if (scheduler.Step())
                    StopSimulation();

                if (!formClosed)
                    UpdateUI();

                // Speed is x tick / sec
                await Task.Delay(1000 / speed);
            }
        }

        private void StopSimulation()
        {
            buttonStopSim.Enabled = false;
            buttonStartSim.Text = "Start";
            running = false;

            UpdateUI();
        }

        private void processViewPanel_SizeChanged(object sender, EventArgs e)
        {
            processHeadTable.Width = processViewPanel.ClientSize.Width;
        }

        private void Simulation_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Set the state to closing
            formClosed = true;

            // Stop simulation if running
            running = false;

            //If we added new processes to the list we need to push them back to the main menu as well
            ((MainMenu)Owner).ImportNewProcesses(scheduler.ProcessList.Select(x => x.Process).ToList());
            
            //Shows the main menu
            Owner.Show();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            //Exports the event log
            SaveFileDialog sfd = new SaveFileDialog()
            {
                FileName = "PSSLog_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".exp"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                scheduler.LogCurrentState();
                System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName);
                EventLogger.ExportTo(sw);
                sw.Close();
            }
        }

        private void UpdateUI()
        {
            // Update label async
            labelUtil.BeginInvoke((Action)(() =>
            {
                labelUtil.Text = running ? (Math.Round((double)scheduler.Worktime * 100 / 
                                                        scheduler.ElapsedTime).ToString() + "%") : "-";
            }));
            labelTurnaround.BeginInvoke((Action)(() =>
            {
                labelTurnaround.Text = scheduler.Turnaround.ToString();
            }));
            labelCurrTime.BeginInvoke((Action)(() =>
            {
                labelCurrTime.Text = scheduler.ElapsedTime.ToString();
            }));

            int fullLength = 0;
            int curr = 0;
            foreach (var pcb in scheduler.ProcessList)
            {
                fullLength += pcb.Process.Length;
                curr += pcb.Process.Progress;
            }

            labelCurrTime.BeginInvoke((Action)(() =>
            {
                labelCompletion.Text = Math.Round((double)curr * 100 / fullLength).ToString() + "%";
            }));

            // Sets dynamic parameters of processes in the list
            // Update process view
            foreach (KeyValuePair<int, ProcessSimulationRow> elem in processes)
            {
                PCB pcb = scheduler.GetProcessByID(elem.Key);
                elem.Value.UpdateData(pcb);
            }

            // Updates the Ready Queue label
            string readyQueueString = "";
            foreach (PCB process in scheduler.ReadyQueue)
            {
                readyQueueString += "P#";
                readyQueueString += process.PID.ToString();
                readyQueueString += " ";
            }

            labelrQueue.BeginInvoke((Action)(() =>
            {
                labelrQueue.Text = readyQueueString;
            }));
            
        }
    }
}
