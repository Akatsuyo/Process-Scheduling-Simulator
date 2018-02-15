using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS
{
    public partial class PSS : Form
    {
        BindingList<Process> processList;

        public PSS()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            processList = new BindingList<Process>();
            processData.DataSource = processList;
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
            ProcessDialog editProcessDialog = new ProcessDialog();
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

        private void buttonDeleteProcess_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this process?", "Delete process", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK && processGridView.SelectedRows.Count > 0)
            {
                processList.Remove((Process)processGridView.SelectedRows[0].DataBoundItem);
            }
        }

        
    }
}
