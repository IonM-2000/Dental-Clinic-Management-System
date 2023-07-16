namespace DentalClinic
{
    partial class Payment
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
            this.btnIssue = new System.Windows.Forms.Button();
            this.lblRemainigSum = new System.Windows.Forms.Label();
            this.txtNowPaying = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(101, 140);
            this.btnIssue.Margin = new System.Windows.Forms.Padding(2);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(97, 36);
            this.btnIssue.TabIndex = 53;
            this.btnIssue.Text = "Issue the receipt";
            this.btnIssue.UseVisualStyleBackColor = true;
            // 
            // lblRemainigSum
            // 
            this.lblRemainigSum.AutoSize = true;
            this.lblRemainigSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblRemainigSum.Location = new System.Drawing.Point(115, 60);
            this.lblRemainigSum.Name = "lblRemainigSum";
            this.lblRemainigSum.Size = new System.Drawing.Size(67, 17);
            this.lblRemainigSum.TabIndex = 52;
            this.lblRemainigSum.Text = "0.00 Lei";
            // 
            // txtNowPaying
            // 
            this.txtNowPaying.Location = new System.Drawing.Point(111, 88);
            this.txtNowPaying.Name = "txtNowPaying";
            this.txtNowPaying.Size = new System.Drawing.Size(100, 20);
            this.txtNowPaying.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Now paying";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "To Pay";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.lblRemainigSum);
            this.Controls.Add(this.txtNowPaying);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Label lblRemainigSum;
        private System.Windows.Forms.TextBox txtNowPaying;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}