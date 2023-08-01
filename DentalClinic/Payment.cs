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
    public partial class Payment : Form
    {
        private string connStr = "server=localhost;user=root;database=sincretic_bd;port=3306;password=root;pooling=true";
        private ulong id_appointment;
        private float total_fee;
        private float paid_fee;

        public Payment(ulong id)
        {
            InitializeComponent();
            this.id_appointment = id;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            using(MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM consultatii WHERE id_consultatie = " + id_appointment;
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                total_fee = rdr.GetFloat(4) - rdr.GetFloat(5);
                lblRemainigSum.Text = total_fee + "Lei";
                paid_fee = rdr.GetFloat(5);
                rdr.Close();
            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            float to_pay = float.Parse(txtNowPaying.Text);
            ulong id_receipt = 0;
            if(to_pay > total_fee)
            {
                MessageBox.Show("The paying amount exceeds remaining fee!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(to_pay <= total_fee)
                {
                    using (MySqlConnection conn = new MySqlConnection(connStr))
                    {
                        conn.Open();
                        string query = "CALL insert_chitanta(@id_appointment, @paying_amount)";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id_appointment", id_appointment);
                        cmd.Parameters.AddWithValue("@paying_amount", to_pay);
                        cmd.ExecuteNonQuery();

                        string query1 = "SELECT LAST_INSERT_ID()";
                        cmd = new MySqlCommand(query1, conn);
                        MySqlDataReader rdr = cmd.ExecuteReader();
                        rdr.Read();
                        _ = ulong.TryParse(rdr.GetUInt64(0).ToString(), out id_receipt);
                        rdr.Close();

                        string query2 = "UPDATE consultatii " +
                            "SET cost_achitat = cost_achitat + " + to_pay +
                            " WHERE id_consultatie = " + id_appointment;
                        cmd = new MySqlCommand(query2, conn);
                        cmd.ExecuteNonQuery();
                    }
                    if(to_pay < total_fee)
                    {
                        MessageBox.Show("The remaining fee to pay is " + (total_fee - to_pay) + " Lei", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Hide();
                    Form f = new Bill(id_receipt);
                    f.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
