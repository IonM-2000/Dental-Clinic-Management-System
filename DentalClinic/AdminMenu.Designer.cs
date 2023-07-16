namespace DentalClinic
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPayStubs = new System.Windows.Forms.Button();
            this.btnIncompleteAppoint = new System.Windows.Forms.Button();
            this.btnCashing = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(20, 478);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 36);
            this.btnBack.TabIndex = 57;
            this.btnBack.Text = "<< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(416, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 418);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // btnPayStubs
            // 
            this.btnPayStubs.Location = new System.Drawing.Point(90, 217);
            this.btnPayStubs.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayStubs.Name = "btnPayStubs";
            this.btnPayStubs.Size = new System.Drawing.Size(280, 50);
            this.btnPayStubs.TabIndex = 55;
            this.btnPayStubs.Text = "Pay stubs";
            this.btnPayStubs.UseVisualStyleBackColor = true;
            // 
            // btnIncompleteAppoint
            // 
            this.btnIncompleteAppoint.Location = new System.Drawing.Point(90, 153);
            this.btnIncompleteAppoint.Margin = new System.Windows.Forms.Padding(2);
            this.btnIncompleteAppoint.Name = "btnIncompleteAppoint";
            this.btnIncompleteAppoint.Size = new System.Drawing.Size(280, 50);
            this.btnIncompleteAppoint.TabIndex = 54;
            this.btnIncompleteAppoint.Text = "Partially paid appointments";
            this.btnIncompleteAppoint.UseVisualStyleBackColor = true;
            // 
            // btnCashing
            // 
            this.btnCashing.Location = new System.Drawing.Point(90, 85);
            this.btnCashing.Margin = new System.Windows.Forms.Padding(2);
            this.btnCashing.Name = "btnCashing";
            this.btnCashing.Size = new System.Drawing.Size(280, 50);
            this.btnCashing.TabIndex = 53;
            this.btnCashing.Text = "View cashing";
            this.btnCashing.UseVisualStyleBackColor = true;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 541);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPayStubs);
            this.Controls.Add(this.btnIncompleteAppoint);
            this.Controls.Add(this.btnCashing);
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - administrator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPayStubs;
        private System.Windows.Forms.Button btnIncompleteAppoint;
        private System.Windows.Forms.Button btnCashing;
    }
}