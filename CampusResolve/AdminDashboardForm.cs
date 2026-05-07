using System;
using System.Windows.Forms;

namespace CampusResolve
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
            ApplyTheme();
            LoadData();
        }

        private void ApplyTheme()
        {
            this.BackColor = Theme.LightBeige;
            panelTop.BackColor = Theme.DeepNavy;
            
            lblWelcome.ForeColor = Theme.LightBeige;
            lblWelcome.Font = Theme.HeaderFont;

            lblStats.ForeColor = Theme.DeepNavy;
            lblStats.Font = Theme.HeaderFont;

            lblPending.ForeColor = Theme.DarkBlue;
            lblPending.Font = Theme.SubHeaderFont;

            lblResolved.ForeColor = Theme.DarkBlue;
            lblResolved.Font = Theme.SubHeaderFont;

            btnAssignTask.BackColor = Theme.SoftPeach;
            btnAssignTask.ForeColor = Theme.DeepNavy;
            btnAssignTask.Font = Theme.ButtonFont;

            btnViewReports.BackColor = Theme.SoftPeach;
            btnViewReports.ForeColor = Theme.DeepNavy;
            btnViewReports.Font = Theme.ButtonFont;

            btnLogout.BackColor = Theme.MutedBrown;
            btnLogout.ForeColor = Theme.LightBeige;
            btnLogout.Font = Theme.ButtonFont;

            btnManageUsers.BackColor = Theme.SoftPeach;
            btnManageUsers.ForeColor = Theme.DeepNavy;
            btnManageUsers.Font = Theme.ButtonFont;

            dgvAllComplaints.Font = Theme.ContentFont;
            dgvAllComplaints.ColumnHeadersDefaultCellStyle.Font = Theme.ButtonFont;
            dgvAllComplaints.ColumnHeadersDefaultCellStyle.BackColor = Theme.DarkBlue;
            dgvAllComplaints.ColumnHeadersDefaultCellStyle.ForeColor = Theme.LightBeige;
            dgvAllComplaints.EnableHeadersVisualStyles = false;
        }

        private void LoadData()
        {
            dgvAllComplaints.Rows.Clear();
            int pendingCount = 0;
            int resolvedCount = 0;

            try
            {
                var dt = DatabaseHelper.ExecuteQuery("SELECT complaint_id, title, category, priority, status FROM Complaints ORDER BY created_at DESC");

                foreach (System.Data.DataRow row in dt.Rows)
                {
                    string id = "COMP-" + row["complaint_id"].ToString();
                    string title = row["title"].ToString();
                    string category = row["category"].ToString();
                    string priority = row["priority"].ToString();
                    string status = row["status"].ToString();

                    dgvAllComplaints.Rows.Add(id, title, category, priority, status);

                    if (status == "Pending") pendingCount++;
                    if (status == "Resolved") resolvedCount++;
                }

                lblPending.Text = "Pending Issues: " + pendingCount;
                lblResolved.Text = "Resolved Issues: " + resolvedCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load dashboard data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            ManageUsersForm form = new ManageUsersForm();
            form.ShowDialog();
        }

        private void btnAssignTask_Click(object sender, EventArgs e)
        {
            AssignTaskForm form = new AssignTaskForm();
            form.ShowDialog();
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Displaying system statistics and reports...", "Reports", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["LoginForm"]?.Show();
        }

        private void AdminDashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["LoginForm"]?.Show();
        }
    }
}
