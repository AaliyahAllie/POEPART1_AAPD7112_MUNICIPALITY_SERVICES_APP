using POEPART1_AAPD7112_MUNICIPALITY_SERVICES_APP;
using System;
using System.Windows.Forms;

namespace POEPART1_AAPD7112_MUNICIPALITY_SERVICES_APP.Forms
{
/** MainMenuForm represents the main menu of the municipal services application.
    It provides users with access to the available application features
    and displays the total number of issues that have been reported.**/
    public partial class MainMenuForm : Form
    {
     /**Constructor for the Main Menu form.
        InitializeComponent() loads and sets up all the controls
        designed in the Windows Forms Designer.**/
        public MainMenuForm()
        {
            InitializeComponent();
        }


        /** This event runs when the Main Menu form is loaded.
            It calls UpdateIssueCount() to display the current number
            of reported municipal issues.**/
        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            UpdateIssueCount();
        }


        /** Updates the total number of reported issues displayed on the Main Menu.
            The issue count is retrieved from the IssueList stored in the Program class.**/
        public void UpdateIssueCount()
        {
            /** Displays the number of issues currently stored in IssueList
                next to the "Total Issues Reported" label.**/
            lblTotalReports.Text = "Total Issues Reported: " + Program.IssueList.Count;
        }


        /** Opens the Report Issues form when the user selects
            the "Report Issues" option from the Main Menu.**/
        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            /** Creates a new ReportIssuesForm and passes the current Main Menu
            form to it so that the Main Menu can be accessed again later.**/
            ReportIssuesForm reportForm = new ReportIssuesForm(this);

            // Hides the Main Menu while the Report Issues form is being displayed.
            this.Hide();

            // Displays the Report Issues form to the user.
            reportForm.Show();
        }


        // Handles the Exit button when the user wants to close the application.
        private void btnExit_Click(object sender, EventArgs e)
        {
            /** Displays a confirmation message before closing the application.
            This helps prevent the user from accidentally exiting.**/
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Checks whether the user selected "Yes" in the confirmation message.
            if (result == DialogResult.Yes)
            {
                // Closes the entire application.
                Application.Exit();
            }
        }


        /** Overrides the default form closing behaviour.
        This ensures that the entire application closes when the user
        manually closes the Main Menu window using the X button.**/
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            /** Calls the original OnFormClosing method to allow the
            normal Windows Forms closing process to take place.**/
            base.OnFormClosing(e);

            /** Checks whether the form is being closed by the user,
            rather than being closed by another part of the application.**/
            if (e.CloseReason == CloseReason.UserClosing)
            {
                /** Terminates the application when the user closes
                the Main Menu using the window's close button.**/
                Application.Exit();
            }
        }
    }
}