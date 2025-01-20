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
    public partial class AlternativeVahicles : Form
    {
        private List<Driver> extendedDriversList = OrdersManeger.ExtentedDrivers();
        private List<Vehicle> alternativeVehicles = OrdersManeger.alternativeVehicles();
        public AlternativeVahicles(Order order)
        {
            InitializeComponent();
            CustomizeDriversGrid();
            CustomizeVehiclesGrid();

        }

        private void CustomizeDriversGrid()
        {
            driversGrid.Columns.Clear();


            driversGrid.Columns.Add("FirstName", "First Name");
            driversGrid.Columns.Add("LastName", "Last Name");
            driversGrid.Columns.Add("ID", "ID Number");
            driversGrid.Columns.Add("phoneNumber", "Phone Number");
            driversGrid.Columns.Add("email", "Email");

            foreach (Driver driver in extendedDriversList)
            {

                driversGrid.Rows.Add(driver.GetFirstName(),
                                            driver.GetLastName(),
                                            driver.GetId(),
                                            driver.GetPhoneNumber(),
                                            driver.GetEmail());
                                            
            }
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

        private void AlternativeVahicles_Load(object sender, EventArgs e)
        {

        }
    }
}
