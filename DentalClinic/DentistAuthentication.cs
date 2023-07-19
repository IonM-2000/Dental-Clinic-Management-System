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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DentalClinic
{
    public partial class DentistAuthentication : Form
    {
        private string connStr = "server=localhost;user=root;database=sincretic_bd;port=3306;password=root;pooling=true";

        public DentistAuthentication()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new MainPage();
            f.ShowDialog();
            this.Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {

                string query = "CALL cauta_medic_logare(@username, @password)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                conn.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    ulong id_dentist;
                    _ = ulong.TryParse(rdr.GetUInt64(0).ToString(), out id_dentist);
                    this.Hide();
                    Form f = new DentistMenu(id_dentist);
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
    }
}
