namespace PSS
{
    partial class ProcessDialog
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lengthError = new System.Windows.Forms.Label();
            this.swiftnessError = new System.Windows.Forms.Label();
            this.probabilityError = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.nameValue = new System.Windows.Forms.TextBox();
            this.labelBurst = new System.Windows.Forms.Label();
            this.probabilityValue = new System.Windows.Forms.NumericUpDown();
            this.labelArrival = new System.Windows.Forms.Label();
            this.nameError = new System.Windows.Forms.Label();
            this.SwiftnessList = new System.Windows.Forms.ComboBox();
            this.processLength = new System.Windows.Forms.Label();
            this.lengthValue = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthValue)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonOK, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonCancel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 211);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonOK.Location = new System.Drawing.Point(144, 178);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(70, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(220, 178);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            this.tableLayoutPanel2.Controls.Add(this.lengthError, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.swiftnessError, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.probabilityError, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelId, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.nameValue, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelBurst, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.probabilityValue, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelArrival, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.nameError, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.SwiftnessList, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.processLength, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lengthValue, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 14);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(428, 140);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // lengthError
            // 
            this.lengthError.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lengthError.AutoSize = true;
            this.lengthError.ForeColor = System.Drawing.Color.Red;
            this.lengthError.Location = new System.Drawing.Point(165, 116);
            this.lengthError.Name = "lengthError";
            this.lengthError.Size = new System.Drawing.Size(58, 13);
            this.lengthError.TabIndex = 14;
            this.lengthError.Text = "lengthError";
            // 
            // swiftnessError
            // 
            this.swiftnessError.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.swiftnessError.AutoSize = true;
            this.swiftnessError.ForeColor = System.Drawing.Color.Red;
            this.swiftnessError.Location = new System.Drawing.Point(165, 81);
            this.swiftnessError.Name = "swiftnessError";
            this.swiftnessError.Size = new System.Drawing.Size(72, 13);
            this.swiftnessError.TabIndex = 10;
            this.swiftnessError.Text = "swiftnessError";
            // 
            // probabilityError
            // 
            this.probabilityError.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.probabilityError.AutoSize = true;
            this.probabilityError.ForeColor = System.Drawing.Color.Red;
            this.probabilityError.Location = new System.Drawing.Point(165, 46);
            this.probabilityError.Name = "probabilityError";
            this.probabilityError.Size = new System.Drawing.Size(76, 13);
            this.probabilityError.TabIndex = 9;
            this.probabilityError.Text = "probabilityError";
            // 
            // labelId
            // 
            this.labelId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(3, 11);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(35, 13);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "Name";
            // 
            // nameValue
            // 
            this.nameValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameValue.Location = new System.Drawing.Point(85, 7);
            this.nameValue.MaxLength = 16;
            this.nameValue.Name = "nameValue";
            this.nameValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameValue.Size = new System.Drawing.Size(74, 20);
            this.nameValue.TabIndex = 5;
            // 
            // labelBurst
            // 
            this.labelBurst.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelBurst.AutoSize = true;
            this.labelBurst.Location = new System.Drawing.Point(3, 46);
            this.labelBurst.Name = "labelBurst";
            this.labelBurst.Size = new System.Drawing.Size(74, 13);
            this.labelBurst.TabIndex = 3;
            this.labelBurst.Text = "I/O Probability";
            // 
            // probabilityValue
            // 
            this.probabilityValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.probabilityValue.Location = new System.Drawing.Point(85, 42);
            this.probabilityValue.Name = "probabilityValue";
            this.probabilityValue.Size = new System.Drawing.Size(40, 20);
            this.probabilityValue.TabIndex = 6;
            this.probabilityValue.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // labelArrival
            // 
            this.labelArrival.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelArrival.AutoSize = true;
            this.labelArrival.Location = new System.Drawing.Point(3, 81);
            this.labelArrival.Name = "labelArrival";
            this.labelArrival.Size = new System.Drawing.Size(71, 13);
            this.labelArrival.TabIndex = 4;
            this.labelArrival.Text = "I/O Swiftness";
            // 
            // nameError
            // 
            this.nameError.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameError.AutoSize = true;
            this.nameError.ForeColor = System.Drawing.Color.Red;
            this.nameError.Location = new System.Drawing.Point(165, 11);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(55, 13);
            this.nameError.TabIndex = 8;
            this.nameError.Text = "nameError";
            // 
            // SwiftnessList
            // 
            this.SwiftnessList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SwiftnessList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SwiftnessList.FormattingEnabled = true;
            this.SwiftnessList.Location = new System.Drawing.Point(85, 77);
            this.SwiftnessList.Name = "SwiftnessList";
            this.SwiftnessList.Size = new System.Drawing.Size(74, 21);
            this.SwiftnessList.TabIndex = 11;
            // 
            // processLength
            // 
            this.processLength.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.processLength.AutoSize = true;
            this.processLength.Location = new System.Drawing.Point(3, 116);
            this.processLength.Name = "processLength";
            this.processLength.Size = new System.Drawing.Size(40, 13);
            this.processLength.TabIndex = 12;
            this.processLength.Text = "Length";
            // 
            // lengthValue
            // 
            this.lengthValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lengthValue.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.lengthValue.Location = new System.Drawing.Point(85, 112);
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
            this.lengthValue.Size = new System.Drawing.Size(74, 20);
            this.lengthValue.TabIndex = 13;
            this.lengthValue.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ProcessDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(434, 211);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProcessDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Process";
            this.Load += new System.EventHandler(this.ProcessDialog_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown probabilityValue;
        private System.Windows.Forms.Label labelBurst;
        private System.Windows.Forms.Label labelArrival;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox nameValue;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label swiftnessError;
        private System.Windows.Forms.Label probabilityError;
        private System.Windows.Forms.Label nameError;
        private System.Windows.Forms.ComboBox SwiftnessList;
        private System.Windows.Forms.Label lengthError;
        private System.Windows.Forms.Label processLength;
        private System.Windows.Forms.NumericUpDown lengthValue;
    }
}