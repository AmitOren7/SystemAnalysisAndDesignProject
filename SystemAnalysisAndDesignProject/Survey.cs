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
        private string order; //the order id that is associated with the survey
        private List<Question> questions;
        private List<Answer> answers;


        public Survey(string headline, Order order, List<Question> activeQuestions, bool is_new) 
        {
            this.headline = headline;
            this.completed = false; 
            this.order = order;
            this.questions = new List<Question>(activeQuestions);
            this.answers = new List<Answer>();


            if (is_new)
            {
                this.CreateSurvey();
                Program.SurveyList.Add(this);


            }

            //need to think about the complexity of the logic of creating a survey!!!*************
        }

        public void CreateSurvey()
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE SP_add_Survey @headline, @completed, @order";
            sp.Parameters.AddWithValue("@headline", this.headline);
            sp.Parameters.AddWithValue("@completed", this.completed);
            sp.Parameters.AddWithValue("@id", this.id);
   

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(sp);
        }

    }
}
