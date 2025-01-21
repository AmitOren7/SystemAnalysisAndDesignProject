using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAnalysisAndDesignProject
{
    public partial class Calendar : Form
    {
        private Employee employee;
        private int currentYear;
        private int currentMonth;
        public Calendar(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            currentYear = DateTime.Now.Year;
            currentMonth = DateTime.Now.Month;
        }


        private void DisplayMonth(int year, int month)
        {
            CultureInfo enUS = new CultureInfo("en-US"); 

            string monthName = enUS.DateTimeFormat.GetMonthName(month);
            DateTime date = new DateTime(year, month, 1);

            string monthYear = date.ToString("MMMM yyyy", enUS); 

            labelMonthName.Text = monthYear.ToUpper();
            panel1.Controls.Clear();

            DateTime firstDayOfMonth = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int dayOfWeek = (int)firstDayOfMonth.DayOfWeek; // 0 = Sunday, 6 = Saturday

            int dayCounter = 1;
            int xOffset = 10; // Starting X position for each day
            int yOffset = 70; // Starting Y position for each day

            for (int row = 0; row < 6; row++)  // Loop through 6 rows
            {
                for (int col = 0; col < 7; col++)  // Loop through 7 columns
                {
                    if (dayCounter > daysInMonth) break;

                    // Only display days if within the range of the month
                    if (row == 0 && col < dayOfWeek)
                    {
                        continue; // Skip spaces before the first day
                    }

                    UserControlDay dayControl = new UserControlDay();
                    dayControl.DayNumber = dayCounter;
                    List<string> eventsForDay = GetEventsForDay(year, month, dayCounter);
                    dayControl.Events = eventsForDay;

                    // Position each day on the panel
                    dayControl.Location = new Point(xOffset + col * 110, yOffset + row * 65); // Adjust spacing as needed

                    panel1.Controls.Add(dayControl);
                    dayCounter++;
                }
            }
        }

        private List<string> GetEventsForDay(int year, int month, int day)
        {
            List<string> events = new List<string>();
            DateTime currentDay = new DateTime(year, month, day); // Create a DateTime object for the current day

            foreach (Order order in Program.OrderList)
            {
                // Check if the current day is within the order's date range
                if (currentDay.Date >= order.GetStartDate().Date && currentDay.Date <= order.GetEstimatedFinishDate().Date)
                {
                    // Orders are displayed differently based on user role:
                    // - Employees see only the orders assigned to them.
                    // - Managers see all orders for the selected date.
                    if (this.employee is Driver && order.GetAssignedDriverId().Equals(employee.GetId()))
                    {
                        events.Add(order.GetId()); // Add the order description to the events list
                    }
                    else if (this.employee is Clerk && order.GetAssignedClerkId().Equals(employee.GetId()))
                    {
                        events.Add(order.GetId());
                    }
                    else if (!(this.employee is Clerk) && !(this.employee is Driver))
                    {
                        events.Add(order.GetId());
                    }                                                       
                }
            }
            return events;
        }

        private void buttonNextMonth_Click(object sender, EventArgs e)
        {
            currentMonth++;
            if (currentMonth > 12)
            {
                currentMonth = 1;
                currentYear++;
            }
            DisplayMonth(currentYear, currentMonth);
        }

        private void buttonPreviousMonth_Click(object sender, EventArgs e)
        {
            currentMonth--;
            if (currentMonth < 1)
            {
                currentMonth = 12;
                currentYear--;
            }
            DisplayMonth(currentYear, currentMonth);
        }
    

        private void Calendar_Load(object sender, EventArgs e)
        {
            DisplayMonth(currentYear, currentMonth);
        }

        private void calendarTable_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
