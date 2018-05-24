using System;

namespace PSS
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.clearProcesses = new System.Windows.Forms.Button();
            this.buttonAddProcess = new System.Windows.Forms.Button();
            this.processData = new System.Windows.Forms.BindingSource(this.components);
            this.buttonReady = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importProcessesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportProcessesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.processSettingsButtonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.saveProcessButton = new System.Windows.Forms.Button();
            this.buttonDeleteProcess = new System.Windows.Forms.Button();
            this.resetProcessButton = new System.Windows.Forms.Button();
            this.processSettings = new PSS.ProcessSettings();
            this.processGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IOProbability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IOSwiftness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedAlgorithmLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.processData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.processSettingsButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clearProcesses
            // 
            this.clearProcesses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearProcesses.Image = global::PSS.Properties.Resources.Clear;
            this.clearProcesses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearProcesses.Location = new System.Drawing.Point(265, 3);
            this.clearProcesses.Name = "clearProcesses";
            this.clearProcesses.Size = new System.Drawing.Size(82, 32);
            this.clearProcesses.TabIndex = 3;
            this.clearProcesses.Text = "Clear List";
            this.clearProcesses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clearProcesses.UseVisualStyleBackColor = true;
            this.clearProcesses.Click += new System.EventHandler(this.ClearProcesses_Click);
            // 
            // buttonAddProcess
            // 
            this.buttonAddProcess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddProcess.Image = global::PSS.Properties.Resources.Add;
            this.buttonAddProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddProcess.Location = new System.Drawing.Point(3, 3);
            this.buttonAddProcess.Name = "buttonAddProcess";
            this.buttonAddProcess.Size = new System.Drawing.Size(94, 32);
            this.buttonAddProcess.TabIndex = 0;
            this.buttonAddProcess.Text = "Add Process";
            this.buttonAddProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddProcess.UseVisualStyleBackColor = true;
            this.buttonAddProcess.Click += new System.EventHandler(this.ButtonAddProcess_Click);
            // 
            // buttonReady
            // 
            this.buttonReady.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonReady.Image = global::PSS.Properties.Resources.Run;
            this.buttonReady.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReady.Location = new System.Drawing.Point(353, 3);
            this.buttonReady.Name = "buttonReady";
            this.buttonReady.Size = new System.Drawing.Size(65, 32);
            this.buttonReady.TabIndex = 7;
            this.buttonReady.Text = "Ready";
            this.buttonReady.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReady.UseVisualStyleBackColor = true;
            this.buttonReady.Click += new System.EventHandler(this.ButtonReady_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importProcessesToolStripMenuItem,
            this.exportProcessesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importProcessesToolStripMenuItem
            // 
            this.importProcessesToolStripMenuItem.Name = "importProcessesToolStripMenuItem";
            this.importProcessesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.importProcessesToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.importProcessesToolStripMenuItem.Text = "Import Processes";
            this.importProcessesToolStripMenuItem.Click += new System.EventHandler(this.ImportProcessesToolStripMenuItem_Click);
            // 
            // exportProcessesToolStripMenuItem
            // 
            this.exportProcessesToolStripMenuItem.Name = "exportProcessesToolStripMenuItem";
            this.exportProcessesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.exportProcessesToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.exportProcessesToolStripMenuItem.Text = "Export Processes";
            this.exportProcessesToolStripMenuItem.Click += new System.EventHandler(this.ExportProcessesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 482);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(854, 47);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.buttonAddProcess);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(421, 41);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.buttonReady);
            this.flowLayoutPanel3.Controls.Add(this.clearProcesses);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(430, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(421, 41);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.selectedAlgorithmLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(864, 534);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(5, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 457);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Processes";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.processSettingsButtonsPanel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.processSettings, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.processGridView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.15789F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(848, 438);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // processSettingsButtonsPanel
            // 
            this.processSettingsButtonsPanel.Controls.Add(this.saveProcessButton);
            this.processSettingsButtonsPanel.Controls.Add(this.buttonDeleteProcess);
            this.processSettingsButtonsPanel.Controls.Add(this.resetProcessButton);
            this.processSettingsButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processSettingsButtonsPanel.Location = new System.Drawing.Point(3, 394);
            this.processSettingsButtonsPanel.Name = "processSettingsButtonsPanel";
            this.processSettingsButtonsPanel.Size = new System.Drawing.Size(842, 41);
            this.processSettingsButtonsPanel.TabIndex = 4;
            this.processSettingsButtonsPanel.Visible = false;
            // 
            // saveProcessButton
            // 
            this.saveProcessButton.Image = global::PSS.Properties.Resources.Save;
            this.saveProcessButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveProcessButton.Location = new System.Drawing.Point(3, 3);
            this.saveProcessButton.Name = "saveProcessButton";
            this.saveProcessButton.Size = new System.Drawing.Size(104, 32);
            this.saveProcessButton.TabIndex = 3;
            this.saveProcessButton.Text = "Save Process";
            this.saveProcessButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveProcessButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveProcessButton.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteProcess
            // 
            this.buttonDeleteProcess.Image = global::PSS.Properties.Resources.Delete;
            this.buttonDeleteProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteProcess.Location = new System.Drawing.Point(113, 3);
            this.buttonDeleteProcess.Name = "buttonDeleteProcess";
            this.buttonDeleteProcess.Size = new System.Drawing.Size(104, 32);
            this.buttonDeleteProcess.TabIndex = 2;
            this.buttonDeleteProcess.Text = "Delete Process";
            this.buttonDeleteProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDeleteProcess.UseVisualStyleBackColor = true;
            // 
            // resetProcessButton
            // 
            this.resetProcessButton.Image = global::PSS.Properties.Resources.Reset;
            this.resetProcessButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resetProcessButton.Location = new System.Drawing.Point(223, 3);
            this.resetProcessButton.Name = "resetProcessButton";
            this.resetProcessButton.Size = new System.Drawing.Size(116, 32);
            this.resetProcessButton.TabIndex = 4;
            this.resetProcessButton.Text = "Revert Changes";
            this.resetProcessButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resetProcessButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.resetProcessButton.UseVisualStyleBackColor = true;
            // 
            // processSettings
            // 
            this.processSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processSettings.IOProbability = 0.2D;
            this.processSettings.IOProbabilityPercent = 20;
            this.processSettings.IOSwiftness = PSS.IO.Speed.MEDIUM;
            this.processSettings.Length = 10;
            this.processSettings.Location = new System.Drawing.Point(3, 279);
            this.processSettings.Name = "processSettings";
            this.processSettings.ProcessName = "";
            this.processSettings.Size = new System.Drawing.Size(842, 109);
            this.processSettings.TabIndex = 3;
            this.processSettings.Visible = false;
            // 
            // processGridView
            // 
            this.processGridView.AllowUserToAddRows = false;
            this.processGridView.AllowUserToDeleteRows = false;
            this.processGridView.AllowUserToResizeColumns = false;
            this.processGridView.AllowUserToResizeRows = false;
            this.processGridView.AutoGenerateColumns = false;
            this.processGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.processGridView.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.processGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.processGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.processGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.IOProbability,
            this.IOSwiftness,
            this.Length});
            this.processGridView.DataSource = this.processData;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.processGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.processGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processGridView.Location = new System.Drawing.Point(3, 3);
            this.processGridView.MultiSelect = false;
            this.processGridView.Name = "processGridView";
            this.processGridView.ReadOnly = true;
            this.processGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.processGridView.RowHeadersVisible = false;
            this.processGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.processGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.processGridView.Size = new System.Drawing.Size(842, 270);
            this.processGridView.TabIndex = 2;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "Name";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.name.DefaultCellStyle = dataGridViewCellStyle2;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // IOProbability
            // 
            this.IOProbability.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IOProbability.DataPropertyName = "IOProbabilityPercent";
            this.IOProbability.HeaderText = "I/O Probability";
            this.IOProbability.Name = "IOProbability";
            this.IOProbability.ReadOnly = true;
            // 
            // IOSwiftness
            // 
            this.IOSwiftness.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IOSwiftness.DataPropertyName = "IOSwiftness";
            this.IOSwiftness.HeaderText = "I/O Swiftness";
            this.IOSwiftness.Name = "IOSwiftness";
            this.IOSwiftness.ReadOnly = true;
            // 
            // Length
            // 
            this.Length.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Length.DataPropertyName = "Length";
            this.Length.HeaderText = "Length";
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            // 
            // selectedAlgorithmLabel
            // 
            this.selectedAlgorithmLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectedAlgorithmLabel.Location = new System.Drawing.Point(5, 5);
            this.selectedAlgorithmLabel.Name = "selectedAlgorithmLabel";
            this.selectedAlgorithmLabel.Size = new System.Drawing.Size(854, 20);
            this.selectedAlgorithmLabel.TabIndex = 5;
            this.selectedAlgorithmLabel.Text = "Selected algorithm: FIFO";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process Scheduling Simulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.processData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.processSettingsButtonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.processGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddProcess;
        private System.Windows.Forms.BindingSource processData;
        private System.Windows.Forms.Button buttonReady;
        private System.Windows.Forms.Button clearProcesses;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importProcessesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportProcessesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label selectedAlgorithmLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel processSettingsButtonsPanel;
        private System.Windows.Forms.Button saveProcessButton;
        private System.Windows.Forms.Button buttonDeleteProcess;
        private System.Windows.Forms.Button resetProcessButton;
        private ProcessSettings processSettings;
        private System.Windows.Forms.DataGridView processGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn IOProbability;
        private System.Windows.Forms.DataGridViewTextBoxColumn IOSwiftness;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
    }
}

