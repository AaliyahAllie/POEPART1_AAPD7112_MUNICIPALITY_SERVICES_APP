using POEPART1_AAPD7112_MUNICIPALITY_SERVICES_APP;
using POEPART1_AAPD7112_MUNICIPALITY_SERVICES_APP.Forms;
using System;
using System.IO;
using System.Windows.Forms;

namespace POEPART1_AAPD7112_MUNICIPALITY_SERVICES_APP.Forms
{
    /**
     * ReportIssuesForm provides the user interface for reporting
     * municipal service issues.
     *
     * Users can enter the location, select an issue category,
     * provide a description and optionally attach a supporting file.
     * The form also provides feedback about the estimated resolution
     * time based on the selected category.
     */
    public partial class ReportIssuesForm : Form
    {
        // Stores a reference to the Main Menu form so the user
        // can return to it after submitting or cancelling a report.
        private MainMenuForm mainMenu;

        // Stores the file path of the attachment selected by the user.
        // An empty string indicates that no file has been attached.
        private string selectedFilePath = "";


        /**
         * Constructor for the Report Issues form.
         *
         * The Main Menu form is received as a parameter so that it
         * can be displayed again when the user navigates back.
         */
        public ReportIssuesForm(MainMenuForm menu)
        {
            // Initialises all controls created using the Windows Forms Designer.
            InitializeComponent();

            // Stores the Main Menu reference for later use.
            mainMenu = menu;
        }


        /**
         * Runs when the Report Issues form is loaded.
         *
         * The method populates the category ComboBox with the available
         * municipal service categories and resets the form to its
         * default state.
         */
        private void ReportIssuesForm_Load(object sender, EventArgs e)
        {
            // Clear any existing categories before adding the available options.
            cmbCategory.Items.Clear();

            // Adds the default category selection.
            cmbCategory.Items.Add("-- Select Category --");

            // Adds the municipal issue categories available to the user.
            cmbCategory.Items.Add("Roads and Potholes");
            cmbCategory.Items.Add("Water and Utilities");
            cmbCategory.Items.Add("Electricity");
            cmbCategory.Items.Add("Sanitation");
            cmbCategory.Items.Add("Waste Management");
            cmbCategory.Items.Add("Street Lighting");
            cmbCategory.Items.Add("Public Safety");
            cmbCategory.Items.Add("Parks and Recreation");
            cmbCategory.Items.Add("Other");

            // Sets the ComboBox to the default "Select Category" option.
            cmbCategory.SelectedIndex = 0;

            // Clears and resets all other form fields.
            ResetForm();
        }


        /**
         * User Engagement Strategy: Resolution Time Estimate and Impact Preview.
         *
         * This method provides immediate feedback to the user by displaying
         * an estimated response time based on the selected issue category.
         * It also displays an engagement message explaining how accurate
         * reports can assist municipal response teams.
         */
        private void UpdateResolutionEstimate()
        {
            // Checks whether the user has selected a valid category.
            if (cmbCategory.SelectedIndex <= 0)
            {
                // Displays a message asking the user to select a category.
                lblResolutionEstimate.Text = "Select a category above";

                // Provides an engagement message encouraging users to report issues.
                lblEngagementMsg.Text =
                    "Reporting helps municipal response teams prioritize repair dispatches.";

                // Stops the method because no category has been selected.
                return;
            }

            // Gets the category selected by the user from the ComboBox.
            string selectedCategory = cmbCategory.SelectedItem.ToString();

            // Stores the estimated response time for the selected category.
            string responseTime = "";


            /**
             * Determines the estimated response time according to the
             * selected municipal service category.
             *
             * Different categories are assigned different priorities
             * because some issues may have a greater impact on public
             * safety, health or essential infrastructure.
             */
            switch (selectedCategory)
            {
                case "Roads and Potholes":
                    responseTime = "~48 Hours (High Road Safety Priority)";
                    break;

                case "Water and Utilities":
                    responseTime = "~24 Hours (Urgent Infrastructure)";
                    break;

                case "Electricity":
                    responseTime = "~12 to 24 Hours (Urgent Power Fault)";
                    break;

                case "Sanitation":
                    responseTime = "~24 Hours (Public Health Priority)";
                    break;

                case "Waste Management":
                    responseTime = "~72 Hours (Scheduled Collection)";
                    break;

                case "Street Lighting":
                    responseTime = "~5 Days (Standard Maintenance)";
                    break;

                case "Public Safety":
                    responseTime = "~6 Hours (High Priority Response)";
                    break;

                case "Parks and Recreation":
                    responseTime = "~7 Days (Standard Maintenance)";
                    break;

                // Provides a general estimate for categories
                // that do not have a specific response time.
                default:
                    responseTime = "~3 to 5 Business Days";
                    break;
            }

            // Displays the estimated response time on the form.
            lblResolutionEstimate.Text = responseTime;

            // Provides positive feedback to encourage users to submit
            // clear and detailed information about their issue.
            lblEngagementMsg.Text =
                "Thank you! Clear descriptions help municipal workers resolve issues faster.";
        }


