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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SortedOrdersDiff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_EligibleDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // SortedOrdersDiff
            // 
            this.SortedOrdersDiff.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SortedOrdersDiff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SortedOrdersDiff.Location = new System.Drawing.Point(74, 100);
            this.SortedOrdersDiff.Name = "SortedOrdersDiff";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SortedOrdersDiff.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SortedOrdersDiff.Size = new System.Drawing.Size(463, 137);
            this.SortedOrdersDiff.TabIndex = 0;
            // 
            // headlineLabel
            // 
            this.headlineLabel.AutoSize = true;
            this.headlineLabel.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.headlineLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.headlineLabel.Location = new System.Drawing.Point(47, 15);
            this.headlineLabel.Name = "headlineLabel";
            this.headlineLabel.Size = new System.Drawing.Size(177, 28);
            this.headlineLabel.TabIndex = 1;
            this.headlineLabel.Text = "Unassigned Orders ";
            // 
            // dataGridExplanation
            // 
            this.dataGridExplanation.AutoSize = true;
            this.dataGridExplanation.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dataGridExplanation.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridExplanation.Location = new System.Drawing.Point(71, 63);
            this.dataGridExplanation.Name = "dataGridExplanation";
            this.dataGridExplanation.Size = new System.Drawing.Size(520, 34);
            this.dataGridExplanation.TabIndex = 2;
            this.dataGridExplanation.Text = "Orders are sorted by profitability and estimated completion days.\r\nSelect an orde" +
    "r and drag it to the desired position for manually overriding the current sortin" +
    "g";
            // 
            // DG_EligibleDrivers
            // 
            this.DG_EligibleDrivers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DG_EligibleDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_EligibleDrivers.Location = new System.Drawing.Point(74, 280);
            this.DG_EligibleDrivers.Name = "DG_EligibleDrivers";
            this.DG_EligibleDrivers.Size = new System.Drawing.Size(463, 89);
            this.DG_EligibleDrivers.TabIndex = 3;
            // 
            // refreshOrdersButton
            // 
            this.refreshOrdersButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.refreshOrdersButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.refreshOrdersButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.refreshOrdersButton.Location = new System.Drawing.Point(549, 217);
            this.refreshOrdersButton.Name = "refreshOrdersButton";
            this.refreshOrdersButton.Size = new System.Drawing.Size(90, 12);
            this.refreshOrdersButton.TabIndex = 4;
            this.refreshOrdersButton.Text = "Refresh Orders";
            this.refreshOrdersButton.UseVisualStyleBackColor = false;
            this.refreshOrdersButton.Click += new System.EventHandler(this.refreshOrdersButton_Click);
            // 
            // driversdatagridheadline
            // 
            this.driversdatagridheadline.AutoSize = true;
            this.driversdatagridheadline.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.driversdatagridheadline.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.driversdatagridheadline.Location = new System.Drawing.Point(70, 240);
            this.driversdatagridheadline.Name = "driversdatagridheadline";
            this.driversdatagridheadline.Size = new System.Drawing.Size(240, 21);
            this.driversdatagridheadline.TabIndex = 6;
            this.driversdatagridheadline.Text = "Suitable Drivers For Selected Order";
            this.driversdatagridheadline.Click += new System.EventHandler(this.driversdatagridheadline_Click);
            // 
            // driversgridexp
            // 
            this.driversgridexp.AutoSize = true;
            this.driversgridexp.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.driversgridexp.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.driversgridexp.Location = new System.Drawing.Point(71, 260);
            this.driversgridexp.Name = "driversgridexp";
            this.driversgridexp.Size = new System.Drawing.Size(466, 17);
            this.driversgridexp.TabIndex = 7;
            this.driversgridexp.Text = "Click on the desired driver from the list below to assign them to the selected or" +
    "der\r\n";
            // 
            // clerkscombobox
            // 
            this.clerkscombobox.FormattingEnabled = true;
            this.clerkscombobox.Location = new System.Drawing.Point(74, 399);
            this.clerkscombobox.Name = "clerkscombobox";
            this.clerkscombobox.Size = new System.Drawing.Size(168, 21);
            this.clerkscombobox.TabIndex = 8;
            this.clerkscombobox.SelectedIndexChanged += new System.EventHandler(this.clerkscombobox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(70, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Clerk";
            // 
            // extendDriverButton
            // 
            this.extendDriverButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.extendDriverButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.extendDriverButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.extendDriverButton.Location = new System.Drawing.Point(549, 350);
            this.extendDriverButton.Name = "extendDriverButton";
            this.extendDriverButton.Size = new System.Drawing.Size(124, 10);
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
            this.assignungButton.Location = new System.Drawing.Point(676, 390);
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
            this.back.Location = new System.Drawing.Point(715, 13);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(43, 37);
            this.back.TabIndex = 49;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(16, -15);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(769, 481);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 59;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(640, 385);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(549, 205);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.refreshOrdersButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(549, 337);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(170, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 62;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.extendDriverButton_Click);
            // 
            // UnassignedOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
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
            this.Controls.Add(this.pictureBox4);
            this.Name = "UnassignedOrdersForm";
            this.Load += new System.EventHandler(this.UnassignedOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SortedOrdersDiff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_EligibleDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}