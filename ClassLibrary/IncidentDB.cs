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
                 $"(IncidentDate, FirstResponder, IncidentDetails,Reporter, Picture ) VALUES ('{newIncident.IncidentDate}', '{newIncident.FirstResponder}', '{newIncident.IncidentDetails}', '{newIncident.Reporter}', '{newIncident.PictureURL}' )";
            OleDbConnection myConnection = new OleDbConnection(connection);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(sqlCommand, myConnection);

            DataSet menuDataSet = new DataSet(tableName);

            myDataAdapter.Fill(menuDataSet, tableName);

            DataTable menuTable = menuDataSet.Tables[tableName];


        }
        public List<Incident> GetIncidentToList(List<Incident> incidentList)
        {
            string sqlCommand = $"Select * from {tableName}";
            OleDbConnection myConnection = new OleDbConnection(connection);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(sqlCommand, myConnection);

            DataSet menuDataSet = new DataSet(tableName);

            myDataAdapter.Fill(menuDataSet, tableName);

            DataTable menuTable = menuDataSet.Tables[tableName];

            {
                foreach (DataRow row in menuTable.Rows)
                {
                    Incident incident = new Incident();

                    incident.IncidentDate = row["IncidentDate"].ToString();
                    incident.FirstResponder = row["FirstResponder"].ToString();
                    incident.IncidentDetails = row["IncidentDetails"].ToString();
                    incident.Reporter = row["Reporter"].ToString();
                    incident.PictureURL = row["Picture"].ToString();

                    incidentList.Add(incident);
                }
            }
            return incidentList;
        }
    }
}
