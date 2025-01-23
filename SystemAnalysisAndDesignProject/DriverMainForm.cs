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
    public partial class DriverMainForm : Form
    {
        private Driver driver;
        public DriverMainForm(Driver driver)
        {
            InitializeComponent();
            this.driver = driver;
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            DriverAccountForm driverProfileForm = new DriverAccountForm(driver);
            driverProfileForm.Show();
            this.Hide();
        }

        private void taskForm_Click(object sender, EventArgs e)
        {
            // Assuming the `driver` object is passed to the form
            DriverTaskForm driverTaskForm = new DriverTaskForm(driver);

            // Check if there are tasks for today
            if (driverTaskForm.GetOrder() == null) // Assuming `Task` is a property in DriverTaskForm
            {
                MessageBox.Show("There are no tasks for today.", "No Tasks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Show(); // Show the main form again
            }
            else
            {
                driverTaskForm.Show(); // Show the task form
                this.Hide();           // Hide the main form
            }
        }


        private void DriverMainForm_Load(object sender, EventArgs e)
        {
            String personName = driver.GetName();
            driverLabel.Text = $"Hello {personName}!";
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage hm = new HomePage();
            hm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calendar driverCalendarForm = new Calendar(driver, this);
            driverCalendarForm.Show();
            this.Hide();
        }

       
    }
}
