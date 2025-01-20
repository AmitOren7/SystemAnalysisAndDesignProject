namespace SystemAnalysisAndDesignProject
{
    partial class AlternativeVahicles
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
            this.FormHeadline = new System.Windows.Forms.Label();
            this.driversGrid = new System.Windows.Forms.DataGridView();
            this.vehiclesGrid = new System.Windows.Forms.DataGridView();
            this.dribersHeadline = new System.Windows.Forms.Label();
            this.vehiclesHeadkinr = new System.Windows.Forms.Label();
            this.driversdescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.driversGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FormHeadline
            // 
            this.FormHeadline.AutoSize = true;
            this.FormHeadline.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormHeadline.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormHeadline.Location = new System.Drawing.Point(221, 39);
            this.FormHeadline.Name = "FormHeadline";
            this.FormHeadline.Size = new System.Drawing.Size(312, 45);
            this.FormHeadline.TabIndex = 0;
            this.FormHeadline.Text = "Alternative Options";
            // 
            // driversGrid
            // 
            this.driversGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.driversGrid.Location = new System.Drawing.Point(64, 185);
            this.driversGrid.Name = "driversGrid";
            this.driversGrid.Size = new System.Drawing.Size(240, 150);
            this.driversGrid.TabIndex = 1;
            // 
            // vehiclesGrid
            // 
            this.vehiclesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehiclesGrid.Location = new System.Drawing.Point(467, 185);
            this.vehiclesGrid.Name = "vehiclesGrid";
            this.vehiclesGrid.Size = new System.Drawing.Size(240, 150);
            this.vehiclesGrid.TabIndex = 2;
            // 
            // dribersHeadline
            // 
            this.dribersHeadline.AutoSize = true;
            this.dribersHeadline.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dribersHeadline.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.dribersHeadline.Location = new System.Drawing.Point(59, 109);
            this.dribersHeadline.Name = "dribersHeadline";
            this.dribersHeadline.Size = new System.Drawing.Size(80, 25);
            this.dribersHeadline.TabIndex = 3;
            this.dribersHeadline.Text = "Drivers ";
            // 
            // vehiclesHeadkinr
            // 
            this.vehiclesHeadkinr.AutoSize = true;
            this.vehiclesHeadkinr.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.vehiclesHeadkinr.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.vehiclesHeadkinr.Location = new System.Drawing.Point(462, 109);
            this.vehiclesHeadkinr.Name = "vehiclesHeadkinr";
            this.vehiclesHeadkinr.Size = new System.Drawing.Size(184, 25);
            this.vehiclesHeadkinr.TabIndex = 4;
            this.vehiclesHeadkinr.Text = "Alternative Vehicles";
            // 
            // driversdescription
            // 
            this.driversdescription.AutoSize = true;
            this.driversdescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.driversdescription.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.driversdescription.Location = new System.Drawing.Point(61, 134);
            this.driversdescription.Name = "driversdescription";
            this.driversdescription.Size = new System.Drawing.Size(187, 34);
            this.driversdescription.TabIndex = 5;
            this.driversdescription.Text = "Presanting drivers attached to \r\nunproper vehicles";
            // 
            // AlternativeVahicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.driversdescription);
            this.Controls.Add(this.vehiclesHeadkinr);
            this.Controls.Add(this.dribersHeadline);
            this.Controls.Add(this.vehiclesGrid);
            this.Controls.Add(this.driversGrid);
            this.Controls.Add(this.FormHeadline);
            this.Name = "AlternativeVahicles";
            this.Text = "AlternativeVahicles";
            this.Load += new System.EventHandler(this.AlternativeVahicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.driversGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormHeadline;
        private System.Windows.Forms.DataGridView driversGrid;
        private System.Windows.Forms.DataGridView vehiclesGrid;
        private System.Windows.Forms.Label dribersHeadline;
        private System.Windows.Forms.Label vehiclesHeadkinr;
        private System.Windows.Forms.Label driversdescription;
    }
}