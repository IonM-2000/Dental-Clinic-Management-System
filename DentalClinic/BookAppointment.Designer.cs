namespace DentalClinic
{
    partial class BookAppointment
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
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dpickerAppointDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRequiredDentist = new System.Windows.Forms.ComboBox();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(477, 372);
            this.btnProceed.Margin = new System.Windows.Forms.Padding(2);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(97, 36);
            this.btnProceed.TabIndex = 57;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(313, 372);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 36);
            this.btnBack.TabIndex = 56;
            this.btnBack.Text = "<< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // dpickerAppointDate
            // 
            this.dpickerAppointDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpickerAppointDate.Location = new System.Drawing.Point(376, 188);
            this.dpickerAppointDate.Margin = new System.Windows.Forms.Padding(2);
            this.dpickerAppointDate.Name = "dpickerAppointDate";
            this.dpickerAppointDate.Size = new System.Drawing.Size(198, 20);
            this.dpickerAppointDate.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Date";
            // 
            // cmbRequiredDentist
            // 
            this.cmbRequiredDentist.FormattingEnabled = true;
            this.cmbRequiredDentist.Location = new System.Drawing.Point(376, 290);
            this.cmbRequiredDentist.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRequiredDentist.Name = "cmbRequiredDentist";
            this.cmbRequiredDentist.Size = new System.Drawing.Size(198, 21);
            this.cmbRequiredDentist.TabIndex = 53;
            // 
            // cmbHour
            // 
            this.cmbHour.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Items.AddRange(new object[] {
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00"});
            this.cmbHour.Location = new System.Drawing.Point(376, 239);
            this.cmbHour.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(198, 21);
            this.cmbHour.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 297);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Dentist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Hour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "BOOK AN APPOINTMENT";
            // 
            // BookAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 541);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dpickerAppointDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbRequiredDentist);
            this.Controls.Add(this.cmbHour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment booking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dpickerAppointDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRequiredDentist;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}