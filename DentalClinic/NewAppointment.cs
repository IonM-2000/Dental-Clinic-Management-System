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
    public partial class NewAppointment : Form
    {
        private string connStr = "server=localhost;user=root;database=sincretic_bd;port=3306;password=root;pooling=true";
        ulong id_appointment;
        public NewAppointment(ulong id)
        {
            InitializeComponent();
            this.id_appointment = id;
        }

        private void NewAppointment_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = "SELECT * FROM interventii ORDER BY tip";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        cmbIntervention.Items.Add(rdr.GetString(1));
                    }
                    rdr.NextResult();
                }
                rdr.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new SearchAppointment();
            f.ShowDialog();
            this.Close();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Form f = new Payment();
            f.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string searched_type = cmbIntervention.SelectedValue.ToString();
            int cnt_interventions = (int)nmrIntervention.Value;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query1 = "CALL cautare_interventie(@type)";
                MySqlCommand cmd = new MySqlCommand(query1, conn);
                conn.Open();
                ulong id_to_add;
                _ = ulong.TryParse(cmd.ExecuteScalar().ToString(), out id_to_add);
                for (int i = 0; i < cnt_interventions; i++)
                {
                    cmbIntervention.Items.Add(searched_type);
                    string query2 = "CALL insert_consultatie_interventie(@id_appointment, @id_intervention)";
                    cmd = new MySqlCommand(query2, conn);
                    cmd.Parameters.AddWithValue("@id_appointment", id_appointment);
                    cmd.Parameters.AddWithValue("@id_intervention", id_to_add);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
