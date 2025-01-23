using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAnalysisAndDesignProject
{
    public partial class DriverLicenseCopyForm : Form
    {
        private Driver driver;
        private DriverAccountForm driverAccountForm;
        public DriverLicenseCopyForm(Driver driver, DriverAccountForm driverAccountForm)
        {
            InitializeComponent();
            this.driver = driver;
            this.driverAccountForm = driverAccountForm;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            this.driverAccountForm.Show();
        }


        private void DriverLicenseCopyForm_Load(object sender, EventArgs e)
        {
            string personName = driver.GetName();
            label1.Text = $"{personName} Lisence Copy:";
            string imageUrl = "https://github.com/AmitOren7/SystemAnalysisAndDesignProject/blob/master/driverLisenceIdCopy.jpg";

            //string imageUrl = this.driver.GetLisenceCopy();
            using (WebClient client = new WebClient())
            {
                byte[] imageBytes = client.DownloadData(imageUrl);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }

        }

    }
}
