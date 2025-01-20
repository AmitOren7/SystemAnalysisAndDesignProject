namespace SystemAnalysisAndDesignProject
{
    partial class OperationalManagerMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperationalManagerMainForm));
            this.greeting_OPM = new System.Windows.Forms.Label();
            this.AssignmentsBoard = new System.Windows.Forms.Button();
            this.viewProfileButton = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.viewCalendar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // greeting_OPM
            // 
            this.greeting_OPM.AutoSize = true;
            this.greeting_OPM.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.greeting_OPM.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.greeting_OPM.Location = new System.Drawing.Point(192, 45);
            this.greeting_OPM.Name = "greeting_OPM";
            this.greeting_OPM.Size = new System.Drawing.Size(0, 37);
            this.greeting_OPM.TabIndex = 2;
            // 
            // AssignmentsBoard
            // 
            this.AssignmentsBoard.BackColor = System.Drawing.Color.Transparent;
            this.AssignmentsBoard.FlatAppearance.BorderSize = 0;
            this.AssignmentsBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssignmentsBoard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AssignmentsBoard.Image = ((System.Drawing.Image)(resources.GetObject("AssignmentsBoard.Image")));
            this.AssignmentsBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AssignmentsBoard.Location = new System.Drawing.Point(167, 190);
            this.AssignmentsBoard.Name = "AssignmentsBoard";
            this.AssignmentsBoard.Size = new System.Drawing.Size(405, 98);
            this.AssignmentsBoard.TabIndex = 0;
            this.AssignmentsBoard.UseVisualStyleBackColor = false;
            this.AssignmentsBoard.Click += new System.EventHandler(this.AssignmentsBoard_Click);
            // 
            // viewProfileButton
            // 
            this.viewProfileButton.BackColor = System.Drawing.Color.Transparent;
            this.viewProfileButton.FlatAppearance.BorderSize = 0;
            this.viewProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewProfileButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.viewProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("viewProfileButton.Image")));
            this.viewProfileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewProfileButton.Location = new System.Drawing.Point(167, 91);
            this.viewProfileButton.Name = "viewProfileButton";
            this.viewProfileButton.Size = new System.Drawing.Size(420, 104);
            this.viewProfileButton.TabIndex = 0;
            this.viewProfileButton.UseVisualStyleBackColor = false;
            this.viewProfileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // back
            // 
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(745, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(43, 37);
            this.back.TabIndex = 5;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // viewCalendar
            // 
            this.viewCalendar.FlatAppearance.BorderSize = 0;
            this.viewCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewCalendar.Image = ((System.Drawing.Image)(resources.GetObject("viewCalendar.Image")));
            this.viewCalendar.Location = new System.Drawing.Point(188, 294);
            this.viewCalendar.Name = "viewCalendar";
            this.viewCalendar.Size = new System.Drawing.Size(384, 101);
            this.viewCalendar.TabIndex = 6;
            this.viewCalendar.UseVisualStyleBackColor = true;
            this.viewCalendar.Click += new System.EventHandler(this.viewCalendar_Click);
            // 
            // OperationalManagerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewCalendar);
            this.Controls.Add(this.back);
            this.Controls.Add(this.greeting_OPM);
            this.Controls.Add(this.AssignmentsBoard);
            this.Controls.Add(this.viewProfileButton);
            this.Name = "OperationalManagerMainForm";
            this.Text = "OperationalManagerMainForm";
            this.Load += new System.EventHandler(this.OperationalManagerMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewProfileButton;
        private System.Windows.Forms.Button AssignmentsBoard;
        private System.Windows.Forms.Label greeting_OPM;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button viewCalendar;
    }
}