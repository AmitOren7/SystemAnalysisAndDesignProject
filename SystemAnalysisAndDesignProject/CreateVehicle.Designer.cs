namespace SystemAnalysisAndDesignProject
{
    partial class CreateVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateVehicle));
            this.id = new System.Windows.Forms.Label();
            this.VehicleType = new System.Windows.Forms.Label();
            this.CargoType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TestDate = new System.Windows.Forms.Label();
            this.maxcapacitytext = new System.Windows.Forms.TextBox();
            this.testdatetext = new System.Windows.Forms.TextBox();
            this.IDtext = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.vehicletypebox = new System.Windows.Forms.ComboBox();
            this.cargotypebox = new System.Windows.Forms.ComboBox();
            this.FormHeadline = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.id.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.id.Location = new System.Drawing.Point(72, 70);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(75, 21);
            this.id.TabIndex = 0;
            this.id.Text = "Vehicle ID";
            // 
            // VehicleType
            // 
            this.VehicleType.AutoSize = true;
            this.VehicleType.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.VehicleType.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.VehicleType.Location = new System.Drawing.Point(72, 149);
            this.VehicleType.Name = "VehicleType";
            this.VehicleType.Size = new System.Drawing.Size(91, 21);
            this.VehicleType.TabIndex = 1;
            this.VehicleType.Text = "Vehicle Type";
            // 
            // CargoType
            // 
            this.CargoType.AutoSize = true;
            this.CargoType.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CargoType.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.CargoType.Location = new System.Drawing.Point(72, 228);
            this.CargoType.Name = "CargoType";
            this.CargoType.Size = new System.Drawing.Size(86, 21);
            this.CargoType.TabIndex = 2;
            this.CargoType.Text = "Cargo Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(368, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Max Capacity";
            // 
            // TestDate
            // 
            this.TestDate.AutoSize = true;
            this.TestDate.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TestDate.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.TestDate.Location = new System.Drawing.Point(368, 149);
            this.TestDate.Name = "TestDate";
            this.TestDate.Size = new System.Drawing.Size(100, 21);
            this.TestDate.TabIndex = 5;
            this.TestDate.Text = "Last Test Date";
            // 
            // maxcapacitytext
            // 
            this.maxcapacitytext.Location = new System.Drawing.Point(372, 98);
            this.maxcapacitytext.Name = "maxcapacitytext";
            this.maxcapacitytext.Size = new System.Drawing.Size(144, 20);
            this.maxcapacitytext.TabIndex = 6;
            // 
            // testdatetext
            // 
            this.testdatetext.Location = new System.Drawing.Point(372, 177);
            this.testdatetext.Name = "testdatetext";
            this.testdatetext.Size = new System.Drawing.Size(144, 20);
            this.testdatetext.TabIndex = 8;
            this.testdatetext.TextChanged += new System.EventHandler(this.testdatetext_TextChanged);
            // 
            // IDtext
            // 
            this.IDtext.Location = new System.Drawing.Point(76, 98);
            this.IDtext.Name = "IDtext";
            this.IDtext.Size = new System.Drawing.Size(144, 20);
            this.IDtext.TabIndex = 9;
            // 
            // save
            // 
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.ForeColor = System.Drawing.Color.Black;
            this.save.Image = ((System.Drawing.Image)(resources.GetObject("save.Image")));
            this.save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.Location = new System.Drawing.Point(613, 357);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(136, 57);
            this.save.TabIndex = 76;
            this.save.UseVisualStyleBackColor = true;
            this.save.Visible = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // back
            // 
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(717, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(43, 37);
            this.back.TabIndex = 77;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // vehicletypebox
            // 
            this.vehicletypebox.FormattingEnabled = true;
            this.vehicletypebox.Location = new System.Drawing.Point(76, 175);
            this.vehicletypebox.Name = "vehicletypebox";
            this.vehicletypebox.Size = new System.Drawing.Size(144, 21);
            this.vehicletypebox.TabIndex = 78;
            // 
            // cargotypebox
            // 
            this.cargotypebox.FormattingEnabled = true;
            this.cargotypebox.Location = new System.Drawing.Point(76, 262);
            this.cargotypebox.Name = "cargotypebox";
            this.cargotypebox.Size = new System.Drawing.Size(144, 21);
            this.cargotypebox.TabIndex = 79;
            // 
            // FormHeadline
            // 
            this.FormHeadline.AutoSize = true;
            this.FormHeadline.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.FormHeadline.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormHeadline.Location = new System.Drawing.Point(43, 16);
            this.FormHeadline.Name = "FormHeadline";
            this.FormHeadline.Size = new System.Drawing.Size(130, 28);
            this.FormHeadline.TabIndex = 102;
            this.FormHeadline.Text = "Create Vehicle";
            this.FormHeadline.Click += new System.EventHandler(this.FormHeadline_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(16, -15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(769, 481);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 103;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(543, 332);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(217, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 104;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.save_Click);
            // 
            // CreateVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cargotypebox);
            this.Controls.Add(this.vehicletypebox);
            this.Controls.Add(this.back);
            this.Controls.Add(this.save);
            this.Controls.Add(this.IDtext);
            this.Controls.Add(this.testdatetext);
            this.Controls.Add(this.maxcapacitytext);
            this.Controls.Add(this.TestDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CargoType);
            this.Controls.Add(this.VehicleType);
            this.Controls.Add(this.id);
            this.Controls.Add(this.FormHeadline);
            this.Controls.Add(this.pictureBox3);
            this.Name = "CreateVehicle";
            this.Load += new System.EventHandler(this.CreateVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label VehicleType;
        private System.Windows.Forms.Label CargoType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TestDate;
        private System.Windows.Forms.TextBox maxcapacitytext;
        private System.Windows.Forms.TextBox testdatetext;
        private System.Windows.Forms.TextBox IDtext;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox vehicletypebox;
        private System.Windows.Forms.ComboBox cargotypebox;
        private System.Windows.Forms.Label FormHeadline;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}