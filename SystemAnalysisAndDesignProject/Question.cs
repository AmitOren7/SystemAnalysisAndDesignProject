using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysisAndDesignProject
{
    public class Question
    {
        private int questionNumber;
        private string description;
        private bool associatedRole;
        private bool hide;

        public Question(int questionNumber,  string description, bool AssociatedRole, bool is_new)
        {
            this.questionNumber = questionNumber;
            this.description = description;
            this.associatedRole = AssociatedRole;
            this.hide = false;

            if (is_new)
            {
                //this.CreateQuestion();
                Program.QuestionList.Add(this);
            }

        }








    }
}
