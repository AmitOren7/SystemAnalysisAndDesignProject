﻿using System;
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
    public partial class DriverIdCopyForm : Form
    {
        private Driver driver;
        public DriverIdCopyForm(Driver driver)
        {
            InitializeComponent();
            this.driver = driver;
        }

        private void DriverIdCopyForm_Load(object sender, EventArgs e)
        {
            string personName = driver.GetName();
            label1.Text = $"{personName} ID Copy:";
            pictureBox1.Image = Image.FromFile("C:\\Users\\oren7\\Downloads\\SystemAnalysisAndDesignProject\\IdCopy.jpg");
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            DriverAccountForm driverAccountForm = new DriverAccountForm(driver);
            driverAccountForm.ShowDialog();
        }
    }
}