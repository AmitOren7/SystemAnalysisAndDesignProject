namespace SystemAnalysisAndDesignProject
{
    partial class UnassignedOrdersForm
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
            this.SortedOrdersDiff = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SortedOrdersDiff)).BeginInit();
            this.SuspendLayout();
            // 
            // SortedOrdersDiff
            // 
            this.SortedOrdersDiff.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SortedOrdersDiff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SortedOrdersDiff.Location = new System.Drawing.Point(49, 77);
            this.SortedOrdersDiff.Name = "SortedOrdersDiff";
            this.SortedOrdersDiff.Size = new System.Drawing.Size(682, 186);
            this.SortedOrdersDiff.TabIndex = 0;
            // 
            // UnassignedOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SortedOrdersDiff);
            this.Name = "UnassignedOrdersForm";
            this.Text = "UnassignedOrdersForm";
            ((System.ComponentModel.ISupportInitialize)(this.SortedOrdersDiff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SortedOrdersDiff;
    }
}