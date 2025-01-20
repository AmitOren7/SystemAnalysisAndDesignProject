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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfficeManagerMainForm));
            this.greeting_OPM = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.calendar = new System.Windows.Forms.Button();
            this.profile = new System.Windows.Forms.Button();
            this.EditSurvey = new System.Windows.Forms.Button();
            this.ViewEvaluations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // greeting_OPM
            // 
            this.greeting_OPM.AutoSize = true;
            this.greeting_OPM.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.greeting_OPM.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.greeting_OPM.Location = new System.Drawing.Point(227, 32);
            this.greeting_OPM.Name = "greeting_OPM";
            this.greeting_OPM.Size = new System.Drawing.Size(0, 37);
            this.greeting_OPM.TabIndex = 4;
            // 
            // back
            // 
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(769, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(43, 37);
            this.back.TabIndex = 49;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // calendar
            // 
            this.calendar.FlatAppearance.BorderSize = 0;
            this.calendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendar.Image = ((System.Drawing.Image)(resources.GetObject("calendar.Image")));
            this.calendar.Location = new System.Drawing.Point(219, 418);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(391, 92);
            this.calendar.TabIndex = 3;
            this.calendar.TabStop = false;
            this.calendar.UseVisualStyleBackColor = true;
            this.calendar.Click += new System.EventHandler(this.calendar_Click);
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.Color.Transparent;
            this.profile.FlatAppearance.BorderSize = 0;
            this.profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profile.Image = ((System.Drawing.Image)(resources.GetObject("profile.Image")));
            this.profile.Location = new System.Drawing.Point(219, 92);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(391, 91);
            this.profile.TabIndex = 2;
            this.profile.UseVisualStyleBackColor = false;
            this.profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // EditSurvey
            // 
            this.EditSurvey.FlatAppearance.BorderSize = 0;
            this.EditSurvey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditSurvey.Image = ((System.Drawing.Image)(resources.GetObject("EditSurvey.Image")));
            this.EditSurvey.Location = new System.Drawing.Point(221, 203);
            this.EditSurvey.Name = "EditSurvey";
            this.EditSurvey.Size = new System.Drawing.Size(391, 90);
            this.EditSurvey.TabIndex = 1;
            this.EditSurvey.UseVisualStyleBackColor = true;
            this.EditSurvey.Click += new System.EventHandler(this.EditSurvey_Click);
            // 
            // ViewEvaluations
            // 
            this.ViewEvaluations.FlatAppearance.BorderSize = 0;
            this.ViewEvaluations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewEvaluations.Image = ((System.Drawing.Image)(resources.GetObject("ViewEvaluations.Image")));
            this.ViewEvaluations.Location = new System.Drawing.Point(219, 313);
            this.ViewEvaluations.Name = "ViewEvaluations";
            this.ViewEvaluations.Size = new System.Drawing.Size(391, 81);
            this.ViewEvaluations.TabIndex = 0;
            this.ViewEvaluations.UseVisualStyleBackColor = true;
            this.ViewEvaluations.Click += new System.EventHandler(this.ViewEvaluationsButton_Click);
            // 
            // OfficeManagerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(824, 528);
            this.Controls.Add(this.back);
            this.Controls.Add(this.greeting_OPM);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.EditSurvey);
            this.Controls.Add(this.ViewEvaluations);
            this.Name = "OfficeManagerMainForm";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.OfficeManagerMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ViewEvaluations;
        private System.Windows.Forms.Button EditSurvey;
        private System.Windows.Forms.Button profile;
        private System.Windows.Forms.Button calendar;
        private System.Windows.Forms.Label greeting_OPM;
        private System.Windows.Forms.Button back;
    }
}