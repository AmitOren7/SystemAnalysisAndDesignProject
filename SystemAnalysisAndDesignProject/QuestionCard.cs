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
    public partial class QuestionCard : UserControl
    {
        public QuestionCard()
        {
            InitializeComponent();
        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void buttonJ_Click(object sender, EventArgs e)
        {

        }


        public string Description
        {
            set => richTextBox1.Text = value;
        }

        public string Role
        {
            set => lblRole.Text = value;
        }


    }
}
