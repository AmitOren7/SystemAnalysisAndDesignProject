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
    public partial class TodayTasks : UserControl
    {
        private Order Taskorder;
        private Clerk clerk;
        private OrderStatus currentStatus;


        public TodayTasks(Order order, Clerk clerk)
        {
            InitializeComponent();
            this.clerk = clerk;
            this.Taskorder = order;
            orderStatusCombo.DataSource = Enum.GetValues(typeof(OrderStatus));

            if (Taskorder != null)
            {
                orderlbl.Text = $"Order : {Taskorder.GetId()}";
                customer.Text = $"Customer : {Taskorder.GetCustomerName()}";
                customerPhone.Text = $"Phone : {Taskorder.GetCustomertPhoneNumber()}";
                from.Text = $"From : {Taskorder.GetDeparture()}";
                to.Text = $"To : {Taskorder.GetDestination()}";
                vehicle.Text = $"Vehicle : {Taskorder.GetVehicleType().ToString()}";
                driver.Text = $"Driver : {Taskorder.GetDriver().GetName()}";


                // Handle potential null Driver or missing Driver properties
                if (Taskorder.GetDriver() != null)
                {
                    driver.Text = $"Driver : {Taskorder.GetDriver().GetName()}";
                }
                else
                {
                    driver.Text = "Driver Not Assigned";
                }


                //status.Text = Taskorder.GetOrderStatus().ToString();
            }
            else
            {
                // Handle the case where no order is provided
                orderlbl.Text = "No Order Assigned";
                customer.Text = "";
                customerPhone.Text = "";
                from.Text = "";
                to.Text = "";
                driver.Text = "";
                vehicle.Text = "";
            }
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentStatus = (OrderStatus)orderStatusCombo.SelectedItem;
            //this.clerk.UpdateOrderStatus(currentStatus, this.Taskorder);
        }

        private void TodayTasks_Load(object sender, EventArgs e)
        {
            orderStatusCombo.DataSource = Enum.GetValues(typeof(OrderStatus));
            this.currentStatus = this.Taskorder.GetOrderStatus();
            orderStatusCombo.SelectedItem = currentStatus;
        }

        private void save_Click(object sender, EventArgs e)
        {
            this.clerk.UpdateOrderStatus(this.currentStatus, this.Taskorder);
            MessageBox.Show("Order Status Changed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
