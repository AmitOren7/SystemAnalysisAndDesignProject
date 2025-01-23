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
    public partial class OrderDetailsForm : Form
    {
        private Order order;
        public OrderDetailsForm(Order order)
        {
            InitializeComponent();
            this.order = order;
        }

        private void OrderDetailsForm_Load(object sender, EventArgs e)
        {
            labelOrderId.Text = order.GetId();
            labelCustomer.Text = order.GetCustomerName();
            labelPhone.Text = order.GetCustomertPhoneNumber();
            labelStartDate.Text = order.GetStartDate().ToShortDateString();
            labelFinishDate.Text = order.GetEstimatedFinishDate().ToShortDateString();
            labelStatus.Text = order.GetOrderStatus().ToString();
            labelAddress.Text = order.GetDestination();
        }

       
    }
}
