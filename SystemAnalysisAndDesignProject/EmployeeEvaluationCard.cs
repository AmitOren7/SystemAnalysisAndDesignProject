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

        public Evaluatable Employee { get; set; } // stores the the employee that is associated with the evaluation card



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        // submit button to create a new employee evaluation
        private void button1_Click(object sender, EventArgs e)
        {
            string personalNote = richTextBox1.Text.Trim(); // Get the text from the notes field

            if (string.IsNullOrWhiteSpace(personalNote))
            {
                MessageBox.Show("Please enter a note before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // General details required from the card
                string employeeName = EmployeeName;
                string role = Role;
                double score = double.Parse(Score);

                // Get the year and month from the form
                var form = this.FindForm() as EmployeeEvaluationForm;
                if (form != null)
                {
                    int selectedMonth = int.Parse(form.GetSelectedMonth());
                    int selectedYear = int.Parse(form.GetSelectedYear());
                    Evaluatable employee = Employee;


                    // Create a new evaluation
                    EmployeeMonthlyEvaluation newEvaluation = new EmployeeMonthlyEvaluation(personalNote, selectedMonth, DateTime.Now, selectedYear, employee, score, true);


                    // Success message
                    MessageBox.Show("Evaluation submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the card
                        Parent.Controls.Remove(this);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while submitting the evaluation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void lblEmployeeName_Click(object sender, EventArgs e)
        {

        }
    }
}
