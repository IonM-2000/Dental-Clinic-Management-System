using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X500;
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
        private ulong id_appointment;
        private float materials_cost;
        private float charge;

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

                string query1 = "SELECT * FROM consultatie_interventie " +
                    "INNER JOIN interventii USING(id_interventie)" +
                    "WHERE id_consultatie = \"" + id_appointment + "\"";
                cmd = new MySqlCommand(query1, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        lbInterventions.Items.Add(rdr.GetString(3));
                        materials_cost += rdr.GetFloat(4);
                        charge += rdr.GetFloat(5);
                    }
                    rdr.NextResult();
                }
                rdr.Close();

                string query2 = "SELECT * FROM consultatii WHERE id_consultatie = " + id_appointment;
                cmd = new MySqlCommand(query2, conn);
                rdr = cmd.ExecuteReader();
                rdr.Read();
                txtComments.Text = rdr.GetString(6);
                rdr.Close();

                lbInterventions.Refresh();
                txtMaterialCost.Text = materials_cost.ToString() + " Lei";
                txtCharge.Text = charge.ToString() + " Lei";
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
            float total_fee = 0f;
            float paid_fee = 0f;
            using(MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM consultatii WHERE id_consultatie = " + id_appointment;
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                total_fee = rdr.GetFloat(4);
                paid_fee = rdr.GetFloat(5);
                rdr.Close();
            }
            if(total_fee == paid_fee)
            {
                MessageBox.Show("This appointment has been paid.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (lbInterventions.Items.Count == 0)
                {
                    MessageBox.Show("There is no intervention selected!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using (MySqlConnection conn = new MySqlConnection(connStr))
                    {
                        string comments = txtComments.Text;
                        conn.Open();
                        string query = "CALL update_consultatie(@id_appointment, @total_charge, @comments)";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id_appointment", id_appointment);
                        cmd.Parameters.AddWithValue("@total_charge", materials_cost + charge);
                        cmd.Parameters.AddWithValue("@comments", comments);
                        cmd.ExecuteNonQuery();
                    }
                    Form f = new Payment(id_appointment);
                    f.ShowDialog();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmbIntervention.Refresh();
            string searched_type = cmbIntervention.Items[cmbIntervention.SelectedIndex].ToString();
            int cnt_interventions = (int)nmrIntervention.Value;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query1 = "CALL cautare_interventie(@type)";
                MySqlCommand cmd = new MySqlCommand(query1, conn);
                cmd.Parameters.AddWithValue("@type", searched_type);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                ulong id_to_add;
                _ = ulong.TryParse(rdr.GetUInt64(0).ToString(), out id_to_add);
                materials_cost += (cnt_interventions * rdr.GetFloat(2));
                charge += (cnt_interventions * rdr.GetFloat(3));
                txtMaterialCost.Text = materials_cost.ToString() + " Lei";
                txtCharge.Text = charge.ToString() + " Lei";
                txtMaterialCost.Refresh();
                txtCharge.Refresh();
                rdr.Close();
                for (int i = 0; i < cnt_interventions; i++)
                { 
                    lbInterventions.Items.Add(searched_type);
                    lbInterventions.Refresh();
                    string query2 = "CALL insert_consultatie_interventie(@id_appointment, @id_intervention)";
                    cmd = new MySqlCommand(query2, conn);
                    cmd.Parameters.AddWithValue("@id_appointment", id_appointment);
                    cmd.Parameters.AddWithValue("@id_intervention", id_to_add);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string deleted_type = lbInterventions.SelectedItem.ToString();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "CALL cautare_interventie(@type)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@type", deleted_type);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                ulong id_to_delete;
                _ = ulong.TryParse(rdr.GetUInt64(0).ToString(), out id_to_delete);
                materials_cost -= rdr.GetFloat(2);
                charge -= rdr.GetFloat(3);
                txtMaterialCost.Text = materials_cost.ToString() + " Lei";
                txtCharge.Text = charge.ToString() + " Lei";
                txtMaterialCost.Refresh();
                txtCharge.Refresh();
                rdr.Close();

                string query1 = "DELETE FROM consultatie_interventie " +
                    "WHERE id_interventie = " + id_to_delete +
                    " AND id_consultatie = " + id_appointment + " LIMIT 1";
                cmd = new MySqlCommand(query1, conn);
                cmd.ExecuteNonQuery();
                lbInterventions.Items.RemoveAt(lbInterventions.SelectedIndex);
                lbInterventions.Refresh();
            }
        }

        private void NewAppointment_FormClosing(object sender, FormClosingEventArgs e)
        {
            txtMaterialCost.Text = "";
            txtCharge.Text = "";
            materials_cost = 0f;
            charge = 0f;
        }
    }
}