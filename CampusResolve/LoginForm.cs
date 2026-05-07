using System;
using System.Windows.Forms;

namespace CampusResolve
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            this.BackColor = Theme.LightBeige;
            panelLoginBox.BackColor = Theme.DarkBlue;
            lblTitle.ForeColor = Theme.LightBeige;
            lblUsername.ForeColor = Theme.LightBeige;
            lblPassword.ForeColor = Theme.LightBeige;
            lblRole.ForeColor = Theme.LightBeige;

            btnLogin.BackColor = Theme.SoftPeach;
            btnLogin.ForeColor = Theme.DeepNavy;
            btnLogin.Font = Theme.ButtonFont;

            btnExit.BackColor = Theme.MutedBrown;
            btnExit.ForeColor = Theme.LightBeige;
            btnExit.Font = Theme.ButtonFont;

            lblTitle.Font = Theme.HeaderFont;
            lblUsername.Font = Theme.ContentFont;
            lblPassword.Font = Theme.ContentFont;
            lblRole.Font = Theme.ContentFont;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text; // Stored as plain text per requirements

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = @"
                    SELECT user_id AS id, username, 'User' AS role FROM Usersinvp WHERE username = @Username AND password = @Password
                    UNION ALL
                    SELECT staff_id AS id, username, 'Staff' AS role FROM Staff WHERE username = @Username AND password = @Password
                    UNION ALL
                    SELECT admin_id AS id, username, 'Admin' AS role FROM Admins WHERE username = @Username AND password = @Password
                ";

                var dt = DatabaseHelper.ExecuteQuery(query,
                    new MySql.Data.MySqlClient.MySqlParameter("@Username", username),
                    new MySql.Data.MySqlClient.MySqlParameter("@Password", password));

                if (dt.Rows.Count > 0)
                {
                    SessionManager.UserId = Convert.ToInt32(dt.Rows[0]["id"]);
                    SessionManager.Username = dt.Rows[0]["username"].ToString();
                    SessionManager.Role = dt.Rows[0]["role"].ToString();

                    if (SessionManager.Role == "Admin")
                    {
                        AdminDashboardForm adminForm = new AdminDashboardForm();
                        adminForm.Show();
                    }
                    else if (SessionManager.Role == "Staff")
                    {
                        StaffDashboardForm staffForm = new StaffDashboardForm();
                        staffForm.Show();
                    }
                    else
                    {
                        UserDashboardForm userForm = new UserDashboardForm();
                        userForm.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error during login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.ShowDialog();
        }
    }
}
