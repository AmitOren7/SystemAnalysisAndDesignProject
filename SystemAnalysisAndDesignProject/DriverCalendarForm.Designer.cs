namespace SystemAnalysisAndDesignProject
{
    partial class DriverCalendarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sunday = new System.Windows.Forms.Label();
            this.monday = new System.Windows.Forms.Label();
            this.tuesday = new System.Windows.Forms.Label();
            this.wednesday = new System.Windows.Forms.Label();
            this.thursday = new System.Windows.Forms.Label();
            this.friday = new System.Windows.Forms.Label();
            this.saturday = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(58, 105);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(683, 323);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // sunday
            // 
            this.sunday.AutoSize = true;
            this.sunday.Location = new System.Drawing.Point(58, 71);
            this.sunday.Name = "sunday";
            this.sunday.Size = new System.Drawing.Size(43, 13);
            this.sunday.TabIndex = 1;
            this.sunday.Text = "Sunday";
            // 
            // monday
            // 
            this.monday.AutoSize = true;
            this.monday.Location = new System.Drawing.Point(163, 71);
            this.monday.Name = "monday";
            this.monday.Size = new System.Drawing.Size(45, 13);
            this.monday.TabIndex = 2;
            this.monday.Text = "Monday";
            // 
            // tuesday
            // 
            this.tuesday.AutoSize = true;
            this.tuesday.Location = new System.Drawing.Point(281, 71);
            this.tuesday.Name = "tuesday";
            this.tuesday.Size = new System.Drawing.Size(48, 13);
            this.tuesday.TabIndex = 3;
            this.tuesday.Text = "Tuesday";
            // 
            // wednesday
            // 
            this.wednesday.AutoSize = true;
            this.wednesday.Location = new System.Drawing.Point(389, 71);
            this.wednesday.Name = "wednesday";
            this.wednesday.Size = new System.Drawing.Size(64, 13);
            this.wednesday.TabIndex = 4;
            this.wednesday.Text = "Wednesday";
            // 
            // thursday
            // 
            this.thursday.AutoSize = true;
            this.thursday.Location = new System.Drawing.Point(529, 71);
            this.thursday.Name = "thursday";
            this.thursday.Size = new System.Drawing.Size(51, 13);
            this.thursday.TabIndex = 5;
            this.thursday.Text = "Thursday";
            // 
            // friday
            // 
            this.friday.AutoSize = true;
            this.friday.Location = new System.Drawing.Point(612, 71);
            this.friday.Name = "friday";
            this.friday.Size = new System.Drawing.Size(35, 13);
            this.friday.TabIndex = 6;
            this.friday.Text = "Friday";
            // 
            // saturday
            // 
            this.saturday.AutoSize = true;
            this.saturday.Location = new System.Drawing.Point(692, 71);
            this.saturday.Name = "saturday";
            this.saturday.Size = new System.Drawing.Size(49, 13);
            this.saturday.TabIndex = 7;
            this.saturday.Text = "Saturday";
            // 
            // DriverCalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saturday);
            this.Controls.Add(this.friday);
            this.Controls.Add(this.thursday);
            this.Controls.Add(this.wednesday);
            this.Controls.Add(this.tuesday);
            this.Controls.Add(this.monday);
            this.Controls.Add(this.sunday);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "DriverCalendarForm";
            this.Text = "DriverCalendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label sunday;
        private System.Windows.Forms.Label monday;
        private System.Windows.Forms.Label tuesday;
        private System.Windows.Forms.Label wednesday;
        private System.Windows.Forms.Label thursday;
        private System.Windows.Forms.Label friday;
        private System.Windows.Forms.Label saturday;
    }
}