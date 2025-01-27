﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAnalysisAndDesignProject
{
    public partial class OperationalManagerMainForm : Form
    {
        private OperationalManager operationalManager;

        public OperationalManagerMainForm(OperationalManager operationalManager)
        {
            InitializeComponent();
            this.operationalManager = operationalManager;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OperationalManagerAccountForm operationalManagerAccountForm = new OperationalManagerAccountForm(operationalManager);
            operationalManagerAccountForm.Show();
            this.Hide();
        }


        private void OperationalManagerMainForm_Load(object sender, EventArgs e)
        {
            String personName = operationalManager.GetName();
            Namelbl.Text = $"Hello {personName}!";
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage hm = new HomePage();
            hm.Show();
        }

        private void AssignmentsBoard_Click(object sender, EventArgs e)
        {
            UnassignedOrdersForm UOF = new UnassignedOrdersForm(this.operationalManager);
            UOF.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage hm = new HomePage();
            hm.Show();
        }

        private void viewCalendar_Click(object sender, EventArgs e)
        {
            Calendar CalendarForm = new Calendar(operationalManager, this);
            CalendarForm.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            CreateVehicle createVehicleForm = new CreateVehicle( this);
            createVehicleForm.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            vehicleDetails vehicleDetailsForm = new vehicleDetails(this);
            vehicleDetailsForm.Show();
            this.Hide();
        }
    }
}
