namespace PSS
{
    partial class Settings
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
            this.settingsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.algList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSimSpeed = new System.Windows.Forms.Label();
            this.simSpeed = new System.Windows.Forms.TrackBar();
            this.descLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbAlgorithm = new System.Windows.Forms.GroupBox();
            this.tlpAlgorithmSettings = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.settingsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simSpeed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbAlgorithm.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.ColumnCount = 2;
            this.settingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.settingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.settingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.settingsPanel.Controls.Add(this.label3, 0, 0);
            this.settingsPanel.Controls.Add(this.algList, 1, 0);
            this.settingsPanel.Controls.Add(this.label2, 0, 1);
            this.settingsPanel.Controls.Add(this.label1, 0, 2);
            this.settingsPanel.Controls.Add(this.panel1, 1, 2);
            this.settingsPanel.Controls.Add(this.descLabel, 1, 1);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(3, 16);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.RowCount = 3;
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.settingsPanel.Size = new System.Drawing.Size(537, 196);
            this.settingsPanel.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Algorithm:";
            // 
            // algList
            // 
            this.algList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.algList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algList.FormattingEnabled = true;
            this.algList.Location = new System.Drawing.Point(342, 22);
            this.algList.Name = "algList";
            this.algList.Size = new System.Drawing.Size(121, 21);
            this.algList.TabIndex = 2;
            this.algList.SelectedIndexChanged += new System.EventHandler(this.algList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Short Description:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Simulation Speed:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.labelSimSpeed);
            this.panel1.Controls.Add(this.simSpeed);
            this.panel1.Location = new System.Drawing.Point(271, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 54);
            this.panel1.TabIndex = 6;
            // 
            // labelSimSpeed
            // 
            this.labelSimSpeed.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSimSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSimSpeed.Location = new System.Drawing.Point(0, 34);
            this.labelSimSpeed.Name = "labelSimSpeed";
            this.labelSimSpeed.Size = new System.Drawing.Size(263, 20);
            this.labelSimSpeed.TabIndex = 9;
            this.labelSimSpeed.Text = "MIDDLE";
            this.labelSimSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // simSpeed
            // 
            this.simSpeed.BackColor = System.Drawing.SystemColors.Control;
            this.simSpeed.Dock = System.Windows.Forms.DockStyle.Top;
            this.simSpeed.LargeChange = 1;
            this.simSpeed.Location = new System.Drawing.Point(0, 0);
            this.simSpeed.Maximum = 5;
            this.simSpeed.Minimum = 1;
            this.simSpeed.Name = "simSpeed";
            this.simSpeed.Size = new System.Drawing.Size(263, 45);
            this.simSpeed.TabIndex = 4;
            this.simSpeed.Value = 3;
            this.simSpeed.ValueChanged += new System.EventHandler(this.simSpeed_ValueChanged);
            // 
            // descLabel
            // 
            this.descLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(397, 91);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(10, 13);
            this.descLabel.TabIndex = 3;
            this.descLabel.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.settingsPanel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 215);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General settings";
            // 
            // gbAlgorithm
            // 
            this.gbAlgorithm.Controls.Add(this.tlpAlgorithmSettings);
            this.gbAlgorithm.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAlgorithm.Location = new System.Drawing.Point(5, 220);
            this.gbAlgorithm.Name = "gbAlgorithm";
            this.gbAlgorithm.Size = new System.Drawing.Size(543, 72);
            this.gbAlgorithm.TabIndex = 9;
            this.gbAlgorithm.TabStop = false;
            this.gbAlgorithm.Text = "Algorithm settings";
            // 
            // tlpAlgorithmSettings
            // 
            this.tlpAlgorithmSettings.ColumnCount = 2;
            this.tlpAlgorithmSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAlgorithmSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAlgorithmSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAlgorithmSettings.Location = new System.Drawing.Point(3, 16);
            this.tlpAlgorithmSettings.Name = "tlpAlgorithmSettings";
            this.tlpAlgorithmSettings.RowCount = 1;
            this.tlpAlgorithmSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAlgorithmSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAlgorithmSettings.Size = new System.Drawing.Size(537, 53);
            this.tlpAlgorithmSettings.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cancelButton);
            this.flowLayoutPanel1.Controls.Add(this.saveButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 345);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(543, 33);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(465, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(384, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Settings
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(553, 383);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gbAlgorithm);
            this.Controls.Add(this.groupBox1);
            this.Name = "Settings";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simSpeed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gbAlgorithm.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel settingsPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox algList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbAlgorithm;
        private System.Windows.Forms.TableLayoutPanel tlpAlgorithmSettings;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar simSpeed;
        private System.Windows.Forms.Label labelSimSpeed;
    }
}