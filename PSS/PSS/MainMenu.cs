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
    public partial class MainMenu : Form
    {
        protected SortableBindingList<Process> processList;

        public MainMenu()
        {
            InitializeComponent();
            labelSimSpeed.Text = simSpeed.Value.ToString();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Initialize process list
            processList = new SortableBindingList<Process>();
            processData.DataSource = processList;

            // Get all implemented Algorithms
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(y => typeof(IAlgorithm).IsAssignableFrom(y) && y.IsClass);

            algList.DataSource = types.ToArray();
            algList.DisplayMember = "Name";
        }

        public void ImportNewProcesses(List<Process> toImport)
        {
            processList.Clear();
            toImport.ForEach(x => processList.Add(x));
        }

        // --------------- Buttons --------------- //

        private void buttonAddProcess_Click(object sender, EventArgs e)
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

        private void buttonEditProcess_Click(object sender, EventArgs e)
        {
            // Open a dialog for editing selected process
            if (processGridView.SelectedRows.Count > 0)
            {
                ProcessDialog editProcessDialog = new ProcessDialog(true);
                editProcessDialog.Text = "Edit Process";
                Process selected = (Process)processGridView.SelectedRows[0].DataBoundItem;
                editProcessDialog.SetProcess(selected);
                DialogResult dialogResult = editProcessDialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    processList[processList.IndexOf(selected)] = editProcessDialog.GetProcess();
                }
                editProcessDialog.Dispose();
            }
            else
            {
                MessageBox.Show("Select a process first!", "No process selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDeleteProcess_Click(object sender, EventArgs e)
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

        private void buttonReady_Click(object sender, EventArgs e)
        {
            // Dont start with empty list
            if (processList.Count == 0)
            {
                MessageBox.Show("Process list is empty!", "No processes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //TODO Calibrate simSpeed
                // Make a scheduler class from the parameters
                Simulation simulation = new Simulation(new Scheduler(
                    processList.ToList(),
                    (IAlgorithm)Activator.CreateInstance((Type)algList.SelectedItem)), simSpeed.Value);

                //Hides the main menu
                Hide();
                //Shows the simulation
                simulation.Show(this);
            }
        }

        // --------------------------------------- //

        // Updates label below slider
        private void simSpeed_ValueChanged(object sender, EventArgs e)
        {
            labelSimSpeed.Text = simSpeed.Value.ToString();
        }

        void MakeColumnsSortable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in processGridView.Columns)
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
        }

        private void processGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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

        private void buttonImportData_Click(object sender, EventArgs e)
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
                        .Where(y => typeof(IAlgorithm).IsAssignableFrom(y) && y.IsClass)
                        .ToList().ForEach(x =>
                        {

                    if (x.ToString().Substring(x.ToString().LastIndexOf('.') + 1) == file.Element("algorithm").Value)
                            {
                                algList.SelectedIndex = algList.FindStringExact(file.Element("algorithm").Value);
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
                        int ioprob, length;
                        IO.Speed speed;

                        if (!int.TryParse(item.Attribute("ioprob").Value, out ioprob))
                        {
                            throw new System.Xml.XmlException("Ioprob must be numeric");
                        }
                        if (!int.TryParse(item.Attribute("length").Value, out length))
                        {
                            throw new System.Xml.XmlException("Length must be numeric");
                        }
                        if (!Enum.TryParse<IO.Speed>(item.Attribute("ioswift").Value, out speed))
                        {
                            throw new System.Xml.XmlException("Ioswift must be the following: FAST, MEDIUM, SLOW");
                        }

                        processList.Add(new Process(item.Value, (double)ioprob / 100, speed, length));
                    }
                    
                }
                catch (System.Xml.XmlException ex)
                {
                    MessageBox.Show(ex.Message, "Not fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearProcesses_Click(object sender, EventArgs e)
        {
            if (processList.Count == 0 || MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                processList.Clear();
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                FileName = "PSSExport_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".exp"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                XDocument file = new XDocument();
                file.Add(new XElement("scheduler"));
                file.Element("scheduler").Add(new XElement("algorithm", algList.SelectedItem.ToString()));
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
}
