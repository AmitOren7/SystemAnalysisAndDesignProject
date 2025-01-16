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
    public partial class DriverLicenseCopyForm : Form
    {
        private Driver driver;
        public DriverLicenseCopyForm(Driver driver)
        {
            InitializeComponent();
            this.driver = driver;
        }

        private void DriverLicenseCopyForm_Load(object sender, EventArgs e)
        {
            string personName = driver.GetName();
            label1.Text = $"{personName} Lisence Copy:";
            pictureBox1.Image = Image.FromFile("C:\\Users\\oren7\\Downloads\\SystemAnalysisAndDesignProject\\driverLisenceIdCopy.jpg");
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            DriverAccountForm driverAccountForm = new DriverAccountForm(driver);
            driverAccountForm.ShowDialog();
        }
    }
}
