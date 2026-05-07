namespace CampusResolve
{
    partial class StaffDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.dgvAssignedComplaints = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.lblStats = new System.Windows.Forms.Label();
            this.lblPending = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedComplaints)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnLogout);
            this.panelTop.Controls.Add(this.lblWelcome);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(982, 60);
            this.panelTop.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(850, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 40);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(117, 16);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Staff Dashboard";
            // 
            // dgvAssignedComplaints
            // 
            this.dgvAssignedComplaints.AllowUserToAddRows = false;
            this.dgvAssignedComplaints.AllowUserToDeleteRows = false;
            this.dgvAssignedComplaints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssignedComplaints.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvAssignedComplaints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedComplaints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTitle,
            this.colCategory,
            this.colPriority,
            this.colStatus});
            this.dgvAssignedComplaints.Location = new System.Drawing.Point(20, 180);
            this.dgvAssignedComplaints.Name = "dgvAssignedComplaints";
            this.dgvAssignedComplaints.ReadOnly = true;
            this.dgvAssignedComplaints.RowHeadersVisible = false;
            this.dgvAssignedComplaints.Size = new System.Drawing.Size(930, 350);
            this.dgvAssignedComplaints.TabIndex = 1;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            // 
            // colPriority
            // 
            this.colPriority.HeaderText = "Priority";
            this.colPriority.Name = "colPriority";
            this.colPriority.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStatus.Location = new System.Drawing.Point(20, 550);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(150, 40);
            this.btnUpdateStatus.TabIndex = 2;
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Location = new System.Drawing.Point(20, 80);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(61, 16);
            this.lblStats.TabIndex = 4;
            this.lblStats.Text = "Statistics";
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.Location = new System.Drawing.Point(20, 110);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(116, 16);
            this.lblPending.TabIndex = 5;
            this.lblPending.Text = "Assigned Issues: --";
            // 
            // StaffDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 613);
            this.Controls.Add(this.lblPending);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.dgvAssignedComplaints);
            this.Controls.Add(this.panelTop);
            this.Name = "StaffDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CampusResolve - Staff";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StaffDashboardForm_FormClosed);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedComplaints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dgvAssignedComplaints;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Label lblPending;
    }
}
