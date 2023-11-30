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
    public partial class frmLogIn : Form
    {
        public static frmLogIn instance;
        public frmLogIn()
        {
            instance = this;
            InitializeComponent();
        }
        string strConnection = "provider=Microsoft.ACE.OLEDB.12.0; Data Source = SafetyDatabase.accdb;";

        private void pbHelp_Click(object sender, EventArgs e)
        {
            frmLogInHelp instructions = new frmLogInHelp();
            instructions.ShowDialog();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            frmAccountCreation createAccount = new frmAccountCreation();
            createAccount.ShowDialog();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            frmViewCrime viewCrimes = new frmViewCrime();
            viewCrimes.ShowDialog();
            instance.Hide();
        }
    }
}
