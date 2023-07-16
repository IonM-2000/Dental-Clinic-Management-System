namespace DentalClinic
{
    partial class Cashing
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
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMonth = new System.Windows.Forms.Button();
            this.dpickerRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDay = new System.Windows.Forms.Button();
            this.dgvCashing = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashing)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.Location = new System.Drawing.Point(655, 413);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(127, 24);
            this.lblTotalAmount.TabIndex = 67;
            this.lblTotalAmount.Text = "45670.00 Lei";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(478, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 24);
            this.label3.TabIndex = 66;
            this.label3.Text = "Cashing overall";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(22, 494);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 36);
            this.btnBack.TabIndex = 65;
            this.btnBack.Text = "<< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnMonth
            // 
            this.btnMonth.Location = new System.Drawing.Point(204, 82);
            this.btnMonth.Margin = new System.Windows.Forms.Padding(2);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(100, 24);
            this.btnMonth.TabIndex = 64;
            this.btnMonth.Text = "Per month";
            this.btnMonth.UseVisualStyleBackColor = true;
            // 
            // dpickerRequiredDate
            // 
            this.dpickerRequiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpickerRequiredDate.Location = new System.Drawing.Point(224, 58);
            this.dpickerRequiredDate.Name = "dpickerRequiredDate";
            this.dpickerRequiredDate.Size = new System.Drawing.Size(109, 20);
            this.dpickerRequiredDate.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Enter the date: ";
            // 
            // btnDay
            // 
            this.btnDay.Location = new System.Drawing.Point(120, 82);
            this.btnDay.Margin = new System.Windows.Forms.Padding(2);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(80, 24);
            this.btnDay.TabIndex = 61;
            this.btnDay.Text = "Per day";
            this.btnDay.UseVisualStyleBackColor = true;
            // 
            // dgvCashing
            // 
            this.dgvCashing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCashing.Location = new System.Drawing.Point(97, 122);
            this.dgvCashing.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCashing.Name = "dgvCashing";
            this.dgvCashing.RowHeadersWidth = 51;
            this.dgvCashing.RowTemplate.Height = 24;
            this.dgvCashing.Size = new System.Drawing.Size(723, 280);
            this.dgvCashing.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "CASHING";
            // 
            // Cashing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 541);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMonth);
            this.Controls.Add(this.dpickerRequiredDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDay);
            this.Controls.Add(this.dgvCashing);
            this.Controls.Add(this.label1);
            this.Name = "Cashing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View cashing";
            this.Load += new System.EventHandler(this.Cashing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.DateTimePicker dpickerRequiredDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.DataGridView dgvCashing;
        private System.Windows.Forms.Label label1;
    }
}