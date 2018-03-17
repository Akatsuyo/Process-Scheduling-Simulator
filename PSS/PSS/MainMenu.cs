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
        private static BindingList<Process> bPrList;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize process list
            bPrList = new BindingList<Process>();
            processData.DataSource = bPrList;

            // Get All Implemented IAlgorithms
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(y => typeof(IAlgorithm).IsAssignableFrom(y) && y.IsClass);

            algList.DataSource = types.ToArray();
            algList.DisplayMember = "Name";
        }

        private void buttonAddProcess_Click(object sender, EventArgs e)
        {
            // Open a new dialog for adding a process to the list
            ProcessDialog newProcessDialog = new ProcessDialog();
            DialogResult dialogResult = newProcessDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                bPrList.Add(newProcessDialog.GetProcess());
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
                    bPrList[bPrList.IndexOf(selected)] = editProcessDialog.GetProcess();
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
                    bPrList.Remove((Process)processGridView.SelectedRows[0].DataBoundItem);
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
            if (bPrList.Count == 0)
            {
                MessageBox.Show("Process list is empty!", "No processes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Open simulation form
                Simulation simulation = new Simulation(new Scheduler(
                    bPrList.ToList(),
                    (IAlgorithm)Activator.CreateInstance((Type)algList.SelectedItem),
                    simSpeed.Value));
                Hide();
                simulation.Show();
            }
        }
    }
}
