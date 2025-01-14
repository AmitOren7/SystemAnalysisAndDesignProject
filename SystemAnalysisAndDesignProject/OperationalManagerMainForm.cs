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
        private OperationalManager operational_manager;
        public OperationalManagerMainForm(string username)
        {
            InitializeComponent();
            operational_manager = Program.EmployeeList.FirstOrDefault(username);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
