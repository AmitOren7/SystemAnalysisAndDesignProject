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
    public partial class ClerkIdCopyForm : Form
    {
        private Clerk clerk;
        private ClerkAccountForm clerkAccountForm;
        public ClerkIdCopyForm(Clerk clerk, ClerkAccountForm clerkAccountForm)
        {
            InitializeComponent();
            this.clerk = clerk;
            this.clerkAccountForm = clerkAccountForm;
        }

        private void ClerkIdCopyForm_Load(object sender, EventArgs e)
        {
            string personName = clerk.GetName();
            label1.Text = $"{personName} ID Copy:";
            //pictureBox1.Image = Image.FromFile("C:\\Users\\oren7\\Downloads\\SystemAnalysisAndDesignProject\\IdCopy.jpg");
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            this.clerkAccountForm.Show();
        }
    }
}
