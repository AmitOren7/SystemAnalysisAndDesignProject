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
        List<EmployeeMonthlyEvaluation> evaluations = Program.EmployeeMonthlyEvaluationList;

        public EmployeeEvaluationForm()
        {
            InitializeComponent();
            LoadYears();
            LoadMonths();

        }

        private void InitializeComponent()
        {
            this.PendingEvaluationsButton = new System.Windows.Forms.Button();
            this.CompletedEvaluationsButton = new System.Windows.Forms.Button();
            this.PendingEvaluationsDisplay = new System.Windows.Forms.Panel();
            this.CompletedEvaluationsDisplay = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.FetchPendEvalButton = new System.Windows.Forms.Button();
            this.PendingEvaluationsDisplay.SuspendLayout();
            this.CompletedEvaluationsDisplay.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PendingEvaluationsButton
            // 
            this.PendingEvaluationsButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PendingEvaluationsButton.FlatAppearance.BorderSize = 0;
            this.PendingEvaluationsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.PendingEvaluationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PendingEvaluationsButton.Location = new System.Drawing.Point(52, 67);
            this.PendingEvaluationsButton.Name = "PendingEvaluationsButton";
            this.PendingEvaluationsButton.Size = new System.Drawing.Size(312, 26);
            this.PendingEvaluationsButton.TabIndex = 0;
            this.PendingEvaluationsButton.Text = "Pending Evaluations";
            this.PendingEvaluationsButton.UseVisualStyleBackColor = false;
            this.PendingEvaluationsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CompletedEvaluationsButton
            // 
            this.CompletedEvaluationsButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CompletedEvaluationsButton.FlatAppearance.BorderSize = 0;
            this.CompletedEvaluationsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.CompletedEvaluationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompletedEvaluationsButton.Location = new System.Drawing.Point(364, 67);
            this.CompletedEvaluationsButton.Name = "CompletedEvaluationsButton";
            this.CompletedEvaluationsButton.Size = new System.Drawing.Size(312, 26);
            this.CompletedEvaluationsButton.TabIndex = 1;
            this.CompletedEvaluationsButton.Text = "Completed Evaluations";
            this.CompletedEvaluationsButton.UseVisualStyleBackColor = false;
            this.CompletedEvaluationsButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // PendingEvaluationsDisplay
            // 
            this.PendingEvaluationsDisplay.Controls.Add(this.CompletedEvaluationsDisplay);
            this.PendingEvaluationsDisplay.Location = new System.Drawing.Point(52, 99);
            this.PendingEvaluationsDisplay.Name = "PendingEvaluationsDisplay";
            this.PendingEvaluationsDisplay.Size = new System.Drawing.Size(624, 307);
            this.PendingEvaluationsDisplay.TabIndex = 2;
            // 
            // CompletedEvaluationsDisplay
            // 
            this.CompletedEvaluationsDisplay.Controls.Add(this.flowLayoutPanel1);
            this.CompletedEvaluationsDisplay.Controls.Add(this.comboBox1);
            this.CompletedEvaluationsDisplay.Location = new System.Drawing.Point(0, 0);
            this.CompletedEvaluationsDisplay.Name = "CompletedEvaluationsDisplay";
            this.CompletedEvaluationsDisplay.Size = new System.Drawing.Size(624, 307);
            this.CompletedEvaluationsDisplay.TabIndex = 0;
            this.CompletedEvaluationsDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(190, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "All Roles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.ForeColor = System.Drawing.SystemColors.ButtonShadow;
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
            this.comboBoxYear.ForeColor = System.Drawing.SystemColors.ButtonShadow;
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
            this.FetchPendEvalButton.Location = new System.Drawing.Point(257, 3);
            this.FetchPendEvalButton.Name = "FetchPendEvalButton";
            this.FetchPendEvalButton.Size = new System.Drawing.Size(101, 21);
            this.FetchPendEvalButton.TabIndex = 2;
            this.FetchPendEvalButton.Text = "Generate";
            this.FetchPendEvalButton.UseVisualStyleBackColor = true;
            this.FetchPendEvalButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // EmployeeEvaluationForm
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(720, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PendingEvaluationsDisplay);
            this.Controls.Add(this.CompletedEvaluationsButton);
            this.Controls.Add(this.PendingEvaluationsButton);
            this.Name = "EmployeeEvaluationForm";
            this.Text = "Employee Evaluation Form";
            this.Load += new System.EventHandler(this.EmployeeEvaluationForm_Load);
            this.PendingEvaluationsDisplay.ResumeLayout(false);
            this.CompletedEvaluationsDisplay.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //pending evaluations
        private void button1_Click(object sender, EventArgs e)
        {
            this.PendingEvaluationsDisplay.Visible = true;
            this.CompletedEvaluationsDisplay.Visible = false;
        }

        private void EmployeeEvaluationForm_Load(object sender, EventArgs e)
        {

            //foreach (EmployeeMonthlyEvaluation evaluation in evaluations)
            //{
            //    var card = new EmployeeEvaluationCard
            //    {
            //        EmployeeName = evaluation.GetEmployeeName(),
            //        Role = evaluation.GetAssociatedRole(),
            //        Score = evaluation.GetGradePerMonth().ToString("N1"), // Format to 1 decimal place
            //    };

            //         flowLayoutPanel1.Controls.Add(card);
            }
        


        //completed evaluations
        private void button2_Click(object sender, EventArgs e)
        {

            this.PendingEvaluationsDisplay.Visible = false;
            this.CompletedEvaluationsDisplay.Visible = true;

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
                            Score = score.ToString("N1")
                        };
                         flowLayoutPanel1.Controls.Add(card);

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
                            Score = score.ToString("N1")
                        };
                        flowLayoutPanel1.Controls.Add(card);
                
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

    }
}
