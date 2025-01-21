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
            DriverTaskForm driverTaskForm = new DriverTaskForm(driver);
            driverTaskForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            hm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calendar driverCalendarForm = new Calendar(driver);
            driverCalendarForm.Show();
            this.Hide();
        }
    }
}
