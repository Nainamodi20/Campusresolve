namespace CampusResolve
{
    partial class UserDashboardForm
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
            this.panelNav = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnViewReports = new System.Windows.Forms.Button();
            this.btnTrackComplaint = new System.Windows.Forms.Button();
            this.btnRaiseComplaint = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.labelPlaceholder = new System.Windows.Forms.Label();
            this.panelNav.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.Controls.Add(this.btnLogout);
            this.panelNav.Controls.Add(this.btnViewReports);
            this.panelNav.Controls.Add(this.btnTrackComplaint);
            this.panelNav.Controls.Add(this.btnRaiseComplaint);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 60);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(200, 493);
            this.panelNav.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(0, 443);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 50);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnViewReports
            // 
            this.btnViewReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReports.Location = new System.Drawing.Point(0, 100);
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.Size = new System.Drawing.Size(200, 50);
            this.btnViewReports.TabIndex = 2;
            this.btnViewReports.Text = "View Reports";
            this.btnViewReports.UseVisualStyleBackColor = true;
            this.btnViewReports.Click += new System.EventHandler(this.btnViewReports_Click);
            // 
            // btnTrackComplaint
            // 
            this.btnTrackComplaint.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrackComplaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrackComplaint.Location = new System.Drawing.Point(0, 50);
            this.btnTrackComplaint.Name = "btnTrackComplaint";
            this.btnTrackComplaint.Size = new System.Drawing.Size(200, 50);
            this.btnTrackComplaint.TabIndex = 1;
            this.btnTrackComplaint.Text = "Track Complaint";
            this.btnTrackComplaint.UseVisualStyleBackColor = true;
            this.btnTrackComplaint.Click += new System.EventHandler(this.btnTrackComplaint_Click);
            // 
            // btnRaiseComplaint
            // 
            this.btnRaiseComplaint.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRaiseComplaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaiseComplaint.Location = new System.Drawing.Point(0, 0);
            this.btnRaiseComplaint.Name = "btnRaiseComplaint";
            this.btnRaiseComplaint.Size = new System.Drawing.Size(200, 50);
            this.btnRaiseComplaint.TabIndex = 0;
            this.btnRaiseComplaint.Text = "Raise Complaint";
            this.btnRaiseComplaint.UseVisualStyleBackColor = true;
            this.btnRaiseComplaint.Click += new System.EventHandler(this.btnRaiseComplaint_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblWelcome);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(882, 60);
            this.panelTop.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(100, 16);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, User";
            // 
            // labelPlaceholder
            // 
            this.labelPlaceholder.AutoSize = true;
            this.labelPlaceholder.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaceholder.ForeColor = System.Drawing.Color.Gray;
            this.labelPlaceholder.Location = new System.Drawing.Point(400, 250);
            this.labelPlaceholder.Name = "labelPlaceholder";
            this.labelPlaceholder.Size = new System.Drawing.Size(273, 37);
            this.labelPlaceholder.TabIndex = 2;
            this.labelPlaceholder.Text = "Select an option from the left";
            // 
            // UserDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.labelPlaceholder);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.panelTop);
            this.Name = "UserDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CampusResolve - Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserDashboardForm_FormClosed);
            this.panelNav.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button btnRaiseComplaint;
        private System.Windows.Forms.Button btnTrackComplaint;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnViewReports;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label labelPlaceholder;
    }
}
