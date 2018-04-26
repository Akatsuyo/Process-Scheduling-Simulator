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
    public partial class ProcessSimulationRow : UserControl
    {
        public ProcessSimulationRow(int pid, string name, PCB.ProcessState state)
        {
            InitializeComponent();
            labelPID.Text = pid.ToString();
            labelName.Text = name;
            labelState.Text = state.ToString();
            ChangeBackgroundByState(state);
        }

        /// <summary>
        /// Changes layout by parameters
        /// </summary>
        /// <param name="state">Current state</param>
        /// <param name="progress">Current progress</param>
        /// <param name="ioProgress">Current I/O progress</param>
        public void UpdateData(PCB.ProcessState state, double progress, double ioProgress)
        {

            labelState.Text = state.ToString();
            progressBarProgress.Value = (int)(progress * 100);
            progressBarIO.Value = (int)(ioProgress * 100);
            ChangeBackgroundByState(state);
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