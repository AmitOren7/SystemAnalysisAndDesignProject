using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysisAndDesignProject
{
    public class Driver :Employee, Evaluatable
    {
   
        private string licenseCopy; //path of license file
        private string licenseId; //serial number of license
        private PerformanceStatus performanceStatus;
        private Vehicle vehicle;


        public Driver(string firstName, string lastName, string id, string phoneNumber,
            string email, string address, string userName, string password,
            string idCopy, string licenseCopy, string licenseId, bool is_new,
            PerformanceStatus performanceStatus, Vehicle vehicle)
            : base (firstName, lastName, id, phoneNumber,email, address, userName, password,idCopy)
        {
          
            this.licenseCopy = licenseCopy;
            this.licenseId = licenseId;
            this.performanceStatus = performanceStatus;
            this.vehicle = vehicle;
            if (is_new)
            {
                this.Create();
                Program.DriverList.Add(this);
            }

        }

        public override void Create()
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE SP_add_Driver @firstName, @lastName, @id, @phoneNumber" +
                ",@email, @address, @userName, @password, @idCopy, @licenseCopy, @licenseId, @performanceStatus, @vehicle";
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
            sp.Parameters.AddWithValue("@performanceStatus", this.performanceStatus.ToString());
            if (this.vehicle != null) 
            {
                sp.Parameters.AddWithValue("@vehicle", this.vehicle.GetID());
            }
            sp.Parameters.AddWithValue("@vehicle", DBNull.Value);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(sp); 
        }



        public PerformanceStatus GetPerformanceStatus() 
        {
            return this.performanceStatus;
        }

        public Vehicle GetVehicle()
        {
            return this.vehicle;
        }

        public string GetLicenseId() 
        {
            return this.licenseId;
        }

        public string GetLisenceCopy() 
        {
            return this.licenseCopy;
        }

        public void SetLicenseCopy(string licenseCopy)
        {
            this.licenseCopy = licenseCopy;
        }

        public void SetLicenseId(string licenseId)
        {
            this.licenseId = licenseId;
        }

        //public void FillWorkCertification() { }


        public void UpdateOrderStatus(OrderStatus orderStatus, Order order)
        {
            order.SetOrderStatus(orderStatus);
            if (order.GetOrderStatus() == OrderStatus.orderClosed)
            {
                SqlCommand sp = new SqlCommand();
                sp.CommandText = "EXECUTE SP_Update_OrderStatus @OrderId, @OrderStatus";
                sp.Parameters.AddWithValue("@OrderStatus", orderStatus);
                sp.Parameters.AddWithValue("@OrderId", orderStatus);

                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(sp);
            }
        }
        
        public override void Update()
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE SP_update_driver @firstName, @lastName, @id, @phoneNumber" +
                ",@email, @address, @userName, @password, @idCopy, @licenseCopy, @licenseId";
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


            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(sp);
        }



        public bool GetAssociatedRole()  // indicated associated role for driver and clerk roles in the survey.
        {
            return true;
        }

        public void SetVehicle (Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public void changeStatus(PerformanceStatus status)
        {
            this.performanceStatus = status;

            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE SP_Update_Driver_Status @id, @performanceStatus";

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
            sp.CommandText = "EXECUTE SP_archive_driver @id";

            sp.Parameters.AddWithValue("@id", this.id);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(sp);

            Program.ArchivedEmployeeList.Add(this);
            Program.EmployeeList.Remove(this);
            Program.DriverList.Remove(this);

        }
    }

  
}
