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
        public static List<Order> GetPendingOrders(List<Order> currentOrders)
        {
            List<Order> pendingOrders = new List<Order>();
            foreach (var Order in currentOrders)
            {
                if (Order.GetOrderStatus() == OrderStatus.pendingForAssignment)
                {
                    pendingOrders.Add(Order);
                }

            }
            return pendingOrders;
        }

        public static List<Order> PrioritizeOrders(List<Order> pendingOrders)
        {
            List<Order> FilteredOrders = new List<Order>();
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

         
    }
}
