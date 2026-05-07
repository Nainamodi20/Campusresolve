using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusResolve
{
    public partial class ManageUsersForm : Form
    {
        public ManageUsersForm()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            this.BackColor = Theme.LightBeige;
            panelManageBox.BackColor = Theme.SoftPeach;

            lblTitle.ForeColor = Theme.DeepNavy;
            lblUsername.ForeColor = Theme.DeepNavy;
            lblPassword.ForeColor = Theme.DeepNavy;
            lblRole.ForeColor = Theme.DeepNavy;

            btnCreateAccount.BackColor = Theme.DarkBlue;
            btnCreateAccount.ForeColor = Theme.SoftPeach;
            btnCreateAccount.Font = Theme.ButtonFont;

            btnCancel.BackColor = Theme.MutedBrown;
            btnCancel.ForeColor = Theme.LightBeige;
            btnCancel.Font = Theme.ButtonFont;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (SessionManager.Role != "Admin")
            {
                MessageBox.Show("Unauthorized Action. Area restricted to Admins.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text; // Required as plain text
            
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || cmbRole.SelectedItem == null)
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string role = cmbRole.SelectedItem.ToString();

            try
            {
                string query = @"
                    SELECT username FROM Usersinvp WHERE username = @Username
                    UNION ALL
                    SELECT username FROM Staff WHERE username = @Username
                    UNION ALL
                    SELECT username FROM Admins WHERE username = @Username
                ";

                var existingUsers = DatabaseHelper.ExecuteQuery(query, new MySqlParameter("@Username", username));

                if (existingUsers.Rows.Count > 0)
                {
                    MessageBox.Show("Username already exists.", "Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (role == "Admin")
                {
                    DatabaseHelper.ExecuteNonQuery(
                        "INSERT INTO Admins (username, password) VALUES (@Username, @Password)",
                        new MySqlParameter("@Username", username),
                        new MySqlParameter("@Password", password));
                }
                else if (role == "Staff")
                {
                    DatabaseHelper.ExecuteNonQuery(
                        "INSERT INTO Staff (username, password) VALUES (@Username, @Password)",
                        new MySqlParameter("@Username", username),
                        new MySqlParameter("@Password", password));
                }

                MessageBox.Show($"{role} account successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                txtUsername.Clear();
                txtPassword.Clear();
                cmbRole.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
