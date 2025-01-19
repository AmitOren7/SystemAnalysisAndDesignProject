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
            this.ViewEvaluationsButton = new System.Windows.Forms.Button();
            this.EditSurvey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewEvaluationsButton
            // 
            this.ViewEvaluationsButton.Location = new System.Drawing.Point(594, 335);
            this.ViewEvaluationsButton.Name = "ViewEvaluationsButton";
            this.ViewEvaluationsButton.Size = new System.Drawing.Size(142, 67);
            this.ViewEvaluationsButton.TabIndex = 0;
            this.ViewEvaluationsButton.Text = "View Evaluations";
            this.ViewEvaluationsButton.UseVisualStyleBackColor = true;
            this.ViewEvaluationsButton.Click += new System.EventHandler(this.ViewEvaluationsButton_Click);
            // 
            // EditSurvey
            // 
            this.EditSurvey.Location = new System.Drawing.Point(594, 248);
            this.EditSurvey.Name = "EditSurvey";
            this.EditSurvey.Size = new System.Drawing.Size(142, 67);
            this.EditSurvey.TabIndex = 1;
            this.EditSurvey.Text = "Edit Survey";
            this.EditSurvey.UseVisualStyleBackColor = true;
            this.EditSurvey.Click += new System.EventHandler(this.EditSurvey_Click);
            // 
            // OfficeManagerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditSurvey);
            this.Controls.Add(this.ViewEvaluationsButton);
            this.Name = "OfficeManagerMainForm";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.OfficeManagerMainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewEvaluationsButton;
        private System.Windows.Forms.Button EditSurvey;
    }
}