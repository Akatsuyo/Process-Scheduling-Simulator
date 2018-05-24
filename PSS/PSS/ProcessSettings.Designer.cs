namespace PSS
{
    partial class ProcessSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lengthError = new System.Windows.Forms.Label();
            this.nameError = new System.Windows.Forms.Label();
            this.processLength = new System.Windows.Forms.Label();
            this.lengthValue = new System.Windows.Forms.NumericUpDown();
            this.nameValue = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.probabilityValue = new System.Windows.Forms.NumericUpDown();
            this.probabilityError = new System.Windows.Forms.Label();
            this.labelBurst = new System.Windows.Forms.Label();
            this.SwiftnessList = new System.Windows.Forms.ComboBox();
            this.labelArrival = new System.Windows.Forms.Label();
            this.swiftnessError = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityValue)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lengthError, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.nameError, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.processLength, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lengthValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.nameValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.probabilityValue, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.probabilityError, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelBurst, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.SwiftnessList, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelArrival, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.swiftnessError, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(610, 234);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lengthError
            // 
            this.lengthError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lengthError.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lengthError, 2);
            this.lengthError.ForeColor = System.Drawing.Color.Red;
            this.lengthError.Location = new System.Drawing.Point(3, 215);
            this.lengthError.Name = "lengthError";
            this.lengthError.Size = new System.Drawing.Size(207, 13);
            this.lengthError.TabIndex = 14;
            this.lengthError.Text = "lengthError";
            this.lengthError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nameError
            // 
            this.nameError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameError.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.nameError, 2);
            this.nameError.ForeColor = System.Drawing.Color.Red;
            this.nameError.Location = new System.Drawing.Point(3, 98);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(207, 13);
            this.nameError.TabIndex = 8;
            this.nameError.Text = "nameError";
            this.nameError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // processLength
            // 
            this.processLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.processLength.AutoSize = true;
            this.processLength.Location = new System.Drawing.Point(3, 156);
            this.processLength.Name = "processLength";
            this.processLength.Size = new System.Drawing.Size(85, 13);
            this.processLength.TabIndex = 12;
            this.processLength.Text = "Length";
            this.processLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lengthValue
            // 
            this.lengthValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lengthValue.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.lengthValue.Location = new System.Drawing.Point(94, 152);
            this.lengthValue.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.lengthValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lengthValue.Name = "lengthValue";
            this.lengthValue.Size = new System.Drawing.Size(116, 20);
            this.lengthValue.TabIndex = 13;
            this.lengthValue.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lengthValue.Leave += new System.EventHandler(this.LengthValue_Leave);
            // 
            // nameValue
            // 
            this.nameValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameValue.Location = new System.Drawing.Point(94, 36);
            this.nameValue.MaxLength = 16;
            this.nameValue.Name = "nameValue";
            this.nameValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameValue.Size = new System.Drawing.Size(116, 20);
            this.nameValue.TabIndex = 5;
            this.nameValue.Leave += new System.EventHandler(this.NameValue_Leave);
            // 
            // labelId
            // 
            this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(3, 40);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(85, 13);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "Name";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // probabilityValue
            // 
            this.probabilityValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.probabilityValue.Location = new System.Drawing.Point(490, 36);
            this.probabilityValue.Name = "probabilityValue";
            this.probabilityValue.Size = new System.Drawing.Size(117, 20);
            this.probabilityValue.TabIndex = 6;
            this.probabilityValue.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.probabilityValue.Leave += new System.EventHandler(this.ProbabilityValue_Leave);
            // 
            // probabilityError
            // 
            this.probabilityError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.probabilityError.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.probabilityError, 2);
            this.probabilityError.ForeColor = System.Drawing.Color.Red;
            this.probabilityError.Location = new System.Drawing.Point(368, 98);
            this.probabilityError.Name = "probabilityError";
            this.probabilityError.Size = new System.Drawing.Size(239, 13);
            this.probabilityError.TabIndex = 9;
            this.probabilityError.Text = "probabilityError";
            this.probabilityError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelBurst
            // 
            this.labelBurst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBurst.AutoSize = true;
            this.labelBurst.Location = new System.Drawing.Point(368, 40);
            this.labelBurst.Name = "labelBurst";
            this.labelBurst.Size = new System.Drawing.Size(116, 13);
            this.labelBurst.TabIndex = 3;
            this.labelBurst.Text = "I/O Probability";
            this.labelBurst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SwiftnessList
            // 
            this.SwiftnessList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SwiftnessList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SwiftnessList.FormattingEnabled = true;
            this.SwiftnessList.Location = new System.Drawing.Point(490, 152);
            this.SwiftnessList.Name = "SwiftnessList";
            this.SwiftnessList.Size = new System.Drawing.Size(117, 21);
            this.SwiftnessList.TabIndex = 11;
            this.SwiftnessList.Leave += new System.EventHandler(this.SwiftnessList_Leave);
            // 
            // labelArrival
            // 
            this.labelArrival.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelArrival.AutoSize = true;
            this.labelArrival.Location = new System.Drawing.Point(368, 156);
            this.labelArrival.Name = "labelArrival";
            this.labelArrival.Size = new System.Drawing.Size(116, 13);
            this.labelArrival.TabIndex = 4;
            this.labelArrival.Text = "I/O Swiftness";
            this.labelArrival.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // swiftnessError
            // 
            this.swiftnessError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.swiftnessError.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.swiftnessError, 2);
            this.swiftnessError.ForeColor = System.Drawing.Color.Red;
            this.swiftnessError.Location = new System.Drawing.Point(368, 215);
            this.swiftnessError.Name = "swiftnessError";
            this.swiftnessError.Size = new System.Drawing.Size(239, 13);
            this.swiftnessError.TabIndex = 10;
            this.swiftnessError.Text = "swiftnessError";
            this.swiftnessError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProcessSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProcessSettings";
            this.Size = new System.Drawing.Size(610, 234);
            this.Load += new System.EventHandler(this.ProcessSettings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label probabilityError;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox nameValue;
        private System.Windows.Forms.Label labelBurst;
        private System.Windows.Forms.NumericUpDown probabilityValue;
        private System.Windows.Forms.Label labelArrival;
        private System.Windows.Forms.Label nameError;
        private System.Windows.Forms.ComboBox SwiftnessList;
        private System.Windows.Forms.Label processLength;
        private System.Windows.Forms.NumericUpDown lengthValue;
        private System.Windows.Forms.Label lengthError;
        private System.Windows.Forms.Label swiftnessError;
    }
}
