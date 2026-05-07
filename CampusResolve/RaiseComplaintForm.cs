using System;
using System.Windows.Forms;

namespace CampusResolve
{
    public partial class RaiseComplaintForm : Form
    {
        public RaiseComplaintForm()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            this.BackColor = Theme.LightBeige;
            
            lblHeader.ForeColor = Theme.DarkBlue;
            lblHeader.Font = Theme.HeaderFont;

            lblTitle.ForeColor = Theme.DeepNavy;
            lblTitle.Font = Theme.SubHeaderFont;

            lblCategory.ForeColor = Theme.DeepNavy;
            lblCategory.Font = Theme.SubHeaderFont;

            lblOtherCategory.ForeColor = Theme.DeepNavy;
            lblOtherCategory.Font = Theme.SubHeaderFont;

            lblLocation.ForeColor = Theme.DeepNavy;
            lblLocation.Font = Theme.SubHeaderFont;

            lblPriority.ForeColor = Theme.DeepNavy;
            lblPriority.Font = Theme.SubHeaderFont;

            lblDescription.ForeColor = Theme.DeepNavy;
            lblDescription.Font = Theme.SubHeaderFont;

            btnSubmit.BackColor = Theme.SoftPeach;
            btnSubmit.ForeColor = Theme.DeepNavy;
            btnSubmit.Font = Theme.ButtonFont;

            btnCancel.BackColor = Theme.MutedBrown;
            btnCancel.ForeColor = Theme.LightBeige;
            btnCancel.Font = Theme.ButtonFont;

            txtTitle.Font = Theme.ContentFont;
            txtLocation.Font = Theme.ContentFont;
            txtOtherCategory.Font = Theme.ContentFont;
            txtDescription.Font = Theme.ContentFont;
            cmbCategory.Font = Theme.ContentFont;
            cmbPriority.Font = Theme.ContentFont;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem != null && cmbCategory.SelectedItem.ToString() == "Others")
            {
                lblOtherCategory.Visible = true;
                txtOtherCategory.Visible = true;
            }
            else
            {
                lblOtherCategory.Visible = false;
                txtOtherCategory.Visible = false;
                txtOtherCategory.Text = "";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || 
                string.IsNullOrWhiteSpace(txtLocation.Text) || 
                string.IsNullOrWhiteSpace(txtDescription.Text) || 
                cmbCategory.SelectedItem == null || 
                cmbPriority.SelectedItem == null ||
                (cmbCategory.SelectedItem.ToString() == "Others" && string.IsNullOrWhiteSpace(txtOtherCategory.Text)))
            {
                MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string title = txtTitle.Text.Trim();
                string category = cmbCategory.SelectedItem.ToString();
                string customCategory = category == "Others" ? txtOtherCategory.Text.Trim() : null;
                string location = txtLocation.Text.Trim();
                string priority = cmbPriority.SelectedItem.ToString();
                string description = txtDescription.Text.Trim();

                DatabaseHelper.ExecuteNonQuery(
                    "INSERT INTO Complaints (user_id, title, description, category, custom_category, location, priority) " +
                    "VALUES (@UserId, @Title, @Description, @Category, @CustomCategory, @Location, @Priority)",
                    new MySql.Data.MySqlClient.MySqlParameter("@UserId", SessionManager.UserId),
                    new MySql.Data.MySqlClient.MySqlParameter("@Title", title),
                    new MySql.Data.MySqlClient.MySqlParameter("@Description", description),
                    new MySql.Data.MySqlClient.MySqlParameter("@Category", category),
                    new MySql.Data.MySqlClient.MySqlParameter("@CustomCategory", customCategory),
                    new MySql.Data.MySqlClient.MySqlParameter("@Location", location),
                    new MySql.Data.MySqlClient.MySqlParameter("@Priority", priority)
                );

                MessageBox.Show("Complaint submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to submit complaint: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
