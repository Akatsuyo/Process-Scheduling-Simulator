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
    /// <summary>
    /// Dialog for the process management
    /// </summary>
    public partial class ProcessDialog : Form
    {
        /// <summary>
        /// Constructor of the dialog
        /// </summary>
        public ProcessDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Returns a process with the values of the dialog
        /// </summary>
        /// <returns>Made process</returns>
        public Process GetProcess()
        {
            return new Process(
                processSettings.ProcessName,
                processSettings.IOProbability,
                processSettings.IOSwiftness,
                processSettings.Length);
        }

        private void ProcessDialog_Load(object sender, EventArgs e)
        {
            this.Icon = PSS.Properties.Resources.ApplicationIcon;
        }

        /// <summary>
        /// Sets the dialog values based on a process
        /// </summary>
        /// <param name="process">A process which the dialog values should be based on</param>
        public void SetProcess(Process process)
        {
            processSettings.ProcessName = process.Name;
            processSettings.IOProbability = process.IOProbability;
            processSettings.IOSwiftness = process.IOSwiftness;
            processSettings.Length = process.Length;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!processSettings.Error)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

    }
}
