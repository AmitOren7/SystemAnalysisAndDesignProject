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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlternativeVahicles));
            this.FormHeadline = new System.Windows.Forms.Label();
            this.driversGrid = new System.Windows.Forms.DataGridView();
            this.vehiclesGrid = new System.Windows.Forms.DataGridView();
            this.dribersHeadline = new System.Windows.Forms.Label();
            this.vehiclesHeadline = new System.Windows.Forms.Label();
            this.NameSearch = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.refreshDriversButton = new System.Windows.Forms.Button();
            this.assignButton = new System.Windows.Forms.Button();
            this.clerksComboBox = new System.Windows.Forms.ComboBox();
            this.clerksheadline = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
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
            this.driversGrid.Location = new System.Drawing.Point(88, 175);
            this.driversGrid.Name = "driversGrid";
            this.driversGrid.Size = new System.Drawing.Size(431, 150);
            this.driversGrid.TabIndex = 1;
            this.driversGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.driversGrid_CellClick);
            // 
            // vehiclesGrid
            // 
            this.vehiclesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehiclesGrid.Location = new System.Drawing.Point(88, 454);
            this.vehiclesGrid.Name = "vehiclesGrid";
            this.vehiclesGrid.Size = new System.Drawing.Size(431, 136);
            this.vehiclesGrid.TabIndex = 2;
            this.vehiclesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vehiclesGrid_CellClick);
            // 
            // dribersHeadline
            // 
            this.dribersHeadline.AutoSize = true;
            this.dribersHeadline.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dribersHeadline.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.dribersHeadline.Location = new System.Drawing.Point(83, 104);
            this.dribersHeadline.Name = "dribersHeadline";
            this.dribersHeadline.Size = new System.Drawing.Size(80, 25);
            this.dribersHeadline.TabIndex = 3;
            this.dribersHeadline.Text = "Drivers ";
            // 
            // vehiclesHeadline
            // 
            this.vehiclesHeadline.AutoSize = true;
            this.vehiclesHeadline.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.vehiclesHeadline.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.vehiclesHeadline.Location = new System.Drawing.Point(83, 397);
            this.vehiclesHeadline.Name = "vehiclesHeadline";
            this.vehiclesHeadline.Size = new System.Drawing.Size(184, 25);
            this.vehiclesHeadline.TabIndex = 4;
            this.vehiclesHeadline.Text = "Alternative Vehicles";
            // 
            // NameSearch
            // 
            this.NameSearch.Location = new System.Drawing.Point(88, 132);
            this.NameSearch.Name = "NameSearch";
            this.NameSearch.Size = new System.Drawing.Size(135, 20);
            this.NameSearch.TabIndex = 6;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SearchButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.SearchButton.Location = new System.Drawing.Point(253, 132);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(72, 20);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // refreshDriversButton
            // 
            this.refreshDriversButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.refreshDriversButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.refreshDriversButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.refreshDriversButton.Location = new System.Drawing.Point(301, 340);
            this.refreshDriversButton.Name = "refreshDriversButton";
            this.refreshDriversButton.Size = new System.Drawing.Size(119, 33);
            this.refreshDriversButton.TabIndex = 8;
            this.refreshDriversButton.Text = "Refresh Drivers";
            this.refreshDriversButton.UseVisualStyleBackColor = false;
            this.refreshDriversButton.Click += new System.EventHandler(this.refreshDriversButton_Click);
            // 
            // assignButton
            // 
            this.assignButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.assignButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.assignButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.assignButton.Location = new System.Drawing.Point(671, 617);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(78, 33);
            this.assignButton.TabIndex = 13;
            this.assignButton.Text = "Assign";
            this.assignButton.UseVisualStyleBackColor = false;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // clerksComboBox
            // 
            this.clerksComboBox.FormattingEnabled = true;
            this.clerksComboBox.Location = new System.Drawing.Point(551, 175);
            this.clerksComboBox.Name = "clerksComboBox";
            this.clerksComboBox.Size = new System.Drawing.Size(147, 21);
            this.clerksComboBox.TabIndex = 14;
            this.clerksComboBox.SelectedIndexChanged += new System.EventHandler(this.clerkscombobox_SelectedIndexChanged);
            // 
            // clerksheadline
            // 
            this.clerksheadline.AutoSize = true;
            this.clerksheadline.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clerksheadline.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.clerksheadline.Location = new System.Drawing.Point(546, 116);
            this.clerksheadline.Name = "clerksheadline";
            this.clerksheadline.Size = new System.Drawing.Size(66, 25);
            this.clerksheadline.TabIndex = 15;
            this.clerksheadline.Text = "Clerks";
            // 
            // BackButton
            // 
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(706, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(43, 37);
            this.BackButton.TabIndex = 50;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AlternativeVahicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(761, 662);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.clerksheadline);
            this.Controls.Add(this.clerksComboBox);
            this.Controls.Add(this.assignButton);
            this.Controls.Add(this.refreshDriversButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.NameSearch);
            this.Controls.Add(this.vehiclesHeadline);
            this.Controls.Add(this.dribersHeadline);
            this.Controls.Add(this.vehiclesGrid);
            this.Controls.Add(this.driversGrid);
            this.Controls.Add(this.FormHeadline);
            this.Name = "AlternativeVahicles";
            this.Text = "AlternativeVahicles";
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
        private System.Windows.Forms.Label vehiclesHeadline;
        private System.Windows.Forms.TextBox NameSearch;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button refreshDriversButton;
        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.ComboBox clerksComboBox;
        private System.Windows.Forms.Label clerksheadline;
        private System.Windows.Forms.Button BackButton;
    }
}