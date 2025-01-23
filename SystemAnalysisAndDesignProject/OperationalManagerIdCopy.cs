using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAnalysisAndDesignProject
{
    public partial class OperationalManagerIdCopy : Form
    {
        private OperationalManager operationalManager;
        public OperationalManagerIdCopy(OperationalManager operationalManager)
        {
            InitializeComponent();
            this.operationalManager = operationalManager;
        }

        private void DriverIdCopyForm_Load(object sender, EventArgs e)
        {
            string personName =operationalManager.GetName();
            label1.Text = $"{personName} ID Copy:";
            string imageUrl = this.operationalManager.GetIdCopy();
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
            this.Close();
            OperationalManagerAccountForm operationalManagerAccountForm = new OperationalManagerAccountForm(operationalManager);
            operationalManagerAccountForm.ShowDialog();
        }
    }
}
