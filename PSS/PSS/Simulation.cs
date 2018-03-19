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
    public partial class Simulation : Form
    {
        private static ProgressBar[] prBars;

        private static Scheduler scheduler;

        public Simulation(Scheduler sch)
        {
            scheduler = sch;

            InitializeComponent();
        }

        private void Simulation_Load(object sender, EventArgs e)
        {
            labelUtil.Text = "-";
            labelTurnaround.Text = "-";
            labelCurrTime.Text = "-";
            labelCompletion.Text = "-";
            labelrQueue.Text = "";

            // Process table
            TableLayoutPanel tlp = new TableLayoutPanel
            {
                ColumnCount = 5,
                RowCount = scheduler.ProcessCount + 1,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                Height = (scheduler.ProcessCount + 1) * 30
            };

            // Column styles
            for (int i = 0; i < 5; i++)
            {
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            }

            // Row styles
            for (int i = 0; i < scheduler.ProcessCount + 1; i++)
            {
                tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            }

            tableLayoutPanel1.Controls.Add(tlp, 3, 1);
            tableLayoutPanel1.SetRowSpan(tlp, 5);

            // Headers
            string[] headers = { "Name", "Burst", "Arrival", "Priority", "Progress" };
            Label[] headerLabels = new Label[headers.Length];
            for (int i = 0; i < headers.Length; i++)
            {
                headerLabels[i] = new Label
                {
                    Text = headers[i],
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = false,
                    Font = new Font("Microsoft Sans Serif", 12)
                };

                tlp.Controls.Add(headerLabels[i], i, 0);
            }

            // Data
            prBars = new ProgressBar[scheduler.ProcessCount];
            for (int i = 0; i < scheduler.ProcessCount; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    tlp.Controls.Add(new Label
                    {
                        Text = typeof(Process).GetProperty(headers[j]).GetValue(scheduler.ProcessAt(i)).ToString(),
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter,
                        AutoSize = false,
                    }, j, i + 1);
                }

                prBars[i] = new ProgressBar
                {
                    Height = 30,
                    Minimum = 0,
                    Step = 1,
                    Maximum = scheduler.ProcessAt(i).Burst
                };
                tlp.Controls.Add(prBars[i], 4, i + 1);
            }
        }

        private async void buttonStartSim_Click(object sender, EventArgs e)
        {
            buttonStartSim.Enabled = false;
            buttonStopSim.Enabled = true;

            while (true)
            {
                bool ok = scheduler.Step();

                // Update UI
                labelUtil.Text = (Math.Round((double)scheduler.Worktime / scheduler.ElapsedTime, 2) * 100).ToString() + "%";
                labelTurnaround.Text = scheduler.Turnaround.ToString();
                labelCurrTime.Text = scheduler.ElapsedTime.ToString();

                for (int i = 0; i < scheduler.ProcessCount; i++)
                {
                    prBars[i].Value = scheduler.ProcessAt(i).Progress;
                }

                string rqueue = "";
                for (int i = scheduler.QueueList.Count - 1; i >= 0; i--)
                {
                    rqueue += "P#";
                    rqueue += scheduler.QueueList[i];
                    rqueue += " ";
                }
                labelrQueue.Text = rqueue;

                if (!ok)
                    break;

                await Task.Delay(1000);
            }

            buttonStartSim.Enabled = true;
            buttonStopSim.Enabled = false;
        }

        private void Simulation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
