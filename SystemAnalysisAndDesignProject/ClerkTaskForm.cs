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
    public partial class ClerkTaskForm : Form
    {
        private Clerk clerk;
        private ClerkMainForm clerkMainForm;
        List<Order> OrderList = Program.OrderList.Where(order => order.GetOrderStatus() != OrderStatus.pendingForAssignment &&
                    order.GetOrderStatus() != OrderStatus.orderClosed).ToList();
        List<TodayTasks> taskCards = new List<TodayTasks>();
        public ClerkTaskForm(Clerk clerk, ClerkMainForm clerkMainForm)
        {
            InitializeComponent();
            this.clerk = clerk;
            this.clerkMainForm = clerkMainForm;
            PopulateTodayTasks();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            this.clerkMainForm.Show();
        }

        private void PopulateTodayTasks()
        {
            DateTime today = DateTime.Today;


            List<Order> todayOrders = OrderList.FindAll(order =>
                order.GetClerk() != null &&
                order.GetClerk().GetId() == this.clerk.GetId() &&
                order.GetStartDate() <= today &&
                order.GetEstimatedFinishDate() >= today
            );

            TodayTasks taskCard;

            foreach (Order order in todayOrders)
            {

                string taskDetails = $"Order ID: {order.GetId()}\n" +
                                     $"Customer: {order.GetCustomerName()}\n" +
                                     $"Customer Phone: {order.GetCustomertPhoneNumber()}\n" +
                                     $"From: {order.GetDeparture()}\n" +
                                     $"To: {order.GetDestination()}\n" +
                                     $"Driver: {order.GetDriver()?.GetFirstName() + " " + order.GetDriver()?.GetLastName()}\n" +
                                     $"Vehicle: {order.GetDriver()?.GetVehicle()?.GetID()} \n";


                taskCard = new TodayTasks(taskDetails);

 
                flowLayoutPanel1.Controls.Add(taskCard);

   
                taskCards.Add(taskCard);
            }
        }
    }


   
}
