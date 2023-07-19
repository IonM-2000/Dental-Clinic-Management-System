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
    public partial class BookAppointment : Form
    {
        private string connStr = "server=localhost;user=root;database=sincretic_bd;port=3306;password=root;pooling=true";
        private ulong id_patient;

        public BookAppointment(ulong id)
        {
            this.id_patient = id;
            InitializeComponent();
        }

        private void BookAppointment_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = "SELECT id_dentist, nume, prenume FROM medici WHERE bool_angajat = 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        cmbRequiredDentist.Items.Add(rdr.GetString(1) + " " + rdr.GetString(2));
                    }
                    rdr.NextResult();
                }
                rdr.Close();
            }
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
            if (dpickerAppointDate.Value < DateTime.Now)
            {
                MessageBox.Show("You cannot make appontments in the past :)", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string[] surname_name = cmbRequiredDentist.SelectedItem.ToString().Split(' ');
                    conn.Open();

                    string query1 = "SELECT id_dentist FROM medici WHERE nume = @surname AND prenume = @name";
                    MySqlCommand cmd = new MySqlCommand(query1, conn);
                    cmd.Parameters.AddWithValue("@surname", surname_name[0].ToString());
                    cmd.Parameters.AddWithValue("@name", surname_name[1].ToString());
                    ulong id_dentist;
                    _ = ulong.TryParse(cmd.ExecuteScalar().ToString(), out id_dentist);

                    string query2 = "SELECT consultatii_medic_zi(@id_dentist,@date)";
                    cmd = new MySqlCommand(query2, conn);
                    cmd.Parameters.AddWithValue("@id_dentist", id_dentist);
                    cmd.Parameters.AddWithValue("@date", dpickerAppointDate.Value.ToString("yyyy-MM-dd"));
                    int nr_consultatii = (int)cmd.ExecuteScalar();

                    string query3 = "CALL programare_pacient(@date, @hour, @surname_dentist, @name_dentist)";
                    cmd = new MySqlCommand(query3, conn);
                    cmd.Parameters.AddWithValue("@date", dpickerAppointDate.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@hour", dpickerAppointDate.Value.ToString("yyyy-MM-dd") + " " + cmbHour.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@surname_dentist", surname_name[0]);
                    cmd.Parameters.AddWithValue("@name_dentist", surname_name[1]);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.HasRows)
                    {
                        if (nr_consultatii == 9)
                        {
                            MessageBox.Show("There is no room for required dentist", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            rdr.Close();
                            string query4 = "CALL consultatii_per_medic(@id_dentist,@date)";
                            cmd = new MySqlCommand(query4, conn);
                            cmd.Parameters.AddWithValue("@id_dentist", id_dentist);
                            cmd.Parameters.AddWithValue("@date", dpickerAppointDate.Value.ToString("yyyy-MM-dd"));
                            MySqlDataReader rdr2 = cmd.ExecuteReader();
                            List<string> available_appointments = new List<string>();
                            foreach (string i in cmbHour.Items)
                            {
                                available_appointments.Add(i);
                            }
                            while (rdr2.HasRows)
                            {
                                int i = 0;
                                int n = available_appointments.Count;
                                rdr2.Read();
                                for (i = 0; i < n;)
                                {
                                    if ((available_appointments[i] + ":00") == rdr2.GetDateTime(5).TimeOfDay.ToString())
                                    {
                                        available_appointments.Remove(available_appointments[i]);
                                        n--;
                                    }
                                    else
                                        i++;
                                }
                                rdr2.NextResult();
                            }
                            if (available_appointments.Count != 0)
                            {
                                MessageBox.Show("Selected hour is unavailable!\nThe list of available hours: "
                                    + string.Join(", ", available_appointments), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            rdr2.Close();
                        }

                    }
                    else
                    {
                        rdr.Close();
                        string query5 = "CALL cautare_fisa(@id_patient)";
                        cmd = new MySqlCommand(query5, conn);
                        cmd.Parameters.AddWithValue("@id_patient", id_patient);
                        ulong id_chart;
                        _ = ulong.TryParse(cmd.ExecuteScalar().ToString(), out id_chart);

                        string date = dpickerAppointDate.Value.ToString("yyyy-MM-dd") + " " + cmbHour.SelectedItem.ToString();
                        string query6 = "CALL insert_consultatie(@id_chart, @id_dentist, @date, @comments)";
                        cmd = new MySqlCommand(query6, conn);
                        cmd.Parameters.AddWithValue("@id_chart", id_chart);
                        cmd.Parameters.AddWithValue("@id_dentist", id_dentist);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@comments", "-");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("An appointment has been made in " + dpickerAppointDate.Value.ToString("yyyy-MM-dd")
                            + ", time " + cmbHour.SelectedItem.ToString() + ", at Dr. " + cmbRequiredDentist.SelectedItem.ToString());

                        cmbRequiredDentist.Text = "";
                        cmbHour.Text = "";
                        dpickerAppointDate.Value = DateTime.Today;
                    }
                }
        }
    }
}
