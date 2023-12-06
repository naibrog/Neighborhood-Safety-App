namespace Neighborhood_Safety_App
{
    partial class frmAddIncident
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddIncident));
            this.tbIncidentDetails = new System.Windows.Forms.TextBox();
            this.pbReportButton = new System.Windows.Forms.PictureBox();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.radMentalHealth = new System.Windows.Forms.RadioButton();
            this.radFireDept = new System.Windows.Forms.RadioButton();
            this.radAmbulance = new System.Windows.Forms.RadioButton();
            this.radPolice = new System.Windows.Forms.RadioButton();
            this.lblReporterName = new System.Windows.Forms.Label();
            this.tbPicture = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbReportButton)).BeginInit();
            this.gbType.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbIncidentDetails
            // 
            this.tbIncidentDetails.Location = new System.Drawing.Point(151, 153);
            this.tbIncidentDetails.Margin = new System.Windows.Forms.Padding(2);
            this.tbIncidentDetails.Name = "tbIncidentDetails";
            this.tbIncidentDetails.Size = new System.Drawing.Size(170, 20);
            this.tbIncidentDetails.TabIndex = 1;
            this.tbIncidentDetails.Text = "Incident Details";
            // 
            // pbReportButton
            // 
            this.pbReportButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbReportButton.BackgroundImage")));
            this.pbReportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbReportButton.Location = new System.Drawing.Point(182, 235);
            this.pbReportButton.Name = "pbReportButton";
            this.pbReportButton.Size = new System.Drawing.Size(109, 103);
            this.pbReportButton.TabIndex = 2;
            this.pbReportButton.TabStop = false;
            this.pbReportButton.Click += new System.EventHandler(this.pbReportButton_Click);
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.radMentalHealth);
            this.gbType.Controls.Add(this.radFireDept);
            this.gbType.Controls.Add(this.radAmbulance);
            this.gbType.Controls.Add(this.radPolice);
            this.gbType.Location = new System.Drawing.Point(151, 30);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(170, 118);
            this.gbType.TabIndex = 3;
            this.gbType.TabStop = false;
            this.gbType.Text = "Responder Type";
            // 
            // radMentalHealth
            // 
            this.radMentalHealth.AutoSize = true;
            this.radMentalHealth.Location = new System.Drawing.Point(7, 92);
            this.radMentalHealth.Name = "radMentalHealth";
            this.radMentalHealth.Size = new System.Drawing.Size(148, 26);
            this.radMentalHealth.TabIndex = 3;
            this.radMentalHealth.TabStop = true;
            this.radMentalHealth.Text = "Mental Health Services";
            this.radMentalHealth.UseVisualStyleBackColor = true;
            // 
            // radFireDept
            // 
            this.radFireDept.AutoSize = true;
            this.radFireDept.Location = new System.Drawing.Point(7, 68);
            this.radFireDept.Name = "radFireDept";
            this.radFireDept.Size = new System.Drawing.Size(113, 26);
            this.radFireDept.TabIndex = 2;
            this.radFireDept.TabStop = true;
            this.radFireDept.Text = "Fire Department";
            this.radFireDept.UseVisualStyleBackColor = true;
            // 
            // radAmbulance
            // 
            this.radAmbulance.AutoSize = true;
            this.radAmbulance.Location = new System.Drawing.Point(7, 44);
            this.radAmbulance.Name = "radAmbulance";
            this.radAmbulance.Size = new System.Drawing.Size(91, 26);
            this.radAmbulance.TabIndex = 1;
            this.radAmbulance.TabStop = true;
            this.radAmbulance.Text = "Ambulance";
            this.radAmbulance.UseVisualStyleBackColor = true;
            // 
            // radPolice
            // 
            this.radPolice.AutoSize = true;
            this.radPolice.Location = new System.Drawing.Point(7, 20);
            this.radPolice.Name = "radPolice";
            this.radPolice.Size = new System.Drawing.Size(67, 26);
            this.radPolice.TabIndex = 0;
            this.radPolice.TabStop = true;
            this.radPolice.Text = "Police";
            this.radPolice.UseVisualStyleBackColor = true;
            // 
            // lblReporterName
            // 
            this.lblReporterName.AutoSize = true;
            this.lblReporterName.Location = new System.Drawing.Point(80, 10);
            this.lblReporterName.Name = "lblReporterName";
            this.lblReporterName.Size = new System.Drawing.Size(63, 13);
            this.lblReporterName.TabIndex = 4;
            this.lblReporterName.Text = "report name";
            // 
            // tbPicture
            // 
            this.tbPicture.Location = new System.Drawing.Point(151, 190);
            this.tbPicture.Margin = new System.Windows.Forms.Padding(2);
            this.tbPicture.Name = "tbPicture";
            this.tbPicture.Size = new System.Drawing.Size(170, 20);
            this.tbPicture.TabIndex = 6;
            this.tbPicture.Text = "Add picture url";
            // 
            // frmAddIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(470, 372);
            this.Controls.Add(this.tbPicture);
            this.Controls.Add(this.lblReporterName);
            this.Controls.Add(this.gbType);
            this.Controls.Add(this.pbReportButton);
            this.Controls.Add(this.tbIncidentDetails);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddIncident";
            this.Text = "frmAddIncident";
            ((System.ComponentModel.ISupportInitialize)(this.pbReportButton)).EndInit();
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbIncidentDetails;
        private System.Windows.Forms.PictureBox pbReportButton;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.RadioButton radMentalHealth;
        private System.Windows.Forms.RadioButton radFireDept;
        private System.Windows.Forms.RadioButton radAmbulance;
        private System.Windows.Forms.RadioButton radPolice;
        private System.Windows.Forms.Label lblReporterName;
        private System.Windows.Forms.TextBox tbPicture;
    }
}