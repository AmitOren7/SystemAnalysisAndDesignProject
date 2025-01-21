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
    public partial class ClerkMainForm : Form
    {
        private Clerk clerk;
        public ClerkMainForm(Clerk clerk)
        {
            InitializeComponent();
            this.clerk = clerk;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage hm = new HomePage();
            hm.Show();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            ClerkAccountForm clerkProfileForm = new ClerkAccountForm(clerk);
            clerkProfileForm.Show();
            this.Hide();
        }

        private void newEmployee_Click(object sender, EventArgs e)
        {
            ClerkCreateNewEmployeeForm clerkCreateNewEnployeeForm = new ClerkCreateNewEmployeeForm(clerk, this);
            clerkCreateNewEnployeeForm.Show();
            this.Hide();
        }

        private void todaysTask_Click(object sender, EventArgs e)
        {
            ClerkTaskForm clerkTaskForm = new ClerkTaskForm(clerk, this);
            clerkTaskForm.Show();
            this.Hide();
        }

        private void viewCalendar_Click(object sender, EventArgs e)
        {
            ClerkCalendarForm clerkCalendarForm = new ClerkCalendarForm(clerk);
            clerkCalendarForm.Show();
            this.Hide();
        }

        private void ClerkMainForm_Load(object sender, EventArgs e)
        {
            String personName = clerk.GetName();
            driverLabel.Text = $"Hello {personName}!";
        }
    }

    
    
}
