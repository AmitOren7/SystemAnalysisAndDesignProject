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
            this.orderlbl = new System.Windows.Forms.Label();
            this.customer = new System.Windows.Forms.Label();
            this.customerPhone = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.Label();
            this.driver = new System.Windows.Forms.Label();
            this.vehicle = new System.Windows.Forms.Label();
            this.orderStatusCombo = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.currentorderstatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(730, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // orderlbl
            // 
            this.orderlbl.AutoSize = true;
            this.orderlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderlbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.orderlbl.Location = new System.Drawing.Point(172, 44);
            this.orderlbl.Name = "orderlbl";
            this.orderlbl.Size = new System.Drawing.Size(57, 21);
            this.orderlbl.TabIndex = 1;
            this.orderlbl.Text = "label1";
            // 
            // customer
            // 
            this.customer.AutoSize = true;
            this.customer.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.customer.Location = new System.Drawing.Point(174, 79);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(39, 17);
            this.customer.TabIndex = 2;
            this.customer.Text = "label1";
            // 
            // customerPhone
            // 
            this.customerPhone.AutoSize = true;
            this.customerPhone.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPhone.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.customerPhone.Location = new System.Drawing.Point(173, 114);
            this.customerPhone.Name = "customerPhone";
            this.customerPhone.Size = new System.Drawing.Size(39, 17);
            this.customerPhone.TabIndex = 3;
            this.customerPhone.Text = "label1";
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.from.Location = new System.Drawing.Point(173, 149);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(39, 17);
            this.from.TabIndex = 4;
            this.from.Text = "label1";
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.to.Location = new System.Drawing.Point(173, 184);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(39, 17);
            this.to.TabIndex = 5;
            this.to.Text = "label1";
            // 
            // driver
            // 
            this.driver.AutoSize = true;
            this.driver.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driver.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.driver.Location = new System.Drawing.Point(514, 123);
            this.driver.Name = "driver";
            this.driver.Size = new System.Drawing.Size(39, 17);
            this.driver.TabIndex = 6;
            this.driver.Text = "label1";
            // 
            // vehicle
            // 
            this.vehicle.AutoSize = true;
            this.vehicle.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.vehicle.Location = new System.Drawing.Point(514, 153);
            this.vehicle.Name = "vehicle";
            this.vehicle.Size = new System.Drawing.Size(39, 17);
            this.vehicle.TabIndex = 7;
            this.vehicle.Text = "label1";
            // 
            // orderStatusCombo
            // 
            this.orderStatusCombo.FormattingEnabled = true;
            this.orderStatusCombo.Location = new System.Drawing.Point(514, 86);
            this.orderStatusCombo.Name = "orderStatusCombo";
            this.orderStatusCombo.Size = new System.Drawing.Size(121, 21);
            this.orderStatusCombo.TabIndex = 8;
            this.orderStatusCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.status.Location = new System.Drawing.Point(511, 44);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(73, 17);
            this.status.TabIndex = 9;
            this.status.Text = "Select Satus";
            // 
            // save
            // 
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.ForeColor = System.Drawing.Color.Transparent;
            this.save.Image = ((System.Drawing.Image)(resources.GetObject("save.Image")));
            this.save.Location = new System.Drawing.Point(612, 33);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(47, 47);
            this.save.TabIndex = 21;
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // currentorderstatus
            // 
            this.currentorderstatus.AutoSize = true;
            this.currentorderstatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentorderstatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.currentorderstatus.Location = new System.Drawing.Point(514, 183);
            this.currentorderstatus.Name = "currentorderstatus";
            this.currentorderstatus.Size = new System.Drawing.Size(45, 17);
            this.currentorderstatus.TabIndex = 22;
            this.currentorderstatus.Text = "label1";
            // 
            // TodayTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.currentorderstatus);
            this.Controls.Add(this.save);
            this.Controls.Add(this.status);
            this.Controls.Add(this.orderStatusCombo);
            this.Controls.Add(this.vehicle);
            this.Controls.Add(this.driver);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Controls.Add(this.customerPhone);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.orderlbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TodayTasks";
            this.Size = new System.Drawing.Size(749, 257);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label orderlbl;
        private System.Windows.Forms.Label customer;
        private System.Windows.Forms.Label customerPhone;
        private System.Windows.Forms.Label from;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.Label driver;
        private System.Windows.Forms.Label vehicle;
        private System.Windows.Forms.ComboBox orderStatusCombo;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label currentorderstatus;
    }
}
