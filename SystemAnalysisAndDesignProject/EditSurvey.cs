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
    public partial class EditSurvey : Form
    {
        private OfficeManager officeManager;

        public EditSurvey(OfficeManager officeManager)
        {
            this.officeManager = officeManager;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void EditSurvey_Load(object sender, EventArgs e)
        {

            foreach (Question question in Program.QuestionList)
            {
                // Create a new card for the current evaluation
                var card = new QuestionCard
                {
                    Description = question.GetDescription(),
                    Role = question.GetAssociatedRole() ? "Driver":"Clerk",

                };

                // Add the card to the panel only if it's not null (for safety)
                if (card != null)
                {
                    flowLayoutPanel1.Controls.Add(card);
                }
            }

        }
    }
}
