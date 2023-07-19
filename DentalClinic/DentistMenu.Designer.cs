namespace DentalClinic
{
    partial class DentistMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DentistMenu));
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAppointments = new System.Windows.Forms.Button();
            this.btnPacientDetails = new System.Windows.Forms.Button();
            this.btnNewAppointment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(20, 478);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 36);
            this.btnBack.TabIndex = 52;
            this.btnBack.Text = "<< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(416, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 418);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // btnAppointments
            // 
            this.btnAppointments.Location = new System.Drawing.Point(90, 217);
            this.btnAppointments.Margin = new System.Windows.Forms.Padding(2);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Size = new System.Drawing.Size(280, 50);
            this.btnAppointments.TabIndex = 50;
            this.btnAppointments.Text = "Appointments";
            this.btnAppointments.UseVisualStyleBackColor = true;
            // 
            // btnPacientDetails
            // 
            this.btnPacientDetails.Location = new System.Drawing.Point(90, 153);
            this.btnPacientDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnPacientDetails.Name = "btnPacientDetails";
            this.btnPacientDetails.Size = new System.Drawing.Size(280, 50);
            this.btnPacientDetails.TabIndex = 49;
            this.btnPacientDetails.Text = "Pacient Details";
            this.btnPacientDetails.UseVisualStyleBackColor = true;
            // 
            // btnNewAppointment
            // 
            this.btnNewAppointment.Location = new System.Drawing.Point(90, 85);
            this.btnNewAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewAppointment.Name = "btnNewAppointment";
            this.btnNewAppointment.Size = new System.Drawing.Size(280, 50);
            this.btnNewAppointment.TabIndex = 48;
            this.btnNewAppointment.Text = "New appointment";
            this.btnNewAppointment.UseVisualStyleBackColor = true;
            // 
            // DentistMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 541);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAppointments);
            this.Controls.Add(this.btnPacientDetails);
            this.Controls.Add(this.btnNewAppointment);
            this.Name = "DentistMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - Dentist";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnPacientDetails;
        private System.Windows.Forms.Button btnNewAppointment;
    }
}