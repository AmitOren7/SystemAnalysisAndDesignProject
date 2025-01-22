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
    public partial class OperationalManagerAccountForm : Form
    {
        private OperationalManager operationalManager;
        public OperationalManagerAccountForm(OperationalManager operationalManager)
        {
            this.operationalManager = operationalManager;
            string operationalManagerFirstName = operationalManager.GetFirstName();
            Console.WriteLine(operationalManagerFirstName);
            InitializeComponent();

        }

        private void OperationalManagerAccountForm_Load(object sender, EventArgs e)
        {
            // Populate the form fields with the OperationalManager details
            string managerFirstName = operationalManager.GetFirstName();
            firstname.Text = $"{managerFirstName}";
            string managerLastName = operationalManager.GetLastName();
            lastName.Text = $"{managerLastName}";
            string managerId = operationalManager.GetId();
            id.Text = $"{managerId}";
            string managerEmail = operationalManager.GetEmail();
            email.Text = $"{managerEmail}";
            string managerAddress = operationalManager.GetAddress();
            address.Text = $"{managerAddress}";
            string managerUsername = operationalManager.GetUserName();
            username.Text = $"{managerUsername}";
            string managerPassword = operationalManager.GetPassword();
            password.Text = $"{managerPassword}";
            string managerIdCopy = operationalManager.GetIdCopy();
            idCopy.Text = $"{managerIdCopy}";
        }


        private void idCopy_Click(object sender, EventArgs e)
        {
            OperationalManagerIdCopy operationalManagerIdCopy = new OperationalManagerIdCopy(operationalManager);
            operationalManagerIdCopy.Show();
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
         
            first_name.Text = operationalManager.GetFirstName();
            last_name.Text = operationalManager.GetLastName();
            email_.Text = operationalManager.GetEmail();
            address_.Text = operationalManager.GetAddress();
            username_.Text = operationalManager.GetUserName();
            password_.Text = operationalManager.GetPassword();
        }

        private void save_Click(object sender, EventArgs e)
        {

            operationalManager.SetFirstName(first_name.Text);
            operationalManager.SetLastName(last_name.Text);
            operationalManager.SetEmail(email_.Text);
            operationalManager.SetAddress(address_.Text);
            operationalManager.SetUserName(username_.Text);
            operationalManager.SetPassword(password_.Text);



            operationalManager.Update();


            string operationalManagerFirstName = operationalManager.GetFirstName();
            firstname.Text = $"{operationalManagerFirstName}";
            string operationalManagerLastName = operationalManager.GetLastName();
            lastName.Text = $"{operationalManagerLastName}";
            string operationalManagerId = operationalManager.GetId();
            id.Text = $"{operationalManagerId}";
            string operationalManagerEmail = operationalManager.GetEmail();
            email.Text = $"{operationalManagerEmail}";
            string operationalManagerAddress = operationalManager.GetAddress();
            address.Text = $"{operationalManagerAddress}";
            string operationalManagerUsername = operationalManager.GetUserName();
            username.Text = $"{operationalManagerUsername}";
            string operationalManagerPassword = operationalManager.GetPassword();
            password.Text = $"{operationalManagerPassword}";

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
            OperationalManagerMainForm operationalManagerAccountForm = new OperationalManagerMainForm(operationalManager);
            operationalManagerAccountForm.ShowDialog();
        }

    }
}
