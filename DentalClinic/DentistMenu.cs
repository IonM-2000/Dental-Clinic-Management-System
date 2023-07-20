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
    public partial class DentistMenu : Form
    {
        private ulong id_dentist;
        public DentistMenu(ulong id)
        {
            InitializeComponent();
            this.id_dentist = id;
        }
        public DentistMenu()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new DentistAuthentication();
            f.ShowDialog();
            this.Close();
        }

        private void btnNewAppointment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new SearchAppointment(id_dentist);
            f.ShowDialog();
            this.Close();
        }

        private void btnPacientDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new PacientDetails();
            f.ShowDialog();
            this.Close();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new AppointmentDetails();
            f.ShowDialog();
            this.Close();
        }
    }
}
