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
    public partial class ClerkCreateNewEmployeeForm : Form
    {
        private Clerk Clerk;
        private ClerkMainForm clerkMainForm;
        private string employeeType;
        public ClerkCreateNewEmployeeForm(Clerk clerk, ClerkMainForm clerkMainForm)
        {
            InitializeComponent();
            this.Clerk = clerk;
            this.clerkMainForm = clerkMainForm;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            this.clerkMainForm.Show();
        }

        private void selectEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            employeeType = selectEmployee.Text;
            if (selectEmployee.Text == "Driver")
            {
                first_name.Visible = true;
                last_name.Visible = true;
                address_.Visible = true;
                id_.Visible = true;
                username_.Visible = true;
                password_.Visible = true;
                email_.Visible = true;
                phone_.Visible = true;
                id_copy.Visible = true;
                license_id.Visible = true;
                license_copy.Visible = true;
                lisenceCopy.Visible = true;
                lisenceId.Visible = true;
            }
            else 
            {
                first_name.Visible = true;
                last_name.Visible = true;
                address_.Visible = true;
                id_.Visible = true;
                username_.Visible = true;
                password_.Visible = true;
                email_.Visible = true;
                phone_.Visible = true;
                id_copy.Visible = true;
                lisenceCopy.Visible = false;
                lisenceId.Visible = false;
                license_id.Visible = false;
                license_copy.Visible = false;
            }

            save.Visible = true;

        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(first_name.Text) || string.IsNullOrEmpty(last_name.Text) || string.IsNullOrEmpty(id_.Text) ||
                    string.IsNullOrEmpty(phone_.Text) || string.IsNullOrEmpty(email_.Text) || string.IsNullOrEmpty(address_.Text) ||
                    string.IsNullOrEmpty(username_.Text) || string.IsNullOrEmpty(password_.Text) || string.IsNullOrEmpty(id_copy.Text))
                {
                    MessageBox.Show("All fields must be filled out before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (employeeType == "Clerk")
            {
                Clerk newClerk = new Clerk(first_name.Text, last_name.Text, id_.Text,
                                            phone_.Text, email_.Text, address_.Text,
                                            username_.Text, password_.Text, id_copy.Text,
                                            true, PerformanceStatus.pendingForAssignment);
            }
            if (employeeType == "Driver")
            {
                Driver newDriver = new Driver(first_name.Text, last_name.Text, id_.Text,
                                            phone_.Text, email_.Text, address_.Text,
                                            username_.Text, password_.Text, id_copy.Text,
                                            license_copy.Text, license_id.Text, true,
                                            PerformanceStatus.pendingForAssignment, null);
                if (string.IsNullOrEmpty(license_copy.Text) || string.IsNullOrEmpty(license_id.Text))
                {
                    MessageBox.Show("All fields must be filled out before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }
            if (employeeType == "Office Manager")
            {
                OfficeManager newOfficeManager = new OfficeManager(first_name.Text, last_name.Text, id_.Text,
                                            phone_.Text, email_.Text, address_.Text,
                                            username_.Text, password_.Text, id_copy.Text, true);
            }
            if (employeeType == "Operational Manager")
            {
                OperationalManager newOperationalManager = new OperationalManager(first_name.Text, last_name.Text, id_.Text,
                                            phone_.Text, email_.Text, address_.Text,
                                            username_.Text, password_.Text, id_copy.Text, true);
            }

            first_name.Visible = false;
            last_name.Visible = false;
            address_.Visible = false;
            id_.Visible = false;
            username_.Visible = false;
            password_.Visible = false;
            email_.Visible = false;
            phone_.Visible = false;
            id_copy.Visible = false;
            

            MessageBox.Show("New Employee successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            this.clerkMainForm.Show();
        }
    }
}
