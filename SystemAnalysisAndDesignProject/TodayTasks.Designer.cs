namespace SystemAnalysisAndDesignProject
{
    partial class TodayTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodayTasks));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.order = new System.Windows.Forms.Label();
            this.customer = new System.Windows.Forms.Label();
            this.customerPhone = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.Label();
            this.driver = new System.Windows.Forms.Label();
            this.vehicle = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // order
            // 
            this.order.AutoSize = true;
            this.order.Location = new System.Drawing.Point(124, 56);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(35, 13);
            this.order.TabIndex = 1;
            this.order.Text = "label1";
            // 
            // customer
            // 
            this.customer.AutoSize = true;
            this.customer.Location = new System.Drawing.Point(127, 93);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(35, 13);
            this.customer.TabIndex = 2;
            this.customer.Text = "label1";
            // 
            // customerPhone
            // 
            this.customerPhone.AutoSize = true;
            this.customerPhone.Location = new System.Drawing.Point(263, 93);
            this.customerPhone.Name = "customerPhone";
            this.customerPhone.Size = new System.Drawing.Size(35, 13);
            this.customerPhone.TabIndex = 3;
            this.customerPhone.Text = "label1";
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.Location = new System.Drawing.Point(124, 127);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(35, 13);
            this.from.TabIndex = 4;
            this.from.Text = "label1";
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Location = new System.Drawing.Point(266, 127);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(35, 13);
            this.to.TabIndex = 5;
            this.to.Text = "label1";
            // 
            // driver
            // 
            this.driver.AutoSize = true;
            this.driver.Location = new System.Drawing.Point(127, 157);
            this.driver.Name = "driver";
            this.driver.Size = new System.Drawing.Size(35, 13);
            this.driver.TabIndex = 6;
            this.driver.Text = "label1";
            // 
            // vehicle
            // 
            this.vehicle.AutoSize = true;
            this.vehicle.Location = new System.Drawing.Point(266, 157);
            this.vehicle.Name = "vehicle";
            this.vehicle.Size = new System.Drawing.Size(35, 13);
            this.vehicle.TabIndex = 7;
            this.vehicle.Text = "label1";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(419, 93);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(35, 13);
            this.status.TabIndex = 8;
            this.status.Text = "label1";
            // 
            // TodayTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.status);
            this.Controls.Add(this.vehicle);
            this.Controls.Add(this.driver);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Controls.Add(this.customerPhone);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.order);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TodayTasks";
            this.Size = new System.Drawing.Size(551, 215);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label order;
        private System.Windows.Forms.Label customer;
        private System.Windows.Forms.Label customerPhone;
        private System.Windows.Forms.Label from;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.Label driver;
        private System.Windows.Forms.Label vehicle;
        private System.Windows.Forms.Label status;
    }
}
