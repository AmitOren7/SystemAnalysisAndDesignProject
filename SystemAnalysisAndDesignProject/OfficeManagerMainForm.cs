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

        private void ViewEvaluationsButton_Click(object sender, EventArgs e)
        {
            EmployeeEvaluationForm employeeEvaluationForm = new EmployeeEvaluationForm(this.officeManager);
            employeeEvaluationForm.Show();
            this.Hide();
        }

        private void EditSurvey_Click(object sender, EventArgs e)
        {

            EditSurvey editSurvey = new EditSurvey(this.officeManager);
            editSurvey.Show();
            this.Hide();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            OfficeManagerAccountForm officeManagerAccountForm = new OfficeManagerAccountForm(officeManager);
            officeManagerAccountForm.Show();
            this.Hide();
        }

        private void calendar_Click(object sender, EventArgs e)
        {
            OfficeManagerCalendarForm officeManagerCalendarForm = new OfficeManagerCalendarForm(officeManager);
            officeManagerCalendarForm.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage hm = new HomePage();
            hm.Show();
        }
    }
}
