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
            this.greeting_OPM = new System.Windows.Forms.Label();
            this.signOutButton = new System.Windows.Forms.Button();
            this.AssignmentsBoard = new System.Windows.Forms.Button();
            this.viewProfileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // greeting_OPM
            // 
            this.greeting_OPM.AutoSize = true;
            this.greeting_OPM.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.greeting_OPM.Location = new System.Drawing.Point(70, 50);
            this.greeting_OPM.Name = "greeting_OPM";
            this.greeting_OPM.Size = new System.Drawing.Size(0, 29);
            this.greeting_OPM.TabIndex = 2;
            // 
            // signOutButton
            // 
            this.signOutButton.BackColor = System.Drawing.Color.SkyBlue;
            this.signOutButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.signOutButton.Image = global::SystemAnalysisAndDesignProject.Properties.Resources.log_out;
            this.signOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signOutButton.Location = new System.Drawing.Point(681, 22);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(97, 28);
            this.signOutButton.TabIndex = 3;
            this.signOutButton.Text = "Sign Out";
            this.signOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.signOutButton.UseVisualStyleBackColor = false;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // AssignmentsBoard
            // 
            this.AssignmentsBoard.BackColor = System.Drawing.Color.SkyBlue;
            this.AssignmentsBoard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AssignmentsBoard.Image = global::SystemAnalysisAndDesignProject.Properties.Resources.done;
            this.AssignmentsBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AssignmentsBoard.Location = new System.Drawing.Point(75, 239);
            this.AssignmentsBoard.Name = "AssignmentsBoard";
            this.AssignmentsBoard.Size = new System.Drawing.Size(281, 79);
            this.AssignmentsBoard.TabIndex = 1;
            this.AssignmentsBoard.Text = "View Unassigned Orders";
            this.AssignmentsBoard.UseVisualStyleBackColor = false;
            this.AssignmentsBoard.Click += new System.EventHandler(this.AssignmentsBoard_Click);
            // 
            // viewProfileButton
            // 
            this.viewProfileButton.BackColor = System.Drawing.Color.SkyBlue;
            this.viewProfileButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.viewProfileButton.Image = global::SystemAnalysisAndDesignProject.Properties.Resources.user__2_;
            this.viewProfileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewProfileButton.Location = new System.Drawing.Point(75, 130);
            this.viewProfileButton.Name = "viewProfileButton";
            this.viewProfileButton.Size = new System.Drawing.Size(281, 76);
            this.viewProfileButton.TabIndex = 0;
            this.viewProfileButton.Text = "My Account";
            this.viewProfileButton.UseVisualStyleBackColor = false;
            this.viewProfileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OperationalManagerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signOutButton);
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
        private System.Windows.Forms.Button signOutButton;
    }
}