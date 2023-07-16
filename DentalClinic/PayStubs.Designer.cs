namespace DentalClinic
{
    partial class PayStubs
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
            this.btnBack = new System.Windows.Forms.Button();
            this.dpickerRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPayStubs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayStubs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(23, 482);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 36);
            this.btnBack.TabIndex = 66;
            this.btnBack.Text = "<< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // dpickerRequiredDate
            // 
            this.dpickerRequiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpickerRequiredDate.Location = new System.Drawing.Point(231, 70);
            this.dpickerRequiredDate.Name = "dpickerRequiredDate";
            this.dpickerRequiredDate.Size = new System.Drawing.Size(109, 20);
            this.dpickerRequiredDate.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Enter the date:";
            // 
            // dgvPayStubs
            // 
            this.dgvPayStubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayStubs.Location = new System.Drawing.Point(105, 108);
            this.dgvPayStubs.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPayStubs.Name = "dgvPayStubs";
            this.dgvPayStubs.RowHeadersWidth = 51;
            this.dgvPayStubs.RowTemplate.Height = 24;
            this.dgvPayStubs.Size = new System.Drawing.Size(723, 280);
            this.dgvPayStubs.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "MONTHLY PAY STUBS";
            // 
            // PayStubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 541);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dpickerRequiredDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPayStubs);
            this.Controls.Add(this.label1);
            this.Name = "PayStubs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay stubs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayStubs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dpickerRequiredDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPayStubs;
        private System.Windows.Forms.Label label1;
    }
}