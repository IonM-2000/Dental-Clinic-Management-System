namespace DentalClinic
{
    partial class IncompleteAppointments
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
            this.dgvPartiallyPaid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartiallyPaid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(22, 485);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 36);
            this.btnBack.TabIndex = 62;
            this.btnBack.Text = "<< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // dgvPartiallyPaid
            // 
            this.dgvPartiallyPaid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartiallyPaid.Location = new System.Drawing.Point(101, 111);
            this.dgvPartiallyPaid.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPartiallyPaid.Name = "dgvPartiallyPaid";
            this.dgvPartiallyPaid.RowHeadersWidth = 51;
            this.dgvPartiallyPaid.RowTemplate.Height = 24;
            this.dgvPartiallyPaid.Size = new System.Drawing.Size(723, 280);
            this.dgvPartiallyPaid.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 26);
            this.label1.TabIndex = 60;
            this.label1.Text = "PATIENTS THAT HAVE PAID ONLY \r\nA PART OF THEIR APPOINTMENT";
            // 
            // IncompleteAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 541);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvPartiallyPaid);
            this.Controls.Add(this.label1);
            this.Name = "IncompleteAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Partially paid appointments";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartiallyPaid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvPartiallyPaid;
        private System.Windows.Forms.Label label1;
    }
}