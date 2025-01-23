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
    public partial class OfficeManagerIdCopyForm : Form
    {
        private OfficeManager officeManager;
        public OfficeManagerIdCopyForm(OfficeManager officeManager)
        {
            InitializeComponent();
            this.officeManager = officeManager;
        }

        private void OfficeManagerIdCopyForm_Load(object sender, EventArgs e)
        {
            string personName = officeManager.GetName();
            label1.Text = $"{personName} ID Copy";
            string imageUrl = this.officeManager.GetIdCopy();

            using (WebClient client = new WebClient())
            {
                byte[] imageBytes = client.DownloadData(imageUrl);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            OfficeManagerAccountForm officelManagerAccountForm = new OfficeManagerAccountForm(officeManager);
            this.Hide();
            officelManagerAccountForm.ShowDialog();
            this.Close();

        }
    }
}
