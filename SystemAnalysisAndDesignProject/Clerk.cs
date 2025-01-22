using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                sp.CommandText = "EXECUTE UpdateOrderStatus @OrderId, @OrderStatus";
                sp.Parameters.AddWithValue("@OrderStatus", orderStatus);

                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(sp);

                order.Archive();
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


    }


}
