using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ClassLibrary
{
    public class LoginDB
    {
        string connection = "provider=Microsoft.ACE.OLEDB.12.0; Data Source = SafetyDatabase.accdb;";
        string tableName = "UserLogIn";
        /*
        internal void ClearFrmAddToMenu()
        {
            cboCategory.Text = "Select Category";
            txtShortDescription.Text = "";
            txtLongDescription.Text = "";
            txtRetailPrice.Text = "";
            txtManufactureCost.Text = "";
            txtPictureURL.Text = "";
        } */
        public void BindData()
        {
            string sqlCommand = $"SELECT * FROM {tableName}";
            OleDbConnection myConnection = new OleDbConnection(connection);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(sqlCommand, myConnection);

            DataSet crimeDataSet = new DataSet(tableName);

            myDataAdapter.Fill(crimeDataSet, tableName);
            BindingSource myBindingSource = new BindingSource();
            myBindingSource.DataSource = crimeDataSet;
            myBindingSource.DataMember = tableName;

            Binding objUserNameBinding = new Binding("Text", myBindingSource, "UserName");
        }

        public void InsertNewUser(User newUser)
        {
                string sqlCommand = $"INSERT INTO {tableName} " +
                     $"(UserName, Password, FirstName, LastName, Email, PhoneNumber, StreetAddress, City, State, ZipCode)" +
                     $" VALUES ('{newUser.UserName}', '{newUser.Password}', '{newUser.FirstName}', '{newUser.LastName}'," +
                     $" '{newUser.Email}', '{newUser.Phone}','{newUser.StreetAddress}','{newUser.City}'," +
                     $"'{newUser.State}','{newUser.ZipCode}' )";
                OleDbConnection myConnection = new OleDbConnection(connection);
                OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(sqlCommand, myConnection);

                DataSet menuDataSet = new DataSet(tableName);

                myDataAdapter.Fill(menuDataSet, tableName);

                DataTable menuTable = menuDataSet.Tables[tableName];

            
        }
        public DataTable UpdateLogInTable()
        {
            string sqlCommand = $"SELECT * FROM {tableName}";
            OleDbConnection myConnection = new OleDbConnection(connection);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(sqlCommand, myConnection);

            DataSet crimeDataSet = new DataSet(tableName);

            myDataAdapter.Fill(crimeDataSet, tableName);

            DataTable crimeTable = crimeDataSet.Tables[tableName];
            return crimeTable;
        }

        public bool IfAccountExists( string username, string password)
        {
            string strCommand = $"SELECT COUNT(*) FROM  {tableName} WHERE UserName = '" + username + " '" +
                 "AND Password = '" + password + "'";

            OleDbConnection myConnection = new OleDbConnection(connection);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(strCommand, myConnection);

            DataSet crimeDataSet = new DataSet(tableName);

            myDataAdapter.Fill(crimeDataSet, tableName);

            DataTable crimeTable = crimeDataSet.Tables[tableName];


            return true;
        }
    }
}
