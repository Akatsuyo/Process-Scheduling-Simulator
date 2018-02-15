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
            this.labelId = new System.Windows.Forms.Label();
            this.labelBurst = new System.Windows.Forms.Label();
            this.labelArrival = new System.Windows.Forms.Label();
            this.idValue = new System.Windows.Forms.TextBox();
            this.burstValue = new System.Windows.Forms.NumericUpDown();
            this.arrivalValue = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.burstValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalValue)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.buttonOK, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonCancel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelId, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelBurst, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelArrival, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.idValue, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.burstValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.arrivalValue, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 161);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(106, 129);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(202, 129);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelId
            // 
            this.labelId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(37, 53);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(21, 13);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "ID:";
            // 
            // labelBurst
            // 
            this.labelBurst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBurst.AutoSize = true;
            this.labelBurst.Location = new System.Drawing.Point(127, 53);
            this.labelBurst.Name = "labelBurst";
            this.labelBurst.Size = new System.Drawing.Size(34, 13);
            this.labelBurst.TabIndex = 3;
            this.labelBurst.Text = "Burst:";
            // 
            // labelArrival
            // 
            this.labelArrival.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelArrival.AutoSize = true;
            this.labelArrival.Location = new System.Drawing.Point(220, 53);
            this.labelArrival.Name = "labelArrival";
            this.labelArrival.Size = new System.Drawing.Size(39, 13);
            this.labelArrival.TabIndex = 4;
            this.labelArrival.Text = "Arrival:";
            // 
            // idValue
            // 
            this.idValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idValue.Location = new System.Drawing.Point(3, 90);
            this.idValue.Name = "idValue";
            this.idValue.Size = new System.Drawing.Size(90, 20);
            this.idValue.TabIndex = 5;
            // 
            // burstValue
            // 
            this.burstValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.burstValue.Location = new System.Drawing.Point(99, 90);
            this.burstValue.Name = "burstValue";
            this.burstValue.Size = new System.Drawing.Size(90, 20);
            this.burstValue.TabIndex = 6;
            // 
            // arrivalValue
            // 
            this.arrivalValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arrivalValue.Location = new System.Drawing.Point(195, 90);
            this.arrivalValue.Name = "arrivalValue";
            this.arrivalValue.Size = new System.Drawing.Size(90, 20);
            this.arrivalValue.TabIndex = 7;
            // 
            // NewProcessDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NewProcessDialog";
            this.Text = "New Process";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.burstValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelBurst;
        private System.Windows.Forms.Label labelArrival;
        private System.Windows.Forms.TextBox idValue;
        private System.Windows.Forms.NumericUpDown burstValue;
        private System.Windows.Forms.NumericUpDown arrivalValue;
    }
}