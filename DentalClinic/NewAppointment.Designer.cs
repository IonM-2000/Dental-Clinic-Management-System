namespace DentalClinic
{
    partial class NewAppointment
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
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbInterventions = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbIntervention = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.nmrIntervention = new System.Windows.Forms.NumericUpDown();
            this.tbCharge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMaterialCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbComments = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrIntervention)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(776, 484);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(97, 36);
            this.btnPayment.TabIndex = 67;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(657, 166);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 66;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // lbInterventions
            // 
            this.lbInterventions.FormattingEnabled = true;
            this.lbInterventions.Items.AddRange(new object[] {
            "Drenaj dinte temporar",
            "Extracție dinte temporar + anestezie fara ac pt copii"});
            this.lbInterventions.Location = new System.Drawing.Point(322, 166);
            this.lbInterventions.Name = "lbInterventions";
            this.lbInterventions.Size = new System.Drawing.Size(329, 108);
            this.lbInterventions.TabIndex = 65;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(657, 124);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 64;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbIntervention
            // 
            this.cmbIntervention.FormattingEnabled = true;
            this.cmbIntervention.Location = new System.Drawing.Point(322, 125);
            this.cmbIntervention.Name = "cmbIntervention";
            this.cmbIntervention.Size = new System.Drawing.Size(290, 21);
            this.cmbIntervention.TabIndex = 63;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(11, 484);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 36);
            this.btnBack.TabIndex = 62;
            this.btnBack.Text = "<< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // nmrIntervention
            // 
            this.nmrIntervention.Location = new System.Drawing.Point(618, 125);
            this.nmrIntervention.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nmrIntervention.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrIntervention.Name = "nmrIntervention";
            this.nmrIntervention.Size = new System.Drawing.Size(33, 20);
            this.nmrIntervention.TabIndex = 61;
            this.nmrIntervention.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbCharge
            // 
            this.tbCharge.Location = new System.Drawing.Point(322, 445);
            this.tbCharge.Margin = new System.Windows.Forms.Padding(2);
            this.tbCharge.Name = "tbCharge";
            this.tbCharge.Size = new System.Drawing.Size(174, 20);
            this.tbCharge.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 448);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Charge";
            // 
            // tbMaterialCost
            // 
            this.tbMaterialCost.Location = new System.Drawing.Point(322, 412);
            this.tbMaterialCost.Margin = new System.Windows.Forms.Padding(2);
            this.tbMaterialCost.Name = "tbMaterialCost";
            this.tbMaterialCost.Size = new System.Drawing.Size(174, 20);
            this.tbMaterialCost.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 417);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Cost of materials";
            // 
            // tbComments
            // 
            this.tbComments.Location = new System.Drawing.Point(322, 285);
            this.tbComments.Margin = new System.Windows.Forms.Padding(2);
            this.tbComments.Name = "tbComments";
            this.tbComments.Size = new System.Drawing.Size(329, 95);
            this.tbComments.TabIndex = 56;
            this.tbComments.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 285);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Comments";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Interventions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "APPOINTMENT DETAILS";
            // 
            // NewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 541);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbInterventions);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbIntervention);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.nmrIntervention);
            this.Controls.Add(this.tbCharge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbMaterialCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbComments);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "NewAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New appointment";
            this.Load += new System.EventHandler(this.NewAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrIntervention)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lbInterventions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbIntervention;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.NumericUpDown nmrIntervention;
        private System.Windows.Forms.TextBox tbCharge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMaterialCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox tbComments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}