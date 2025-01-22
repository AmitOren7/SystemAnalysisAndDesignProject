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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnassignedOrdersForm));
            this.SortedOrdersDiff = new System.Windows.Forms.DataGridView();
            this.headlineLabel = new System.Windows.Forms.Label();
            this.dataGridExplanation = new System.Windows.Forms.Label();
            this.DG_EligibleDrivers = new System.Windows.Forms.DataGridView();
            this.refreshOrdersButton = new System.Windows.Forms.Button();
            this.driversdatagridheadline = new System.Windows.Forms.Label();
            this.driversgridexp = new System.Windows.Forms.Label();
            this.clerkscombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.extendDriverButton = new System.Windows.Forms.Button();
            this.assignungButton = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SortedOrdersDiff.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.dataGridExplanation.Size = new System.Drawing.Size(555, 34);
            this.dataGridExplanation.TabIndex = 2;
            this.dataGridExplanation.Text = "Orders are sorted by profitability and estimated completion days.\r\nSelect an orde" +
    "r and drag it to the desired position for manually overriding the current sortin" +
    "g";
            // 
            // DG_EligibleDrivers
            // 
            this.DG_EligibleDrivers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DG_EligibleDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_EligibleDrivers.Location = new System.Drawing.Point(74, 310);
            this.DG_EligibleDrivers.Name = "DG_EligibleDrivers";
            this.DG_EligibleDrivers.Size = new System.Drawing.Size(420, 150);
            this.DG_EligibleDrivers.TabIndex = 3;
            // 
            // refreshOrdersButton
            // 
            this.refreshOrdersButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.refreshOrdersButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.refreshOrdersButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.refreshOrdersButton.Location = new System.Drawing.Point(344, 220);
            this.refreshOrdersButton.Name = "refreshOrdersButton";
            this.refreshOrdersButton.Size = new System.Drawing.Size(119, 33);
            this.refreshOrdersButton.TabIndex = 4;
            this.refreshOrdersButton.Text = "Refresh Orders";
            this.refreshOrdersButton.UseVisualStyleBackColor = false;
            this.refreshOrdersButton.Click += new System.EventHandler(this.refreshOrdersButton_Click);
            // 
            // driversdatagridheadline
            // 
            this.driversdatagridheadline.AutoSize = true;
            this.driversdatagridheadline.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.driversdatagridheadline.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.driversdatagridheadline.Location = new System.Drawing.Point(69, 265);
            this.driversdatagridheadline.Name = "driversdatagridheadline";
            this.driversdatagridheadline.Size = new System.Drawing.Size(323, 25);
            this.driversdatagridheadline.TabIndex = 6;
            this.driversdatagridheadline.Text = "Suitable Drivers For Selected Order";
            // 
            // driversgridexp
            // 
            this.driversgridexp.AutoSize = true;
            this.driversgridexp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.driversgridexp.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.driversgridexp.Location = new System.Drawing.Point(71, 290);
            this.driversgridexp.Name = "driversgridexp";
            this.driversgridexp.Size = new System.Drawing.Size(491, 17);
            this.driversgridexp.TabIndex = 7;
            this.driversgridexp.Text = "Click on the desired driver from the list below to assign them to the selected or" +
    "der\r\n";
            // 
            // clerkscombobox
            // 
            this.clerkscombobox.FormattingEnabled = true;
            this.clerkscombobox.Location = new System.Drawing.Point(614, 310);
            this.clerkscombobox.Name = "clerkscombobox";
            this.clerkscombobox.Size = new System.Drawing.Size(202, 21);
            this.clerkscombobox.TabIndex = 8;
            this.clerkscombobox.SelectedIndexChanged += new System.EventHandler(this.clerkscombobox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(609, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Clerk";
            // 
            // extendDriverButton
            // 
            this.extendDriverButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.extendDriverButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.extendDriverButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.extendDriverButton.Location = new System.Drawing.Point(74, 466);
            this.extendDriverButton.Name = "extendDriverButton";
            this.extendDriverButton.Size = new System.Drawing.Size(198, 33);
            this.extendDriverButton.TabIndex = 10;
            this.extendDriverButton.Text = "Select Drivers Manually";
            this.extendDriverButton.UseVisualStyleBackColor = false;
            this.extendDriverButton.Click += new System.EventHandler(this.extendDriverButton_Click);
            // 
            // assignungButton
            // 
            this.assignungButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.assignungButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.assignungButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.assignungButton.Location = new System.Drawing.Point(747, 466);
            this.assignungButton.Name = "assignungButton";
            this.assignungButton.Size = new System.Drawing.Size(78, 33);
            this.assignungButton.TabIndex = 12;
            this.assignungButton.Text = "Assign";
            this.assignungButton.UseVisualStyleBackColor = false;
            this.assignungButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // back
            // 
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(794, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(43, 37);
            this.back.TabIndex = 49;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // UnassignedOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(849, 509);
            this.Controls.Add(this.back);
            this.Controls.Add(this.assignungButton);
            this.Controls.Add(this.extendDriverButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clerkscombobox);
            this.Controls.Add(this.driversgridexp);
            this.Controls.Add(this.driversdatagridheadline);
            this.Controls.Add(this.refreshOrdersButton);
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
        private System.Windows.Forms.Button refreshOrdersButton;
        private System.Windows.Forms.Label driversdatagridheadline;
        private System.Windows.Forms.Label driversgridexp;
        private System.Windows.Forms.ComboBox clerkscombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button extendDriverButton;
        private System.Windows.Forms.Button assignungButton;
        private System.Windows.Forms.Button back;
    }
}