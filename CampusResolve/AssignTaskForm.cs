using System;
using System.Windows.Forms;

namespace CampusResolve
{
    public partial class AssignTaskForm : Form
    {
        public AssignTaskForm()
        {
            InitializeComponent();
            ApplyTheme();
            LoadStaff();
        }

        private void LoadStaff()
        {
            try
            {
                var dt = DatabaseHelper.ExecuteQuery("SELECT staff_id, username FROM Staff");
                cmbAssignTo.DisplayMember = "username";
                cmbAssignTo.ValueMember = "staff_id";
                cmbAssignTo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load staff list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyTheme()
        {
            this.BackColor = Theme.LightBeige;
            
            lblHeader.ForeColor = Theme.DarkBlue;
            lblHeader.Font = Theme.HeaderFont;

            lblComplaintID.ForeColor = Theme.DeepNavy;
            lblComplaintID.Font = Theme.SubHeaderFont;

            lblAssignTo.ForeColor = Theme.DeepNavy;
            lblAssignTo.Font = Theme.SubHeaderFont;

            lblDeadline.ForeColor = Theme.DeepNavy;
            lblDeadline.Font = Theme.SubHeaderFont;

            btnAssign.BackColor = Theme.SoftPeach;
            btnAssign.ForeColor = Theme.DeepNavy;
            btnAssign.Font = Theme.ButtonFont;

            btnCancel.BackColor = Theme.MutedBrown;
            btnCancel.ForeColor = Theme.LightBeige;
            btnCancel.Font = Theme.ButtonFont;

            txtComplaintID.Font = Theme.ContentFont;
            cmbAssignTo.Font = Theme.ContentFont;
            dtpDeadline.Font = Theme.ContentFont;
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtComplaintID.Text) || cmbAssignTo.SelectedItem == null)
            {
                MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtComplaintID.Text.Replace("COMP-", ""), out int complaintId))
            {
                MessageBox.Show("Invalid Complaint ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int staffId = Convert.ToInt32(cmbAssignTo.SelectedValue);
            DateTime deadline = dtpDeadline.Value;

            try
            {
                // Verify the complaint exists before assigning
                var dtComplaint = DatabaseHelper.ExecuteQuery("SELECT complaint_id FROM Complaints WHERE complaint_id = @ComplaintId",
                    new MySql.Data.MySqlClient.MySqlParameter("@ComplaintId", complaintId));
                
                if (dtComplaint.Rows.Count == 0)
                {
                    MessageBox.Show("Complaint ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DatabaseHelper.ExecuteNonQuery(
                    "INSERT INTO Assignments (complaint_id, assigned_to, deadline) VALUES (@ComplaintId, @StaffId, @Deadline)",
                    new MySql.Data.MySqlClient.MySqlParameter("@ComplaintId", complaintId),
                    new MySql.Data.MySqlClient.MySqlParameter("@StaffId", staffId),
                    new MySql.Data.MySqlClient.MySqlParameter("@Deadline", deadline));

                MessageBox.Show("Task successfully assigned!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to assign task: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
