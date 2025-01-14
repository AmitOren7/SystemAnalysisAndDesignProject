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
    public partial class MainForm : Form
    {
        private TextBox txt_username;
        private TextBox txt_password;
        private Label lblError;
        private Button btnLogin;

        public MainForm()
        {
            InitializeComponent();

            lblError = new Label
            {
                Name = "lblError",
                Text = "",
                ForeColor = Color.Red,
                AutoSize = true,
                Location = new Point(20, 200)
            };
            this.Controls.Add(lblError);


            txt_username = new TextBox
            {
                Name = "txtUsername",
                Location = new Point(20, 50),
                Size = new Size(200, 30)
            };
            this.Controls.Add(txt_username);


            txt_password = new TextBox
            {
                Name = "txtPassword",
                Location = new Point(20, 100),
                Size = new Size(200, 30),
                PasswordChar = '*'
            };
            this.Controls.Add(txt_password);

            btnLogin = new Button
            {
                Name = "btnLogin",
                Text = "Login",
                Location = new Point(20, 150),
                Size = new Size(100, 30)
            };
            btnLogin.Click += LoginButton_Click;
            this.Controls.Add(btnLogin);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            //    // Search for the user in EmployeeList
            Employee employee = Program.EmployeeList.FirstOrDefault(emp => emp.GetUserName() == username);
            if (employee != null & employee.GetPassword() == password)
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
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
    
}
