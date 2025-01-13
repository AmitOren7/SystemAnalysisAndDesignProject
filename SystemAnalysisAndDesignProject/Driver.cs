using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysisAndDesignProject
{
    public class Driver : Evaluatable
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
        private string licenseCopy; //path of license file
        private string licenseId; //serial number of license
        private Role role;
        private PerformanceStatus performanceStatus;
        private Vehicle vehicle;


        public Driver(string firstName, string lastName, string id, string phoneNumber,
            string email, string address, string userName, string password,
            string idCopy, string licenseCopy, string licenseId, bool is_new, Role role,
            PerformanceStatus performanceStatus, Vehicle vehicle)
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
            this.licenseCopy = licenseCopy;
            this.licenseId = licenseId;
            this.role = role;
            this.performanceStatus = performanceStatus;
            this.vehicle = vehicle;
            if (is_new)
            {
                this.CreateDriver();
                Program.DriverList.Add(this);
            }

        }



        public void CreateDriver()
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE SP_add_Driver @firstName, @lastName, @id, @phoneNumber" +
                ", @email, @address, @userName, @password, @idCopy, @licenseCopy, @licenseId, @role, @performanceStatus, @vehicle";
            sp.Parameters.AddWithValue("@firstName", this.firstName);
            sp.Parameters.AddWithValue("@lastName", this.lastName);
            sp.Parameters.AddWithValue("@id", this.id);
            sp.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
            sp.Parameters.AddWithValue("@email", this.email);
            sp.Parameters.AddWithValue("@address", this.address);
            sp.Parameters.AddWithValue("@userName", this.userName);
            sp.Parameters.AddWithValue("@password", this.password);
            sp.Parameters.AddWithValue("@idCopy", this.idCopy);
            sp.Parameters.AddWithValue("@licenseCopy", this.licenseCopy);
            sp.Parameters.AddWithValue("@licenseId", this.licenseId);
            sp.Parameters.AddWithValue("@role", this.role);
            sp.Parameters.AddWithValue("@performanceStatus", this.performanceStatus);
            sp.Parameters.AddWithValue("@vehicle", this.vehicle.GetID());

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

        public string GetLicenseId()
        {
            return this.licenseId;
        }


        public Role GetRole()
        {
            return this.role;
        }

        public PerformanceStatus GetPerformanceStatus() 
        {
            return this.performanceStatus;
        }

        public Vehicle GetVehicle()
        {
            return this.vehicle;
        }

        //public void FillWorkCertification() { }


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

        public void UpdateDriverProfile() 
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE SP_update_driver @firstName, @lastName, @id, @phoneNumber" +
                ", @email, @address, @userName, @password, @idCopy, @licenseCopy, @licenseId, @role";
            sp.Parameters.AddWithValue("@firstName", this.firstName);
            sp.Parameters.AddWithValue("@lastName", this.lastName);
            sp.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
            sp.Parameters.AddWithValue("@email", this.email);
            sp.Parameters.AddWithValue("@address", this.address);
            sp.Parameters.AddWithValue("@userName", this.userName);
            sp.Parameters.AddWithValue("@password", this.password);
            sp.Parameters.AddWithValue("@idCopy", this.idCopy);
            sp.Parameters.AddWithValue("@licenseCopy", this.licenseCopy);
            sp.Parameters.AddWithValue("@licenseId", this.licenseId);
            sp.Parameters.AddWithValue("@role", this.role);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(sp);
        }

        public bool GetAssociatedRole()
        {
            return true;
        }


    }
}
