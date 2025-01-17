using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysisAndDesignProject
{
    public class OrdersManeger
    {
        public static List<Order> orders = Program.OrderList;
        public static List<Driver> drivers = Program.DriverList;
        public static List<Order> GetPendingOrders()
        {
            List<Order> pendingOrders = new List<Order>();
            foreach (var Order in orders)
            {
                if (Order.GetOrderStatus() == OrderStatus.pendingForAssignment)
                {
                    pendingOrders.Add(Order);
                }

            }
            return pendingOrders;
        }

        public static List<Order> PrioritizeOrders()
        {
            List<Order> pendingOrders = GetPendingOrders();
            Dictionary<Order, double> OrderGrade = new Dictionary<Order, double>();
            foreach (var order in pendingOrders)
            {
                TimeSpan orderDuration = order.GetEstimatedFinishDate() - order.GetStartDate();
                double grade = order.GetProfit() / orderDuration.Days;
                OrderGrade.Add(order, grade);
            }
            List<Order> sortedOrders = OrderGrade
           .OrderByDescending(pair => pair.Value)
           .Select(pair => pair.Key)
           .ToList();
            return sortedOrders;
        }

        public static Dictionary<Order, List<Driver>> GetEligibleDrivers(List<Order> sortedOrders)
        {
            Dictionary<Order, List<Driver>> orderDrivers = new Dictionary<Order, List<Driver>>();
            foreach (var order in sortedOrders)
            {

                var suitableDrivers = Program.DriverList.Where(driver =>
                    driver.GetVehicle().GetVehicleType() == order.GetVehicleType() &&
                    driver.GetVehicle().GetMaxCapacity() >= order.GetTotalWeight() &&
                    driver.GetVehicle().GetCargoType() == order.GetCargoType()
                ).ToList();
                orderDrivers[order] = suitableDrivers;
            }
            return orderDrivers;


        }
        public static Dictionary<string, List<Driver>> GetEligibleDriver(List<Order> sortedOrders)
        {
            Dictionary<string, List<Driver>> orderDrivers = new Dictionary<string, List<Driver>>();

            foreach (var order in sortedOrders)
            {
                Console.WriteLine($"Checking drivers for Order ID: {order.GetId()}, VehicleType: {order.GetVehicleType()}, TotalWeight: {order.GetTotalWeight()}, CargoType: {order.GetCargoType()}");

                var suitableDrivers = Program.DriverList.Where(driver =>
                {
                    Console.WriteLine($"    Checking Driver: {driver.GetName()}, VehicleType: {driver.GetVehicle().GetVehicleType()}, MaxCapacity: {driver.GetVehicle().GetMaxCapacity()}, CargoType: {driver.GetVehicle().GetCargoType()}");
                    return driver.GetVehicle().GetVehicleType() == order.GetVehicleType() &&
                           driver.GetVehicle().GetMaxCapacity() >= order.GetTotalWeight() &&
                           driver.GetVehicle().GetCargoType() == order.GetCargoType();
                }).ToList();

                orderDrivers[order.GetId()] = suitableDrivers;

                if (suitableDrivers.Any())
                {
                    foreach (var driver in suitableDrivers)
                    {
                        Console.WriteLine($"    Eligible Driver: {driver.GetName()}");
                    }
                }
                else
                {
                    Console.WriteLine("    No eligible drivers found.");
                }
            }

            return orderDrivers;
        }





    }


}
