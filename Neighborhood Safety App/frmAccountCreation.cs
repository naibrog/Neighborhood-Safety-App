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
    public partial class frmAccountCreation : Form
    {
        LoginDB loginDB = new LoginDB();

        public frmAccountCreation()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // Validate the input fields
            if (!ValidateInput())
            {
                // Display an error message if validation fails
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if validation fails
            }

            // Your account creation logic goes here...

            // Display a success message
            MessageBox.Show("Account successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the form or perform any other necessary actions
            ClearForm();
        }

        // Method to validate input fields
        private bool ValidateInput()
        {
            // Add your validation logic here
            // For example, check if required fields are not empty
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                return false;
            }

            // Add more validation checks as needed...

            return true; // Validation successful
        }

        // Method to clear the form
        private void ClearForm()
        {
            // Clear all input fields
            txtID.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtLoginDate.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtBirthDate.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            txtStreetAddress.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtZipCode.Text = "";
            btnCreateAccount.BackColor = System.Drawing.Color.AliceBlue;
        }

        private void frmAccountCreation_Load(object sender, EventArgs e)
        {

        }
    }
}