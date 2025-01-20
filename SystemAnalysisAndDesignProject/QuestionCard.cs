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
        private Question question;
        public QuestionCard(Question question)
        {
            InitializeComponent();
            this.question = question;
            // Set initial visibility and text of buttons based on HIDE value
            UpdateButtonVisibility();
        }


        private void UpdateButtonVisibility()
        {
            buttonShow.Visible = !question.IsActive();
            pictureBox3.Visible = !question.IsActive();
            buttonHide.Visible = question.IsActive();
            pictureBox1.Visible = question.IsActive();
        }


        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            this.question.SetHide(true);
            UpdateButtonVisibility();
            // Update database or data source (if applicable)
            question.Update();
        }


        public string Description
        {
            set => richTextBox1.Text = value;
        }

        public string Role
        {
            set => lblRole.Text = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.question.SetHide(false);
            UpdateButtonVisibility();
            // Update database or data source (if applicable)
            question.Update();
        }
    }
}
