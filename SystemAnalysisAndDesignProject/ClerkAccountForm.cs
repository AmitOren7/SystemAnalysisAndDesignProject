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
    public partial class ClerkAccountForm : Form
    {
        private Clerk clerk;
        public ClerkAccountForm(Clerk clerk)
        {
            this.clerk = clerk;
            string driverFirstName = clerk.GetFirstName();
            Console.WriteLine(driverFirstName);
            InitializeComponent();
           
        }

        private void ClerkAccountForm_Load(object sender, EventArgs e)
        {
            string clerkFirstName = clerk.GetFirstName();
            firstname.Text = $"{clerkFirstName}";
            string clerkLastName = clerk.GetLastName();
            lastName.Text = $"{clerkLastName}";
            string clerkId = clerk.GetId();
            id.Text = $"{clerkId}";
            string clerkEmail = clerk.GetEmail();
            email.Text = $"{clerkEmail}";
            string clerkAddress = clerk.GetAddress();
            address.Text = $"{clerkAddress}";
            string clerkUsername = clerk.GetUserName();
            username.Text = $"{clerkUsername}";
            string clerkPassword = clerk.GetPassword();
            password.Text = $"{clerkPassword}";
        }

        private void idCopy_Click(object sender, EventArgs e)
        {
            ClerkIdCopyForm clerkIdCopyForm = new ClerkIdCopyForm(clerk, this);
            clerkIdCopyForm.Show();
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
      
            first_name.Text = clerk.GetFirstName();
            last_name.Text = clerk.GetLastName();
            email_.Text = clerk.GetEmail();
            address_.Text = clerk.GetAddress();
            username_.Text = clerk.GetUserName();
            password_.Text = clerk.GetPassword();
        }

        private void save_Click(object sender, EventArgs e)
        {

            clerk.SetFirstName(first_name.Text);
            clerk.SetLastName(last_name.Text);
            clerk.SetEmail(email_.Text);
            clerk.SetAddress(address_.Text);
            clerk.SetUserName(username_.Text);
            clerk.SetPassword(password_.Text);

            clerk.Update();

            string clerkFirstName = clerk.GetFirstName();
            firstname.Text = $"{clerkFirstName}";
            string clerkLastName = clerk.GetLastName();
            lastName.Text = $"{clerkLastName}";
            string clerkId = clerk.GetId();
            id.Text = $"{clerkId}";
            string clerkEmail = clerk.GetEmail();
            email.Text = $"{clerkEmail}";
            string clerkAddress = clerk.GetAddress();
            address.Text = $"{clerkAddress}";
            string clerkUsername = clerk.GetUserName();
            username.Text = $"{clerkUsername}";
            string clerkPassword = clerk.GetPassword();
            password.Text = $"{clerkPassword}";


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
            ClerkMainForm clerkAccountForm = new ClerkMainForm(clerk);
            clerkAccountForm.ShowDialog();
        }

    }
}
