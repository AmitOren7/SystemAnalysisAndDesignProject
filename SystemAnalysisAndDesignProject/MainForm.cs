using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAnalysisAndDesignProject
{
    public partial class MainForm : Form
    {
        private Label lblError;
        public MainForm()
        {
            InitializeComponent();

            lblError = new Label
            {
                Name = "lblError",
                Text = "",
                ForeColor = Color.Red,
                AutoSize = true,
                Location = new Point(20, 150) // Adjust location as needed
            };


            txtUsername = new TextBox
            {
                Name = "txtUsername",
                Text = "",
                Location = new Point(20, 50), // Adjust location as needed
                Size = new Size(200, 30)      // Adjust size as needed
            };

            // Add the TextBox to the form
            this.Controls.Add(txtUsername);

        }

        private void Username(object sender, EventArgs e)
        {

        }
        private void Password(object sender, EventArgs e)
        {

        }

        //private Driver ValidateLogin(string username, string password)
        //{
        //    foreach (Driver d in Program.DriverList)
        //    {
        //        if (d.GetUserName() == username && d.GetPassword() == password)
        //        {
        //            return d;
        //        }
        //    }

        //    return null;
        //}

        //private void LoginButton_Click(object sender, EventArgs e)
        //{

        //    Driver authenticatedDriver = ValidateLogin(txtUserName.Text, txtPassword.Text);

        //    if (authenticatedDriver != null)
        //    {

        //        MessageBox.Show("Login successful! Welcome, " + authenticatedDriver.GetFirstName());
        //        DriverMainForm driverMainForm = new DriverMainForm(authenticatedDriver);
        //        driverMainForm.Show();

        //    }
        //    else
        //    {

        //        MessageBox.Show("Invalid username or password. Please try again.");
        //    }

        //}

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Search for the user in EmployeeList
            object employee = Program.EmployeeList.FirstOrDefault(emp =>
            {
                if (emp is Driver driver && driver.GetUserName() == username)
                    return true;
                if (emp is Clerk clerk && clerk.GetUserName() == username)
                    return true;
                if (emp is OperationalManager manager && manager.GetUserName() == username)
                    return true;
                return false;
            });

            if (employee != null)
            {
                // Check the password
                if ((employee is Driver driver && driver.GetPassword() == password) ||
                    (employee is Clerk clerk && clerk.GetPassword() == password) ||
                    (employee is OperationalManager manager && manager.GetPassword() == password))
                {
                    // Navigate to the role-specific form
                    string role = employee is Driver ? "Driver" :
                                  employee is Clerk ? "Clerk" :
                                  employee is OperationalManager ? "Operational Manager" : "Unknown";

                    switch (role)
                    {
                        case "Driver":
                            new DriverForm().Show();
                            break;
                        case "Clerk":
                            new ClerkForm().Show();
                            break;
                        case "Operational Manager":
                            new OperationalOfficerForm().Show();
                            break;
                        default:
                            MessageBox.Show("Unknown role!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }

                    this.Hide(); // Hide the login form
                }
                else
                {
                    lblError.Text = "Invalid password!";
                    lblError.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                lblError.Text = "Invalid username!";
                lblError.ForeColor = System.Drawing.Color.Red;
            }
        }

    }
}

