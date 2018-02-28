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
            this.arrivalError = new System.Windows.Forms.Label();
            this.burstError = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.nameValue = new System.Windows.Forms.TextBox();
            this.labelBurst = new System.Windows.Forms.Label();
            this.burstValue = new System.Windows.Forms.NumericUpDown();
            this.labelArrival = new System.Windows.Forms.Label();
            this.arrivalValue = new System.Windows.Forms.NumericUpDown();
            this.nameError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.priorityValue = new System.Windows.Forms.NumericUpDown();
            this.priorityError = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.burstValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityValue)).BeginInit();
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
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.arrivalError, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.burstError, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelId, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.nameValue, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelBurst, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.burstValue, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelArrival, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.arrivalValue, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.nameError, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.priorityValue, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.priorityError, 2, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(92, 14);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99812F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(339, 140);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // arrivalError
            // 
            this.arrivalError.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.arrivalError.AutoSize = true;
            this.arrivalError.ForeColor = System.Drawing.Color.Red;
            this.arrivalError.Location = new System.Drawing.Point(153, 81);
            this.arrivalError.Name = "arrivalError";
            this.arrivalError.Size = new System.Drawing.Size(57, 13);
            this.arrivalError.TabIndex = 10;
            this.arrivalError.Text = "arrivalError";
            // 
            // burstError
            // 
            this.burstError.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.burstError.AutoSize = true;
            this.burstError.ForeColor = System.Drawing.Color.Red;
            this.burstError.Location = new System.Drawing.Point(153, 46);
            this.burstError.Name = "burstError";
            this.burstError.Size = new System.Drawing.Size(52, 13);
            this.burstError.TabIndex = 9;
            this.burstError.Text = "burstError";
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
            this.nameValue.Location = new System.Drawing.Point(53, 7);
            this.nameValue.MaxLength = 16;
            this.nameValue.Name = "nameValue";
            this.nameValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameValue.Size = new System.Drawing.Size(80, 20);
            this.nameValue.TabIndex = 5;
            // 
            // labelBurst
            // 
            this.labelBurst.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelBurst.AutoSize = true;
            this.labelBurst.Location = new System.Drawing.Point(3, 46);
            this.labelBurst.Name = "labelBurst";
            this.labelBurst.Size = new System.Drawing.Size(31, 13);
            this.labelBurst.TabIndex = 3;
            this.labelBurst.Text = "Burst";
            // 
            // burstValue
            // 
            this.burstValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.burstValue.Location = new System.Drawing.Point(53, 42);
            this.burstValue.Name = "burstValue";
            this.burstValue.Size = new System.Drawing.Size(40, 20);
            this.burstValue.TabIndex = 6;
            this.burstValue.Value = new decimal(new int[] {
            1,
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
            this.labelArrival.Size = new System.Drawing.Size(36, 13);
            this.labelArrival.TabIndex = 4;
            this.labelArrival.Text = "Arrival";
            // 
            // arrivalValue
            // 
            this.arrivalValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.arrivalValue.Location = new System.Drawing.Point(53, 77);
            this.arrivalValue.Name = "arrivalValue";
            this.arrivalValue.Size = new System.Drawing.Size(40, 20);
            this.arrivalValue.TabIndex = 7;
            // 
            // nameError
            // 
            this.nameError.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameError.AutoSize = true;
            this.nameError.ForeColor = System.Drawing.Color.Red;
            this.nameError.Location = new System.Drawing.Point(153, 11);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(55, 13);
            this.nameError.TabIndex = 8;
            this.nameError.Text = "nameError";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Priority";
            // 
            // priorityValue
            // 
            this.priorityValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.priorityValue.Location = new System.Drawing.Point(53, 112);
            this.priorityValue.Name = "priorityValue";
            this.priorityValue.Size = new System.Drawing.Size(40, 20);
            this.priorityValue.TabIndex = 12;
            // 
            // priorityError
            // 
            this.priorityError.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.priorityError.AutoSize = true;
            this.priorityError.ForeColor = System.Drawing.Color.Red;
            this.priorityError.Location = new System.Drawing.Point(153, 116);
            this.priorityError.Name = "priorityError";
            this.priorityError.Size = new System.Drawing.Size(59, 13);
            this.priorityError.TabIndex = 13;
            this.priorityError.Text = "priorityError";
            // 
            // ProcessDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 211);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProcessDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Process";
            this.Load += new System.EventHandler(this.ProcessDialog_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.burstValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown burstValue;
        private System.Windows.Forms.Label labelBurst;
        private System.Windows.Forms.Label labelArrival;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox nameValue;
        private System.Windows.Forms.NumericUpDown arrivalValue;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label arrivalError;
        private System.Windows.Forms.Label burstError;
        private System.Windows.Forms.Label nameError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown priorityValue;
        private System.Windows.Forms.Label priorityError;
    }
}