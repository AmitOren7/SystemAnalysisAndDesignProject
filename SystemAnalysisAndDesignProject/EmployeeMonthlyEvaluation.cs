using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO.Pipes;
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
        private double score; 

        public EmployeeMonthlyEvaluation(string personalNote, int associatedMonth, DateTime submissionDate, 
            int year, Evaluatable employee, double score, bool is_new)
        {
            this.personalNote = personalNote;
            this.associatedMonth = associatedMonth;
            this.submissionDate = submissionDate;
            this.year = year;
            this.employee = employee;
            this.score = score;

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
                "@submissionDate, @year, @employee, @score";

            sp.Parameters.AddWithValue("@personalNote", this.personalNote);
            sp.Parameters.AddWithValue("@associatedMonth", this.associatedMonth);
            sp.Parameters.AddWithValue("@submissionDate", this.submissionDate);
            sp.Parameters.AddWithValue("@year", this.year);
            sp.Parameters.AddWithValue("@employee", this.employee.GetId());
            sp.Parameters.AddWithValue("@score", this.score);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(sp);
        }

        public string GetEmployeeName()
        {
            return this.employee.GetName();
        }

        public string GetAssociatedRole()
        {
            if (this.employee.GetAssociatedRole())
                return "Driver";
            else
                return "Clerk";

        }


        public int GetAssociatedMonth()
        {
            return this.associatedMonth;
        }

        public int GetAssociatedYear()
        {
            return this.year;
        }

        public string GetAssociatedEmployeeId()
        {
            return this.employee.GetId();
        }

        public double GetScore()
        {
            return this.score;
        }

        public string GetPersonalNote()
        {
            return this.personalNote;
        }

    }
}
