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
        private List<Order> sortedOrders = OrdersManeger.PrioritizeOrders();
        private Order selectedOrder;
        private List<Driver> currentDriversList;
        private OperationalManager operationalManager;
        private List<Clerk> clerks = OrdersManeger.Clerks;
        private Driver selectedDriver;
        private Clerk selectedClerk;

        public UnassignedOrdersForm(OperationalManager operationalManager)
        {
            InitializeComponent();
            extendDriverButton.Visible = false;
            this.operationalManager = operationalManager;
            CustomizeDataGridView();
            PopulateOrdersGridDiff();
            SortedOrdersDiff_customise_looking();
            populateClerksComboBox();
            SortedOrdersDiff.AllowDrop = true;
            SortedOrdersDiff.AllowUserToAddRows = false;
            SortedOrdersDiff.MouseDown += PrioritizedOrderDiff_MouseDown;
            SortedOrdersDiff.MouseMove += PrioritizedOrderDiff_MouseMove;
            SortedOrdersDiff.DragOver += PrioritizedOrderDiff_DragOver;
            SortedOrdersDiff.DragDrop += PrioritizedOrderDiff_DragDrop;
            SortedOrdersDiff.CellClick += SortedOrdersDiff_CellClick;
            DG_EligibleDrivers.CellClick += DG_EligibleDrivers_CellClick;

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
            SortedOrdersDiff.Rows.Clear();
            sortedOrders = OrdersManeger.PrioritizeOrders();

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
        private void SortedOrdersDiff_customise_looking()
        {
            // Set font for the column headers
            SortedOrdersDiff.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);

            // Set font for the content rows
            SortedOrdersDiff.DefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Regular);

        }
        
        private void SortedOrdersDiff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the click is on a valid row
            {
                // Retrieve the corresponding Order object
                 selectedOrder = sortedOrders[e.RowIndex];
                Dictionary<Order, List<Driver>> eligibleDrivers = OrdersManeger.GetEligibleDrivers(sortedOrders, selectedOrder);
                extendDriverButton.Visible = true;
                currentDriversList = eligibleDrivers[selectedOrder];
                // Fetch the list of eligible drivers for the selected order from the dictionary
                if (currentDriversList.Count > 0)
                {
                    ShowEligibleDrivers(currentDriversList);
                }
                else
                {
                    DG_EligibleDrivers.Rows.Clear();
                    MessageBox.Show("No drivers found for the selected order, please look for other options through extend drivers options","extend options", MessageBoxButtons.OK);
                }
            }
        }
        private void ShowEligibleDrivers(List<Driver> drivers)
        {
            DG_EligibleDrivers.Columns.Clear();
            DG_EligibleDrivers_customise_looking();

            DG_EligibleDrivers.Columns.Add("FirstName", "First Name");
            DG_EligibleDrivers.Columns.Add("LastName", "Last Name");
            DG_EligibleDrivers.Columns.Add("ID", "ID Number");
            DG_EligibleDrivers.Columns.Add("phoneNumber", "Phone Number");
            DG_EligibleDrivers.Columns.Add("email", "Email");
            DG_EligibleDrivers.Columns.Add("vehicleType", "Vehicle Type");
            DG_EligibleDrivers.Columns.Add("MaxCapacity", "Max Capacity");

            foreach (Driver driver in drivers)
            {

                DG_EligibleDrivers.Rows.Add(driver.GetFirstName(),
                                            driver.GetLastName(),
                                            driver.GetId(),
                                            driver.GetPhoneNumber(),
                                            driver.GetEmail(),
                                            driver.GetVehicle().GetVehicleType(),
                                            driver.GetVehicle().GetMaxCapacity());
            }
        }

        private void DG_EligibleDrivers_customise_looking ()
        {
            DG_EligibleDrivers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);

            // Set font for the content rows
            DG_EligibleDrivers.DefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Regular);
        }

        private void DG_EligibleDrivers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the click is on a valid row
            {
                // Retrieve the corresponding driver object
                 selectedDriver =currentDriversList[e.RowIndex];   
            }
        }

        private void refreshOrdersButton_Click(object sender, EventArgs e)
        {
            PopulateOrdersGridDiff();
        }

        private void populateClerksComboBox ()
        {
           foreach ( Clerk clerk  in clerks )
            {
                clerkscombobox.Items.Add(clerk);
            }
        }

        private void clerkscombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected Clerk object
             selectedClerk = (Clerk)clerkscombobox.SelectedItem;   
        }

        private void extendDriverButton_Click(object sender, EventArgs e)
        {
            AlternativeVahicles av = new AlternativeVahicles(selectedOrder , operationalManager);
            av.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedClerk != null && selectedDriver!= null)
            {

                OperationalManager.assign_clerk(selectedClerk, selectedOrder);
                OperationalManager.assign_driver(selectedDriver, selectedOrder);
                OperationalManager.ChengeDriverStatus(selectedDriver);
                OperationalManager.ChangeClerkStatus(selectedClerk);    
                MessageBox.Show($"{selectedClerk.GetFirstName()} {selectedClerk.GetLastName()} as clerk and {selectedDriver.GetFirstName()} {selectedDriver.GetLastName()} as driver assigned successfully to order number {selectedOrder.GetId()}");


            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            OperationalManagerMainForm operationalManagerAccountForm = new OperationalManagerMainForm(operationalManager);
            operationalManagerAccountForm.ShowDialog();
        }
    }
}
