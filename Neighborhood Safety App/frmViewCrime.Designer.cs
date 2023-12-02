namespace Neighborhood_Safety_App
{
    partial class frmViewCrime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewCrime));
            this.pbFileReport = new System.Windows.Forms.PictureBox();
            this.dgvCrime = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbFileReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrime)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFileReport
            // 
            this.pbFileReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbFileReport.BackgroundImage")));
            this.pbFileReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFileReport.Location = new System.Drawing.Point(64, 260);
            this.pbFileReport.Name = "pbFileReport";
            this.pbFileReport.Size = new System.Drawing.Size(100, 50);
            this.pbFileReport.TabIndex = 0;
            this.pbFileReport.TabStop = false;
            this.pbFileReport.Click += new System.EventHandler(this.pbFileReport_Click);
            // 
            // dgvCrime
            // 
            this.dgvCrime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrime.Location = new System.Drawing.Point(41, 45);
            this.dgvCrime.Name = "dgvCrime";
            this.dgvCrime.RowHeadersWidth = 51;
            this.dgvCrime.Size = new System.Drawing.Size(483, 151);
            this.dgvCrime.TabIndex = 1;
            this.dgvCrime.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCrime_CellContentClick);
            // 
            // frmViewCrime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(609, 391);
            this.Controls.Add(this.dgvCrime);
            this.Controls.Add(this.pbFileReport);
            this.Name = "frmViewCrime";
            this.Text = "frmViewCrime";
            this.Load += new System.EventHandler(this.frmViewCrime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFileReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFileReport;
        public System.Windows.Forms.DataGridView dgvCrime;
    }
}