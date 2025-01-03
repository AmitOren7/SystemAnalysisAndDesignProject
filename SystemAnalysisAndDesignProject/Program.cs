using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
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

        [STAThread]


        public static void InitLists()
        {
            InitVehicleList();
            InitDriverList();
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

                Driver driver = new Driver(firstName, lastName, id, phoneNumber, email, address, userName, password, idCopy, licenseCopy, licenseId, false);

                DriverList.Add(driver);
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

  
