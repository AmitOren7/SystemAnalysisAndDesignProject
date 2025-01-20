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
            label1.Text = $"{personName} ID Copy:";
            //pictureBox1.Image = Image.FromFile("C:\\Users\\oren7\\Downloads\\SystemAnalysisAndDesignProject\\IdCopy.jpg");
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            OfficeManagerAccountForm officelManagerAccountForm = new OfficeManagerAccountForm(officeManager);
            officelManagerAccountForm.ShowDialog();
        }
    }
}
