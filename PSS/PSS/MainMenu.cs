using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Xml.Linq;

namespace PSS
{
    /// <summary>
    /// Main menu of the simulation (this is where the program starts)
    /// </summary>
    public partial class MainMenu : Form
    {
        /// <summary>
        /// List of the processes
        /// </summary>
        protected SortableBindingList<Process> processList;

        private Process selectedProcess;
        private bool rowChanged = false;

        Settings settings;

        /// <summary>
        /// Constructor of the main menu
        /// </summary>
        public MainMenu()
        {
            settings = new Settings();
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.Icon = PSS.Properties.Resources.ApplicationIcon;
            // Initialize process list
            processList = new SortableBindingList<Process>();
            processData.DataSource = processList;

            selectedAlgorithmLabel.Text = "Selected algorithm: " + settings.AlgList.SelectedItem.ToString().Substring(settings.AlgList.SelectedItem.ToString().LastIndexOf('.') + 1);

            selectedProcess = null;

            // Get all implemented Algorithms
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(y => typeof(SchedulingAlgorithm).IsAssignableFrom(y) && y.IsClass && !y.IsAbstract);

        }

        /// <summary>
        /// Replace current processes with new processes
        /// </summary>
        /// <param name="toImport"></param>
        public void ImportNewProcesses(List<Process> toImport)
        {
            processList.Clear();
            toImport.ForEach(x => processList.Add(x));
        }

        // --------------- Buttons --------------- //

        private void ButtonAddProcess_Click(object sender, EventArgs e)
        {
            // Open a new dialog for adding a process to the list
            ProcessDialog newProcessDialog = new ProcessDialog();
            DialogResult dialogResult = newProcessDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                processList.Add(newProcessDialog.GetProcess());
            }
            newProcessDialog.Dispose();
        }

