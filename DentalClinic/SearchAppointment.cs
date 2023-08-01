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
    public partial class SearchAppointment : Form
    {
        private string connStr = "server=localhost;user=root;database=sincretic_bd;port=3306;password=root;pooling=true";
        private ulong id_dentist;

        public SearchAppointment(ulong id)
        {
            InitializeComponent();
            this.id_dentist = id;
        }

        public SearchAppointment()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new DentistMenu();
            f.ShowDialog();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ulong id_appointment;
            if (dpickerAppointDate.Value > DateTime.Now)
            {
                MessageBox.Show("This date is not valid for an appointment", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query1 = "CALL cautare_consultatie(@surname, @name, @date)";
                    MySqlCommand cmd = new MySqlCommand(query1, conn);
                    cmd.Parameters.AddWithValue("@surname", txtPatientSurname.Text);
                    cmd.Parameters.AddWithValue("@name", txtPatientName.Text);
                    cmd.Parameters.AddWithValue("@date", dpickerAppointDate.Value.ToString("yyyy-MM-dd"));
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.HasRows)
                    {
                        rdr.Read();
                        if (rdr.GetUInt64(5) != id_dentist)
                        {
                            ulong id_dentist_patient;
                            _ = ulong.TryParse(rdr.GetUInt64(5).ToString(), out id_dentist_patient);
                            rdr.Close();
                            string query2 = "SELECT CONCAT(nume, \" \", prenume) AS nume_prenume " +
                                "FROM medici WHERE id_medic = @id_required";
                            cmd = new MySqlCommand(query2, conn);
                            cmd.Parameters.AddWithValue("@id_required", id_dentist_patient);
                            string surname_name = cmd.ExecuteScalar().ToString();

                            MessageBox.Show(txtPatientSurname.Text + " " + txtPatientName.Text +
                            " made an appointment to Dr." + surname_name, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            _ = ulong.TryParse(rdr.GetUInt64(0).ToString(), out id_appointment);
                            rdr.Close();

                            this.Hide();
                            Form f = new NewAppointment(id_appointment);
                            f.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        rdr.Close();
                        MessageBox.Show(txtPatientSurname.Text + " " + txtPatientName.Text +
                            " doesn't have any appointments in " + dpickerAppointDate.Value.ToString("yyyy-MM-dd"), "",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
