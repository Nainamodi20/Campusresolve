using System;
using System.Windows.Forms;

namespace CampusResolve
{
    public partial class StaffDashboardForm : Form
    {
        public StaffDashboardForm()
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
            lblWelcome.Text = "Staff Dashboard - " + SessionManager.Username;

            lblStats.ForeColor = Theme.DeepNavy;
            lblStats.Font = Theme.HeaderFont;

            lblPending.ForeColor = Theme.DarkBlue;
            lblPending.Font = Theme.SubHeaderFont;

            btnUpdateStatus.BackColor = Theme.SoftPeach;
            btnUpdateStatus.ForeColor = Theme.DeepNavy;
            btnUpdateStatus.Font = Theme.ButtonFont;

            btnLogout.BackColor = Theme.MutedBrown;
            btnLogout.ForeColor = Theme.LightBeige;
            btnLogout.Font = Theme.ButtonFont;

            dgvAssignedComplaints.Font = Theme.ContentFont;
            dgvAssignedComplaints.ColumnHeadersDefaultCellStyle.Font = Theme.ButtonFont;
            dgvAssignedComplaints.ColumnHeadersDefaultCellStyle.BackColor = Theme.DarkBlue;
            dgvAssignedComplaints.ColumnHeadersDefaultCellStyle.ForeColor = Theme.LightBeige;
            dgvAssignedComplaints.EnableHeadersVisualStyles = false;
        }

        private void LoadData()
        {
            dgvAssignedComplaints.Rows.Clear();
            int assignedCount = 0;

            try
            {
                var dt = DatabaseHelper.ExecuteQuery(
                    "SELECT c.complaint_id, c.title, c.category, c.priority, c.status " +
                    "FROM Complaints c " +
                    "INNER JOIN Assignments a ON c.complaint_id = a.complaint_id " +
                    "WHERE a.assigned_to = @StaffId ORDER BY a.assigned_at DESC",
                    new MySql.Data.MySqlClient.MySqlParameter("@StaffId", SessionManager.UserId));

                foreach (System.Data.DataRow row in dt.Rows)
                {
                    string id = "COMP-" + row["complaint_id"].ToString();
                    string title = row["title"].ToString();
                    string category = row["category"].ToString();
                    string priority = row["priority"].ToString();
                    string status = row["status"].ToString();

                    dgvAssignedComplaints.Rows.Add(id, title, category, priority, status);
                    assignedCount++;
                }

                lblPending.Text = "Assigned Issues: " + assignedCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load assigned tasks: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            UpdateStatusForm form = new UpdateStatusForm();
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["LoginForm"]?.Show();
        }

        private void StaffDashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["LoginForm"]?.Show();
        }
    }
}
