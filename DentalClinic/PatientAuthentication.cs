using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class PatientAuthentication : Form
    {
        private string connStr = "server=localhost;user=root;database=sincretic_bd;port=3306;password=root;pooling=true";

        public PatientAuthentication()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = "CALL cauta_pacient_logare(@username, @password)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                conn.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    ulong id_patient;
                    _ = ulong.TryParse(rdr.GetUInt64(0).ToString(), out id_patient);

                    this.Hide();
                    Form f = new BookAppointment(id_patient);
                    f.ShowDialog();
                    rdr.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong username or password!");
                }
                rdr.Close();
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new CreateAccount();
            f.ShowDialog();
            this.Close();
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new MainPage();
            f.ShowDialog();
            this.Close();
        }
    }
}
