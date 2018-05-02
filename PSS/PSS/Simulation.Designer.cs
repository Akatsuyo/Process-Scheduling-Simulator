namespace PSS
{
    partial class Simulation
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.labelUtil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStartSim = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCompletion = new System.Windows.Forms.Label();
            this.buttonExport = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCurrTime = new System.Windows.Forms.Label();
            this.labelrQueue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTurnaround = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddProcess = new System.Windows.Forms.Button();
            this.processViewPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.processHeadTable = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelPID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.buttonStopSim = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.processViewPanel.SuspendLayout();
            this.processHeadTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.38095F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelUtil, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonStartSim, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelCompletion, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.buttonExport, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelCurrTime, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelrQueue, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelTurnaround, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddProcess, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.processViewPanel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonStopSim, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50328F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(520, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Processes";
            // 
            // labelUtil
            // 
            this.labelUtil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUtil.AutoSize = true;
            this.labelUtil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUtil.Location = new System.Drawing.Point(172, 15);
            this.labelUtil.Name = "labelUtil";
            this.labelUtil.Size = new System.Drawing.Size(65, 26);
            this.labelUtil.TabIndex = 1;
            this.labelUtil.Text = "xxx%";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(49, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Util:";
            // 
            // buttonStartSim
            // 
            this.buttonStartSim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStartSim.Location = new System.Drawing.Point(278, 17);
            this.buttonStartSim.Name = "buttonStartSim";
            this.buttonStartSim.Size = new System.Drawing.Size(75, 23);
            this.buttonStartSim.TabIndex = 9;
            this.buttonStartSim.Text = "Start";
            this.buttonStartSim.UseVisualStyleBackColor = true;
            this.buttonStartSim.Click += new System.EventHandler(this.buttonStartSim_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(10, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Completion:";
            // 
            // labelCompletion
            // 
            this.labelCompletion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCompletion.AutoSize = true;
            this.labelCompletion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCompletion.Location = new System.Drawing.Point(172, 357);
            this.labelCompletion.Name = "labelCompletion";
            this.labelCompletion.Size = new System.Drawing.Size(65, 26);
            this.labelCompletion.TabIndex = 8;
            this.labelCompletion.Text = "xxx%";
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExport.Location = new System.Drawing.Point(278, 359);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 11;
            this.buttonExport.Text = "Export...";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(5, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Current time:";
            // 
            // labelCurrTime
            // 
            this.labelCurrTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCurrTime.AutoSize = true;
            this.labelCurrTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCurrTime.Location = new System.Drawing.Point(187, 300);
            this.labelCurrTime.Name = "labelCurrTime";
            this.labelCurrTime.Size = new System.Drawing.Size(34, 26);
            this.labelCurrTime.TabIndex = 7;
            this.labelCurrTime.Text = "xx";
            // 
            // labelrQueue
            // 
            this.labelrQueue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.labelrQueue, 2);
            this.labelrQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelrQueue.Location = new System.Drawing.Point(3, 228);
            this.labelrQueue.Name = "labelrQueue";
            this.labelrQueue.Size = new System.Drawing.Size(254, 57);
            this.labelrQueue.TabIndex = 13;
            this.labelrQueue.Text = "rQueue";
            this.labelrQueue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 2);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(57, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ready Queue";
            // 
            // labelTurnaround
            // 
            this.labelTurnaround.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTurnaround.AutoSize = true;
            this.labelTurnaround.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTurnaround.Location = new System.Drawing.Point(187, 72);
            this.labelTurnaround.Name = "labelTurnaround";
            this.labelTurnaround.Size = new System.Drawing.Size(34, 26);
            this.labelTurnaround.TabIndex = 3;
            this.labelTurnaround.Text = "xx";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(10, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Turnaround:";
            // 
            // buttonAddProcess
            // 
            this.buttonAddProcess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddProcess.Location = new System.Drawing.Point(278, 418);
            this.buttonAddProcess.Name = "buttonAddProcess";
            this.buttonAddProcess.Size = new System.Drawing.Size(75, 23);
            this.buttonAddProcess.TabIndex = 15;
            this.buttonAddProcess.Text = "Add process";
            this.buttonAddProcess.UseVisualStyleBackColor = true;
            this.buttonAddProcess.Click += new System.EventHandler(this.buttonAddProcess_Click);
            // 
            // processViewPanel
            // 
            this.processViewPanel.AutoScroll = true;
            this.processViewPanel.BackColor = System.Drawing.Color.Transparent;
            this.processViewPanel.Controls.Add(this.processHeadTable);
            this.processViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processViewPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.processViewPanel.Location = new System.Drawing.Point(374, 60);
            this.processViewPanel.Name = "processViewPanel";
            this.tableLayoutPanel1.SetRowSpan(this.processViewPanel, 7);
            this.processViewPanel.Size = new System.Drawing.Size(407, 398);
            this.processViewPanel.TabIndex = 16;
            this.processViewPanel.WrapContents = false;
            this.processViewPanel.SizeChanged += new System.EventHandler(this.processViewPanel_SizeChanged);
            // 
            // processHeadTable
            // 
            this.processHeadTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.processHeadTable.BackColor = System.Drawing.Color.LightGray;
            this.processHeadTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.processHeadTable.ColumnCount = 5;
            this.processHeadTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.processHeadTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.processHeadTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.processHeadTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.processHeadTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.processHeadTable.Controls.Add(this.label8, 4, 0);
            this.processHeadTable.Controls.Add(this.label7, 3, 0);
            this.processHeadTable.Controls.Add(this.labelPID, 0, 0);
            this.processHeadTable.Controls.Add(this.labelName, 1, 0);
            this.processHeadTable.Controls.Add(this.labelState, 2, 0);
            this.processHeadTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.processHeadTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.processHeadTable.Location = new System.Drawing.Point(0, 0);
            this.processHeadTable.Margin = new System.Windows.Forms.Padding(0);
            this.processHeadTable.Name = "processHeadTable";
            this.processHeadTable.RowCount = 1;
            this.processHeadTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.processHeadTable.Size = new System.Drawing.Size(407, 30);
            this.processHeadTable.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(308, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 28);
            this.label8.TabIndex = 4;
            this.label8.Text = "I/O";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(207, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 28);
            this.label7.TabIndex = 3;
            this.label7.Text = "Progress";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPID
            // 
            this.labelPID.AutoSize = true;
            this.labelPID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPID.Location = new System.Drawing.Point(4, 1);
            this.labelPID.Name = "labelPID";
            this.labelPID.Size = new System.Drawing.Size(34, 28);
            this.labelPID.TabIndex = 0;
            this.labelPID.Text = "pID";
            this.labelPID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Location = new System.Drawing.Point(45, 1);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(74, 28);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelState.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelState.Location = new System.Drawing.Point(126, 1);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(74, 28);
            this.labelState.TabIndex = 2;
            this.labelState.Text = "State";
            this.labelState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStopSim
            // 
            this.buttonStopSim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStopSim.Enabled = false;
            this.buttonStopSim.Location = new System.Drawing.Point(278, 74);
            this.buttonStopSim.Name = "buttonStopSim";
            this.buttonStopSim.Size = new System.Drawing.Size(75, 23);
            this.buttonStopSim.TabIndex = 10;
            this.buttonStopSim.Text = "Stop";
            this.buttonStopSim.UseVisualStyleBackColor = true;
            this.buttonStopSim.Click += new System.EventHandler(this.buttonStopSim_Click);
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Simulation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Process Scheduling Simulator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Simulation_FormClosed);
            this.Load += new System.EventHandler(this.Simulation_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.processViewPanel.ResumeLayout(false);
            this.processHeadTable.ResumeLayout(false);
            this.processHeadTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelUtil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTurnaround;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCurrTime;
        private System.Windows.Forms.Label labelCompletion;
        private System.Windows.Forms.Button buttonStartSim;
        private System.Windows.Forms.Button buttonStopSim;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Label labelrQueue;
        private System.Windows.Forms.Button buttonAddProcess;
        private System.Windows.Forms.FlowLayoutPanel processViewPanel;
        private System.Windows.Forms.TableLayoutPanel processHeadTable;
        private System.Windows.Forms.Label labelPID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}