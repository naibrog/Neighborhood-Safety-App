using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Incident
    {
        public DateTime reportTime;
        public FirstResponder responder;
        public string incidentDetails;
        public User reporter;
        //asdf
        //asdf
        //asdf
        //asdf
        public Incident() { }
        public Incident(DateTime reportTime, FirstResponder responder, string incidentDetails, User reporter)
        {
            this.reportTime = reportTime;
            this.responder = responder;
            this.incidentDetails = incidentDetails;
            this.reporter = reporter;
        }
        public DateTime IncidentDate { get { return this.reportTime; } set { reportTime = value; } }
        public FirstResponder FirstResponder { get { return this.responder; } set { this.responder = value; } }
        public string IncidentDetails { get {  return this.incidentDetails; } set {  incidentDetails = value; } }
        public User Reporter { get { return this.reporter; } set { this.reporter = value; } }



    }
}
