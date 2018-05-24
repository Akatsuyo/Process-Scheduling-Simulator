using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS
{
    /// <summary>
    /// About dialog (shows author, name, logo, etc.)
    /// </summary>
    public partial class AboutDialog : Form
    {
        /// <summary>
        /// Constructor of the class
        /// </summary>
        public AboutDialog()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/Akatsuyo/Process-Scheduling-Simulator");
            System.Diagnostics.Process.Start(sInfo);
        }
    }
}