        // Updates the resolution estimate whenever the selected category changes.
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Calls the method responsible for calculating and displaying
            // the appropriate estimated response time.
            UpdateResolutionEstimate();
        }


        /**
         * Opens a file selection dialog that allows the user to attach
         * an image or document as supporting evidence for the reported issue.
         *
         * The selected file path is stored so that the attachment can
         * be associated with the Issue object when the report is submitted.
         */
        private void btnAttachFile_Click(object sender, EventArgs e)
        {
            // Opens the file selection dialog and checks whether
            // the user selected a file.
            if (ofdAttachment.ShowDialog() == DialogResult.OK)
            {
                // Stores the complete path of the selected file.
                selectedFilePath = ofdAttachment.FileName;

                // Checks whether the selected file still exists.
                if (File.Exists(selectedFilePath))
                {
                    // Displays only the filename instead of the full file path.
                    lblAttachmentName.Text = Path.GetFileName(selectedFilePath);

                    // Makes the Remove Attachment button visible.
                    btnRemoveAttachment.Visible = true;
                }
                else
                {
                    // Displays an error message if the selected file cannot be found.
                    MessageBox.Show(
                        "The selected file could not be found.",
                        "File Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }


        // Removes the currently selected attachment from the report.
        private void btnRemoveAttachment_Click(object sender, EventArgs e)
        {
            // Clears the stored file path.
            selectedFilePath = "";

            // Updates the attachment label to show that no file is attached.
            lblAttachmentName.Text = "No file attached.";

            // Hides the Remove Attachment button because there is no attachment.
            btnRemoveAttachment.Visible = false;
        }


        /**
         * Handles the submission of a municipal issue report.
         *
         * Before creating the issue, the method validates the required
         * information entered by the user. If validation is successful,
         * a unique reference number is generated and a new Issue object
         * is added to the application's IssueList.
         */
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // 1. Validate Location

            // Checks whether the location field is empty or contains
            // only spaces.
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                // Informs the user that a location is required.
                MessageBox.Show(
                    "Please enter the location of the issue.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                // Places the cursor in the location field.
                txtLocation.Focus();

                // Stops the submission process until the problem is corrected.
                return;
            }


            // 2. Validate Category

            // Checks whether the user has selected an actual category
            // rather than the default option.
            if (cmbCategory.SelectedIndex <= 0)
            {
                // Informs the user that a category must be selected.
                MessageBox.Show(
                    "Please select an issue category.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                // Places the cursor on the category ComboBox.
                cmbCategory.Focus();

                // Stops the submission process.
                return;
            }


            // 3. Validate Description

            /**
             * Checks whether the description is empty or shorter than
             * 10 characters. A minimum description length encourages
             * users to provide enough information for the municipality
             * to understand and investigate the reported issue.
             */
            if (string.IsNullOrWhiteSpace(rtbDescription.Text) ||
                rtbDescription.Text.Trim().Length < 10)
            {
                // Displays a validation message to the user.
                MessageBox.Show(
                    "Please provide a description of the issue (at least 10 characters).",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                // Places the cursor in the description field.
                rtbDescription.Focus();

                // Stops the submission process.
                return;
            }


            /**
             * Generates a unique reference number for the issue.
             *
             * The reference number uses the format MS-0001, MS-0002,
             * MS-0003 and so on. This gives each report a unique identifier
             * that can be used to identify the submitted issue.
             */
            string refNumber = "MS-" + Program.IssueCounter.ToString("D4");

            // Increases the counter so the next issue receives a new reference number.
            Program.IssueCounter++;


            /**
             * Creates a new Issue object using the information entered
             * by the user.
             *
             * Trim() is used on the location and description to remove
             * unnecessary spaces before the information is stored.
             */
            Issue newIssue = new Issue(
                refNumber,
                txtLocation.Text.Trim(),
                cmbCategory.SelectedItem.ToString(),
                rtbDescription.Text.Trim(),
                selectedFilePath
            );


            // Adds the newly created Issue object to the application's
            // central list of reported issues.
            Program.IssueList.Add(newIssue);


            /**
             * Creates a confirmation message containing the important
             * information about the submitted report.
             *
             * This provides immediate feedback to the user and allows
             * them to confirm that their report was successfully recorded.
             */
            string confirmText =
                "Your issue has been successfully reported.\n\n" +
                "Reference Number: " + newIssue.ReferenceNumber + "\n" +
                "Location: " + newIssue.Location + "\n" +
                "Category: " + newIssue.Category + "\n" +
                "Est. Resolution Time: " + lblResolutionEstimate.Text + "\n" +
                "Attachment: " + newIssue.GetAttachmentFileName() + "\n\n" +
                "Thank you for helping improve your community!";


            // Displays the successful submission confirmation to the user.
            MessageBox.Show(
                confirmText,
                "Report Submitted",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);


            // Resets the form so that another issue can be submitted.
            ResetForm();
        }


        // Handles the Clear button and removes all information currently
        // entered into the report form.
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Resets the form to its default state.
            ResetForm();
        }


        /**
         * Handles navigation back to the Main Menu.
         *
         * The current Report Issues form is closed and the Main Menu
         * is displayed again. The issue counter is also refreshed so
         * that the latest number of submitted reports is shown.
         */
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Closes the Report Issues form.
            this.Close();

            // Displays the Main Menu again.
            mainMenu.Show();

            // Updates the total issue count shown on the Main Menu.
            mainMenu.UpdateIssueCount();
        }


        /**
         * Resets all input fields and controls on the Report Issues form.
         *
         * This method is used after a successful submission, when the
         * user selects Clear, and when the form is initially loaded.
         */
        private void ResetForm()
        {
            // Clears the location text field.
            txtLocation.Clear();

            // Checks that the category ComboBox contains items.
            if (cmbCategory.Items.Count > 0)
            {
                // Returns the category selection to the default option.
                cmbCategory.SelectedIndex = 0;
            }

            // Clears the issue description.
            rtbDescription.Clear();

            // Removes the stored attachment path.
            selectedFilePath = "";

            // Resets the attachment label.
            lblAttachmentName.Text = "No file attached.";

            // Hides the Remove Attachment button.
            btnRemoveAttachment.Visible = false;

            // Resets the resolution estimate and engagement message.
            UpdateResolutionEstimate();
        }


        /**
         * Overrides the default form closing behaviour.
         *
         * When the user closes the Report Issues form using the window's
         * close button, the Main Menu is displayed again and its issue
         * count is refreshed.
         */
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Calls the base implementation of the form closing event.
            base.OnFormClosing(e);

            // Checks whether the user manually closed the form.
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Displays the Main Menu again.
                mainMenu.Show();

                // Refreshes the total number of reported issues.
                mainMenu.UpdateIssueCount();
            }
        }
    }
}