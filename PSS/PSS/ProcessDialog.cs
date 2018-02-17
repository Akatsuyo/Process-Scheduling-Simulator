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
        public ProcessDialog()
        {
            InitializeComponent();
        }

        public Process GetProcess()
        {
            return new Process(idValue.Text, (int)burstValue.Value, (int)arrivalValue.Value);
        }

        public void SetProcess(Process process)
        {
            idValue.Text = process.ID;
            burstValue.Value = process.Burst;
            arrivalValue.Value = process.Arrival;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            ClearErrorLabels();
            bool error = false;
            if (idValue.Text == "")
            {
                idError.Text = "ID cannot be empty!";
                error = true;
            }
            else if (MainMenu.processList.Where(x => x.ID == idValue.Text).Count() != 0)
            {
                idError.Text = "This ID already exists!";
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
            idError.Text = "";
            burstError.Text = "";
            arrivalError.Text = "";
        }
    }
}
