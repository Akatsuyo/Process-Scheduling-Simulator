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
    /// Settings dialog
    /// </summary>
    public partial class Settings : Form
    {
        private Dictionary<SimulationSpeed, int> speeds = new Dictionary<SimulationSpeed, int>()
        {
            { SimulationSpeed.VERY_SLOW, 1000},
            { SimulationSpeed.SLOW, 500},
            { SimulationSpeed.MEDIUM, 250},
            { SimulationSpeed.FAST, 100},
            { SimulationSpeed.VERY_FAST, 10}
        };

        private SchedulingAlgorithm algorithm = new FIFO();
        private int speed;

        /// <summary>
        /// List of the algorithms in the combobox
        /// </summary>
        public ComboBox AlgList
        {
            get
            {
                return algList;
            }
        }

        /// <summary>
        /// Selected algorithm (only use it when the settings dialog is closed)
        /// </summary>
        public SchedulingAlgorithm Algorithm
        {
            get
            {
                return algorithm;
            }
        }

        /// <summary>
        /// Speed of the simulation
        /// </summary>
        public int Speed
        {
            get
            {
                return speed;
            }
        }

        private enum SimulationSpeed
        {
            VERY_SLOW = 1,
            SLOW,
            MEDIUM,
            FAST,
            VERY_FAST
        }

        /// <summary>
        /// Constructor of the settings dialog
        /// </summary>
        public Settings()
        {
            speed = speeds[SimulationSpeed.MEDIUM];
            InitializeComponent();
            labelSimSpeed.Text = ((SimulationSpeed)simSpeed.Value).ToString();
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(y => typeof(SchedulingAlgorithm).IsAssignableFrom(y) && y.IsClass && !y.IsAbstract);

            algList.DataSource = types.ToArray();
            algList.DisplayMember = "Name";
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            this.Icon = PSS.Properties.Resources.ApplicationIcon;
        }

        private void simSpeed_ValueChanged(object sender, EventArgs e)
        {
            speed = speeds[(SimulationSpeed)simSpeed.Value];
            labelSimSpeed.Text = ((SimulationSpeed)simSpeed.Value).ToString();
        }

        private void algList_SelectedIndexChanged(object sender, EventArgs e)
        {
            algorithm = (SchedulingAlgorithm)Activator.CreateInstance((Type)algList.SelectedItem);
            //Show Description
            descLabel.Text = algorithm.Desc();
            if (algorithm != null && algorithm.GetAlgorithmSettings() != null)
            {
                AlgorithmSettings.ISetting[] settings = algorithm.GetAlgorithmSettings().Settings;
                tlpAlgorithmSettings.Controls.Clear();
                tlpAlgorithmSettings.RowCount = algorithm.GetAlgorithmSettings().SettingsCount;
                for (int i = 0; i < algorithm.GetAlgorithmSettings().SettingsCount; ++i)
                {
                    AlgorithmSettings.ISetting setting = algorithm.GetAlgorithmSettings().Settings[i];
                    //Label
                    tlpAlgorithmSettings.Controls.Add(CreateLabel(setting.Name, setting.Label), 0, i);
                    //Data
                    switch (setting.SettingType)
                    {
                        case AlgorithmSettings.SettingType.RANGE:
                            tlpAlgorithmSettings.Controls.Add(CreateRangeWithNumeric(
                                setting.Name,
                                ((AlgorithmSettings.RangeSetting) setting).From,
                                ((AlgorithmSettings.RangeSetting) setting).To,
                                ((AlgorithmSettings.RangeSetting) setting).Step,
                                ((AlgorithmSettings.RangeSetting) setting).Value,
                                ((AlgorithmSettings.RangeSetting)setting).Method
                            ), 1, i);
                            break;
                    }
                    
                }
                gbAlgorithm.Visible = true;
            }
            else
            {
                gbAlgorithm.Visible = false;
            }
        }

        private Label CreateLabel(string name, string text)
        {
            Label lb = new Label();
            lb.Anchor = System.Windows.Forms.AnchorStyles.None;
            lb.AutoSize = true;
            lb.Name = "label" + name;
            lb.Size = new System.Drawing.Size(92, 13);
            lb.TabIndex = 3;
            lb.Text = text + ":";
            return lb;
        }

        private Panel CreateRangeWithNumeric(string name, int from, int to, int step, int value, Action<string> action)
        {
            Panel panel = new System.Windows.Forms.Panel();
            TrackBar range = new System.Windows.Forms.TrackBar();
            Label rangeLabel = new System.Windows.Forms.Label();
        
            panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            panel.Controls.Add(rangeLabel);
            panel.Controls.Add(range);
            panel.Location = new System.Drawing.Point(447, 68);
            panel.Name = "panel";
            panel.Size = new System.Drawing.Size(439, 50);
            panel.TabIndex = 6;
            range.BackColor = System.Drawing.SystemColors.Control;
            range.Dock = System.Windows.Forms.DockStyle.Top;
            range.LargeChange = 1;
            range.Location = new System.Drawing.Point(0, 0);
            range.Maximum = to;
            range.Minimum = from;
            range.Name = "range" + name;
            range.Size = new System.Drawing.Size(439, 45);
            range.TabIndex = 4;
            range.SmallChange = step;
            range.LargeChange = step * 3;
            range.Value = value;
            range.ValueChanged += new System.EventHandler((object sender, EventArgs e) => {
                action(range.Value.ToString());
                rangeLabel.Text = range.Value.ToString();
            });
            rangeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            rangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            rangeLabel.Location = new System.Drawing.Point(190, 28);
            rangeLabel.Name = "labelRange" + name;
            rangeLabel.Size = new System.Drawing.Size(59, 17);
            rangeLabel.TabIndex = 5;
            rangeLabel.Text = value.ToString();
            rangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            return panel;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
