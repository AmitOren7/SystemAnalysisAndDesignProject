using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SystemAnalysisAndDesignProject
{
    public partial class ManageEmployeeStatusForm : Form
    {
        private List<Evaluatable> allEmployees; // List to hold all evaluatable employees

        public ManageEmployeeStatusForm()
        {
            InitializeComponent();
            allEmployees = new List<Evaluatable>();
        }

        private void ManageEmployeeStatusForm_Load(object sender, EventArgs e)
        {
            // Populate status ComboBox
            comboBoxStatus.Items.AddRange(new object[] { PerformanceStatus.archived, PerformanceStatus.pendingForHearingResults });
            comboBoxStatus.SelectedIndex = 0; // Select the first item by default

            LoadEmployees();
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEmployees(); // Reload employees based on selected status
        }

        private void LoadEmployees()
        {
            comboBoxEmployee.Items.Clear();
            allEmployees.Clear();

            PerformanceStatus selectedStatus = (PerformanceStatus)comboBoxStatus.SelectedItem;

            if (selectedStatus == PerformanceStatus.archived)
            {
                // Load all clerks and drivers (no filtering needed)
                allEmployees.AddRange(Program.ClerkList);
                allEmployees.AddRange(Program.DriverList);
            }
            else if (selectedStatus == PerformanceStatus.pendingForHearingResults)
            {
                // Load only employees with UnderWarning status - FILTERING IS DONE HERE
                allEmployees.AddRange(Program.ClerkList.Where(emp => emp.GetPerformanceStatus() == PerformanceStatus.underWarning));
                allEmployees.AddRange(Program.DriverList.Where(emp => emp.GetPerformanceStatus() == PerformanceStatus.underWarning));
            }

            // Populate the employee combo box with employee names
            comboBoxEmployee.Items.AddRange(allEmployees.Select(emp => emp.GetName()).ToArray());

            if (comboBoxEmployee.Items.Count > 0)
            {
                comboBoxEmployee.SelectedIndex = 0;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployee.SelectedItem != null && comboBoxStatus.SelectedItem != null)
            {
                int selectedIndex = comboBoxEmployee.SelectedIndex;
                Evaluatable selectedEmployee = allEmployees[selectedIndex]; // Get employee object by index
                PerformanceStatus newStatus = (PerformanceStatus)comboBoxStatus.SelectedItem;

                selectedEmployee.changeStatus(newStatus);

                MessageBox.Show("Employee status updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployees(); // Refresh the employee list after status change
            }
            else
            {
                MessageBox.Show("Please select an employee and a status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxStatus_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadEmployees(); // Reload employees based on selected status

        }
    }
}