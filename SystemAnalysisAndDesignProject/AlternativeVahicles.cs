using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAnalysisAndDesignProject
{
    public partial class AlternativeVahicles : Form
    {
        private List<Driver> driversList = OrdersManeger.drivers;
        private List<Vehicle> alternativeVehicles = OrdersManeger.alternativeVehicles();
        private Driver selectedDriver;
        private Order selectedOrder;
        private Vehicle selectedVehicle;
        private int originalIndex;
        private List<Clerk> clerks = OrdersManeger.Clerks;
        private Clerk selectedClerk;
        private OperationalManager operationalManager;
        
        public AlternativeVahicles(Order order , OperationalManager operationalManager)
        {
            InitializeComponent();
            this.selectedOrder = order;
            CustomizeDriversGrid();
            populateDriversGrid_Diff();
            CustomizeVehiclesGrid();
            vehiclesGrid.Visible = false;
            vehiclesHeadline.Visible= false;
            populateClerksComboBox();
            this.operationalManager = operationalManager;
            



        }

        private void CustomizeDriversGrid()
        {
            driversGrid.Columns.Clear();


            driversGrid.Columns.Add("FirstName", "First Name");
            driversGrid.Columns.Add("LastName", "Last Name");
            driversGrid.Columns.Add("ID", "ID Number");
            driversGrid.Columns.Add("phoneNumber", "Phone Number");
            driversGrid.Columns.Add("email", "Email");

            //adding an hidden column that saves the original index fo the driver from the drivers list
            var indexColumn = new DataGridViewTextBoxColumn
            {
                Name = "Index",
                Visible = false 
            };
            driversGrid.Columns.Add(indexColumn);

        }

        private void CustomizeVehiclesGrid()
        {
            vehiclesGrid.Columns.Clear();
            vehiclesGrid.Columns.Add("VehicleID", "ID Number");
            vehiclesGrid.Columns.Add("CergoType", "Cargo Type");
            vehiclesGrid.Columns.Add("vehicleType", "Type");
            vehiclesGrid.Columns.Add("maxCapacity", "Max Capacity");

            foreach (Vehicle vehicle in alternativeVehicles)
            {

                vehiclesGrid.Rows.Add(vehicle.GetID(),
                                            vehicle.GetCargoType().ToString(),
                                            vehicle.GetVehicleType().ToString(),
                                            vehicle.GetMaxCapacity());

            }


        }

        private void populateDriversGrid_Diff()
        {
            driversGrid.Rows.Clear();
            for (int i = 0; i < driversList.Count; i++)
            {
                Driver driver = driversList[i];
                driversGrid.Rows.Add(driver.GetFirstName(),
                                     driver.GetLastName(),
                                     driver.GetId(),
                                     driver.GetPhoneNumber(),
                                     driver.GetEmail(),
                                     i); // setting the index to the hidden column
            }

        }

        private void driversGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                originalIndex = Convert.ToInt32(driversGrid.Rows[e.RowIndex].Cells["Index"].Value);
                selectedDriver = driversList[originalIndex];


                if (selectedDriver.GetVehicle().GetVehicleCondition() != VehicleConditionStatus.proper)
                {
                    MessageBox.Show($"{selectedDriver.GetName()}'s vehicle is not in proper condition for assignment. please choose alternative vehicle");
                    vehiclesHeadline.Visible = true;
                    vehiclesGrid.Visible = true;
                }
            } 
        }

        private void populateDriverGridByName ()
        {
            driversGrid.Rows.Clear();
            for (int i = 0; i < driversList.Count; i++)
            {
                Driver driver = driversList[i];
                if (driver.GetName() == NameSearch.Text)
                {
                    driversGrid.Rows.Add(driver.GetFirstName(),
                                         driver.GetLastName(),
                                         driver.GetId(),
                                         driver.GetPhoneNumber(),
                                         driver.GetEmail(),
                                         i); // Add the index to the hidden column
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            populateDriverGridByName();
        }

        private void refreshDriversButton_Click(object sender, EventArgs e)
        {
            populateDriversGrid_Diff();

        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            Order check = OrdersManeger.overlapCheck (selectedOrder, selectedDriver);    
            if (selectedDriver != null && selectedClerk != null)
            {
                if (check != null)
                {
                    DialogResult result = MessageBox.Show($"Are you sure you want to ovveride order {check.GetId()} assignment?",
                                     "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        OperationalManager.assign_driver(selectedDriver, selectedOrder);
                        OperationalManager.assign_clerk(selectedClerk , selectedOrder);
                        OperationalManager.ChangeDriverStatus(selectedDriver);
                        OperationalManager.ChangeClerkStatus(selectedClerk);
                        OperationalManager.UnAssign (check);

                    }
                    else
                    {

                    }
                }
                OperationalManager.assign_driver(selectedDriver, selectedOrder);
                OperationalManager.assign_clerk(selectedClerk, selectedOrder);
                OperationalManager.ChangeDriverStatus(selectedDriver);
                OperationalManager.ChangeClerkStatus(selectedClerk);
            }
            if (selectedVehicle != null)
            {
                OperationalManager.SetDriverAlternativeVehicle (selectedDriver, selectedVehicle);
            }


        }

        private void vehiclesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                this.selectedVehicle = alternativeVehicles[e.RowIndex];
            }

        }

        private void populateClerksComboBox()
        {
            foreach (Clerk clerk in clerks)
            {
                clerksComboBox.Items.Add(clerk);
            }
        }

        private void clerkscombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected Clerk object
            selectedClerk = (Clerk)clerksComboBox.SelectedItem;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            UnassignedOrdersForm unassignedOrdersForm = new UnassignedOrdersForm(this.operationalManager);
            unassignedOrdersForm.Show();


        }

        private void AlternativeVahicles_Load(object sender, EventArgs e)
        {

        }
    }
}
