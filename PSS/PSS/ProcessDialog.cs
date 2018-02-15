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
    }
}
