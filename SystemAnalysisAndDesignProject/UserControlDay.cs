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
    public partial class UserControlDay : UserControl
    {
        public UserControlDay()
        {
            InitializeComponent();
        }

        public void days(int day) 
        {
            date.Text = day.ToString();
        }

        public void displayTask() 
        {
            foreach (Order order in Program.OrderList) 
            {
                if (int.Parse(date.Text) == order.GetStartDate().Day && order.GetStartDate().Month == DateTime.Now.Month) 
                {
                    task.Text = "Task";
                }
            }
        }

        public void UserControlDay_Click()
        {
            foreach (Order order in Program.OrderList)
            {
                if (int.Parse(date.Text) == order.GetStartDate().Day && order.GetStartDate().Month == DateTime.Now.Month)
                {
                    //TaskDetails task = new TaskDetails(task);
                    //task.Show();
                }
            }
        }
    }
}
