using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysisAndDesignProject
{
    public class Clerk : Evaluatable
    {
            private string firstName;
            private string lastName;
            private string id;
            private string phoneNumber;
            private string email;
            private string address;
            private string userName;
            private string password;
            private string idCopy; //path of id file
            private Role role;
            private PerformanceStatus performanceStatus;

        public Clerk(string firstName, string lastName, string id, string phoneNumber,
           string email, string address, string userName, string password,
           string idCopy, bool is_new, Role role, PerformanceStatus performanceStatus)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.address = address;
            this.userName = userName;
            this.password = password;
            this.idCopy = idCopy;
            this.role = role;
            this.performanceStatus = performanceStatus;
            if (is_new)
            {
                this.CreateClerk();
                Program.ClerkList.Add(this);
            }

        }

        public void CreateClerk()
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE SP_add_Driver @firstName, @lastName, @id, @phoneNumber" +
                ", @email, @address, @userName, @password, @idCopy, @licenseCopy, @licenseId, @role, @performanceStatus";
            sp.Parameters.AddWithValue("@firstName", this.firstName);
            sp.Parameters.AddWithValue("@lastName", this.lastName);
            sp.Parameters.AddWithValue("@id", this.id);
            sp.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
            sp.Parameters.AddWithValue("@email", this.email);
            sp.Parameters.AddWithValue("@address", this.address);
            sp.Parameters.AddWithValue("@userName", this.userName);
            sp.Parameters.AddWithValue("@password", this.password);
            sp.Parameters.AddWithValue("@idCopy", this.idCopy);
            sp.Parameters.AddWithValue("@role", this.role);
            sp.Parameters.AddWithValue("@performanceStatus", this.performanceStatus);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(sp);
        }

        public string GetFirstName()
        {
            return this.firstName;
        }

        public string GetLastName()
        {
            return this.lastName;
        }

        public string GetId()
        {
            return this.id;
        }

 
        public string GetPhoneNumber()
        {
            return this.phoneNumber;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public string GetAddress()
        {
            return this.address;
        }


        public string GetUserName()
        {
            return this.userName;
        }

        public string GetPassword()
        {
            return this.password;
        }

        public string GetIdCopy()
        {
            return this.idCopy;
        }

        public Role GetRole()
        {
            return this.role;
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
            }
        }

        public void UpdateClerkProfile()
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE SP_update_driver @firstName, @lastName, @id, @phoneNumber" +
                ", @email, @address, @userName, @password, @idCopy, @role";
            sp.Parameters.AddWithValue("@firstName", this.firstName);
            sp.Parameters.AddWithValue("@lastName", this.lastName);
            sp.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
            sp.Parameters.AddWithValue("@email", this.email);
            sp.Parameters.AddWithValue("@address", this.address);
            sp.Parameters.AddWithValue("@userName", this.userName);
            sp.Parameters.AddWithValue("@password", this.password);
            sp.Parameters.AddWithValue("@idCopy", this.idCopy);
            sp.Parameters.AddWithValue("@role", this.role);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(sp);
        }

        public void CreateNewDriver(string firstName, string lastName, string id, string phoneNumber,
            string email, string address, string userName, string password,
            string idCopy, string licenseCopy, string licenseId, bool is_new, Role role,
            PerformanceStatus performanceStatus, Vehicle vehicle) 
        {
             Driver driver = new Driver(firstName, lastName, id, phoneNumber,
                                        email, address, userName, password, idCopy, licenseCopy, 
                                        licenseId, is_new, role, performanceStatus, vehicle);

            }

        public void CreateNewOperationalManager(string firstName, string lastName, string id, string phoneNumber,
               string email, string address, string userName, string password,
               string idCopy, bool is_new, Role role)
        {
            OperationalManager operationalManager = new OperationalManager(firstName, lastName, id, phoneNumber,
                                        email, address, userName, password, idCopy, is_new, role);
        }

        public bool GetAssociatedRole()
        {
            return false;
        }

        public string GetName()
        {
            string fullName = this.firstName + " " + this.lastName;
            return fullName;
        }



    }


}
