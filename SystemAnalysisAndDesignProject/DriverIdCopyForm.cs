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
    public partial class DriverIdCopyForm : Form
    {
        private Driver driver;
        private DriverAccountForm driverAccountForm;
        public DriverIdCopyForm(Driver driver, DriverAccountForm driverAccountForm)
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


        private void DriverIdCopyForm_Load(object sender, EventArgs e)
        {
            string personName = driver.GetName();
            label1.Text = $"{personName} ID Copy:";
            string imageUrl = this.driver.GetIdCopy();
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
