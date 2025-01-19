using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysisAndDesignProject
{
    public class Order
    {
        private string id;
        private string customerName;
        private string customerPhoneNamber;
        private string customerEmail;
        private DateTime startDate;
        private string departure;
        private string destenation;
        private CargoType cargoType;
        private DateTime estimatedFinishDate;
        private OrderStatus orderStatus;
        private Driver driver;
        private Clerk clerk;
        private double profit;
        private VehicleType vehicleType;
        private int totalWeight;


        public Order(string id, string customerName, string customerPhoneNamber,
                     string customerEmail, DateTime startDate,
                     string departure, string destenation, CargoType cargoType,
                     DateTime estimatedFinishDate, OrderStatus orderStatus, Driver driver, Clerk clerk, 
                     double profit, VehicleType vehicleType, int totalWeight,  bool is_new)
        {
            this.id = id;
            this.customerName = customerName;
            this.customerPhoneNamber = customerPhoneNamber;
            this.customerEmail = customerEmail;
            this.startDate = startDate;
            this.departure = departure;
            this.destenation = destenation;
            this.cargoType = cargoType;
            this.estimatedFinishDate = estimatedFinishDate;
            this.orderStatus = orderStatus;
            this.driver = driver;
            this.clerk = clerk;
            this.profit = profit;
            this.vehicleType = vehicleType;
            this.totalWeight = totalWeight;
            if (is_new)
            {
                this.CreateOrder();
                Program.OrderList.Add(this);
            }

        }

        public void CreateOrder()
        {
            // Create a new SqlCommand for the stored procedure
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE SP_add_Order @id, @customerName, @customerPhoneNamber, " +
                             " @customerEmail, @startDate, @departure, @destenation, " +
                             "@cargoType, @estimatedFinishDate,@orderStatus @driver, @clerk, @profit, @vehicleType, @totalWeight";

            // Add parameters with values from the Order object
            sp.Parameters.AddWithValue("@id", this.id);
            sp.Parameters.AddWithValue("@customerName", this.customerName);
            sp.Parameters.AddWithValue("@customerPhoneNamber", this.customerPhoneNamber);
            sp.Parameters.AddWithValue("@customerEmail", this.customerEmail);
            sp.Parameters.AddWithValue("@startDate", this.startDate);
            sp.Parameters.AddWithValue("@departure", this.departure);
            sp.Parameters.AddWithValue("@destenation", this.destenation);
            sp.Parameters.AddWithValue("@cargoType", this.cargoType.ToString()); // Assuming CargoType is an Enum
            sp.Parameters.AddWithValue("@estimatedFinishDate", this.estimatedFinishDate);
            sp.Parameters.AddWithValue("@orderStatus", this.orderStatus);
            sp.Parameters.AddWithValue("@driver", this.driver.GetId());
            sp.Parameters.AddWithValue("@clerk", this.clerk.GetId());
            sp.Parameters.AddWithValue("@profit", this.profit);
            sp.Parameters.AddWithValue("@vehicleType", this.vehicleType.ToString());
            sp.Parameters.AddWithValue("@totalWeight", this.totalWeight);


            // Execute the stored procedure to insert the order into the database
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(sp); // Call the method to execute the command (assuming it handles the database connection)
        }

        public string GetId() 
        {
            return this.id;
        }

        public string GetCustomerName() 
        {
            return this.customerName;
        }

        public string GetCustomertPhoneNumber() 
        {
            return this.customerPhoneNamber;
        }

        public string GetCustomerEmail() 
        {
            return this.customerEmail;
        }

        public DateTime GetStartDate() 
        {
            return this.startDate;
        }

        public string GetDeparture() 
        { 
            return this.departure;
        }

        public string GetDestination() 
        {
            return this.destenation;
        }

        public CargoType GetCargoType() 
        {
            return this.cargoType;
        }

        public DateTime GetEstimatedFinishDate() 
        {
            return this.estimatedFinishDate;
        }

        public double GetProfit()
        {
            return this.profit;
        }

        public VehicleType GetVehicleType()
        {
            return this.vehicleType;
        }

        public int GetTotalWeight()
        {
            return this.totalWeight;
        }

        public void SetCustomerName(string customerName)
        {
            this.customerName = customerName;
        }

        public void SetCustomerPhoneNamber(string customerPhoneNamber)
        {
            this.customerPhoneNamber = customerPhoneNamber;
        }

        public void SetCustomerEmail(string customerEmail)
        {
            this.customerEmail = customerEmail;
        }

        public void SetStartDate(DateTime startDate)
        {
            this.startDate = startDate;
        }

        public void SetDeparture(string departure)
        {
            this.departure = departure;
        }

        public void SetDestenation(string destenation)
        {
            this.destenation = destenation;
        }

        public void SetCargoType(CargoType cargoType)
        {
            this.cargoType = cargoType;
        }

        public void SetEstimatedFinishDate(DateTime estimatedFinishDate)
        {
            this.estimatedFinishDate = estimatedFinishDate;
        }

        public void SetDriver (Driver driver)
        {
            this.driver = driver;
        }

        public void SetClerk (Clerk clerk)
        {
            this.clerk = clerk;
        }

        public OrderStatus GetOrderStatus() 
        { 
            return this.orderStatus;
        }

        public Driver GetDriver()
        {
            return this.driver;
        }

        public void SetOrderStatus( OrderStatus orderStatus) 
        {
            this.orderStatus = orderStatus;
        }

        public string GetAssignedClerkId()
        {
            if (this.clerk != null)
                return this.clerk.GetId();
            else return "";
        }

        public string GetAssignedDriverId()
        {
            if (this.driver != null)
                return this.driver.GetId();
            else return "";
        }

        public Driver GetDriver() 
        {
            return this.driver;
        }

        public void SetOrderStatus(OrderStatus orderStatus) 
        {
            this.orderStatus = new OrderStatus();
        }



    }

}
