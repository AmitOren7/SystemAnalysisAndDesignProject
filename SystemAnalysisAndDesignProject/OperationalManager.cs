using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAnalysisAndDesignProject
{
    public class OperationalManager : Employee
    {
       
        public OperationalManager(string firstName, string lastName, string id, string phoneNumber,
               string email, string address, string userName, string password,
               string idCopy, bool is_new)
               : base ( firstName, lastName, id, phoneNumber,email, address, userName, password,idCopy)
        {

            if (is_new)
            {
                this.Create();
                Program.OperationalManagerList.Add(this);
            }

        }

        public override void Create()
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE dbo.sp_add_OperationalManager @firstName, @lastName, @id, @phoneNumber" +
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
        public override void Update()
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE SP_update_OperationalManager @firstName, @lastName, @id, @phoneNumber" +
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

        public static void assign_driver (Driver driver, Order order )
        {
            order.SetDriver(driver);
            order.SetOrderStatus(OrderStatus.assigned);
            SqlCommand sp1 = new SqlCommand();
            sp1.CommandText = "EXECUTE SP_Update_orderDriver @id, @Driver";
            sp1.Parameters.AddWithValue("@id", order.GetId());
            sp1.Parameters.AddWithValue("@Driver", driver.GetId());
            SqlCommand sp2 = new SqlCommand();
            sp2.CommandText = "EXECUTE SP_Update_orderStatus @id, @orderStatus";
            sp2.Parameters.AddWithValue("@id", order.GetId());
            sp2.Parameters.AddWithValue("@orderStatus", OrderStatus.assigned.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(sp1);
            SC.execute_non_query(sp2);


        }

        public static void assign_clerk (Clerk clerk , Order order ) 
        {
            order.SetClerk(clerk);
            SqlCommand sp1 = new SqlCommand();
            sp1.CommandText = "EXECUTE SP_Update_orderClerk @id, @clerkID";
            sp1.Parameters.AddWithValue("@id", order.GetId());
            sp1.Parameters.AddWithValue("@clerkID", clerk.GetId());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(sp1);

        }

        public static void SetDriverAlternativeVehicle (Driver driver , Vehicle vehicle)
        {
            driver.SetVehicle(vehicle);
            SqlCommand sp1 = new SqlCommand();
            sp1.CommandText = "EXECUTE SP_Update_driverVehicle @id, @vehicleID";
            sp1.Parameters.AddWithValue("@id", driver.GetId());
            sp1.Parameters.AddWithValue("@vehicleID", vehicle.GetID());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(sp1);



        }

        public static void UnAssign (Order order)
        {
            SqlCommand sp1 = new SqlCommand();
            sp1.CommandText = "EXECUTE SP_Update_orderDriver @id, @Driver";
            sp1.Parameters.AddWithValue("@id", order.GetId());
            sp1.Parameters.AddWithValue("@Driver", DBNull.Value);
            SqlCommand sp2 = new SqlCommand();
            sp2.CommandText = "EXECUTE SP_Update_orderStatus @id, @orderStatus";
            sp2.Parameters.AddWithValue("@id", order.GetId());
            sp2.Parameters.AddWithValue("@orderStatus", OrderStatus.pendingForAssignment.ToString());
            SqlCommand sp3 = new SqlCommand();
            sp3.CommandText = "EXECUTE SP_Update_orderClerk @id, @clerkID";
            sp3.Parameters.AddWithValue("@id", order.GetId());
            sp3.Parameters.AddWithValue("@clerkID", DBNull.Value);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(sp1);
            SC.execute_non_query(sp2);
            SC.execute_non_query(sp3);
        }

        public static void ChangeDriverStatus (Driver driver)
        {
            driver.changeStatus(PerformanceStatus.assignedToOrder);
        }

        public static void ChangeClerkStatus (Clerk clerk)
        {
            clerk.changeStatus(PerformanceStatus.assignedToOrder);
        }

    }
}

