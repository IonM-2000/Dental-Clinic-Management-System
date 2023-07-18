using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class CreateAccount : Form
    {
        private string connStr = "server=localhost;user=root;database=sincretic_bd;port=3306;password=root;pooling=true";

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new PatientAuthentication();
            f.ShowDialog();
            this.Close();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = "CALL insert_pacient(@username, @password, @cnp, @surname, @name, @birthdate, @address, @phone)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@cnp", txtCNP.Text);
                cmd.Parameters.AddWithValue("@surname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@birthdate", dpickerBirthDate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("New account was succesfully created!");

                foreach (Control c in this.Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        c.Text = string.Empty;
                    }
                }
                dpickerBirthDate.Value = DateTime.Today;
            }
        }
    }
}
