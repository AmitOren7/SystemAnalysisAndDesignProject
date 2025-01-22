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
        List<Order> OrderList = Program.OrderList;
        List<TodayTasks> taskCards = new List<TodayTasks>();
        public ClerkTaskForm(Clerk clerk, ClerkMainForm clerkMainForm)
        {
            InitializeComponent();
            this.clerk = clerk;
            this.clerkMainForm = clerkMainForm;
            //PopulateTodayTasks();
            //this.Load += ClerkTaskForm_Load;
        }

        //public void ClerkTaskForm_Load(object sender, EventArgs e) 
        //{
        //    PopulateTodayTasks();
        //}

        private void ClerkTaskForm_Shown(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear(); 
            taskCards.Clear(); 
            PopulateTodayTasks(); 
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            ClerkMainForm clerkAccountForm = new ClerkMainForm(this.clerk);
            clerkAccountForm.ShowDialog();
        }

        private void PopulateTodayTasks()
        {
            DateTime today = DateTime.Today;
            List <Order> filteredOrderList = new List<Order>();
            foreach (Order order in OrderList)
            {
                if (order.GetClerk() != null &&
                    order.GetOrderStatus() != OrderStatus.pendingForAssignment &&
                    order.GetClerk().GetId() == this.clerk.GetId() &&
                    order.GetStartDate().Date <= today &&
                    order.GetEstimatedFinishDate().Date >= today)
                {
                    filteredOrderList.Add(order);
                }
            }
            TodayTasks taskCard;
            foreach (Order order1 in filteredOrderList)
            {
                taskCard = new TodayTasks(order1, this.clerk);
                flowLayoutPanel1.Controls.Add(taskCard);
                taskCards.Add(taskCard);
            }
        }

    }

}
