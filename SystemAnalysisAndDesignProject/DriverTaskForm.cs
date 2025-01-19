using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SystemAnalysisAndDesignProject
{
    public partial class DriverTaskForm : Form
    {
        private Driver driver;
        private Order order;
        private List<Order> orderList = Program.OrderList;
        public DriverTaskForm(Driver driver)
        {
            InitializeComponent();
            this.driver = driver;
            DateTime today = DateTime.Today;
            foreach (var order in orderList)
            {
                if (order != null && order.GetStartDate().Date == today && order.GetDriver() == this.driver)
                {
                    this.order = order;
                    break;
                }
            }
            if (this.order == null)
            {
                MessageBox.Show("No order found for the selected driver and date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            fillTaskStatus();
        }

        private void DriverTaskForm_Load(object sender, EventArgs e)
        {
            departure_.Text = $"{this.order.GetDeparture()}";
            destination_.Text = $"{this.order.GetDestination()}";
            start_time.Text = $"{this.order.GetStartDate()}";
            end_time.Text = $"{this.order.GetEstimatedFinishDate()}";
            cargo_type.Text = $"{this.order.GetCargoType()}";

            task_status2.Visible = false;
            task_status3.Visible = false;
            task_status4.Visible = false;
            task_status5.Visible = false;

        }

        private void fillTaskStatus()
        {
            var orderStatusValues = GetFilteredOrderStatusValues();
            task_status.DataSource = orderStatusValues;
        }

        private List<OrderStatus> GetFilteredOrderStatusValues()
        {
            var orderStatusValues = Enum.GetValues(typeof(OrderStatus)).Cast<OrderStatus>().ToList();
            List<OrderStatus> filteredStatusValues = new List<OrderStatus>();
            foreach (var status in orderStatusValues)
            {
                if (status != OrderStatus.pendingForAssignment || status != OrderStatus.assigned || status != OrderStatus.orderClosed)
                {
                    filteredStatusValues.Add(status);
                }
            }
            return filteredStatusValues;
        }


        private void task_status_SelectedIndexChanged(object sender, EventArgs e) {

            var selectedStatus = (OrderStatus)task_status.SelectedItem;
            this.driver.UpdateOrderStatus(selectedStatus, this.order);
            if (selectedStatus == OrderStatus.departure)
                {
                task_status2.Visible = true;
                task_status1.Visible = false;
                }
            if (selectedStatus == OrderStatus.arrivedToSite)
            { 
                task_status3.Visible = true;
                task_status2.Visible= false;
            }
            if (selectedStatus == OrderStatus.taskCompleted) 
            {
                task_status4.Visible = true;
                task_status3.Visible= false;
            }
            if (selectedStatus == OrderStatus.workCertificateSigned) 
            {
                task_status5.Visible = true;
               task_status4.Visible= false;
           }

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            DriverMainForm driverAccountForm = new DriverMainForm(driver);
            driverAccountForm.ShowDialog();
        }
    }
}