        private void ButtonDeleteProcess_Click(object sender, EventArgs e)
        {
            // Delete selected process
            if (processGridView.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this process?", "Delete process", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    processList.Remove((Process)processGridView.SelectedRows[0].DataBoundItem);
                }
            }
            else
            {
                MessageBox.Show("Select a process first!", "No process selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonReady_Click(object sender, EventArgs e)
        {
            // Dont start with empty list
            if (processList.Count == 0)
            {
                MessageBox.Show("Process list is empty!", "No processes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    // Make a scheduler class from the parameters
                    Simulation simulation = new Simulation(new Scheduler(
                    processList.ToList(), settings.Algorithm), settings.Speed);

                    //Hides the main menu
                    Hide();
                    //Shows the simulation
                    simulation.Show(this);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --------------------------------------- //

        void MakeColumnsSortable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in processGridView.Columns)
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
        }

        private void ProcessGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = processGridView.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = processGridView.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not sorted.
            if (oldColumn != null)
            {
                // Sort the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    processGridView.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    // Sort a new column and remove the old SortGlyph.
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            // Sort the selected column.
            processGridView.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }


        private void ClearProcesses_Click(object sender, EventArgs e)
        {
            if (processList.Count == 0 || MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                processList.Clear();
            }
        }

        private void ImportProcessesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (processList.Count != 0)
            {
                if (MessageBox.Show("You are about to replace existing processes. Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }

            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XElement file;
                    //File validation
                    if ((file = XDocument.Load(ofd.FileName).Element("scheduler")) == null)
                    {
                        throw new System.Xml.XmlException("Scheduler tag not found");
                    }
                    if (file.Element("algorithm") == null)
                    {
                        throw new System.Xml.XmlException("Algorithm tag not found");
                    }
                    AppDomain.CurrentDomain.GetAssemblies()
                        .SelectMany(x => x.GetTypes())
                        .Where(y => typeof(SchedulingAlgorithm).IsAssignableFrom(y) && y.IsClass)
                        .ToList().ForEach(x =>
                        {
                            if (x.ToString().Substring(x.ToString().LastIndexOf('.') + 1) == file.Element("algorithm").Value)
                            {
                                settings.AlgList.SelectedIndex = settings.AlgList.FindStringExact(file.Element("algorithm").Value);
                            }
                        });

                    if (file.Element("processes") == null)
                    {
                        throw new System.Xml.XmlException("Processes tag not found");
                    }

                    processList.Clear();

                    List<Process> processes = new List<Process>();

                    foreach (XElement item in file.Element("processes").Elements())
                    {
                        //Process validation
                        if (item.Attribute("ioprob") == null)
                        {
                            throw new System.Xml.XmlException("Ioprob attribute not found");
                        }
                        if (item.Attribute("ioswift") == null)
                        {
                            throw new System.Xml.XmlException("Ioswift attribute not found");
                        }
                        if (item.Attribute("length") == null)
                        {
                            throw new System.Xml.XmlException("Length attribute not found");
                        }

                        if (!int.TryParse(item.Attribute("ioprob").Value, out int ioprob))
                        {
                            throw new System.Xml.XmlException("Ioprob must be numeric");
                        }
                        if (!int.TryParse(item.Attribute("length").Value, out int length))
                        {
                            throw new System.Xml.XmlException("Length must be numeric");
                        }
                        if (!Enum.TryParse<IO.Speed>(item.Attribute("ioswift").Value, out IO.Speed speed))
                        {
                            throw new System.Xml.XmlException("Ioswift must be the following: FAST, MEDIUM, SLOW");
                        }

                        processList.Add(new Process(item.Value, ioprob, speed, length));
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExportProcessesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (processList.Count == 0)
            {
                MessageBox.Show("Process list is empty!", "No processes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Exports the current settings
                SaveFileDialog sfd = new SaveFileDialog()
                {
                    FileName = "PSSExport_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".exp"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    /*
                     The format should be this:

                     <?xml version="1.0"?>
                     <scheduler>
                        <algorithm>[Algorithm]</algorithm>
                        <processes>
                            <process ioprob="[I/O Probability]" ioswift="[I/O Swiftness]" length="[Length]">[Name]</process>
                            <process ioprob="[I/O Probability]" ioswift="[I/O Swiftness]" length="[Length]">[Name]</process>
                        </processes>
                    </scheduler>
                    */
                    XDocument file = new XDocument();
                    file.Add(new XElement("scheduler"));
                    file.Element("scheduler").Add(new XElement("algorithm", settings.AlgList.SelectedItem.ToString().Substring(settings.AlgList.SelectedItem.ToString().LastIndexOf('.') + 1)));
                    file.Element("scheduler").Add(new XElement("processes"));
                    foreach (Process p in processList)
                    {
                        XElement elem = new XElement("process", p.Name);
                        elem.SetAttributeValue("ioprob", p.IOProbabilityPercent);
                        elem.SetAttributeValue("ioswift", p.IOSwiftness.ToString());
                        elem.SetAttributeValue("length", p.Length);
                        file.Element("scheduler").Element("processes").Add(elem);
                    }
                    file.Save(sfd.FileName);
                }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult mb = MessageBox.Show(
                "Are you sure want to exit the application?",
                "Exit Application",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            e.Cancel = (mb != DialogResult.Yes);
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings.ShowDialog();
            selectedAlgorithmLabel.Text = "Selected algorithm: " + settings.AlgList.SelectedItem.ToString().Substring(settings.AlgList.SelectedItem.ToString().LastIndexOf('.') + 1);
        }

        private void ProcessGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (processGridView.CurrentRow != null)
            {
                processSettings.Visible = true;
                processSettingsButtonsPanel.Visible = true;
                selectedProcess = (Process)processGridView.CurrentRow.DataBoundItem;
                processSettings.ProcessName = selectedProcess.Name;
                processSettings.Length = selectedProcess.Length;
                processSettings.IOProbability = selectedProcess.IOProbability;
                processSettings.IOSwiftness = selectedProcess.IOSwiftness;
            }
            else
            {
                processSettings.Visible = false;
                processSettingsButtonsPanel.Visible = false;
            }
        }

        private void ResetProcessButton_Click(object sender, EventArgs e)
        {
            if (IsSelectedProcessEdited((Process) processGridView.SelectedRows[0].DataBoundItem))
            {
                DialogResult mb = MessageBox.Show("Are you sure want to revert changes?", "Revert changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mb == DialogResult.Yes)
                {
                    processSettings.ProcessName = ((Process)processGridView.SelectedRows[0].DataBoundItem).Name;
                    processSettings.Length = ((Process)processGridView.SelectedRows[0].DataBoundItem).Length;
                    processSettings.IOProbability = ((Process)processGridView.SelectedRows[0].DataBoundItem).IOProbability;
                    processSettings.IOSwiftness = ((Process)processGridView.SelectedRows[0].DataBoundItem).IOSwiftness;
                }
            }
        }
        private void ProcessGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            rowChanged = true;
        }

        private void ProcessGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (rowChanged)
            {
                rowChanged = false;
                if (IsSelectedProcessEdited(selectedProcess))
                {
                    DialogResult mb = MessageBox.Show("Are you sure want to switch process? All changes will be lost!", "Switch process", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (mb == DialogResult.No)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
            }
        }

        private void SaveProcessButton_Click(object sender, EventArgs e)
        {
            if (processSettings.Error)
            {
                MessageBox.Show("The data you have entered is not valid", "Error while validating", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            selectedProcess.Name = processSettings.ProcessName;
            selectedProcess.Length = processSettings.Length;
            selectedProcess.IOProbability = processSettings.IOProbability;
            selectedProcess.IOSwiftness = processSettings.IOSwiftness;
            processGridView.Refresh();
        }

        private bool IsSelectedProcessEdited(Process selectedProcess)
        {
            if (selectedProcess == null)
            {
                return false;
            }
            return !(processSettings.ProcessName == selectedProcess.Name &&
                processSettings.Length == selectedProcess.Length &&
                processSettings.IOProbability == selectedProcess.IOProbability &&
                processSettings.IOSwiftness == selectedProcess.IOSwiftness);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutDialog().Show();
        }
    }
}
