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
        public static BindingList<Process> processList;
        public static string selectedAlg;
        public static int selectedSpeed;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            processList = new BindingList<Process>();
            processData.DataSource = processList;

            MethodInfo[] methodInfo = typeof(Algorithm).GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Static);
            algList.DataSource = methodInfo.Select(x => x.Name).ToList();
        }

        private void buttonAddProcess_Click(object sender, EventArgs e)
        {
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
            selectedAlg = algList.SelectedItem.ToString();
            selectedSpeed = simSpeed.Value;

            Simulation simulation = new Simulation();
            Hide();
            simulation.Show();
        }
    }
}
