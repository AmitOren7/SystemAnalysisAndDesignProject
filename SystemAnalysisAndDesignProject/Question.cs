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
        private static int questionCounter;

        public Question(int questionNumber, string description, bool associatedRole, bool hide, bool is_new)
        {
            this.questionNumber = questionNumber;
            this.description = description;
            this.associatedRole = associatedRole; //clerk = false, driver = true
            this.hide = hide;

            // for handling instances that were retrieved and created from the database
            // updating the question_counter accordingly 
            if (this.questionNumber > questionCounter)
            {
                questionCounter = this.questionNumber;
            }

            if (is_new)
            {
                this.CreateQuestion();
                Program.QuestionList.Add(this);
            }

        }

        // Constructor without question number
        public Question(string description, bool associatedRole, bool hide, bool is_new)
            : this(++questionCounter, description, associatedRole, hide, is_new)
        {
        }


        public void CreateQuestion()
        {
            // Create a new SqlCommand for the stored procedure
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE SP_add_Order @id, @customerName, @customerPhoneNamber, " +
                             " @customerEmail, @startDate, @departure, @destenation, " +
                             "@cargoType, @estimatedFinishDate,@orderStatus @driver, @clerk, @profit, @vehicleType, @totalWeight";

            // Add parameters with values from the Order object
            sp.Parameters.AddWithValue("@questionNumber", this.questionNumber);
            sp.Parameters.AddWithValue("@description", this.description);
            sp.Parameters.AddWithValue("@associatedRole", this.associatedRole);
            sp.Parameters.AddWithValue("@hide", this.hide);

            // Execute the stored procedure to insert the order into the database
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(sp); // Call the method to execute the command (assuming it handles the database connection)
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

        public string GetDescription()
        {
            return this.description;
        }






    }
}
