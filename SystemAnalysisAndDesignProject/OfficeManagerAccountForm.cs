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
    public partial class OfficeManagerAccountForm : Form
    {
        private OfficeManager officeManager;
        public OfficeManagerAccountForm(OfficeManager officeManager)
        {
            
            this.officeManager = officeManager;
            string officeManagerFirstName = officeManager.GetFirstName();
            Console.WriteLine(officeManagerFirstName);
            InitializeComponent();
        }

        private void OperationalManagerAccountForm_Load(object sender, EventArgs e)
        {
            // Populate the form fields with the OperationalManager details
            string managerFirstName = officeManager.GetFirstName();
            firstname.Text = $"{managerFirstName}";
            string managerLastName = officeManager.GetLastName();
            lastName.Text = $"{managerLastName}";
            string managerId = officeManager.GetId();
            id.Text = $"{managerId}";
            string managerEmail = officeManager.GetEmail();
            email.Text = $"{managerEmail}";
            string managerAddress = officeManager.GetAddress();
            address.Text = $"{managerAddress}";
            string managerUsername = officeManager.GetUserName();
            username.Text = $"{managerUsername}";
            string managerPassword = officeManager.GetPassword();
            password.Text = $"{managerPassword}";
            string managerIdCopy = officeManager.GetIdCopy();
            idCopy.Text = $"{managerIdCopy}";
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

            first_name.Text = officeManager.GetFirstName();
            last_name.Text = officeManager.GetLastName();
            email_.Text = officeManager.GetEmail();
            address_.Text = officeManager.GetAddress();
            username_.Text = officeManager.GetUserName();
            password_.Text = officeManager.GetPassword();
        }

        private void save_Click(object sender, EventArgs e)
        {

            officeManager.SetFirstName(first_name.Text);
            officeManager.SetLastName(last_name.Text);
            officeManager.SetEmail(email_.Text);
            officeManager.SetAddress(address_.Text);
            officeManager.SetUserName(username_.Text);
            officeManager.SetPassword(password_.Text);



            officeManager.Update();


            string driverFirstName = officeManager.GetFirstName();
            firstname.Text = $"{driverFirstName}";
            string driverLastName = officeManager.GetLastName();
            lastName.Text = $"{driverLastName}";
            string driverId = officeManager.GetId();
            id.Text = $"{driverId}";
            string driverEmail = officeManager.GetEmail();
            email.Text = $"{driverEmail}";
            string driverAddress = officeManager.GetAddress();
            address.Text = $"{driverAddress}";
            string driverUsername = officeManager.GetUserName();
            username.Text = $"{driverUsername}";
            string driverPassword = officeManager.GetPassword();
            password.Text = $"{driverPassword}";

            save.Visible = false;
            first_name.Visible = false;
            last_name.Visible = false;
            email_.Visible = false;
            address_.Visible = false;
            username_.Visible = false;
            password_.Visible = false;


            MessageBox.Show("Details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            OfficeManagerMainForm officeManagerAccountForm = new OfficeManagerMainForm(officeManager);
            officeManagerAccountForm.ShowDialog();
        }

        private void idCopy_Click(object sender, EventArgs e)
        {
            OfficeManagerIdCopyForm officeManagerIdCopy = new OfficeManagerIdCopyForm(officeManager);
            officeManagerIdCopy.Show();
            this.Hide();
        }
    }
}
