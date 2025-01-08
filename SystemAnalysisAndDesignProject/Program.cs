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


namespace SystemAnalysisAndDesignProject
{
    internal static class Program
    {
        public static System.Collections.Generic.List<Vehicle> VehicleList;
        public static System.Collections.Generic.List<Driver> DriverList;
        public static System.Collections.Generic.List<OperationalManager> OperationalManagerList;
        public static System.Collections.Generic.List<Order> OrderList;
        public static System.Collections.Generic.List<Clerk> ClerkList;

        [STAThread]


        public static void InitLists()
        {
            InitVehicleList();
            InitDriverList();
            InitOperationalManagerList();
            InitOrderList();
            InitClerkList();
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
                Role role = (Role)Enum.Parse(typeof(Role), rdr.GetValue(11).ToString());
                PerformanceStatus status = (PerformanceStatus)Enum.Parse(typeof(PerformanceStatus), rdr.GetValue(12).ToString());
                string vehicleId = rdr.GetValue(13).ToString();
                Vehicle vehicle = Program.VehicleList.FirstOrDefault(v => v.GetID() == vehicleId);

                Driver driver = new Driver(firstName, lastName, id, phoneNumber, email, address,
                                           userName, password, idCopy, licenseCopy, licenseId, 
                                           false, role, status, vehicle);

               
                DriverList.Add(driver);
            }
        }

        public static void InitOperationalManagerList()
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE dbo.Get_All_OperationalManagers"; // Adjust the stored procedure name if needed
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
                Role role = (Role)Enum.Parse(typeof(Role), rdr.GetValue(9).ToString());

                OperationalManager operationalManager = new OperationalManager(firstName, lastName, id, phoneNumber, email, address, userName, password, idCopy, false, role);

                Program.OperationalManagerList.Add(operationalManager);
            }
        }

        public static void InitOrderList()
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE dbo.Get_All_Orders";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(sp);

            Program.OrderList = new List<Order>();
            while (rdr.Read())
            {
                string id = rdr.GetValue(0).ToString();
                string customerName = rdr.GetValue(1).ToString();
                string customerPhoneNamber = rdr.GetValue(2).ToString();
                string customerPhoneName = rdr.GetValue(3).ToString();
                string customerEmail = rdr.GetValue(4).ToString();
                DateTime startDate = Convert.ToDateTime(rdr.GetValue(5).ToString());
                string departure = rdr.GetValue(6).ToString();
                string destenation = rdr.GetValue(7).ToString();
                CargoType cargoType = (CargoType)Enum.Parse(typeof(CargoType), rdr.GetValue(8).ToString());
                DateTime estimatedFinishDate = Convert.ToDateTime(rdr.GetValue(9).ToString());
                OrderStatus orderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), rdr.GetValue(10).ToString());
                string driverId = rdr.GetValue(11).ToString();
                Driver driver = Program.DriverList.FirstOrDefault(d => d.GetId() == driverId);
                string clerkId = rdr.GetValue(12).ToString();
                Clerk clerk = Program.ClerkList.FirstOrDefault(c => c.GetId() == clerkId);


                Order order = new Order(id, customerName, customerPhoneNamber, customerPhoneName,
                    customerEmail, startDate, departure, destenation, cargoType, estimatedFinishDate, orderStatus,driver, clerk, false);

                Program.OrderList.Add(order);
            }

        }

        public static void InitClerkList()
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE dbo.Get_All_Clerks";  
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
                Role role = (Role)Enum.Parse(typeof(Role), rdr.GetValue(9).ToString()); 
                PerformanceStatus performanceStatus = (PerformanceStatus)Enum.Parse(typeof(PerformanceStatus), rdr.GetValue(10).ToString());
                

                Clerk clerk = new Clerk(firstName, lastName, id, phoneNumber, email, address, userName, password, idCopy, false, role, performanceStatus);

                Program.ClerkList.Add(clerk);
            }

        }




        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitLists();
            Application.Run(new MainForm());
        }
    }
}


  
