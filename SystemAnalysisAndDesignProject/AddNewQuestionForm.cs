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
    public partial class AddNewQuestionForm : Form
    {
        private OfficeManager officeManager;
        private EditSurvey originEditSurveyForm;
            
        public AddNewQuestionForm(OfficeManager officeManager, EditSurvey originEditSurveyForm)
        {
            this.officeManager = officeManager;
            this.originEditSurveyForm = originEditSurveyForm;
            InitializeComponent();
        }
         //when the office manager wants to add a new question to the survey
        private void AddNewQuestionForm_Load(object sender, EventArgs e)
        {
            NewQuestionCard card = new NewQuestionCard();
            flowLayoutPanel1.Controls.Add(card);
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            this.originEditSurveyForm.Show();
        }
    }
}
