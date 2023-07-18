namespace DentalClinic
{
    partial class MainPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnDentist = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(646, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Access your specific role";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(377, 353);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(146, 36);
            this.btnAdmin.TabIndex = 8;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnDentist
            // 
            this.btnDentist.Location = new System.Drawing.Point(377, 302);
            this.btnDentist.Margin = new System.Windows.Forms.Padding(2);
            this.btnDentist.Name = "btnDentist";
            this.btnDentist.Size = new System.Drawing.Size(146, 36);
            this.btnDentist.TabIndex = 7;
            this.btnDentist.Text = "Dentist";
            this.btnDentist.UseVisualStyleBackColor = true;
            // 
            // btnPatient
            // 
            this.btnPatient.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPatient.Location = new System.Drawing.Point(377, 253);
            this.btnPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(146, 36);
            this.btnPatient.TabIndex = 6;
            this.btnPatient.Text = "Patient";
            this.btnPatient.UseVisualStyleBackColor = true;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 541);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnDentist);
            this.Controls.Add(this.btnPatient);
            this.Controls.Add(this.label1);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnDentist;
        private System.Windows.Forms.Button btnPatient;
    }
}

