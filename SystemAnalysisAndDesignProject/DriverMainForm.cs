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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DriverMainForm_Load(object sender, EventArgs e)
        {
            string personName = driver.GetName();
            driverLabel.Text = $"Hello {personName}!";
        }
    }
}
