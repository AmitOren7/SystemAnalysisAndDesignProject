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
    public partial class DriverProfile : Form
    {
        public DriverProfile(Driver driver)
        {
            InitializeComponent();

            firstNameTxt.Text = driver.GetFirstName();
            lastNameTxt.Text = driver.GetLastName();
            IDTxt.Text = driver.GetId();
            phoneNumberTxt.Text = driver.GetPhoneNumber();
            emailTxt.Text = driver.GetEmail();
            addressTxt.Text = driver.GetAddress();
            licenseIDTxt.Text = driver.GetlicenseId();
        }
    }
}
