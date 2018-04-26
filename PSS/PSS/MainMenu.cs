using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace PSS
{
    public partial class MainMenu : Form
    {
        protected BindingList<Process> processList;

        public MainMenu()
        {
            InitializeComponent();
            labelSimSpeed.Text = simSpeed.Value.ToString();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Initialize process list
            processList = new BindingList<Process>();
            processData.DataSource = processList;

            // Get all implemented Algorithms
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(y => typeof(IAlgorithm).IsAssignableFrom(y) && y.IsClass);

            algList.DataSource = types.ToArray();
            algList.DisplayMember = "Name";
        }

        public void ImportNewProcesses(List<Process> toImport)
        {
            processList.Clear();
            toImport.ForEach(x => processList.Add(x));
        }

        // --------------- Buttons --------------- //

        private void buttonAddProcess_Click(object sender, EventArgs e)
        {
            // Open a new dialog for adding a process to the list
            ProcessDialog newProcessDialog = new ProcessDialog();
            DialogResult dialogResult = newProcessDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                processList.Add(newProcessDialog.GetProcess());
            }
            newProcessDialog.Dispose();
        }

        private void buttonEditProcess_Click(object sender, EventArgs e)
        {
            // Open a dialog for editing selected process
            if (processGridView.SelectedRows.Count > 0)
            {
                ProcessDialog editProcessDialog = new ProcessDialog(true);
                editProcessDialog.Text = "Edit Process";
                Process selected = (Process)processGridView.SelectedRows[0].DataBoundItem;
                editProcessDialog.SetProcess(selected);
                DialogResult dialogResult = editProcessDialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    processList[processList.IndexOf(selected)] = editProcessDialog.GetProcess();
                }
                editProcessDialog.Dispose();
            }
            else
            {
                MessageBox.Show("Select a process first!", "No process selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDeleteProcess_Click(object sender, EventArgs e)
        {
            // Delete selected process
            if (processGridView.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this process?", "Delete process", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    processList.Remove((Process)processGridView.SelectedRows[0].DataBoundItem);
                }
            }
            else
            {
                MessageBox.Show("Select a process first!", "No process selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonReady_Click(object sender, EventArgs e)
        {
            // Dont start with empty list
            if (processList.Count == 0)
            {
                MessageBox.Show("Process list is empty!", "No processes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //TODO Calibrate simSpeed
                // Make a scheduler class from the parameters
                Simulation simulation = new Simulation(new Scheduler(
                    processList.ToList(),
                    (IAlgorithm)Activator.CreateInstance((Type)algList.SelectedItem)), simSpeed.Value);

                //Hides the main menu
                Hide();
                //Shows the simulation
                simulation.Show(this);
            }
        }

        // --------------------------------------- //

        // Updates label below slider
        private void simSpeed_ValueChanged(object sender, EventArgs e)
        {
            labelSimSpeed.Text = simSpeed.Value.ToString();
        }
    }
}
