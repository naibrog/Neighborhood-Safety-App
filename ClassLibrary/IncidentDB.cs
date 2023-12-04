using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class IncidentDB
    {
        string connection = "provider=Microsoft.ACE.OLEDB.12.0; Data Source = SafetyDatabase.accdb;";
        string tableName = "Incident";
        public void InsertNewIncident(Incident newIncident)
        {
            string sqlCommand = $"INSERT INTO {tableName} " +
                 $"(IncidentDate, FirstResponder, IncidentDetails,Reporter) VALUES ('{newIncident.IncidentDate}', '{newIncident.FirstResponder}', '{newIncident.IncidentDetails}', '{newIncident.Reporter} )";
            OleDbConnection myConnection = new OleDbConnection(connection);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(sqlCommand, myConnection);

            DataSet menuDataSet = new DataSet(tableName);

            myDataAdapter.Fill(menuDataSet, tableName);

            DataTable menuTable = menuDataSet.Tables[tableName];


        }
    }
}
