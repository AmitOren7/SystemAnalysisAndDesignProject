using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.ComponentModel;
using System.Net;
using System.Runtime.ConstrainedExecution;


namespace SystemAnalysisAndDesignProject
{
    internal static class Program
    {
        public static System.Collections.Generic.List<Vehicle> VehicleList;
        public static System.Collections.Generic.List<Driver> DriverList;
        public static System.Collections.Generic.List<OperationalManager> OperationalManagerList;
        public static System.Collections.Generic.List<Order> OrderList;
        public static System.Collections.Generic.List<Clerk> ClerkList;
        public static System.Collections.Generic.List<Survey> SurveyList;
        public static System.Collections.Generic.List<Question> QuestionList;
        public static System.Collections.Generic.List<Question> ActiveQuestionList; //a list of questions that are not hidden
        public static System.Collections.Generic.List<Answer> AnswerList; //a list of survey responses
        public static System.Collections.Generic.List<Employee> EmployeeList;
        public static System.Collections.Generic.List<EmployeeMonthlyEvaluation> EmployeeMonthlyEvaluationList;
        public static System.Collections.Generic.List<OfficeManager> OfficeManagerList;

        [STAThread]


        public static void InitLists()
        {
            InitClerkList();
            InitVehicleList();
            InitDriverList();
            InitOperationalManagerList();
            InitOrderList();
            InitQuestionList();
            InitSurveyList();
            InitAnswerList();
            InitClerkList();
            InitActiveQuestionList();
            InitEmployeeMonthlyEvaluation();
            InitOfficeManagerList();
            InitEmployeeList();
        }

        public static void InitVehicleList()
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE dbo.Get_all_Vehicles";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(sp);

            VehicleList = new List<Vehicle>();

            while (rdr.Read())
            {
                string id = rdr.GetValue(0).ToString();
                VehicleType vehicleType = (VehicleType)Enum.Parse(typeof(VehicleType), rdr.GetValue(1).ToString());
                float maxCapacity = Convert.ToSingle(rdr.GetValue(2));
                DateTime testDate = Convert.ToDateTime(rdr.GetValue(3));
                VehicleConditionStatus vehicleCondition = (VehicleConditionStatus)Enum.Parse(typeof(VehicleConditionStatus), rdr.GetValue(4).ToString());
                CargoType cargoType = (CargoType)Enum.Parse(typeof(CargoType), rdr.GetValue(5).ToString());
                Vehicle vehicle = new Vehicle(id, vehicleType, maxCapacity, testDate, vehicleCondition, cargoType, false);
                VehicleList.Add(vehicle);
            }
        }

        public static void InitDriverList()
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE dbo.Get_All_Drivers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(sp);


