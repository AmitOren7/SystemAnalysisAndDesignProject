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
        private TextBox txt_username;
        private TextBox txt_password;
        private Label lblError;
        private Button btnLogin;

        public MainForm()
        {
            InitializeComponent();

            lblError = new Label
            {
                Name = "lblError",
                Text = "",
                ForeColor = Color.Red,
                AutoSize = true,
                Location = new Point(20, 200)
            };
            this.Controls.Add(lblError);


            txt_username = new TextBox
            {
                Name = "txtUsername",
                Location = new Point(20, 50),
                Size = new Size(200, 30)
            };
            this.Controls.Add(txt_username);


            txt_password = new TextBox
            {
                Name = "txtPassword",
                Location = new Point(20, 100),
                Size = new Size(200, 30),
                PasswordChar = '*'
            };
            this.Controls.Add(txt_password);

            btnLogin = new Button
            {
                Name = "btnLogin",
                Text = "Login",
                Location = new Point(20, 150),
                Size = new Size(100, 30)
            };
            btnLogin.Click += LoginButton_Click;
            this.Controls.Add(btnLogin);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            // Search for the user in EmployeeList
            object employee = Program.EmployeeList.FirstOrDefault(emp =>
            {
                if (emp is Driver driver && driver.GetUserName() == username)
                    return true;
                if (emp is Clerk clerk && clerk.GetUserName() == username)
                    return true;
                if (emp is OperationalManager operational_manager && operational_manager.GetUserName() == username)
                    return true;
                if (emp is OfficeManager office_manager && office_manager.GetUserName() == username)
                    return true;
                //((OfficeManager)emp).GetUserName();
                return false;
            });

            if (employee != null)
            {
                // Check the password
                if ((employee is Driver driver && driver.GetPassword() == password) ||
                    (employee is Clerk clerk && clerk.GetPassword() == password) ||
                    (employee is OperationalManager operational_manager && operational_manager.GetPassword() == password) ||
                    (employee is OfficeManager office_manager && office_manager.GetPassword() == password))
                {
                    // Navigate to the role-specific form
                    string role = employee is Driver ? "Driver" :
                                  employee is Clerk ? "Clerk" :
                                  employee is OperationalManager ? "Operational Manager" :
                                  employee is OfficeManager ? "Office Manager" : "Unknown";

                    switch (role)
                    {
                        case "Driver":
                            new DriverForm().Show();
                            break;
                        case "Clerk":
                            new ClerkForm().Show();
                            break;
                        case "Operational Manager":
                            new OperationalManagerMainForm().Show();
                            break;
                        case "Office Manager":
                            new OfficeManagerMainForm().Show();
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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

