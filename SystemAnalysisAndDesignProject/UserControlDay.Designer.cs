using System.Drawing;
using System.Windows.Forms;

namespace SystemAnalysisAndDesignProject
{
    partial class UserControlDay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            this.dayLabel = new System.Windows.Forms.Label();
            this.eventListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // dayLabel
            // 
            this.dayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dayLabel.BackColor = System.Drawing.Color.Transparent;
            this.dayLabel.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.dayLabel.Location = new System.Drawing.Point(23, 5);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(57, 15);
            this.dayLabel.TabIndex = 0;
            this.dayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventListBox
            // 
            this.eventListBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.eventListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventListBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.eventListBox.FormattingEnabled = true;
            this.eventListBox.Location = new System.Drawing.Point(27, 30);
            this.eventListBox.Name = "eventListBox";
            this.eventListBox.Size = new System.Drawing.Size(54, 26);
            this.eventListBox.TabIndex = 1;
            this.eventListBox.Visible = false;
            this.eventListBox.SelectedIndexChanged += new System.EventHandler(this.eventListBox_SelectedIndexChanged);
            // 
            // UserControlDay
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.eventListBox);
            this.Name = "UserControlDay";
            this.Size = new System.Drawing.Size(100, 59);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DayControl_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label task;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.ListBox listBox1;
    }
}
