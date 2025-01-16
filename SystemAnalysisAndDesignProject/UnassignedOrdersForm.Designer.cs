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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SortedOrdersDiff = new System.Windows.Forms.DataGridView();
            this.headlineLabel = new System.Windows.Forms.Label();
            this.dataGridExplanation = new System.Windows.Forms.Label();
            this.DG_EligibleDrivers = new System.Windows.Forms.DataGridView();
            this.originalpriortization = new System.Windows.Forms.Button();
            this.savepriortization = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SortedOrdersDiff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_EligibleDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // SortedOrdersDiff
            // 
            this.SortedOrdersDiff.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SortedOrdersDiff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SortedOrdersDiff.Location = new System.Drawing.Point(74, 79);
            this.SortedOrdersDiff.Name = "SortedOrdersDiff";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SortedOrdersDiff.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SortedOrdersDiff.Size = new System.Drawing.Size(680, 125);
            this.SortedOrdersDiff.TabIndex = 0;
            // 
            // headlineLabel
            // 
            this.headlineLabel.AutoSize = true;
            this.headlineLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.headlineLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.headlineLabel.Location = new System.Drawing.Point(244, -3);
            this.headlineLabel.Name = "headlineLabel";
            this.headlineLabel.Size = new System.Drawing.Size(311, 45);
            this.headlineLabel.TabIndex = 1;
            this.headlineLabel.Text = "Unassigned Orders ";
            // 
            // dataGridExplanation
            // 
            this.dataGridExplanation.AutoSize = true;
            this.dataGridExplanation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dataGridExplanation.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridExplanation.Location = new System.Drawing.Point(71, 42);
            this.dataGridExplanation.Name = "dataGridExplanation";
            this.dataGridExplanation.Size = new System.Drawing.Size(539, 34);
            this.dataGridExplanation.TabIndex = 2;
            this.dataGridExplanation.Text = "Orders are sorted by profitability and estimated completion days.\r\nSelect an orde" +
    "r and drag it to the desired position to manually override the current sorting";
            // 
            // DG_EligibleDrivers
            // 
            this.DG_EligibleDrivers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DG_EligibleDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_EligibleDrivers.Location = new System.Drawing.Point(74, 314);
            this.DG_EligibleDrivers.Name = "DG_EligibleDrivers";
            this.DG_EligibleDrivers.Size = new System.Drawing.Size(240, 150);
            this.DG_EligibleDrivers.TabIndex = 3;
            // 
            // originalpriortization
            // 
            this.originalpriortization.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.originalpriortization.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.originalpriortization.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.originalpriortization.Location = new System.Drawing.Point(225, 224);
            this.originalpriortization.Name = "originalpriortization";
            this.originalpriortization.Size = new System.Drawing.Size(134, 23);
            this.originalpriortization.TabIndex = 4;
            this.originalpriortization.Text = "Original Priortization";
            this.originalpriortization.UseVisualStyleBackColor = false;
            // 
            // savepriortization
            // 
            this.savepriortization.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.savepriortization.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.savepriortization.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.savepriortization.Location = new System.Drawing.Point(440, 224);
            this.savepriortization.Name = "savepriortization";
            this.savepriortization.Size = new System.Drawing.Size(147, 23);
            this.savepriortization.TabIndex = 5;
            this.savepriortization.Text = "Save Edited Priortization";
            this.savepriortization.UseVisualStyleBackColor = false;
            // 
            // UnassignedOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(849, 509);
            this.Controls.Add(this.savepriortization);
            this.Controls.Add(this.originalpriortization);
            this.Controls.Add(this.DG_EligibleDrivers);
            this.Controls.Add(this.dataGridExplanation);
            this.Controls.Add(this.headlineLabel);
            this.Controls.Add(this.SortedOrdersDiff);
            this.Name = "UnassignedOrdersForm";
            this.Text = "UnassignedOrdersForm";
            ((System.ComponentModel.ISupportInitialize)(this.SortedOrdersDiff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_EligibleDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SortedOrdersDiff;
        private System.Windows.Forms.Label headlineLabel;
        private System.Windows.Forms.Label dataGridExplanation;
        private System.Windows.Forms.DataGridView DG_EligibleDrivers;
        private System.Windows.Forms.Button originalpriortization;
        private System.Windows.Forms.Button savepriortization;
    }
}