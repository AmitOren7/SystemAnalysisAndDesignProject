namespace SystemAnalysisAndDesignProject
{
    partial class DriverMainForm
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
            this.ViewProfileButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewProfileButton
            // 
            this.ViewProfileButton.Location = new System.Drawing.Point(519, 114);
            this.ViewProfileButton.Name = "ViewProfileButton";
            this.ViewProfileButton.Size = new System.Drawing.Size(159, 46);
            this.ViewProfileButton.TabIndex = 0;
            this.ViewProfileButton.Text = "View Profile";
            this.ViewProfileButton.UseVisualStyleBackColor = true;
            this.ViewProfileButton.Click += new System.EventHandler(this.ViewProfileButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(517, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "View Tasks";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(517, 274);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "Calendar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ViewProfileButton);
            this.Name = "Form1";
            this.Text = "DriverMainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewProfileButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}