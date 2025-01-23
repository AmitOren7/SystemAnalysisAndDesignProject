using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAnalysisAndDesignProject
{
    public partial class HomePage : Form
    {
        private Label lblError;
        private Button btnLogin;
        public HomePage()
        {
            InitializeComponent();
            lblError = new Label
            {
                Name = "lblError",
                Text = "",
                ForeColor = Color.Red,
                AutoSize = true,
                Font = new Font("Calibri", 14),
            };
            this.Controls.Add(lblError);
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            //    // Search for the user in EmployeeList
            Employee employee = Program.EmployeeList.FirstOrDefault(emp => emp.GetUserName() == username);
            if (employee != null && employee.GetPassword() == password)
            {
                if (employee is Clerk)
                {
                    Clerk clerk = employee as Clerk;
                    ClerkMainForm clerkMainForm = new ClerkMainForm(clerk);
                    clerkMainForm.Show();
                }
                if (employee is Driver)
                {
                    Driver driver = employee as Driver;
                    DriverMainForm driverMainForm = new DriverMainForm(driver);
                    driverMainForm.Show();
                }
                if (employee is OperationalManager)
                {
                    OperationalManager operationalManager = employee as OperationalManager;
                    OperationalManagerMainForm operationalManagerMainForm = new OperationalManagerMainForm(operationalManager);
                    operationalManagerMainForm.Show();
                }
                if (employee is OfficeManager)
                {
                    OfficeManager officeManager = employee as OfficeManager;
                    OfficeManagerMainForm officeManagerMainForm = new OfficeManagerMainForm(officeManager);
                    officeManagerMainForm.Show();
                }
                this.Hide(); // close the login form

            }
            lblError.Text = "Invalid username or password!";
            lblError.ForeColor = System.Drawing.Color.Red;
            int newY = (this.Height - lblError.Height) / 2 + 70; 
            lblError.Location = new Point((this.Width - lblError.Width) / 2, newY);
            labelError.Text = "Invalid username or password!";

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }




    }
}