            DriverList = new List<Driver>();
            while (rdr.Read())
            {
                string firstName = rdr.GetValue(0).ToString();
                string lastName = rdr.GetValue(1).ToString();
                string id = rdr.GetValue(2).ToString();
                string phoneNumber = rdr.GetValue(3).ToString();
                string email = rdr.GetValue(4).ToString();
                string address = rdr.GetValue(5).ToString();
                string userName = rdr.GetValue(6).ToString();
                string password = rdr.GetValue(7).ToString();
                string idCopy = rdr.GetValue(8).ToString();
                string licenseCopy = rdr.GetValue(9).ToString();
                string licenseId = rdr.GetValue(10).ToString();
                PerformanceStatus status = (PerformanceStatus)Enum.Parse(typeof(PerformanceStatus), rdr.GetValue(11).ToString());
                string vehicleId = rdr.GetValue(12).ToString();
                Vehicle vehicle = Program.VehicleList.FirstOrDefault(v => v.GetID() == vehicleId);

                Driver driver = new Driver(firstName, lastName, id, phoneNumber, email, address,
                                           userName, password, idCopy, licenseCopy, licenseId, 
                                           false, status, vehicle);

               
                DriverList.Add(driver);
            }
        }

        public static void InitOperationalManagerList()
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE dbo.Get_all_OperationalManager"; 
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(sp);

            Program.OperationalManagerList = new List<OperationalManager>();
            while (rdr.Read())
            {
                string firstName = rdr.GetValue(0).ToString();
                string lastName = rdr.GetValue(1).ToString();
                string id = rdr.GetValue(2).ToString();
                string phoneNumber = rdr.GetValue(3).ToString();
                string email = rdr.GetValue(4).ToString();
                string address = rdr.GetValue(5).ToString();
                string userName = rdr.GetValue(6).ToString();
                string password = rdr.GetValue(7).ToString();
                string idCopy = rdr.GetValue(8).ToString();

                OperationalManager operationalManager = new OperationalManager(firstName, lastName, id, phoneNumber, email, address, userName, password, idCopy, false);

                Program.OperationalManagerList.Add(operationalManager);
            }
        }

        public static void InitOrderList()
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE dbo.Get_all_Orders";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(sp);

            Program.OrderList = new List<Order>();
            while (rdr.Read())
            {
                string id = rdr.GetValue(0).ToString();
                string customerName = rdr.GetValue(1).ToString();
                string customerPhoneNamber = rdr.GetValue(2).ToString();
                string customerEmail = rdr.GetValue(3).ToString();
                DateTime startDate = Convert.ToDateTime(rdr.GetValue(4).ToString());
                string departure = rdr.GetValue(5).ToString();
                string destenation = rdr.GetValue(6).ToString();
                CargoType cargoType = (CargoType)Enum.Parse(typeof(CargoType), rdr.GetValue(7).ToString());
                DateTime estimatedFinishDate = Convert.ToDateTime(rdr.GetValue(8).ToString());
                OrderStatus orderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), rdr.GetValue(9).ToString());
                string driverId = null;
                Driver driver = null;  

                if (!rdr.IsDBNull(10))
                {
                    driverId = rdr.GetValue(11).ToString();
                    driver = Program.DriverList.FirstOrDefault(d => d.GetId() == driverId);
                }
                string clerkId = null; 
                Clerk clerk = null;    

                if (!rdr.IsDBNull(12)) // בדיקה אם הערך אינו null
                {
                    clerkId = rdr.GetValue(12).ToString(); // קבלת הערך והמרתו למחרוזת
                    clerk = Program.ClerkList.FirstOrDefault(c => c.GetId() == clerkId); // חיפוש פקיד ברשימה
                }
                double profit = Convert.ToDouble(rdr.GetDecimal(12));
                VehicleType VehicleType = (VehicleType)Enum.Parse(typeof(VehicleType), rdr.GetValue(13).ToString());
                int totalWeight = rdr.GetInt32(14);


                Order order = new Order(id, customerName, customerPhoneNamber,
                    customerEmail, startDate, departure, destenation, cargoType, estimatedFinishDate, orderStatus,driver, clerk,profit, VehicleType, totalWeight, false);

                Program.OrderList.Add(order);
            }

        }

        public static void InitClerkList()
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE dbo.Get_all_Clerks";  
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(sp);
            
            Program.ClerkList = new List<Clerk>();
            while (rdr.Read())
            {
                
                string firstName = rdr.GetValue(0).ToString();
                string lastName = rdr.GetValue(1).ToString();
                string id = rdr.GetValue(2).ToString();
                string phoneNumber = rdr.GetValue(3).ToString();
                string email = rdr.GetValue(4).ToString();
                string address = rdr.GetValue(5).ToString();
                string userName = rdr.GetValue(6).ToString();
                string password = rdr.GetValue(7).ToString();
                string idCopy = rdr.GetValue(8).ToString();
                PerformanceStatus performanceStatus = (PerformanceStatus)Enum.Parse(typeof(PerformanceStatus), rdr.GetValue(9).ToString());
                

                Clerk clerk = new Clerk(firstName, lastName, id, phoneNumber, email, address, userName, password, idCopy, false, performanceStatus);

                Program.ClerkList.Add(clerk);
            }

        }

        public static void InitQuestionList()
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE dbo.Get_all_Questions";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(sp);


            QuestionList = new List<Question>();
            while (rdr.Read())
            {
                int questionNumber = Convert.ToInt32(rdr.GetValue(0));
                string description = rdr.GetValue(1).ToString();
                bool associatedRole = rdr.GetBoolean(2);
                bool hide = rdr.GetBoolean(3);
                Question question = new Question(questionNumber, description, associatedRole, hide, false);
                QuestionList.Add(question);
            }
        }

        public static void InitSurveyList()
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE dbo.Get_all_Surveys";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(sp);


            SurveyList = new List<Survey>();
            while (rdr.Read())
            {
                string headline = rdr.GetValue(0).ToString();
                bool completed = rdr.GetBoolean(1);
                string orderId = rdr.GetValue(2).ToString();
                Order order = Program.OrderList.FirstOrDefault(o => o.GetId() == orderId);

               
                Survey survey = new Survey(headline, completed, order, false);

                SurveyList.Add(survey);

                foreach (Question question in QuestionList)
                {
                    survey.AddQuestion(question);
                }
            }
        }


      

        public static void InitAnswerList()
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE dbo.Get_all_Answers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(sp);


            AnswerList = new List<Answer>();
            while (rdr.Read())
            {
                int questionNum = Convert.ToInt32(rdr.GetValue(1));
                Question question = Program.QuestionList.FirstOrDefault(q => q.GetQuestionNum() == questionNum);
                string headline = rdr.GetValue(2).ToString();
                Survey survey = Program.SurveyList.FirstOrDefault(s => s.GetHeadline() == headline);
                int answerValue = Convert.ToInt32(rdr.GetValue(0));
                Answer answer = new Answer(question, survey, answerValue, false);
                
                survey.AddAnswer(answer);               
            }
        }


        static void InitActiveQuestionList()
        {
            List<Question> ActiveQuestionList = new List<Question>();
            foreach (Question question in QuestionList)
            {
                if (question.IsActive())
                {
                    ActiveQuestionList.Add(question);
                }
            }
        }

        public static void InitializeEmployeeList()
        {
            EmployeeList.AddRange(DriverList);
            EmployeeList.AddRange(ClerkList);
            EmployeeList.AddRange(OperationalManagerList);
            // Add office manager
        }

        static void InitEmployeeMonthlyEvaluation()
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE dbo.Get_all_EmployeeMonthlyEvaluation";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(sp);


            EmployeeMonthlyEvaluationList = new List<EmployeeMonthlyEvaluation>();
            while (rdr.Read())
            {
                string personalNote = rdr.GetValue(0).ToString();
                int associatedMonth = Convert.ToInt32(rdr.GetValue(1));
                DateTime submissionDate = Convert.ToDateTime(rdr.GetValue(2));
                int year = Convert.ToInt32(rdr.GetValue(3));

                // combining clerk list and driver list as evaluatables
                // in order to retrieve appropriate employee
                List<Evaluatable> EvaluatableList = new List<Evaluatable>();
                EvaluatableList.AddRange(Program.DriverList); 
                EvaluatableList.AddRange(Program.ClerkList);


                string employeeId = rdr.GetValue(4).ToString();

                // retreiving the associated employee
                Evaluatable employee = EvaluatableList.FirstOrDefault(d => d.GetId() == employeeId);

                EmployeeMonthlyEvaluation employeeMonthlyEvaluation = new EmployeeMonthlyEvaluation(personalNote, 
                    associatedMonth, submissionDate, year, employee, false);
                EmployeeMonthlyEvaluationList.Add(employeeMonthlyEvaluation);
            }
        }

        static void InitOfficeManagerList() 
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE dbo.Get_OfficeManager"; // Adjust the stored procedure name if needed
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(sp);
            OfficeManagerList = new List<OfficeManager>();
            while (rdr.Read())
            {
                string firstName = rdr.GetValue(0).ToString();
                string lastName = rdr.GetValue(1).ToString();
                string id = rdr.GetValue(2).ToString();
                string phoneNumber = rdr.GetValue(3).ToString();
                string email = rdr.GetValue(4).ToString();
                string address = rdr.GetValue(5).ToString();
                string userName = rdr.GetValue(6).ToString();
                string password = rdr.GetValue(7).ToString();
                string idCopy = rdr.GetValue(8).ToString();

            
                OfficeManager office_manager = new OfficeManager(firstName, lastName, id, phoneNumber, email, address, userName, password, idCopy, false);
                Program.OfficeManagerList.Add(office_manager);
            }
        }

        static void InitEmployeeList()
        {
            EmployeeList = new List <Employee>();

            if (DriverList != null)
                EmployeeList.AddRange(DriverList);

            if (ClerkList != null)
                EmployeeList.AddRange(ClerkList);

            if (OperationalManagerList != null)
                EmployeeList.AddRange(OperationalManagerList);

            if (OfficeManagerList != null)
                EmployeeList.AddRange(OfficeManagerList); 
        }



        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitLists();
            InitializeEmployeeList();
            Application.Run(new HomePage());
        }

    }
}


  
