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

           // Incident newIncident = new Incident(DateTime.Now, responder, tbIncidentDetails.Text, reporter);
          //  incidentdb.InsertNewIncident(newIncident);
            frmViewCrime.instance.dgvCrime.DataSource = crimedb.UpdateCrimeTable();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmViewCrime.instance.Visible = true;
            this.Close();
        }
    }
}
