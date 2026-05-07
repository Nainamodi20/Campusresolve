using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CampusResolve
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            this.BackColor = Theme.LightBeige;
            panelRegisterBox.BackColor = Theme.SoftPeach;

            lblTitle.ForeColor = Theme.DeepNavy;
            lblUsername.ForeColor = Theme.DeepNavy;
            lblPassword.ForeColor = Theme.DeepNavy;
            lblConfirmPassword.ForeColor = Theme.DeepNavy;

            btnRegister.BackColor = Theme.DarkBlue;
            btnRegister.ForeColor = Theme.SoftPeach;
            btnRegister.Font = Theme.ButtonFont;

            btnCancel.BackColor = Theme.MutedBrown;
            btnCancel.ForeColor = Theme.LightBeige;
            btnCancel.Font = Theme.ButtonFont;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text; // Storing as plain text per requirements
            string confirmPass = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("All fields are required.", "ValidationError", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPass)
            {
                MessageBox.Show("Passwords do not match.", "ValidationError", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Check if user exists anywhere
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
                    MessageBox.Show("Username already exists. Please choose another one.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Insert into DB. Standard users always go into the Usersinvp table.
                DatabaseHelper.ExecuteNonQuery(
                    "INSERT INTO Usersinvp (username, password) VALUES (@Username, @Password)",
                    new MySqlParameter("@Username", username),
                    new MySqlParameter("@Password", password));

                MessageBox.Show("Account successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Return to Login
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error during registration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
