using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAnalysisAndDesignProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void username(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //private void LoginButton_Click(object sender, EventArgs e)
        //{

        //    foreach (Driver d in driverList)
        //    {
        //        if (d.GetUserName() == txtUserName.Text && d.GetPassword() == txtPassword.Text)
        //        {
        //            return d;
        //        }
        //    }


            private Driver ValidateLogin(string username, string password)
            {
                foreach (Driver d in Program.DriverList)
                {
                    if (d.GetUserName() == username && d.GetPassword() == password)
                    {
                        return d;
                    }
                }

                return null;
            }

            private void LoginButton_Click(object sender, EventArgs e)
            {

                Driver authenticatedDriver = ValidateLogin(txtUserName.Text, txtPassword.Text);

                if (authenticatedDriver != null)
                {

                    MessageBox.Show("Login successful! Welcome, " + authenticatedDriver.GetFirstName());
                    DriverMainForm driverMainForm = new DriverMainForm(authenticatedDriver);
                    driverMainForm.Show();

                }
                else
                {

                    MessageBox.Show("Invalid username or password. Please try again.");
                }

            }

            

        }
    }

