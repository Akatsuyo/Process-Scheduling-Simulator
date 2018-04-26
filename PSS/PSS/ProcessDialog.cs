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
            SwiftnessList.DataSource = Enum.GetValues(typeof(IO.Speed)).Cast<IO.Speed>();
            nameValue.Select();
        }

        // Returns a process with set values
        public Process GetProcess()
        {
            return new Process(nameValue.Text, (double)probabilityValue.Value / 100, (IO.Speed)SwiftnessList.SelectedIndex, (int)lengthValue.Value);
        }

        // Sets control's values based on a process
        public void SetProcess(Process process)
        {
            nameValue.Text = process.Name;
            probabilityValue.Value = (decimal)(process.IOProbability * 100);
            SwiftnessList.SelectedIndex = (int)process.IOSwiftness;
            lengthValue.Value = process.Length;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // Validate values, display error message
            ClearErrorLabels();
            bool error = false;
            if (nameValue.Text.Length < 2 || nameValue.Text.Length > 15)
            {
                nameError.Text = "Must be between 2 and 15!";
                error = true;
            }
            if (probabilityValue.Value < 1 || probabilityValue.Value > 100)
            {
                probabilityError.Text = "Must be between 1 and 100!";
                error = true;
            }
            if (lengthValue.Value <= 0)
            {
                lengthError.Text = "Must be greater than 0!";
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
            probabilityError.Text = "";
            swiftnessError.Text = "";
            lengthError.Text = "";
        }

        private void ProcessDialog_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //buttonOK_Click();
                MessageBox.Show("enter");
            }
            if (e.KeyCode == Keys.Escape)
            {
                //buttonOK_Click();
                MessageBox.Show("esc");
            }

        }
    }
}
