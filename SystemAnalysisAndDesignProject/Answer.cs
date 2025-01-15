using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysisAndDesignProject
{
    public class Answer
    {
        public Question question;
        public Survey survey;
        public int answerValue;

        public Answer(Question question, Survey survey, int answerValue, bool is_new)
        {
            this.question = question;
            this.survey = survey;
            this.answerValue = answerValue;


            if (is_new)
            {
                Program.AnswerList.Add(this);
            }

        }

        public Survey GetSurvey()
        {
            return this.survey;
        }


        public bool GetAssociatedRole()
        {
            return this.question.GetAssociatedRole();
        }

        public int GetAnswerValue()
        {
            return this.answerValue;
        }

        public bool IsEmployeeAssociated(Evaluatable employee)
        {
            return this.question.GetAssociatedRole() == employee.GetAssociatedRole();
        }
    }
}
