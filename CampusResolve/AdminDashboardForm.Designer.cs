namespace CampusResolve
{
    partial class AdminDashboardForm
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
            this.dgvAllComplaints = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAssignTask = new System.Windows.Forms.Button();
            this.btnViewReports = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.lblStats = new System.Windows.Forms.Label();
            this.lblPending = new System.Windows.Forms.Label();
            this.lblResolved = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllComplaints)).BeginInit();
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
            this.lblWelcome.Text = "Admin Dashboard";
            // 
            // dgvAllComplaints
            // 
            this.dgvAllComplaints.AllowUserToAddRows = false;
            this.dgvAllComplaints.AllowUserToDeleteRows = false;
            this.dgvAllComplaints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllComplaints.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvAllComplaints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllComplaints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTitle,
            this.colCategory,
            this.colPriority,
            this.colStatus});
            this.dgvAllComplaints.Location = new System.Drawing.Point(20, 180);
            this.dgvAllComplaints.Name = "dgvAllComplaints";
            this.dgvAllComplaints.ReadOnly = true;
            this.dgvAllComplaints.RowHeadersVisible = false;
            this.dgvAllComplaints.Size = new System.Drawing.Size(930, 350);
            this.dgvAllComplaints.TabIndex = 1;
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
            // btnAssignTask
            // 
            this.btnAssignTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignTask.Location = new System.Drawing.Point(20, 550);
            this.btnAssignTask.Name = "btnAssignTask";
            this.btnAssignTask.Size = new System.Drawing.Size(150, 40);
            this.btnAssignTask.TabIndex = 2;
            this.btnAssignTask.Text = "Assign Task";
            this.btnAssignTask.UseVisualStyleBackColor = true;
            this.btnAssignTask.Click += new System.EventHandler(this.btnAssignTask_Click);
            // 
            // btnViewReports
            // 
            this.btnViewReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReports.Location = new System.Drawing.Point(190, 550);
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.Size = new System.Drawing.Size(150, 40);
            this.btnViewReports.TabIndex = 3;
            this.btnViewReports.Text = "View Reports";
            this.btnViewReports.UseVisualStyleBackColor = true;
            this.btnViewReports.Click += new System.EventHandler(this.btnViewReports_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Location = new System.Drawing.Point(360, 550);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(150, 40);
            this.btnManageUsers.TabIndex = 7;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
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
            this.lblPending.Text = "Pending Issues: --";
            // 
            // lblResolved
            // 
            this.lblResolved.AutoSize = true;
            this.lblResolved.Location = new System.Drawing.Point(20, 140);
            this.lblResolved.Name = "lblResolved";
            this.lblResolved.Size = new System.Drawing.Size(123, 16);
            this.lblResolved.TabIndex = 6;
            this.lblResolved.Text = "Resolved Issues: --";
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 613);
            this.Controls.Add(this.lblResolved);
            this.Controls.Add(this.lblPending);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnViewReports);
            this.Controls.Add(this.btnAssignTask);
            this.Controls.Add(this.dgvAllComplaints);
            this.Controls.Add(this.panelTop);
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CampusResolve - Admin Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDashboardForm_FormClosed);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllComplaints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dgvAllComplaints;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Button btnAssignTask;
        private System.Windows.Forms.Button btnViewReports;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.Label lblResolved;
    }
}
