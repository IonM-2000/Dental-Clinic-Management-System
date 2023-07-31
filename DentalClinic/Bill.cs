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
    public partial class Bill : Form
    {
        private string connStr = "server=localhost;user=root;database=sincretic_bd;port=3306;password=root;pooling=true";
        private ulong id_receipt;

        public Bill(ulong id)
        {
            InitializeComponent();
            this.id_receipt = id;
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            lblBillid.Text = id_receipt.ToString();
            using(MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "CALL generate_receipt(@id_receipt)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_receipt", id_receipt);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                lblAppointmentID.Text = rdr.GetUInt64(0).ToString();
                lblDate.Text = rdr.GetMySqlDateTime(1).Day + "/" + rdr.GetMySqlDateTime(1).Month + "/" + rdr.GetMySqlDateTime(1).Year;
                lblPatientID.Text = rdr.GetUInt64(2).ToString();
                lblSurnameName.Text = rdr.GetString(3);
                lblPaidAmount.Text = rdr.GetFloat(4) + " Lei";
                rdr.Close();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
