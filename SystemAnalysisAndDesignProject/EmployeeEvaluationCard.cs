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
    public partial class EmployeeEvaluationCard : UserControl
    {
        public EmployeeEvaluationCard()
        {
            InitializeComponent();
        }

        public string EmployeeName
        {
            get => lblEmployeeName.Text;
            set => lblEmployeeName.Text = value;
        }

        public string Role
        {
            get => lblRole.Text;
            set => lblRole.Text = value;
        }

        public string Score
        {
            get => lblScore.Text;
            set => lblScore.Text = value;
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
