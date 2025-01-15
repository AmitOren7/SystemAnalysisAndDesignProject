using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAnalysisAndDesignProject
{
    public partial class DriverAccountForm : Form
    {
        private Driver driver;
        public DriverAccountForm(Driver driver)
        {
            this.driver= driver;
            string driverFirstName = driver.GetFirstName();
            Console.WriteLine(driverFirstName);
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void DriverAccountForm_Load(object sender, EventArgs e) 
        {
            string driverFirstName = driver.GetFirstName();
            firstname.Text = $"{driverFirstName}";
            firstname.TextAlign = ContentAlignment.MiddleRight;
            string driverLastName = driver.GetLastName();
            lastName.Text = $"{driverLastName}";
            lastName.TextAlign = ContentAlignment.MiddleRight;
            string driverId = driver.GetId();
            id.Text = $"{driverId}";
            id.TextAlign = ContentAlignment.MiddleRight;
            string driverEmail = driver.GetEmail();
            email.Text = $"{driverEmail}";
            email.TextAlign = ContentAlignment.MiddleRight;
            string driverAddress = driver.GetAddress();
            address.Text = $"{driverAddress}";
            address.TextAlign = ContentAlignment.MiddleRight;
            string driverUsername = driver.GetUserName();
            username.Text = $"{driverUsername}";
            username.TextAlign = ContentAlignment.MiddleRight;
            string driverPassword = driver.GetPassword();
            password.Text = $"{driverPassword}";
            password.TextAlign = ContentAlignment.MiddleRight;
            string driverLicenseId = driver.GetlicenseId();
            licenseId.Text = $"{driverLicenseId}";
            licenseId.TextAlign = ContentAlignment.MiddleRight;
        }
    }
}
