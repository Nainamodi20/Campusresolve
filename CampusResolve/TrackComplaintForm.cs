using System;
using System.Windows.Forms;

namespace CampusResolve
{
    public partial class TrackComplaintForm : Form
    {
        public TrackComplaintForm()
        {
            InitializeComponent();
            ApplyTheme();
            LoadData();
        }

        private void ApplyTheme()
        {
            this.BackColor = Theme.LightBeige;

            lblHeader.ForeColor = Theme.DarkBlue;
            lblHeader.Font = Theme.HeaderFont;

            btnSearch.BackColor = Theme.SoftPeach;
            btnSearch.ForeColor = Theme.DeepNavy;
            btnSearch.Font = Theme.ButtonFont;

            btnClose.BackColor = Theme.MutedBrown;
            btnClose.ForeColor = Theme.LightBeige;
            btnClose.Font = Theme.ButtonFont;

            txtSearch.Font = Theme.ContentFont;
            dgvComplaints.Font = Theme.ContentFont;
            dgvComplaints.ColumnHeadersDefaultCellStyle.Font = Theme.ButtonFont;
            dgvComplaints.ColumnHeadersDefaultCellStyle.BackColor = Theme.DarkBlue;
            dgvComplaints.ColumnHeadersDefaultCellStyle.ForeColor = Theme.LightBeige;
            dgvComplaints.EnableHeadersVisualStyles = false;
        }

        private void LoadData()
        {
            dgvComplaints.Rows.Clear();
            try
            {
                var dt = DatabaseHelper.ExecuteQuery(
                    "SELECT complaint_id, status, created_at FROM Complaints WHERE user_id = @UserId ORDER BY created_at DESC", 
                    new MySql.Data.MySqlClient.MySqlParameter("@UserId", SessionManager.UserId));

                foreach (System.Data.DataRow row in dt.Rows)
                {
                    string id = "COMP-" + row["complaint_id"].ToString();
                    string status = row["status"].ToString();
                    string date = Convert.ToDateTime(row["created_at"]).ToString("yyyy-MM-dd");
                    dgvComplaints.Rows.Add(id, status, date);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load complaints: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            foreach (DataGridViewRow row in dgvComplaints.Rows)
            {
                if (row.IsNewRow) continue;
                
                bool match = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(keyword))
                    {
                        match = true;
                        break;
                    }
                }
                
                row.Visible = match;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
