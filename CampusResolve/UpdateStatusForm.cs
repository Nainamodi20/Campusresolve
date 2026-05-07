using System;
using System.Windows.Forms;

namespace CampusResolve
{
    public partial class UpdateStatusForm : Form
    {
        public UpdateStatusForm()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            this.BackColor = Theme.LightBeige;
            
            lblHeader.ForeColor = Theme.DarkBlue;
            lblHeader.Font = Theme.HeaderFont;

            lblComplaintID.ForeColor = Theme.DeepNavy;
            lblComplaintID.Font = Theme.SubHeaderFont;

            lblStatus.ForeColor = Theme.DeepNavy;
            lblStatus.Font = Theme.SubHeaderFont;

            btnUpdate.BackColor = Theme.SoftPeach;
            btnUpdate.ForeColor = Theme.DeepNavy;
            btnUpdate.Font = Theme.ButtonFont;

            btnCancel.BackColor = Theme.MutedBrown;
            btnCancel.ForeColor = Theme.LightBeige;
            btnCancel.Font = Theme.ButtonFont;

            txtComplaintID.Font = Theme.ContentFont;
            cmbStatus.Font = Theme.ContentFont;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtComplaintID.Text) || cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtComplaintID.Text.Replace("COMP-", ""), out int complaintId))
            {
                MessageBox.Show("Invalid Complaint ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newStatus = cmbStatus.SelectedItem.ToString();

            try
            {
                // Verify the complaint is assigned to this staff member
                var dtAssignment = DatabaseHelper.ExecuteQuery(
                    "SELECT assignment_id FROM Assignments WHERE complaint_id = @ComplaintId AND assigned_to = @StaffId",
                    new MySql.Data.MySqlClient.MySqlParameter("@ComplaintId", complaintId),
                    new MySql.Data.MySqlClient.MySqlParameter("@StaffId", SessionManager.UserId));

                if (dtAssignment.Rows.Count == 0)
                {
                    MessageBox.Show("This complaint is not assigned to you.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update Complaints table
                DatabaseHelper.ExecuteNonQuery(
                    "UPDATE Complaints SET status = @Status WHERE complaint_id = @ComplaintId",
                    new MySql.Data.MySqlClient.MySqlParameter("@Status", newStatus),
                    new MySql.Data.MySqlClient.MySqlParameter("@ComplaintId", complaintId));

                // Insert into Status_Updates
                DatabaseHelper.ExecuteNonQuery(
                    "INSERT INTO Status_Updates (complaint_id, status, updated_by) VALUES (@ComplaintId, @Status, @UpdatedBy)",
                    new MySql.Data.MySqlClient.MySqlParameter("@ComplaintId", complaintId),
                    new MySql.Data.MySqlClient.MySqlParameter("@Status", newStatus),
                    new MySql.Data.MySqlClient.MySqlParameter("@UpdatedBy", SessionManager.UserId));

                MessageBox.Show("Status successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update status: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
