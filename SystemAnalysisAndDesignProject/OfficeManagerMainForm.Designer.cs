namespace SystemAnalysisAndDesignProject
{
    partial class OfficeManagerMainForm
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
            this.ViewEvaluations = new System.Windows.Forms.Button();
            this.EditSurvey = new System.Windows.Forms.Button();
            this.profile = new System.Windows.Forms.Button();
            this.calendar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewEvaluations
            // 
            this.ViewEvaluations.Location = new System.Drawing.Point(320, 234);
            this.ViewEvaluations.Name = "ViewEvaluations";
            this.ViewEvaluations.Size = new System.Drawing.Size(142, 67);
            this.ViewEvaluations.TabIndex = 0;
            this.ViewEvaluations.Text = "View Evaluations";
            this.ViewEvaluations.UseVisualStyleBackColor = true;
            this.ViewEvaluations.Click += new System.EventHandler(this.ViewEvaluationsButton_Click);
            // 
            // EditSurvey
            // 
            this.EditSurvey.Location = new System.Drawing.Point(320, 147);
            this.EditSurvey.Name = "EditSurvey";
            this.EditSurvey.Size = new System.Drawing.Size(142, 67);
            this.EditSurvey.TabIndex = 1;
            this.EditSurvey.Text = "Edit Survey";
            this.EditSurvey.UseVisualStyleBackColor = true;
            this.EditSurvey.Click += new System.EventHandler(this.EditSurvey_Click);
            // 
            // profile
            // 
            this.profile.Location = new System.Drawing.Point(354, 90);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(75, 23);
            this.profile.TabIndex = 2;
            this.profile.Text = "button1";
            this.profile.UseVisualStyleBackColor = true;
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(354, 346);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(75, 23);
            this.calendar.TabIndex = 3;
            this.calendar.Text = "button2";
            this.calendar.UseVisualStyleBackColor = true;
            // 
            // OfficeManagerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.EditSurvey);
            this.Controls.Add(this.ViewEvaluations);
            this.Name = "OfficeManagerMainForm";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.OfficeManagerMainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewEvaluations;
        private System.Windows.Forms.Button EditSurvey;
        private System.Windows.Forms.Button profile;
        private System.Windows.Forms.Button calendar;
    }
}