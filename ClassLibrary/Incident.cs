using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class Incident
    {

        public string reportTime;
        public string responder;
        public string incidentDetails;
        public string reporter;
        public string pictureURL;


        public Incident() { }
        public Incident(string reportTime, string responder, string incidentDetails, string reporter)
        {
            this.reportTime = reportTime;
            this.responder = responder;
            this.incidentDetails = incidentDetails;
            this.reporter = reporter;

        }
        public string IncidentDate { get { return this.reportTime; } set { reportTime = value; } }
        public string FirstResponder { get { return this.responder; } set { this.responder = value; } }
        public string IncidentDetails { get { return this.incidentDetails; } set { incidentDetails = value; } }
        public string Reporter { get { return this.reporter; } set { this.reporter = value; } }
        public string PictureURL { get { return this.pictureURL; } set { this.pictureURL = value; } }


    }
}
