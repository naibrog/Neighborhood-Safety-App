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
        public CrimeDB viewCrime = new CrimeDB();
        string strConnection = "provider=Microsoft.ACE.OLEDB.12.0; Data Source = SafetyDatabase.accdb;";
        public frmViewCrime()
        {
            InitializeComponent();
        }

        private void frmViewCrime_Load(object sender, EventArgs e)
        {
            dgvCrime.DataSource = viewCrime.UpdateCrimeTable(strConnection);
            dgvCrime.Columns["ID"].Visible = false;
        }
    }
}
