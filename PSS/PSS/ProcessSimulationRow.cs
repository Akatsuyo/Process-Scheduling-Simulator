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
    /// A row of the simulationdialog (a process)
    /// </summary>
    public partial class ProcessSimulationRow : UserControl
    {
        /// <summary>
        /// Constructor of the Control
        /// </summary>
        /// <param name="pcb"></param>
        public ProcessSimulationRow(PCB pcb)
        {
            InitializeComponent();
            labelPID.Text = pcb.PID.ToString();
            labelName.Text = pcb.Process.Name;
            labelState.Text = pcb.State.ToString();
            ChangeBackgroundByState(pcb.State);
        }

        /// <summary>
        /// Changes layout by a specified process
        /// </summary>
        /// <param name="pcb">Process which the layout should be based on</param>

        public void UpdateData(PCB pcb)
        {
            labelState.Text = pcb.State.ToString();
            progressBarProgress.Maximum = pcb.Process.Length;
            progressBarProgress.Value = pcb.Process.Progress;
            if (pcb.Process.CurrentIO != null)
            {
                progressBarIO.Maximum = pcb.Process.CurrentIO.Length;
                progressBarIO.Value = pcb.Process.CurrentIO.Progress;
            }
            else
            {
                progressBarIO.Value = 0;
            }
            ChangeBackgroundByState(pcb.State);
        }

        /// <summary>
        /// Change component background by current state
        /// </summary>
        /// <param name="state">Current state</param>
        private void ChangeBackgroundByState(PCB.ProcessState state)
        {
            switch(state)
            {
                case PCB.ProcessState.NEW:
                    this.BackColor = Color.DodgerBlue;
                    break;
                case PCB.ProcessState.WAITING:
                    this.BackColor = Color.Firebrick;
                    break;
                case PCB.ProcessState.RUNNING:
                    this.BackColor = Color.DarkSalmon;
                    break;
                case PCB.ProcessState.READY:
                    this.BackColor = Color.White;
                    break;
                case PCB.ProcessState.DEAD:
                    this.BackColor = Color.LimeGreen;
                    break;
            }
        }
    }
}