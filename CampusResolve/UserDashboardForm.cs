using System;
using System.Windows.Forms;

namespace CampusResolve
{
    public partial class UserDashboardForm : Form
    {
        public UserDashboardForm()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            this.BackColor = Theme.LightBeige;
            panelNav.BackColor = Theme.DarkBlue;
            panelTop.BackColor = Theme.DeepNavy;
            
            lblWelcome.ForeColor = Theme.LightBeige;
            lblWelcome.Font = Theme.HeaderFont;
            lblWelcome.Text = "Welcome, " + SessionManager.Username;

            btnRaiseComplaint.BackColor = Theme.DarkBlue;
            btnRaiseComplaint.ForeColor = Theme.SoftPeach;
            btnRaiseComplaint.Font = Theme.ButtonFont;

            btnTrackComplaint.BackColor = Theme.DarkBlue;
            btnTrackComplaint.ForeColor = Theme.SoftPeach;
            btnTrackComplaint.Font = Theme.ButtonFont;

            btnViewReports.BackColor = Theme.DarkBlue;
            btnViewReports.ForeColor = Theme.SoftPeach;
            btnViewReports.Font = Theme.ButtonFont;

            btnLogout.BackColor = Theme.MutedBrown;
            btnLogout.ForeColor = Theme.LightBeige;
            btnLogout.Font = Theme.ButtonFont;
        }

        private void btnRaiseComplaint_Click(object sender, EventArgs e)
        {
            RaiseComplaintForm form = new RaiseComplaintForm();
            form.ShowDialog();
        }

        private void btnTrackComplaint_Click(object sender, EventArgs e)
        {
            TrackComplaintForm form = new TrackComplaintForm();
            form.ShowDialog();
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Generating Reports...", "View Reports", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SessionManager.ClearSession();
            this.Close();
            Application.OpenForms["LoginForm"]?.Show();
        }

        private void UserDashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SessionManager.ClearSession();
            Application.OpenForms["LoginForm"]?.Show();
        }
    }
}
