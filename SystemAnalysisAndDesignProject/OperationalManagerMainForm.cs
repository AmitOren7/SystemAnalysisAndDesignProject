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
    public partial class OperationalManagerMainForm : Form
    {
        private OperationalManager operationalManager;
        
        public OperationalManagerMainForm(OperationalManager operationalManager)
        {
            InitializeComponent();
            this.operationalManager = operationalManager;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

      

        private void OperationalManagerMainForm_Load(object sender, EventArgs e)
        {
            string personName = operationalManager.GetName();
            greeting_OPM.Text = $"Hello {personName}!";
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage hm = new HomePage();
            hm.Show();
        }
    }
}
