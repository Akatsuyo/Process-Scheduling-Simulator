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
    public partial class ProcessDialog : Form
    {
        private bool editing;

        public ProcessDialog(bool edit = false)
        {
            InitializeComponent();
            editing = edit;
        }

        public Process GetProcess()
        {
            return new Process(nameValue.Text, (int)burstValue.Value, (int)arrivalValue.Value, (int)priorityValue.Value);
        }

        public void SetProcess(Process process)
        {
            nameValue.Text = process.Name;
            burstValue.Value = process.Burst;
            arrivalValue.Value = process.Arrival;
            priorityValue.Value = process.Priority;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            ClearErrorLabels();
            bool error = false;
            if (nameValue.Text == "")
            {
                nameError.Text = "Name cannot be empty!";
                error = true;
            }
            if (burstValue.Value < 1 || burstValue.Value > 100)
            {
                burstError.Text = "Must be between 1 and 100!";
                error = true;
            }
            if (arrivalValue.Value < 0 || arrivalValue.Value > 100)
            {
                arrivalError.Text = "Must be between 0 and 100!";
                error = true;
            }
            if (priorityValue.Value < 0 || priorityValue.Value > 100)
            {
                priorityError.Text = "Must be between 0 and 100!";
                error = true;
            }
            if (!error)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void ProcessDialog_Load(object sender, EventArgs e)
        {
            ClearErrorLabels();
        }

        private void ClearErrorLabels()
        {
            nameError.Text = "";
            burstError.Text = "";
            arrivalError.Text = "";
            priorityError.Text = "";
        }
    }
}
