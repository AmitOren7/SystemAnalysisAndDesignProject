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
using System.Data.SqlClient;

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

        private void DriverAccountForm_Load(object sender, EventArgs e) 
        {
            string driverFirstName = driver.GetFirstName();
            firstname.Text = $"{driverFirstName}";
            string driverLastName = driver.GetLastName();
            lastName.Text = $"{driverLastName}";
            string driverId = driver.GetId();
            id.Text = $"{driverId}";
            string driverEmail = driver.GetEmail();
            email.Text = $"{driverEmail}";
            string driverAddress = driver.GetAddress();
            address.Text = $"{driverAddress}";
            string driverUsername = driver.GetUserName();
            username.Text = $"{driverUsername}";
            string driverPassword = driver.GetPassword();
            password.Text = $"{driverPassword}";
            string driverLicenseId = driver.GetLicenseId();
            licenseId.Text = $"{driverLicenseId}";
        }

        private void idCopy_Click(object sender, EventArgs e)
        {
            DriverIdCopyForm driverIdCopyForm = new DriverIdCopyForm(driver, this);
            driverIdCopyForm.Show();
            this.Hide();
        }

        private void licenseCopy_Click(object sender, EventArgs e)
        {
            DriverLicenseCopyForm driverLicenseCopyForm = new DriverLicenseCopyForm(driver, this);
            driverLicenseCopyForm.Show();
            this.Hide();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            save.Visible = true;
            first_name.Visible = true;
            last_name.Visible = true;
            email_.Visible = true;
            address_.Visible = true;
            username_.Visible = true;
            password_.Visible = true;
            license_id.Visible = true;

            first_name.Text = driver.GetFirstName();
            last_name.Text = driver.GetLastName();
            email_.Text = driver.GetEmail();
            address_.Text = driver.GetAddress();
            username_.Text = driver.GetUserName();
            password_.Text = driver.GetPassword();
            license_id.Text = driver.GetLicenseId();
        }
        

        private void save_Click(object sender, EventArgs e)
        {

            driver.SetFirstName(first_name.Text);
            driver.SetLastName(last_name.Text);
            driver.SetEmail(email_.Text);
            driver.SetAddress(address_.Text);
            driver.SetUserName(username_.Text);
            driver.SetPassword(password_.Text);
            driver.SetLicenseId(license_id.Text);


            driver.Update();


            string driverFirstName = driver.GetFirstName();
            firstname.Text = $"{driverFirstName}";
            string driverLastName = driver.GetLastName();
            lastName.Text = $"{driverLastName}";
            string driverId = driver.GetId();
            id.Text = $"{driverId}";
            string driverEmail = driver.GetEmail();
            email.Text = $"{driverEmail}";
            string driverAddress = driver.GetAddress();
            address.Text = $"{driverAddress}";
            string driverUsername = driver.GetUserName();
            username.Text = $"{driverUsername}";
            string driverPassword = driver.GetPassword();
            password.Text = $"{driverPassword}";
            string driverLicenseId = driver.GetLicenseId();
            licenseId.Text = $"{driverLicenseId}";


            save.Visible = false;
            first_name.Visible = false;
            last_name.Visible = false;
            email_.Visible = false;
            address_.Visible = false;
            username_.Visible = false;
            password_.Visible = false;
            license_id.Visible = false;


            MessageBox.Show("Details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            DriverMainForm driverAccountForm = new DriverMainForm(driver);
            driverAccountForm.ShowDialog();
        }
    }
}
