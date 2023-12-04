namespace Neighborhood_Safety_App
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPw = new System.Windows.Forms.Label();
            this.pbHelp = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.dgvLogin = new System.Windows.Forms.DataGridView();
            this.lblUsernameinstr = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(241, 184);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(95, 36);
            this.btnCreateAccount.TabIndex = 0;
            this.btnCreateAccount.Text = "Create an Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(328, 150);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // lblPw
            // 
            this.lblPw.AutoSize = true;
            this.lblPw.Location = new System.Drawing.Point(238, 152);
            this.lblPw.Name = "lblPw";
            this.lblPw.Size = new System.Drawing.Size(84, 13);
            this.lblPw.TabIndex = 3;
            this.lblPw.Text = "Enter Password:";
            // 
            // pbHelp
            // 
            this.pbHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbHelp.BackgroundImage")));
            this.pbHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbHelp.Location = new System.Drawing.Point(502, 326);
            this.pbHelp.Name = "pbHelp";
            this.pbHelp.Size = new System.Drawing.Size(56, 24);
            this.pbHelp.TabIndex = 4;
            this.pbHelp.TabStop = false;
            this.pbHelp.Click += new System.EventHandler(this.pbHelp_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Poor Richard", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(31, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(494, 43);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Neighborhood Community Watch";
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(119, 191);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 6;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // dgvLogin
            // 
            this.dgvLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogin.Location = new System.Drawing.Point(305, 340);
            this.dgvLogin.Name = "dgvLogin";
            this.dgvLogin.Size = new System.Drawing.Size(42, 10);
            this.dgvLogin.TabIndex = 7;
            this.dgvLogin.Visible = false;
            // 
            // lblUsernameinstr
            // 
            this.lblUsernameinstr.AutoSize = true;
            this.lblUsernameinstr.Location = new System.Drawing.Point(12, 152);
            this.lblUsernameinstr.Name = "lblUsernameinstr";
            this.lblUsernameinstr.Size = new System.Drawing.Size(86, 13);
            this.lblUsernameinstr.TabIndex = 9;
            this.lblUsernameinstr.Text = "Enter Username:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(102, 150);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 20);
            this.tbUsername.TabIndex = 8;
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(557, 349);
            this.Controls.Add(this.lblUsernameinstr);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.dgvLogin);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbHelp);
            this.Controls.Add(this.lblPw);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnCreateAccount);
            this.Name = "frmLogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPw;
        private System.Windows.Forms.PictureBox pbHelp;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.DataGridView dgvLogin;
        private System.Windows.Forms.Label lblUsernameinstr;
        private System.Windows.Forms.TextBox tbUsername;
    }
}

