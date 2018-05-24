using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS
{
    /// <summary>
    /// Process Settings Control
    /// </summary>
    public partial class ProcessSettings : UserControl
    {
        private bool error;

        /// <summary>
        /// Name of the process
        /// </summary>
        public string ProcessName
        {
            get
            {
                return nameValue.Text;
            }
            set
            {
                nameValue.Text = value;
                Evaluate();
            }
        }

        /// <summary>
        /// Length of the process
        /// </summary>
        public int Length
        {
            get
            {
                return (int) lengthValue.Value;
            }
            set
            {
                lengthValue.Value = value;
                Evaluate();
            }
        }

        /// <summary>
        /// I/O Probability of the process
        /// </summary>
        public double IOProbability
        {
            get
            {
                return (double) probabilityValue.Value / 100;
            }
            set
            {
                probabilityValue.Value = (decimal)(value * 100);
                Evaluate();
            }
        }

        /// <summary>
        /// I/O Probability of the process by percent
        /// </summary>
        public int IOProbabilityPercent
        {
            get
            {
                return (int) probabilityValue.Value;
            }
            set
            {
                probabilityValue.Value = value;
                Evaluate();
            }
        }

        /// <summary>
        /// I/O Swiftness of the process
        /// </summary>
        public IO.Speed IOSwiftness
        {
            get
            {
                return (IO.Speed) SwiftnessList.SelectedItem;
            }
            set
            {
                SwiftnessList.SelectedItem = value;
                Evaluate();
            }
        }

        /// <summary>
        /// Is settings are has any errors
        /// </summary>
        public bool Error
        {
            get
            {
                return error;
            }
        }

        /// <summary>
        /// Constructor of the process settings
        /// </summary>
        public ProcessSettings()
        {
            InitializeComponent();
            SwiftnessList.DataSource = Enum.GetValues(typeof(IO.Speed)).Cast<IO.Speed>();
            SwiftnessList.SelectedIndex = 1;
            error = false;
        }

        private void ClearErrorLabels()
        {
            error = false;
            nameError.Text = "";
            probabilityError.Text = "";
            swiftnessError.Text = "";
            lengthError.Text = "";
        }

        private void Evaluate()
        {
            ClearErrorLabels();
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
        }

        private void ProcessSettings_Load(object sender, EventArgs e)
        {
            ClearErrorLabels();
        }

        private void NameValue_Leave(object sender, EventArgs e)
        {
            Evaluate();
        }

        private void ProbabilityValue_Leave(object sender, EventArgs e)
        {
            Evaluate();
        }

        private void LengthValue_Leave(object sender, EventArgs e)
        {
            Evaluate();
        }

        private void SwiftnessList_Leave(object sender, EventArgs e)
        {
            Evaluate();
        }
    }
}
