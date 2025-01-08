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
                //this.CreateAnswer();
                Program.AnswerList.Add(this);
            }



        
    }

}
}
