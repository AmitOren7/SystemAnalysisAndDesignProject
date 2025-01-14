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
            this.AssignmentsBoard = new System.Windows.Forms.Button();
            this.viewProfileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AssignmentsBoard
            // 
            this.AssignmentsBoard.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AssignmentsBoard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AssignmentsBoard.Image = global::SystemAnalysisAndDesignProject.Properties.Resources.done;
            this.AssignmentsBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AssignmentsBoard.Location = new System.Drawing.Point(75, 206);
            this.AssignmentsBoard.Name = "AssignmentsBoard";
            this.AssignmentsBoard.Size = new System.Drawing.Size(281, 79);
            this.AssignmentsBoard.TabIndex = 1;
            this.AssignmentsBoard.Text = "View Unassigned Orders";
            this.AssignmentsBoard.UseVisualStyleBackColor = false;
            // 
            // viewProfileButton
            // 
            this.viewProfileButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.viewProfileButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.viewProfileButton.Image = global::SystemAnalysisAndDesignProject.Properties.Resources.user__2_;
            this.viewProfileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewProfileButton.Location = new System.Drawing.Point(75, 105);
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
            this.Controls.Add(this.AssignmentsBoard);
            this.Controls.Add(this.viewProfileButton);
            this.Name = "OperationalManagerMainForm";
            this.Text = "OperationalManagerMainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewProfileButton;
        private System.Windows.Forms.Button AssignmentsBoard;
    }
}