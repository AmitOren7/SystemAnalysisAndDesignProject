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

        private int dayNumber;
        private List<string> events;

        public int DayNumber
        {
            get { return dayNumber; }
            set { dayNumber = value; dayLabel.Text = value.ToString(); }
        }

        public List<string> Events
        {
            get { return events; }
            set { events = value; UpdateEventsList(); }
        }

        private Label dayLabel;
        private ListBox eventListBox;

        private void UpdateEventsList()
        {
            eventListBox.Items.Clear();
            if (events != null && events.Count > 0)
            {
                eventListBox.Visible = true; // Show the list box if there are events
                foreach (string eventText in events)
                {
                    eventListBox.Items.Add(eventText);
                }
            }
            else
            {
                eventListBox.Visible = false; // Hide the list box if there are no events
            }
        }

        private void DayControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (events != null && events.Count > 0)
            {
                eventListBox.Visible = !eventListBox.Visible; // Toggle the visibility of the list box on click
            }
        }

        private void eventListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (eventListBox.SelectedIndex != -1)
            {
                // Get the selected item
                string selectedItem = eventListBox.SelectedItem.ToString();

                // Find the order object based on the selected item (e.g., order ID)
                Order selectedOrder = Program.OrderList.FirstOrDefault(o => o.GetId() == selectedItem);

                if (selectedOrder != null)
                {
                    // Create an instance of the order details form
                    OrderDetailsForm orderDetailsForm = new OrderDetailsForm(selectedOrder); // Pass the order object to the constructor

                    // Show the order details form
                    orderDetailsForm.ShowDialog(); // Use ShowDialog to make it a modal form (prevents interaction with the main form)
                                                   // or orderDetailsForm.Show() to make it a non-modal form
                }
                else
                {
                    MessageBox.Show("Order not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
