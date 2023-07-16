namespace DentalClinic
{
    partial class AppointmentDetails
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
            this.btnWeek = new System.Windows.Forms.Button();
            this.dpickerRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDay = new System.Windows.Forms.Button();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(24, 482);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 36);
            this.btnBack.TabIndex = 56;
            this.btnBack.Text = "<< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnWeek
            // 
            this.btnWeek.Location = new System.Drawing.Point(201, 78);
            this.btnWeek.Margin = new System.Windows.Forms.Padding(2);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(100, 24);
            this.btnWeek.TabIndex = 55;
            this.btnWeek.Text = "Per week";
            this.btnWeek.UseVisualStyleBackColor = true;
            // 
            // dpickerRequiredDate
            // 
            this.dpickerRequiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpickerRequiredDate.Location = new System.Drawing.Point(221, 54);
            this.dpickerRequiredDate.Name = "dpickerRequiredDate";
            this.dpickerRequiredDate.Size = new System.Drawing.Size(109, 20);
            this.dpickerRequiredDate.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Enter the date:";
            // 
            // btnDay
            // 
            this.btnDay.Location = new System.Drawing.Point(117, 78);
            this.btnDay.Margin = new System.Windows.Forms.Padding(2);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(80, 24);
            this.btnDay.TabIndex = 52;
            this.btnDay.Text = "Per day";
            this.btnDay.UseVisualStyleBackColor = true;
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Location = new System.Drawing.Point(94, 118);
            this.dgvAppointments.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.RowHeadersWidth = 51;
            this.dgvAppointments.RowTemplate.Height = 24;
            this.dgvAppointments.Size = new System.Drawing.Size(723, 280);
            this.dgvAppointments.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "APOINTMENT DETAILS";
            // 
            // AppointmentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 541);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnWeek);
            this.Controls.Add(this.dpickerRequiredDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDay);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.label1);
            this.Name = "AppointmentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment Details";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnWeek;
        private System.Windows.Forms.DateTimePicker dpickerRequiredDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Label label1;
    }
}