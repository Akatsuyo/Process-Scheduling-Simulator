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
            this.burstValue = new System.Windows.Forms.NumericUpDown();
            this.labelBurst = new System.Windows.Forms.Label();
            this.labelArrival = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.idValue = new System.Windows.Forms.TextBox();
            this.arrivalValue = new System.Windows.Forms.NumericUpDown();
            this.idError = new System.Windows.Forms.Label();
            this.burstError = new System.Windows.Forms.Label();
            this.arrivalError = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.burstValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalValue)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 161);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonOK.Location = new System.Drawing.Point(144, 133);
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
            this.buttonCancel.Location = new System.Drawing.Point(220, 133);
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
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.arrivalError, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.burstError, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelId, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.idValue, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelBurst, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.burstValue, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelArrival, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.arrivalValue, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.idError, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(92, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(339, 104);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // burstValue
            // 
            this.burstValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.burstValue.Location = new System.Drawing.Point(53, 41);
            this.burstValue.Name = "burstValue";
            this.burstValue.Size = new System.Drawing.Size(40, 20);
            this.burstValue.TabIndex = 6;
            this.burstValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelBurst
            // 
            this.labelBurst.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelBurst.AutoSize = true;
            this.labelBurst.Location = new System.Drawing.Point(3, 44);
            this.labelBurst.Name = "labelBurst";
            this.labelBurst.Size = new System.Drawing.Size(31, 13);
            this.labelBurst.TabIndex = 3;
            this.labelBurst.Text = "Burst";
            // 
            // labelArrival
            // 
            this.labelArrival.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelArrival.AutoSize = true;
            this.labelArrival.Location = new System.Drawing.Point(3, 79);
            this.labelArrival.Name = "labelArrival";
            this.labelArrival.Size = new System.Drawing.Size(36, 13);
            this.labelArrival.TabIndex = 4;
            this.labelArrival.Text = "Arrival";
            // 
            // labelId
            // 
            this.labelId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(3, 10);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "ID";
            // 
            // idValue
            // 
            this.idValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.idValue.Location = new System.Drawing.Point(53, 7);
            this.idValue.MaxLength = 16;
            this.idValue.Name = "idValue";
            this.idValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.idValue.Size = new System.Drawing.Size(80, 20);
            this.idValue.TabIndex = 5;
            // 
            // arrivalValue
            // 
            this.arrivalValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.arrivalValue.Location = new System.Drawing.Point(53, 76);
            this.arrivalValue.Name = "arrivalValue";
            this.arrivalValue.Size = new System.Drawing.Size(40, 20);
            this.arrivalValue.TabIndex = 7;
            // 
            // idError
            // 
            this.idError.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.idError.AutoSize = true;
            this.idError.ForeColor = System.Drawing.Color.Red;
            this.idError.Location = new System.Drawing.Point(153, 10);
            this.idError.Name = "idError";
            this.idError.Size = new System.Drawing.Size(37, 13);
            this.idError.TabIndex = 8;
            this.idError.Text = "idError";
            // 
            // burstError
            // 
            this.burstError.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.burstError.AutoSize = true;
            this.burstError.ForeColor = System.Drawing.Color.Red;
            this.burstError.Location = new System.Drawing.Point(153, 44);
            this.burstError.Name = "burstError";
            this.burstError.Size = new System.Drawing.Size(52, 13);
            this.burstError.TabIndex = 9;
            this.burstError.Text = "burstError";
            // 
            // arrivalError
            // 
            this.arrivalError.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.arrivalError.AutoSize = true;
            this.arrivalError.ForeColor = System.Drawing.Color.Red;
            this.arrivalError.Location = new System.Drawing.Point(153, 79);
            this.arrivalError.Name = "arrivalError";
            this.arrivalError.Size = new System.Drawing.Size(57, 13);
            this.arrivalError.TabIndex = 10;
            this.arrivalError.Text = "arrivalError";
            // 
            // ProcessDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 161);
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
        private System.Windows.Forms.TextBox idValue;
        private System.Windows.Forms.NumericUpDown arrivalValue;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label arrivalError;
        private System.Windows.Forms.Label burstError;
        private System.Windows.Forms.Label idError;
    }
}