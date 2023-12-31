﻿using ClassLibrary;
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
    public partial class frmAddIncident : Form
    {
        IncidentDB incidentdb = new IncidentDB();
        CrimeDB crimedb = new CrimeDB();
   

        public string ReporterName { get { return lblReporterName.Text; } set { lblReporterName.Text = value; } }
        public frmAddIncident()
        {
            InitializeComponent();
        }

        private void pbReportButton_Click(object sender, EventArgs e)
        {
            FirstResponder firstResponder = new FirstResponder();
            if (radAmbulance.Checked == true) { firstResponder.Type = "Ambulance"; }
            else if(radFireDept.Checked == true) { firstResponder.Type = "FireDept"; }
            else if(radPolice.Checked == true) { firstResponder.Type = "Police"; }
            else if(radMentalHealth.Checked == true) { firstResponder.Type = "MentalHealth"; }

            string responder =  firstResponder.Type;
            string reporter =   frmViewCrime.instance.ReporterName;
            string pictureURL = tbPicture.Text;
            string incidentDetails = tbIncidentDetails.Text;
            string date = DateTime.Now.ToString();

            Incident newIncident = new Incident(date, responder, incidentDetails, reporter, pictureURL);
            incidentdb.InsertNewIncident(newIncident);
            frmViewCrime.instance.dgvCrime.DataSource = crimedb.UpdateCrimeTable();
         //   List<Incident> newCrimes = new List<Incident>();
            frmViewCrime.instance.incidentList.Add(newIncident);


            //how to update the form????
            frmViewCrime.instance.Refresh();
            // frmViewCrime.instance.Visible = true;

            this.Hide();
            frmViewCrime newCrimeForm = new frmViewCrime();
            newCrimeForm.ShowDialog();
           
            this.Close();

            
        }

        
    }
}
