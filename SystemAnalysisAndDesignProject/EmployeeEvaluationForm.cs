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
    public partial class EmployeeEvaluationForm : Form
    {
        private OfficeManager officeManager;
        List<EmployeeMonthlyEvaluation> evaluations = Program.EmployeeMonthlyEvaluationList;
        List<EmployeeEvaluationCard> cards = new List<EmployeeEvaluationCard>();

        public EmployeeEvaluationForm(OfficeManager officeManager)
        {
            this.officeManager = officeManager;
            InitializeComponent();
            LoadYears();
            LoadMonths();
            

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeEvaluationForm));
            this.PendingEvaluationsButton = new System.Windows.Forms.Button();
            this.CompletedEvaluationsButton = new System.Windows.Forms.Button();
            this.PendingEvaluationsDisplay = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.FetchPendEvalButton = new System.Windows.Forms.Button();
            this.CompletedEvaluationsDisplay = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PendingEvaluationsDisplay.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PendingEvaluationsButton
            // 
            this.PendingEvaluationsButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.PendingEvaluationsButton.FlatAppearance.BorderSize = 0;
            this.PendingEvaluationsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PendingEvaluationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PendingEvaluationsButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PendingEvaluationsButton.ForeColor = System.Drawing.Color.White;
            this.PendingEvaluationsButton.Location = new System.Drawing.Point(91, 57);
            this.PendingEvaluationsButton.Name = "PendingEvaluationsButton";
            this.PendingEvaluationsButton.Size = new System.Drawing.Size(312, 26);
            this.PendingEvaluationsButton.TabIndex = 0;
            this.PendingEvaluationsButton.Text = "Pending Evaluations";
            this.PendingEvaluationsButton.UseVisualStyleBackColor = false;
            this.PendingEvaluationsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CompletedEvaluationsButton
            // 
            this.CompletedEvaluationsButton.BackColor = System.Drawing.Color.LightGray;
            this.CompletedEvaluationsButton.FlatAppearance.BorderSize = 0;
            this.CompletedEvaluationsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.CompletedEvaluationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompletedEvaluationsButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CompletedEvaluationsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CompletedEvaluationsButton.Location = new System.Drawing.Point(403, 57);
            this.CompletedEvaluationsButton.Name = "CompletedEvaluationsButton";
            this.CompletedEvaluationsButton.Size = new System.Drawing.Size(312, 26);
            this.CompletedEvaluationsButton.TabIndex = 1;
            this.CompletedEvaluationsButton.Text = "Completed Evaluations";
            this.CompletedEvaluationsButton.UseVisualStyleBackColor = false;
            this.CompletedEvaluationsButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // PendingEvaluationsDisplay
            // 
            this.PendingEvaluationsDisplay.Controls.Add(this.flowLayoutPanel1);
            this.PendingEvaluationsDisplay.Location = new System.Drawing.Point(91, 89);
            this.PendingEvaluationsDisplay.Name = "PendingEvaluationsDisplay";
            this.PendingEvaluationsDisplay.Size = new System.Drawing.Size(624, 307);
            this.PendingEvaluationsDisplay.TabIndex = 2;
            this.PendingEvaluationsDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.PendingEvaluationsDisplay_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.comboBoxMonth);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxYear);
            this.flowLayoutPanel1.Controls.Add(this.FetchPendEvalButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(624, 307);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxMonth.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Location = new System.Drawing.Point(3, 3);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMonth.TabIndex = 0;
            this.comboBoxMonth.Text = "Month";
            this.comboBoxMonth.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonth_SelectedIndexChanged);
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxYear.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(130, 3);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(121, 21);
            this.comboBoxYear.TabIndex = 1;
            this.comboBoxYear.Text = "Year";
            this.comboBoxYear.SelectedIndexChanged += new System.EventHandler(this.comboBoxYear_SelectedIndexChanged);
            // 
            // FetchPendEvalButton
            // 
            this.FetchPendEvalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(70)))));
            this.FetchPendEvalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FetchPendEvalButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FetchPendEvalButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FetchPendEvalButton.Location = new System.Drawing.Point(257, 3);
            this.FetchPendEvalButton.Name = "FetchPendEvalButton";
            this.FetchPendEvalButton.Size = new System.Drawing.Size(101, 21);
            this.FetchPendEvalButton.TabIndex = 2;
            this.FetchPendEvalButton.Text = "Generate";
            this.FetchPendEvalButton.UseVisualStyleBackColor = false;
            this.FetchPendEvalButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CompletedEvaluationsDisplay
            // 
            this.CompletedEvaluationsDisplay.Location = new System.Drawing.Point(-1, -3);
            this.CompletedEvaluationsDisplay.Name = "CompletedEvaluationsDisplay";
            this.CompletedEvaluationsDisplay.Size = new System.Drawing.Size(624, 307);
            this.CompletedEvaluationsDisplay.TabIndex = 0;
            this.CompletedEvaluationsDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(91, 89);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(624, 307);
            this.flowLayoutPanel3.TabIndex = 4;
            this.flowLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel3_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(189, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "All Roles";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(720, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 38);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(108)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(58, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Employee Evaluations";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(640, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 13);
            this.button2.TabIndex = 23;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // back
            // 
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(720, 15);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(43, 37);
            this.back.TabIndex = 20;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(581, 393);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, -11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(769, 481);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // EmployeeEvaluationForm
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.PendingEvaluationsDisplay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PendingEvaluationsButton);
            this.Controls.Add(this.CompletedEvaluationsButton);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Name = "EmployeeEvaluationForm";
            this.Load += new System.EventHandler(this.EmployeeEvaluationForm_Load);
            this.PendingEvaluationsDisplay.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //pending evaluations
        private void button1_Click(object sender, EventArgs e)
        {
            this.PendingEvaluationsDisplay.Visible = true;
            this.CompletedEvaluationsDisplay.Visible = false;
            flowLayoutPanel1.Visible = true;
            flowLayoutPanel3.Visible = false;
            CompletedEvaluationsButton.BackColor = Color.LightGray;
            PendingEvaluationsButton.BackColor = Color.CornflowerBlue;

        }

        private void EmployeeEvaluationForm_Load(object sender, EventArgs e)
        {

        }



        //completed evaluations
        private void button2_Click(object sender, EventArgs e)
        {
            this.PendingEvaluationsDisplay.Visible = false;
            this.CompletedEvaluationsDisplay.Visible = true;
            CompletedEvaluationsButton.BackColor = Color.CornflowerBlue;
            PendingEvaluationsButton.BackColor = Color.LightGray;


            // Check if there are any completed evaluations 
            if (Program.EmployeeMonthlyEvaluationList == null || Program.EmployeeMonthlyEvaluationList.Count == 0)
            {
                MessageBox.Show("No completed evaluations found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Clear any existing evaluation cards from the panel
            flowLayoutPanel3.Controls.Clear(); 

            foreach (EmployeeMonthlyEvaluation evaluation in Program.EmployeeMonthlyEvaluationList)
            {
                // Create a new card for the current evaluation
                var card = new CompletedEmployeeEvaluationCard(evaluation.GetEmployee())
                {
                    EmployeeName = evaluation.GetEmployeeName(),
                    Role = evaluation.GetAssociatedRole(),
                    Score = evaluation.GetScore().ToString("N1"),
                    PersonalNote = evaluation.GetPersonalNote()
                };

                // Add the card to the panel only if it's not null (for safety)
                if (card != null)
                {
                    flowLayoutPanel3.Controls.Add(card);
                }
            }

            // Make sure the panel is visible
            flowLayoutPanel1.Visible = false;
            flowLayoutPanel3.Visible = true;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //retrieving pending evaluations
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cards != null || cards.Count != 0)
            {
                foreach (EmployeeEvaluationCard card1 in cards)
                flowLayoutPanel1.Controls.Remove(card1 as EmployeeEvaluationCard);
            }


            double score;
            int selectedMonth = int.Parse(comboBoxMonth.SelectedItem.ToString());
            int selectedYear = int.Parse(comboBoxYear.SelectedItem.ToString());

            EmployeeEvaluationCard card;

            foreach (Driver driver in Program.DriverList)
            {
                if (!IsAlreadyEvaluated(selectedMonth, selectedYear, driver))
                {
                    score = GetGradePerMonth(selectedMonth, selectedYear, driver);
                        if (score != 0)
                    {
                        card = new EmployeeEvaluationCard
                        {
                            EmployeeName = driver.GetName(),
                            Role = "Driver",
                            Score = score.ToString("N1"),
                            Employee = driver
                        };
                        flowLayoutPanel1.Controls.Add(card);
                        cards.Add(card);

                    }
                }           
            }


            foreach (Clerk clerk in Program.ClerkList)
            {
                if (!IsAlreadyEvaluated(selectedMonth, selectedYear, clerk))
                {
                    score = GetGradePerMonth(selectedMonth, selectedYear, clerk);
                    if (score != 0)
                    {

                        card = new EmployeeEvaluationCard
                        {
                            EmployeeName = clerk.GetName(),
                            Role = "Clerk",
                            Score = score.ToString("N1"),
                            Employee = clerk
                        };
                        flowLayoutPanel1.Controls.Add(card);
                        cards.Add(card);
                    }
                }
            }

        }





        private bool IsAlreadyEvaluated(int month, int year, Evaluatable employee)
        {
            foreach (EmployeeMonthlyEvaluation evaluation in Program.EmployeeMonthlyEvaluationList) 
            {
                if(evaluation.GetAssociatedYear() ==  year
                    && evaluation.GetAssociatedMonth() == month
                    && evaluation.GetAssociatedEmployeeId().Equals(employee.GetId()))
                    { return true; }
            }
            return false;
        }


        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMonth.SelectedIndex != -1)
            {
                string selectedItem = comboBoxMonth.SelectedItem.ToString(); //saving the selected month 
                int selectedindex = comboBoxMonth.SelectedIndex;
                int selectedMonthNumber = selectedindex + 1; //the index starts from 0
            }

        }

        private void LoadYears()
        {
            int currentYear = DateTime.Now.Year;

            int startYear = currentYear - 15;
            int endYear = currentYear;

            for (int year = startYear; year <= endYear; year++)
            {
                comboBoxYear.Items.Add(year);
            }
            comboBoxYear.SelectedItem = currentYear;
        }


        private void LoadMonths()
        {

            for (int i = 1; i <= 12; i++)
            {
                comboBoxMonth.Items.Add(i);
            }

            int currentMonth = DateTime.Now.Month;
            int previousMonth;
            if (currentMonth == 1)
            {
                previousMonth = 12;
                comboBoxYear.SelectedItem = DateTime.Now.Year - 1 ;
     
            }
                
            else
                previousMonth = currentMonth - 1;

            // default selection - the prior month since the evaluations are filled out for the previous months.
            comboBoxMonth.SelectedItem = previousMonth;
 
        }


        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxYear.SelectedItem != null) // Check if an item is selected
            {
                int selectedYear = (int)comboBoxYear.SelectedItem; // Cast to int
            }

        }


        // function that will calculate the grade of the evaluated employee for the month of this evaluation
        private double GetGradePerMonth(int Month, int Year, Evaluatable employee)
        {
            int counter = 0; //counts the number of answers that were included in the calculation
            double total_score = 0; //sums the cumulative score from the included answers 
            foreach (Answer answer in Program.AnswerList)
            {
                // check if it is a releavant answer for the month, year and employee 
                if (answer.GetSurvey().IsCompleted() && answer.GetSurvey().IsEmployeeAssociated(employee.GetId())
                    && answer.IsEmployeeAssociated(employee)
                    && answer.GetSurvey().IsAssociatedMonth(Month) && answer.GetSurvey().IsAssociatedYear(Year))
                {
                    
                    // check if the employee is a driver or a clerk

                    counter++;
                    total_score += answer.GetAnswerValue();
                }
            }
            if (counter == 0)
            {
                return total_score;
            }
            else
            {
                return ((total_score / counter)); // grade between 0 and 5
            }
        }

        //returns the selected month from the combobox for creating the employee evaluation
        public string GetSelectedMonth()
        {
            return this.comboBoxMonth.SelectedItem.ToString();
        }


        //returns the selected year from the combobox for creating the employee evaluation
        public string GetSelectedYear()
        {
            return this.comboBoxYear.SelectedItem.ToString();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PendingEvaluationsDisplay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            OfficeManagerMainForm officerAccountForm = new OfficeManagerMainForm(this.officeManager);
            officerAccountForm.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void employeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IssueWarningButton_Click(object sender, EventArgs e)
        {

        }

        // change employee status
        private void button2_Click_1(object sender, EventArgs e)
        {
            // Create an instance of the form
            ManageEmployeeStatusForm statusForm = new ManageEmployeeStatusForm(); 

            // Show the form
            statusForm.ShowDialog();
        }
    }
}
