using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysisAndDesignProject
{
    public class EmployeeMonthlyEvaluation
    {
        private string personalNote;
        private int associatedMonth;
        private DateTime submissionDate;
        private int year;
        private Evaluatable employee;

        public EmployeeMonthlyEvaluation(string personalNote, int associatedMonth, DateTime submissionDate, 
            int year, Evaluatable employee, bool is_new)
        {
            this.personalNote = personalNote;
            this.associatedMonth = associatedMonth;
            this.submissionDate = submissionDate;
            this.year = year;
            this.employee = employee;

            if (is_new)
            {
                this.CreateEmployeeMonthlyEvaluation(); 
                Program.EmployeeMonthlyEvaluationList.Add(this);
            }
        }


        public void CreateEmployeeMonthlyEvaluation()
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE SP_add_EmployeeMonthlyEvaluation @personalNote, @associatedMonth," +
                "@submissionDate, @year, @employee";

            sp.Parameters.AddWithValue("@personalNote", this.personalNote);
            sp.Parameters.AddWithValue("@associatedMonth", this.associatedMonth);
            sp.Parameters.AddWithValue("@submissionDate", this.submissionDate);
            sp.Parameters.AddWithValue("@year", this.year);
            sp.Parameters.AddWithValue("@employee", this.employee.GetId());

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(sp);
        }

        // function that will calculate the grade of the evaluated employee for the month of this evaluation
        public double GetGradePerMonth()
        {
            int counter = 0; //counts the number of answers that were included in the calculation
            double total_score = 0; //sums the cumulative score from the included answers 
            foreach (Answer answer in Program.AnswerList)
            {
                // check if it is a releavant survey
                if (answer.GetSurvey().IsCompleted() && answer.GetSurvey().IsEmployeeAssociated(this.employee.GetId()) 
                    && answer.GetSurvey().IsAssociatedMonth(this.associatedMonth))
                {
                    // check if the employee is a driver or a clerk
                    if (this.employee.GetAssociatedRole() == answer.GetAssociatedRole())
                    {
                        counter++;
                        total_score += answer.GetAnswerValue();
                    }
                    
                }
            }
            return ((total_score/counter)*20); // grade between 0 and 100
        }

    }
}
