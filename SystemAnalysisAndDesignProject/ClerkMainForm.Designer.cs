namespace SystemAnalysisAndDesignProject
{
    partial class ClerkMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClerkMainForm));
            this.driverLabel = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.profile = new System.Windows.Forms.Button();
            this.viewCalendar = new System.Windows.Forms.Button();
            this.newEnployee = new System.Windows.Forms.Button();
            this.todaysTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // driverLabel
            // 
            this.driverLabel.AutoSize = true;
            this.driverLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.driverLabel.Location = new System.Drawing.Point(168, 43);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(0, 20);
            this.driverLabel.TabIndex = 24;
            // 
            // back
            // 
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(786, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(43, 37);
            this.back.TabIndex = 25;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profile.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.profile.FlatAppearance.BorderSize = 0;
            this.profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profile.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile.Image = ((System.Drawing.Image)(resources.GetObject("profile.Image")));
            this.profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profile.Location = new System.Drawing.Point(143, 81);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(524, 106);
            this.profile.TabIndex = 23;
            this.profile.UseVisualStyleBackColor = false;
            this.profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // viewCalendar
            // 
            this.viewCalendar.BackColor = System.Drawing.Color.Transparent;
            this.viewCalendar.FlatAppearance.BorderSize = 0;
            this.viewCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewCalendar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.viewCalendar.Image = ((System.Drawing.Image)(resources.GetObject("viewCalendar.Image")));
            this.viewCalendar.Location = new System.Drawing.Point(149, 412);
            this.viewCalendar.Name = "viewCalendar";
            this.viewCalendar.Size = new System.Drawing.Size(509, 124);
            this.viewCalendar.TabIndex = 22;
            this.viewCalendar.UseVisualStyleBackColor = false;
            this.viewCalendar.Click += new System.EventHandler(this.viewCalendar_Click);
            // 
            // newEnployee
            // 
            this.newEnployee.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newEnployee.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.newEnployee.FlatAppearance.BorderSize = 0;
            this.newEnployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.newEnployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.newEnployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newEnployee.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.newEnployee.Image = ((System.Drawing.Image)(resources.GetObject("newEnployee.Image")));
            this.newEnployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newEnployee.Location = new System.Drawing.Point(144, 188);
            this.newEnployee.Name = "newEnployee";
            this.newEnployee.Size = new System.Drawing.Size(523, 109);
            this.newEnployee.TabIndex = 21;
            this.newEnployee.UseVisualStyleBackColor = false;
            this.newEnployee.Click += new System.EventHandler(this.newEmployee_Click);
            // 
            // todaysTask
            // 
            this.todaysTask.BackColor = System.Drawing.Color.Transparent;
            this.todaysTask.FlatAppearance.BorderSize = 0;
            this.todaysTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.todaysTask.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.todaysTask.Image = ((System.Drawing.Image)(resources.GetObject("todaysTask.Image")));
            this.todaysTask.Location = new System.Drawing.Point(149, 297);
            this.todaysTask.Name = "todaysTask";
            this.todaysTask.Size = new System.Drawing.Size(509, 124);
            this.todaysTask.TabIndex = 26;
            this.todaysTask.UseVisualStyleBackColor = false;
            this.todaysTask.Click += new System.EventHandler(this.todaysTask_Click);
            // 
            // ClerkMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(841, 538);
            this.Controls.Add(this.todaysTask);
            this.Controls.Add(this.back);
            this.Controls.Add(this.driverLabel);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.viewCalendar);
            this.Controls.Add(this.newEnployee);
            this.Name = "ClerkMainForm";
            this.Text = "ClerkMainForm";
            this.Load += new System.EventHandler(this.ClerkMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label driverLabel;
        private System.Windows.Forms.Button profile;
        private System.Windows.Forms.Button viewCalendar;
        private System.Windows.Forms.Button newEnployee;
        private System.Windows.Forms.Button todaysTask;
    }
}