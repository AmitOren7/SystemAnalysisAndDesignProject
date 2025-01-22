﻿using System;
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
        public static List<Vehicle> vehicles = Program.VehicleList; 
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

        public static Dictionary<Order, List<Driver>> GetEligibleDrivers(List<Order> sortedOrders, Order currentOrder)
        {
            Dictionary<Order, List<Driver>> orderDrivers = new Dictionary<Order, List<Driver>>();
            foreach (var order in sortedOrders)
            {

                var suitableDrivers = drivers.Where(driver =>
                    driver.GetPerformanceStatus() != PerformanceStatus.awaitingFirstEvaluation &&
                    driver.GetVehicle().GetVehicleType() == order.GetVehicleType() &&
                    driver.GetVehicle().GetMaxCapacity() >= order.GetTotalWeight() &&
                    driver.GetVehicle().GetCargoType() == order.GetCargoType() &&
                    driver.GetVehicle().GetVehicleCondition() == VehicleConditionStatus.proper &&
                   !orders.Any(o =>
                               o.GetDriver() == driver && // Same driver is assigned
                               o.GetStartDate() <= currentOrder.GetEstimatedFinishDate() && // Overlap condition
                               o.GetEstimatedFinishDate() >= currentOrder.GetStartDate()    // Overlap condition
                               )
                ).ToList();
                orderDrivers[order] = suitableDrivers;
            }
            return orderDrivers;


        }
        public static List<Vehicle> alternativeVehicles ()
        {
            List<Vehicle> alternativeVehicles = new List<Vehicle>();
            foreach (Vehicle vehicle in vehicles )
            {
                if (vehicle.GetVehicleCondition() == VehicleConditionStatus.alternative)
                {
                    alternativeVehicles.Add(vehicle);
                }
            }
            return alternativeVehicles;
        }


        public static Order overlapCheck(Order clickedOrder, Driver clickedDriver)
        {
            foreach (Order order in orders)
            {
                if (order.GetDriver() == clickedDriver && 
                    order.GetStartDate() <= clickedOrder.GetEstimatedFinishDate() &&
                    order.GetEstimatedFinishDate() >= clickedOrder.GetStartDate()
                    )
                {
                    return order;

                }
            }
            return null;
        }

    }


}
