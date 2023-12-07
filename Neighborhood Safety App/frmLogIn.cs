using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
        LoginDB loginDB = new LoginDB();
        public frmLogIn()
        {
            instance = this;
            InitializeComponent();
            
        }
       public List<User> userList = new List<User>();

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            
            /*  string connection = "provider=Microsoft.ACE.OLEDB.12.0; Data Source = SafetyDatabase.accdb;";
              string tableName = "UserLogIn";

              string sqlCommand = $"SELECT * FROM {tableName}";
              OleDbConnection myConnection = new OleDbConnection(connection);
              OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(sqlCommand, myConnection);

              DataSet crimeDataSet = new DataSet(tableName);

              myDataAdapter.Fill(crimeDataSet, tableName);
              BindingSource myBindingSource = new BindingSource();
              myBindingSource.DataSource = crimeDataSet;
              myBindingSource.DataMember = tableName;

              Binding objUserNameBinding = new Binding("Text", myBindingSource, "UserName");
              cboUserName.DataBindings.Add(objUserNameBinding);
            */

            dgvLogin.SelectAll();
            dgvLogin.DataSource = loginDB.UpdateLogInTable();
            foreach(DataGridView row in dgvLogin.SelectedRows)
            {
                User user = new User();
                user.UserName = row.Columns["UserName"].ToString();
                user.Password = row.Columns["Password"].ToString();
                user.FirstName = row.Columns["FirstName"].ToString() ;
                user.LastName = row.Columns["LastName"].ToString();
                user.Email = row.Columns["Email"].ToString();
                user.Phone = row.Columns["PhoneNumber"].ToString();
                user.StreetAddress = row.Columns["StreetAddress"].ToString();
                user.City = row.Columns["City"].ToString();
                user.State = row.Columns["State"].ToString();
                user.ZipCode = row.Columns["ZipCode"].ToString();
                userList.Add(user);
            }

         //   cboUserName.DataSource = userList;
        //    cboUserName.DisplayMember = "UserName";
         //   cboUserName.ValueMember = "Phone";
         

            string userName = tbUsername.Text;


        }
        private void pbHelp_Click(object sender, EventArgs e)
        {
            frmLogInHelp instructions = new frmLogInHelp();
            instructions.Show();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            frmAccountCreation createAccount = new frmAccountCreation();
            createAccount.ShowDialog();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (loginDB.IfAccountExists(tbUsername.Text, txtPassword.Text))
            {
                User user = new User();
                user.UserName = tbUsername.Text;

                instance.Hide();
                frmViewCrime viewCrimes = new frmViewCrime();
                viewCrimes.ReporterName = user.UserName;

                viewCrimes.ShowDialog();
            }
            else
            {
                string message = "username/password is  incorrect";
                MessageBox.Show(message);
            }
        }

        
    }
}
