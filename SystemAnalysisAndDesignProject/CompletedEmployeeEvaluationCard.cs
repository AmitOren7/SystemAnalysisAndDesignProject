using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SystemAnalysisAndDesignProject
{
    public partial class CompletedEmployeeEvaluationCard : UserControl
    {
        private Evaluatable employee;
        public CompletedEmployeeEvaluationCard(Evaluatable employee)
        {
            this.employee = employee;   
            InitializeComponent();

        }

        public string EmployeeName
        {
            get => lblEmployeeName.Text;
            set => lblEmployeeName.Text = value;
        }

        public string Role
        {
            get => lblRole.Text;
            set => lblRole.Text = value;
        }

        public string Score
        {
            get => lblScore.Text;
            set
            {
                lblScore.Text = value;

                if (double.TryParse(value, out double score) && employee.GetPerformanceStatus() != PerformanceStatus.underWarning)
                {
                    if (score < 2)
                    {
                        pictureBoxIsuueWarning.Visible = true;
                        button1.Visible = true;
                    }
                    else
                    {
                        pictureBoxIsuueWarning.Visible = false;
                        button1.Visible = false;
                    }
                }
                else
                {
                    pictureBoxIsuueWarning.Visible = false;
                    button1.Visible = false;
                }
            }
        }



        public string PersonalNote
        {
            set => richTextBox1.Text = value;
        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmployeeName_Click(object sender, EventArgs e)
        {

        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            employee.changeStatus(PerformanceStatus.underWarning);
            SendWarningEmail();
        }

        private void CompletedEmployeeEvaluationCard_Load(object sender, EventArgs e)
        {

        }
        private void SendWarningEmail()
        {
            try
            {
                // 1. Set up email details
                string fromAddress = "samicranes2000@gmail.com"; // email address
                string fromPassword = "lnxh bvkk nzcf khqn"; // email password
                string toAddress = employee.GetEmail(); // Employee's email address 
                string subject = "Performance Warning"; // Email subject
                string body = $"Dear {employee.GetName()},\n\nYou are receiving this warning due to the recent performance evaluation.\n\n{richTextBox1.Text}\n\nSincerely,\nManagement Team"; // Email body (including notes from richTextBox)

                // 2. Create the MailMessage object
                MailMessage message = new MailMessage(fromAddress, toAddress, subject, body);

                // 3. Set up the SMTP client
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"); // Gmail SMTP server (example)
                smtpClient.Port = 587; // SMTP port (587 for TLS, 465 for SSL)
                smtpClient.Credentials = new NetworkCredential(fromAddress, fromPassword);
                smtpClient.EnableSsl = true; // Enable SSL (Highly recommended!)

                // 4. Send the email
                smtpClient.Send(message);

                MessageBox.Show("Warning email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SmtpException ex)
            {
                // Handle SMTP exceptions (e.g., connection error, incorrect password)
                MessageBox.Show($"Error sending email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                // Handle invalid email address format
                MessageBox.Show($"Invalid email address format: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle general exceptions
                MessageBox.Show($"General error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
