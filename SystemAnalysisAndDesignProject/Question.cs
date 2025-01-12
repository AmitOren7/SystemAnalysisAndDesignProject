using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public Question(int questionNumber, string description, bool associatedRole, bool hide, bool is_new)
        {
            this.questionNumber = questionNumber;
            this.description = description;
            this.associatedRole = associatedRole; //clerk = false, driver = true
            this.hide = hide;

            if (is_new)
            {
                Program.QuestionList.Add(this);
            }

        }

    

        public int GetQuestionNum() 
        { 
            return questionNumber; 
        }

        public bool IsActive()
        { 
            return !this.hide; 
        }

        public bool GetAssociatedRole()
        {
            return this.associatedRole;
        }






    }
}
