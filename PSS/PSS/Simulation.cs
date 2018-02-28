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
        public static List<Process> processList;
        public static ProgressBar[] progressBars;
        public static Queue<int> readyQueue = new Queue<int>();

        private bool finished = false;

        public Simulation()
        {
            InitializeComponent();
        }

        private async void buttonStartSim_Click(object sender, EventArgs e)
        {
            buttonStopSim.Enabled = true;
            Scheduler scheduler = new Scheduler();
            scheduler.Algorithm = MainMenu.selectedAlg;
            scheduler.AnimationSpeed = MainMenu.selectedSpeed;
            
            while (!finished)
            {
                scheduler.Step();
                for (int i = 0; i < progressBars.Length; i++)
                {
                    progressBars[i].Value = processList[i].Progress;
                }
                labelUtil.Text = scheduler.Utilization + "%";
                labelTurnaround.Text = scheduler.Turnaround.ToString();
                labelCurrTime.Text = scheduler.ElapsedTime.ToString();
                labelCompletion.Text = (progressBars.Select(x => x.Value).Sum() / processList.Count).ToString() + "%";

                finished = true;
                for (int i = 0; i < processList.Count; i++)
                {
                    if (processList[i].Progress < 100)
                    {
                        finished = false;
                        break;
                    }
                }

                if (!finished)
                    await Task.Delay(200);
            }

            buttonStopSim.Enabled = false;
        }

        private void Simulation_Load(object sender, EventArgs e)
        {
            processList = MainMenu.processList.ToList();

            labelUtil.Text = "-";
            labelTurnaround.Text = "-";
            labelCurrTime.Text = "-";
            labelCompletion.Text = "-";

            TableLayoutPanel tlp = new TableLayoutPanel
            {
                ColumnCount = 5,
                RowCount = MainMenu.processList.Count + 1,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            for (int i = 0; i < 5; i++)
            {
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            }
            //for (int i = 0; i < MainMenu.processList.Count + 1; i++)
            //{
            //    tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / (MainMenu.processList.Count + 1)));
            //}
            string[] headers = { "Name", "Burst", "Arrival", "Priority", "Progress" };
            Label[] headerLabels = new Label[headers.Length];
            for (int i = 0; i < headers.Length; i++)
            {
                headerLabels[i] = new Label
                {
                    Text = headers[i],
                    Anchor = AnchorStyles.None,
                    Font = new Font("Microsoft Sans Serif", 12)
                };

                tlp.Controls.Add(headerLabels[i], i, 0);
            }

            progressBars = new ProgressBar[processList.Count];
            for (int i = 0; i < processList.Count; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    tlp.Controls.Add(new Label {
                        Text = typeof(Process).GetProperty(headers[j]).GetValue(processList[i]).ToString(),
                        Anchor = AnchorStyles.None
                    }, j, i + 1);
                }

                progressBars[i] = new ProgressBar();
                tlp.Controls.Add(progressBars[i], 4, i + 1);
            }

            tableLayoutPanel1.Controls.Add(tlp, 3, 1);
            tableLayoutPanel1.SetRowSpan(tlp, 5);
        }
    }
}
