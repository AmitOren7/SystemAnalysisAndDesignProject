using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAnalysisAndDesignProject
{
    public class Clerk : Employee,Evaluatable
    {

            private PerformanceStatus performanceStatus;

        public Clerk(string firstName, string lastName, string id, string phoneNumber,
           string email, string address, string userName, string password,
           string idCopy, bool is_new, PerformanceStatus performanceStatus)
           :base ( firstName, lastName, id, phoneNumber, email, address, userName, password,idCopy)
        {
            this.performanceStatus = performanceStatus;
            if (is_new)
            {
                this.Create();
                Program.ClerkList.Add(this);
            }

        }

        public override void Create()
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE SP_add_Clerk @firstName, @lastName, @id, @phoneNumber" +
                ", @email, @address, @userName, @password, @idCopy, @performanceStatus";
            sp.Parameters.AddWithValue("@firstName", this.firstName);
            sp.Parameters.AddWithValue("@lastName", this.lastName);
            sp.Parameters.AddWithValue("@id", this.id);
            sp.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
            sp.Parameters.AddWithValue("@email", this.email);
            sp.Parameters.AddWithValue("@address", this.address);
            sp.Parameters.AddWithValue("@userName", this.userName);
            sp.Parameters.AddWithValue("@password", this.password);
            sp.Parameters.AddWithValue("@idCopy", this.idCopy);
            sp.Parameters.AddWithValue("@performanceStatus", this.performanceStatus.ToString());

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(sp);
        }

    
        public PerformanceStatus GetPerformanceStatus()
        {
            return this.performanceStatus;
        }

     
        public void UpdateOrderStatus(OrderStatus orderStatus, Order order)
        {
            order.SetOrderStatus(orderStatus);
            if (order.GetOrderStatus() == OrderStatus.orderClosed)
            {
                SqlCommand sp = new SqlCommand();
                sp.CommandText = "EXECUTE SP_Update_orderStatus @OrderId, @OrderStatus";
                sp.Parameters.AddWithValue("@OrderId", order.GetId());
                sp.Parameters.AddWithValue("@OrderStatus", OrderStatus.orderClosed.ToString());


                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(sp);

                order.Archive();
                SendSurveyEmail(order);
                Driver driver = order.GetDriver();
                Clerk clerk = order.GetClerk();

                // Check if driver has any assigned orders (excluding the closed one)
                bool driverHasOtherOrders = Program.OrderList.Any(o => o.GetDriver() == driver && o.GetId() != order.GetId());
                if (!driverHasOtherOrders)
                {
                    driver.changeStatus(PerformanceStatus.pendingForAssignment);
                }
                else
                {
                    driver.changeStatus(PerformanceStatus.assignedToOrder);
                }

                // Check if clerk has any assigned orders (excluding the closed one)
                bool clerkHasOtherOrders = Program.OrderList.Any(o => o.GetClerk() == clerk && o.GetId() != order.GetId());
                if (!clerkHasOtherOrders)
                {
                    clerk.changeStatus(PerformanceStatus.pendingForAssignment);
                }
                else
                {
                    clerk.changeStatus(PerformanceStatus.assignedToOrder);
                }
            }
        }
    
            
      
        private void SendSurveyEmail(Order order)
        {
            try
            {
                // 1. Get customer email from the order
                string toAddress = order.GetCustomerEmail();
                if (string.IsNullOrEmpty(toAddress))
                {
                    MessageBox.Show("Customer email is missing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the function if the email is missing
                }

                // 2. Get active questions
                List<Question> activeQuestions = Program.QuestionList.Where(q => q.IsActive()).ToList();

                if (activeQuestions.Count == 0)
                {
                    MessageBox.Show("No active questions found for the survey!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3. Build the email body
                string body = $"Dear {order.GetCustomerName()},\n\nPlease take a moment to complete this short survey regarding your order (ID: {order.GetId()}):\n\n";

                for (int i = 0; i < activeQuestions.Count; i++)
                {
                    body += $"{i + 1}. {activeQuestions[i].GetDescription()}\n"; // Add question description to the body
                }

                body += "\nThank you for your feedback!\n\nSincerely,\nSami Cranes";

                // 4. Set up email details
                string fromAddress = "samicranes2000@gmail.com"; // email address
                string fromPassword = "lnxh bvkk nzcf khqn"; // app password!
                string subject = "Customer Satisfaction Survey"; // Email subject


                // 5. Create the MailMessage object
                MailMessage message = new MailMessage(fromAddress, toAddress, subject, body);

                // 6. Set up the SMTP client
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"); // Gmail SMTP server
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential(fromAddress, fromPassword);
                smtpClient.EnableSsl = true;

                // 7. Send the email
                smtpClient.Send(message);

                MessageBox.Show("Survey email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SmtpException ex)
            {
                MessageBox.Show($"Error sending email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Invalid email address format: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public override void Update()
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE SP_update_Clerk @firstName, @lastName, @id, @phoneNumber" +
                ", @email, @address, @userName, @password, @idCopy";
            sp.Parameters.AddWithValue("@firstName", this.firstName);
            sp.Parameters.AddWithValue("@lastName", this.lastName);
            sp.Parameters.AddWithValue("@id", this.id);
            sp.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
            sp.Parameters.AddWithValue("@email", this.email);
            sp.Parameters.AddWithValue("@address", this.address);
            sp.Parameters.AddWithValue("@userName", this.userName);
            sp.Parameters.AddWithValue("@password", this.password);
            sp.Parameters.AddWithValue("@idCopy", this.idCopy);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(sp);
        }

        public void CreateNewDriver(string firstName, string lastName, string id, string phoneNumber,
            string email, string address, string userName, string password,
            string idCopy, string licenseCopy, string licenseId, bool is_new, 
            PerformanceStatus performanceStatus, Vehicle vehicle) 
        {
             Driver driver = new Driver(firstName, lastName, id, phoneNumber,
                                        email, address, userName, password, idCopy, licenseCopy, 
                                        licenseId, is_new, performanceStatus, vehicle);

            }

        public void CreateNewOperationalManager(string firstName, string lastName, string id, string phoneNumber,
               string email, string address, string userName, string password,
               string idCopy, bool is_new)
        {
            OperationalManager operationalManager = new OperationalManager(firstName, lastName, id, phoneNumber,
                                        email, address, userName, password, idCopy, is_new);
        }

        public void CreateNewOfficeManager(string firstName, string lastName, string id, string phoneNumber,
               string email, string address, string userName, string password,
               string idCopy, bool is_new)
        {
            OfficeManager officeManager = new OfficeManager(firstName, lastName, id, phoneNumber,
                                        email, address, userName, password, idCopy, is_new);
        }

        public bool GetAssociatedRole() // indicated associated role for driver and clerk roles in the survey.
        {
            return false;
        }

        public override string ToString()
        {
            return GetName(); 
        }
        public void changeStatus(PerformanceStatus status)
        {
            this.performanceStatus = status;

            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE SP_Update_Clerk_Status @id, @performanceStatus";

            sp.Parameters.AddWithValue("@id", this.id);
            sp.Parameters.AddWithValue("@performanceStatus", this.performanceStatus.ToString());


            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(sp);

            if (status == PerformanceStatus.archived)
            {
                Archive();
            }

        }

        public void Archive()
        {

            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE SP_archive_clerk @id";

            sp.Parameters.AddWithValue("@id", this.id);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(sp);

            Program.ArchivedEmployeeList.Add(this);
            Program.EmployeeList.Remove(this);
            Program.ClerkList.Remove(this);
        }

    }


}
