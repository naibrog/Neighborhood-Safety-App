using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CrimeDB
    {
        public CrimeDB() { }

        string connection = "provider=Microsoft.ACE.OLEDB.12.0; Data Source = SafetyDatabase.accdb;";
        string tableName = "Incident";
        public DataTable UpdateCrimeTable()
        {
            string sqlCommand = $"SELECT * FROM {tableName}";
            OleDbConnection myConnection = new OleDbConnection(connection);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(sqlCommand, myConnection);

            DataSet crimeDataSet = new DataSet(tableName);

            myDataAdapter.Fill(crimeDataSet, tableName);

            DataTable crimeTable = crimeDataSet.Tables[tableName];
            return crimeTable;
        }
        public void ReportNewIncident(string connection, Incident newIncident)
        {
            string sqlCommand = $"INSERT INTO {tableName} " +
             $"(IncidentDate, FirstResponder, IncidentDetails, Reporter ('{newIncident.IncidentDate}', '{newIncident.FirstResponder}', '{newIncident.IncidentDetails}', '{newIncident.Reporter})";
            OleDbConnection myConnection = new OleDbConnection(connection);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(sqlCommand, myConnection);

            DataSet crimeDataSet = new DataSet(tableName);

            myDataAdapter.Fill(crimeDataSet, tableName);

            DataTable crimeTable = crimeDataSet.Tables[tableName];
        }
    }
}
