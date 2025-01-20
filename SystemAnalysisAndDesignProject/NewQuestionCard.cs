using System;
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
    public partial class NewQuestionCard : UserControl
    {
        public NewQuestionCard()
        {
            InitializeComponent();
            LoadRolesToComboBox();
        }

        // Add the new question
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Get the description from the RichTextBox
                string description = richTextBoxQuestion.Text; // Assuming richTextBoxQuestion is your RichTextBox

                // Validate that the description is not empty
                if (string.IsNullOrWhiteSpace(description))
                {
                    MessageBox.Show("Question description cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Stop execution if description is empty
                }

                // 2. Get the selected role from the ComboBox
                string selectedRoleString = comboBoxRoles.SelectedItem?.ToString(); // Using null-conditional operator

                // Validate that a role is selected
                if (string.IsNullOrEmpty(selectedRoleString))
                {
                    MessageBox.Show("Please select a role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3. Convert the selected role string to a boolean value
                bool associatedRole;
                switch (selectedRoleString)
                {
                    case "driver":
                        associatedRole = true;
                        break;
                    case "clerk":
                        associatedRole = false;
                        break;
                    default:
                        MessageBox.Show("Invalid role selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Stop execution if an invalid role is selected
                }

                // 4. Create a new Question object using the provided constructor
                Question newQuestion = new Question(description, associatedRole, false, true);

                // Provide feedback to the user
                MessageBox.Show("Question added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the input fields
                richTextBoxQuestion.Clear();
                comboBoxRoles.SelectedIndex = -1; // Deselect the ComboBox

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoadRolesToComboBox()
        {
           
            comboBoxRoles.Items.Add("clerk");
            comboBoxRoles.Items.Add("driver");
            comboBoxRoles.SelectedItem = "clerk"; //a default role
        }
    }
}
