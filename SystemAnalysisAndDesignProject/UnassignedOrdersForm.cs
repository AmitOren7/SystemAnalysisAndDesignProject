using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAnalysisAndDesignProject
{
    public partial class UnassignedOrdersForm : Form
    {
        public UnassignedOrdersForm()
        {
            InitializeComponent();
            CustomizeDataGridView();
            PopulateOrdersGridDiff();

        }

        private void CustomizeDataGridView()
        {
            SortedOrdersDiff.Columns.Clear();


            SortedOrdersDiff.Columns.Add("OrderId", "Order ID");
            SortedOrdersDiff.Columns.Add("CustomerName", "Customer Name");
            SortedOrdersDiff.Columns.Add("startDate", "Start Date");
            SortedOrdersDiff.Columns.Add("cargoType", "Cargo Type");
            SortedOrdersDiff.Columns.Add("estimatedFinishDate", "Estimated Finish Date");
            SortedOrdersDiff.Columns.Add("profit", "Estimated Revenue");
            SortedOrdersDiff.Columns.Add("vehicleType", "Vehicle Type");
            SortedOrdersDiff.Columns.Add("totalWeight", "Total Weight");
        }


        private void PopulateOrdersGridDiff()
        {
            List<Order> sortedOrders = OrdersManeger.PrioritizeOrders();
            SortedOrdersDiff.Rows.Clear();

            foreach (var order in sortedOrders)
            {
                
                SortedOrdersDiff.Rows.Add(
                    order.GetId(),
                    order.GetCustomerName(),
                    order.GetStartDate(),
                    order.GetCargoType(),
                    order.GetEstimatedFinishDate(),
                    order.GetProfit(),
                    order.GetVehicleType(),
                    order.GetTotalWeight());
            }

        }
         
    }
}
