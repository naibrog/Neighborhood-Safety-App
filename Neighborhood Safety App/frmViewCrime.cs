using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neighborhood_Safety_App
{
    public partial class frmViewCrime : Form
    {
        public static frmViewCrime instance;
        public CrimeDB viewCrime = new CrimeDB();
        public frmViewCrime()
        {
            instance = this;
            InitializeComponent();
        }

        private void frmViewCrime_Load(object sender, EventArgs e)
        {
            dgvCrime.DataSource = viewCrime.UpdateCrimeTable();
            dgvCrime.Columns["ID"].Visible = false;
        }

        private void pbFileReport_Click(object sender, EventArgs e)
        {
            instance.Hide();
            frmAddIncident newIncident = new frmAddIncident();
            newIncident.ShowDialog();
        }

        private void dgvCrime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
