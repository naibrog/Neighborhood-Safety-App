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
        string tableName = "Incident";
        public DataTable UpdateCrimeTable(string connection)
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
