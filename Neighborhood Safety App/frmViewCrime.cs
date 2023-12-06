using ClassLibrary;
using Neighborhood_Safety_App.Properties;
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
    public partial class frmViewCrime : Form
    {
        public string ReporterName { get { return lblUser.Text; } set { lblUser.Text = value; } }

        public static frmViewCrime instance;
        public CrimeDB viewCrime = new CrimeDB();
        public IncidentDB incidentDB = new IncidentDB();
        public List<Incident> incidentList = new List<Incident>();
        Button hideButton;
        public frmViewCrime()
        {
            instance = this;
            InitializeComponent();


        }

        private void frmViewCrime_Load(object sender, EventArgs e)
        {
            dgvCrime.DataSource = viewCrime.UpdateCrimeTable();
            dgvCrime.Columns["ID"].Visible = false;
            dgvCrime.Visible = false;


           
            

        }

        private void pbFileReport_Click(object sender, EventArgs e)
        {
            instance.Hide();
            frmAddIncident newIncident = new frmAddIncident();
            newIncident.ReporterName = ReporterName;
            newIncident.ShowDialog();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            frmLogIn.instance.Visible = true;
            this.Close();
        }

        private void btnViewCrimes_Click(object sender, EventArgs e)
        {
            incidentList = incidentDB.GetIncidentToList(incidentList);

            int ControlWidth = 100;
            int ControlHeight = 20;
            int Top = 20;
            int OffsetFromLeft = 10;
            int ControlSpacing = 1;


            int offsetFromTop = Top;


            for (int i = 0; i < incidentList.Count; i++)
            {
                {
                    Label lblIncidentDate = new Label();
                    lblIncidentDate.Name = "Incident Date";
                    lblIncidentDate.Text = incidentList[i].IncidentDate;
                    lblIncidentDate.Size = new System.Drawing.Size(ControlWidth, ControlHeight);

                    offsetFromTop = offsetFromTop + lblIncidentDate.Height + ControlSpacing;
                    lblIncidentDate.Location = new System.Drawing.Point(OffsetFromLeft, offsetFromTop);

                    this.Controls.Add(lblIncidentDate);

                    Label lblFirstResponder = new Label();
                    lblFirstResponder.Name = "IncidentFirstResponder";
                    lblFirstResponder.Text = incidentList[i].FirstResponder;
                    lblFirstResponder.Size = new System.Drawing.Size(ControlWidth, ControlHeight);

                    // offsetFromTop = offsetFromTop + lblFirstResponder.Height + ControlSpacing;
                    lblFirstResponder.Location = new System.Drawing.Point(OffsetFromLeft + 100, offsetFromTop);

                    this.Controls.Add(lblFirstResponder);

                    Label lblDetails = new Label();
                    lblDetails.Name = "lblDetails";
                    lblDetails.Text = incidentList[i].IncidentDetails;
                    lblDetails.Size = new System.Drawing.Size(ControlWidth, ControlHeight);

                    // offsetFromTop = offsetFromTop + lblDetails.Height + ControlSpacing + 5;
                    lblDetails.Location = new System.Drawing.Point(OffsetFromLeft + 200, offsetFromTop);

                    this.Controls.Add(lblDetails);

                    Label lblReporter = new Label();
                    lblReporter.Name = "lblReporter";
                    lblReporter.Text = incidentList[i].Reporter;
                    lblReporter.Size = new System.Drawing.Size(ControlWidth, ControlHeight);

                    // offsetFromTop = offsetFromTop + lblReporter.Height + ControlSpacing + 5;
                    lblReporter.Location = new System.Drawing.Point(OffsetFromLeft + 300, offsetFromTop);

                    this.Controls.Add(lblReporter);

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Location = new System.Drawing.Point(OffsetFromLeft + 400, offsetFromTop);
                    pictureBox.ImageLocation = incidentList[i].PictureURL;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Name = "pbPictureBox";
                    pictureBox.Text = incidentList[i].PictureURL;
                    pictureBox.Size = new System.Drawing.Size(ControlWidth + 20, ControlHeight + 20);

                    this.Controls.Add(pictureBox);

                    offsetFromTop += lblIncidentDate.Height + ControlSpacing;

                    ControlSpacing += 50;
                    offsetFromTop = Top;
                }
                btnViewCrimes.Visible = false;
                /*   hideButton = new Button();
                  hideButton.Location = new System.Drawing.Point(61, 15);
                  hideButton.Name = "btnVHideCrimes";
                  hideButton.Size = new System.Drawing.Size(75, 23);
                  hideButton.TabIndex = 4;
                  hideButton.Text = "Hide Crimes";
                  hideButton.UseVisualStyleBackColor = true;
                  hideButton.Click += new System.EventHandler(this.btnVHideCrimes_Click);

                  this.Controls.Add(hideButton);
                  // this.Controls.Clear();



              }

          }
          private void btnVHideCrimes_Click(object sender, EventArgs e)
          {
              hideButton.Visible = false;
              this.Controls.Remove(lblIncidentDate);
              btnViewCrimes.Visible = true;
          } */
            }
        }  }
}
