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
    public partial class vehicleDetails : Form
    {
        private OperationalManagerMainForm OperationalManagerForm;
        private List<Vehicle> vehicles = Program.VehicleList;
        public vehicleDetails(OperationalManagerMainForm operationalManagerForm)
        {
            InitializeComponent();
            OperationalManagerForm = operationalManagerForm;
            label1.Visible = false;
            label8.Visible = false;
            label7.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }

        private void vehicleDetails_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string inputVehicleId = textBoxName.Text.Trim();
            if (string.IsNullOrEmpty(inputVehicleId))
            {
                MessageBox.Show("Please enter a vehicle ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Vehicle foundVehicle = vehicles.FirstOrDefault(v => v.GetID().Equals(inputVehicleId, StringComparison.OrdinalIgnoreCase));
            if (foundVehicle != null)
            {
                label1.Visible = true;
                label8.Visible = true;
                label7.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;

                label1.Text = foundVehicle.GetID();
                label8.Text = foundVehicle.GetVehicleType().ToString();
                label7.Text = foundVehicle.GetCargoType().ToString();
                label4.Text = foundVehicle.GetMaxCapacity().ToString();
                label5.Text = foundVehicle.GetTestDate().ToString();
                label6.Text = foundVehicle.GetVehicleCondition().ToString();

            }
            else
            {
                MessageBox.Show($"Vehicle with ID '{inputVehicleId}' was not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            this.OperationalManagerForm.Show();
        }
    }
}
