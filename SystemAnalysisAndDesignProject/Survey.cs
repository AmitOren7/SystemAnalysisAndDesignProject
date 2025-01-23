using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysisAndDesignProject
{
    public class Survey
    {
        private string headline;
        private bool completed; //indicated whether the survey was completed or not
        private Order order; //the order id that is associated with the survey
        private List<Question> questions;
        private List<Answer> answers;


        public Survey(string headline, bool completed, Order order,bool is_new)
        {
            this.headline = headline;
            this.completed = completed;
            this.order = order;
            this.questions = new List<Question>();
            this.answers = new List<Answer>();


            if (is_new)
            {
                this.CreateSurvey();
                Program.SurveyList.Add(this);

            }
        }

        public void CreateSurvey()
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE SP_add_Survey @headline, @completed, @order";
            sp.Parameters.AddWithValue("@headline", this.headline);
            sp.Parameters.AddWithValue("@completed", this.completed);
            sp.Parameters.AddWithValue("@order", this.order.GetId());


            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(sp);
        }

        public string GetHeadline()
        {
            return this.headline;
        }

        public void AddAnswer(Answer answer)
        {
            this.answers.Add(answer);  
        }

        public void AddQuestion(Question question)
        {
            this.questions.Add(question);
        }

        public bool IsCompleted()
        {
            return this.completed;
        }

        public bool IsEmployeeAssociated(string employeeId)
        {
            return this.order.GetAssignedClerkId().Equals(employeeId) ||
                this.order.GetAssignedDriverId().Equals(employeeId);
        }

        public bool IsAssociatedMonth(int month)
        {
            return this.order.GetEstimatedFinishDate().Month==month;
        }

        public bool IsAssociatedYear(int year)
        {
            return this.order.GetEstimatedFinishDate().Year == year;
        }

    }
}
