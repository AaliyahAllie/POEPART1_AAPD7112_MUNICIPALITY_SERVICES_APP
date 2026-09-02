using POEPART1_AAPD7112_MUNICIPALITY_SERVICES_APP;
using System;
using System.Windows.Forms;

namespace POEPART1_AAPD7112_MUNICIPALITY_SERVICES_APP.Forms
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            UpdateIssueCount();
        }

        // Method to refresh total issue count from Program.IssueList
        public void UpdateIssueCount()
        {
            lblTotalReports.Text = "Total Issues Reported: " + Program.IssueList.Count;
        }

        // Opens the Report Issues form
        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            ReportIssuesForm reportForm = new ReportIssuesForm(this);
            this.Hide();
            reportForm.Show();
        }

        // Exits the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}