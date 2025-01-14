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
    public partial class OfficeManagerMainForm : Form
    {
        private OfficeManager officeManager;
        public OfficeManagerMainForm(OfficeManager officeManager)
        {
            InitializeComponent();
            this.officeManager = officeManager;
        }

        private void OfficeManagerMainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
