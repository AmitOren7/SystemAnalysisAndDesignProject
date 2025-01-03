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

        private void ViewProfileButton_Click(object sender, EventArgs e)
        {
            DriverProfile driverProfileForm = new DriverProfile(driver);
            driverProfileForm.Show();
        }
    }
}
