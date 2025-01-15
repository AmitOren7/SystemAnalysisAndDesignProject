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
        private int rowIndexFromMouseDown;
        private DataGridViewRow draggedRow;
        public UnassignedOrdersForm()
        {
            InitializeComponent();
            CustomizeDataGridView();
            PopulateOrdersGridDiff();
            SortedOrdersDiff.AllowDrop = true;
            SortedOrdersDiff.AllowUserToAddRows = false;
            SortedOrdersDiff.MouseDown += PrioritizedOrderDiff_MouseDown;
            SortedOrdersDiff.MouseMove += PrioritizedOrderDiff_MouseMove;
            SortedOrdersDiff.DragOver += PrioritizedOrderDiff_DragOver;
            SortedOrdersDiff.DragDrop += PrioritizedOrderDiff_DragDrop;

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
        private void PrioritizedOrderDiff_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the index of the row under the mouse pointer
            rowIndexFromMouseDown = SortedOrdersDiff.HitTest(e.X, e.Y).RowIndex;

            if (rowIndexFromMouseDown >= 0)
            {
                draggedRow = SortedOrdersDiff.Rows[rowIndexFromMouseDown];
            }
        }

        private void PrioritizedOrderDiff_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left && draggedRow != null)
            {
                // Initiate the drag-and-drop operation
                SortedOrdersDiff.DoDragDrop(draggedRow, DragDropEffects.Move);
            }
        }

        private void PrioritizedOrderDiff_DragOver(object sender, DragEventArgs e)
        {
            // Allow the move operation
            e.Effect = DragDropEffects.Move;
        }

        private void PrioritizedOrderDiff_DragDrop(object sender, DragEventArgs e)
        {
            // Get the drop location
            Point clientPoint = SortedOrdersDiff.PointToClient(new Point(e.X, e.Y));
            int targetRowIndex = SortedOrdersDiff.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            if (draggedRow != null)
            {
                // If dropped below all rows, add to the last position
                if (targetRowIndex == -1)
                {
                    // Remove the row from the current position
                    SortedOrdersDiff.Rows.RemoveAt(rowIndexFromMouseDown);

                    // Add the row to the end
                    SortedOrdersDiff.Rows.Add(draggedRow);
                }
                else
                {
                    // Remove the row from the current position
                    SortedOrdersDiff.Rows.RemoveAt(rowIndexFromMouseDown);

                    // Insert the row at the new position
                    SortedOrdersDiff.Rows.Insert(targetRowIndex, draggedRow);
                }

                // Clear selection and select the moved row
                SortedOrdersDiff.ClearSelection();
                if (targetRowIndex == -1)
                {
                    SortedOrdersDiff.Rows[SortedOrdersDiff.Rows.Count - 1].Selected = true;
                }
                else
                {
                    SortedOrdersDiff.Rows[targetRowIndex].Selected = true;
                }
            }
        }

    }
}
