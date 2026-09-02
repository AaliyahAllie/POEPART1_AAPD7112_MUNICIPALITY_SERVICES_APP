namespace POEPART1_AAPD7112_MUNICIPALITY_SERVICES_APP.Forms
{
    partial class MainMenuForm
    {
        // Stores the components used by the Main Menu form.
        private System.ComponentModel.IContainer components = null;

        /**
         * Releases the resources used by the form.
         * 
         * The Dispose method is called when the form is no longer needed.
         * It ensures that any components created by the form are properly
         * released from memory.
         */
        protected override void Dispose(bool disposing)
        {
            // Checks whether managed resources should be disposed and
            // whether the components container has been initialised.
            if (disposing && (components != null))
            {
                // Releases all resources stored in the components container.
                components.Dispose();
            }

            // Calls the base class Dispose method to complete the cleanup process.
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /**
         * Initialises and configures all controls used on the Main Menu form.
         * 
         * This method is automatically generated and maintained by the
         * Windows Forms Designer. It defines the appearance, position,
         * size and behaviour of each control on the form.
         */
        private void InitializeComponent()
        {
            // Creates the title label displayed at the top of the Main Menu.
            this.lblTitle = new System.Windows.Forms.Label();

            // Creates the button used to access the Report Issues section.
            this.btnReportIssues = new System.Windows.Forms.Button();

            // Creates the button for the Local Events and Announcements section.
            this.btnLocalEvents = new System.Windows.Forms.Button();

            // Creates the button for viewing Service Request Status.
            this.btnServiceStatus = new System.Windows.Forms.Button();

            // Creates the label used to display the total number of reported issues.
            this.lblTotalReports = new System.Windows.Forms.Label();

            // Creates the button used to exit the application.
            this.btnExit = new System.Windows.Forms.Button();

            // Suspends the layout of the form while its controls are being configured.
            this.SuspendLayout();


            // 
            // lblTitle
            // 

            // Allows the label to automatically adjust its size based on its text.
            this.lblTitle.AutoSize = true;

            // Sets the font style of the title to bold with a size of 12.
            this.lblTitle.Font = new System.Drawing.Font(
                "Microsoft Sans Serif",
                12F,
                System.Drawing.FontStyle.Bold);

            // Sets the position of the title on the form.
            this.lblTitle.Location = new System.Drawing.Point(30, 20);

            // Assigns a unique name to the title label.
            this.lblTitle.Name = "lblTitle";

            // Defines the size of the title label.
            this.lblTitle.Size = new System.Drawing.Size(262, 25);

            // Sets the tab order position of the title label.
            this.lblTitle.TabIndex = 0;

            // Sets the text displayed by the title label.
            this.lblTitle.Text = "Municipal Services Application";


            // 
            // btnReportIssues
            // 

            // Sets the position of the Report Issues button.
            this.btnReportIssues.Location = new System.Drawing.Point(35, 65);

            // Assigns a unique name to the Report Issues button.
            this.btnReportIssues.Name = "btnReportIssues";

            // Defines the width and height of the Report Issues button.
            this.btnReportIssues.Size = new System.Drawing.Size(320, 35);

            // Sets the tab order position of the button.
            this.btnReportIssues.TabIndex = 1;

            // Sets the text displayed on the button.
            this.btnReportIssues.Text = "1. Report Issues";

            // Allows the button to use the default Windows visual style.
            this.btnReportIssues.UseVisualStyleBackColor = true;

            /**
             * Connects the button's Click event to the btnReportIssues_Click
             * event handler. When the user clicks this button, the application
             * opens the Report Issues form.
             */
            this.btnReportIssues.Click += new System.EventHandler(
                this.btnReportIssues_Click);


            // 
            // btnLocalEvents
            // 

            /**
             * Disables the Local Events and Announcements button.
             * 
             * This feature is included in the main menu design but is disabled
             * for Part 1 because it is not implemented in the current version
             * of the application.
             */
            this.btnLocalEvents.Enabled = false;

            // Sets the position of the Local Events button.
            this.btnLocalEvents.Location = new System.Drawing.Point(35, 115);

            // Assigns a unique name to the button.
            this.btnLocalEvents.Name = "btnLocalEvents";

            // Defines the size of the Local Events button.
            this.btnLocalEvents.Size = new System.Drawing.Size(320, 35);

            // Sets the tab order position of the button.
            this.btnLocalEvents.TabIndex = 2;

            // Sets the text displayed on the button.
            this.btnLocalEvents.Text =
                "2. Local Events and Announcements (Disabled)";

            // Allows the button to use the default Windows visual style.
            this.btnLocalEvents.UseVisualStyleBackColor = true;


            // 
            // btnServiceStatus
            // 

            /**
             * Disables the Service Request Status button.
             * 
             * The option is displayed as part of the planned municipal
             * services application but is not implemented in Part 1.
             */
            this.btnServiceStatus.Enabled = false;

            // Sets the position of the Service Status button.
            this.btnServiceStatus.Location = new System.Drawing.Point(35, 165);

            // Assigns a unique name to the button.
            this.btnServiceStatus.Name = "btnServiceStatus";

            // Defines the size of the Service Status button.
            this.btnServiceStatus.Size = new System.Drawing.Size(320, 35);

            // Sets the tab order position of the button.
            this.btnServiceStatus.TabIndex = 3;

            // Sets the text displayed on the button.
            this.btnServiceStatus.Text =
                "3. Service Request Status (Disabled)";

            // Allows the button to use the default Windows visual style.
            this.btnServiceStatus.UseVisualStyleBackColor = true;


            // 
            // lblTotalReports
            // 

            // Allows the label to automatically adjust its size to its text.
            this.lblTotalReports.AutoSize = true;

            // Sets the position of the total reports label.
            this.lblTotalReports.Location = new System.Drawing.Point(32, 220);

            // Assigns a unique name to the label.
            this.lblTotalReports.Name = "lblTotalReports";

            // Defines the size of the label.
            this.lblTotalReports.Size = new System.Drawing.Size(155, 17);

            // Sets the tab order position of the label.
            this.lblTotalReports.TabIndex = 4;

            // Sets the initial text displayed by the label.
            this.lblTotalReports.Text = "Total Issues Reported: 0";


            // 
            // btnExit
            // 

            // Sets the position of the Exit button.
            this.btnExit.Location = new System.Drawing.Point(275, 215);

            // Assigns a unique name to the Exit button.
            this.btnExit.Name = "btnExit";

            // Defines the width and height of the Exit button.
            this.btnExit.Size = new System.Drawing.Size(80, 28);

            // Sets the tab order position of the button.
            this.btnExit.TabIndex = 5;

            // Sets the text displayed on the button.
            this.btnExit.Text = "Exit";

            // Allows the button to use the default Windows visual style.
            this.btnExit.UseVisualStyleBackColor = true;

            /**
             * Connects the Exit button's Click event to the btnExit_Click
             * event handler. This allows the application to display an
             * exit confirmation before closing.
             */
            this.btnExit.Click += new System.EventHandler(
                this.btnExit_Click);


            // 
            // MainMenuForm
            // 

            // Defines the scaling dimensions used by the form.
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);

            // Sets the automatic scaling mode of the form.
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            // Sets the width and height of the Main Menu window.
            this.ClientSize = new System.Drawing.Size(390, 265);

            // Adds the Exit button to the form's collection of controls.
            this.Controls.Add(this.btnExit);

            // Adds the total reports label to the form.
            this.Controls.Add(this.lblTotalReports);

            // Adds the Service Status button to the form.
            this.Controls.Add(this.btnServiceStatus);

            // Adds the Local Events button to the form.
            this.Controls.Add(this.btnLocalEvents);

            // Adds the Report Issues button to the form.
            this.Controls.Add(this.btnReportIssues);

            // Adds the title label to the form.
            this.Controls.Add(this.lblTitle);

            // Prevents the user from resizing the Main Menu window.
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            // Disables the maximise button on the form.
            this.MaximizeBox = false;

            // Assigns the form's internal name.
            this.Name = "MainMenuForm";

            // Positions the form in the centre of the user's screen when opened.
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            // Sets the title displayed in the application's window header.
            this.Text = "Main Menu";

            /**
             * Connects the form's Load event to the MainMenuForm_Load event
             * handler. This allows the issue count to be updated when the
             * Main Menu is first displayed.
             */
            this.Load += new System.EventHandler(this.MainMenuForm_Load);

            // Resumes the layout of the form after all controls have been configured.
            this.ResumeLayout(false);

            // Applies the final layout settings to the controls.
            this.PerformLayout();
        }

        #endregion


        // Stores the label used to display the application title.
        private System.Windows.Forms.Label lblTitle;

        // Stores the button used to navigate to the Report Issues form.
        private System.Windows.Forms.Button btnReportIssues;

        // Stores the disabled button for Local Events and Announcements.
        private System.Windows.Forms.Button btnLocalEvents;

        // Stores the disabled button for Service Request Status.
        private System.Windows.Forms.Button btnServiceStatus;

        // Stores the label displaying the total number of reported issues.
        private System.Windows.Forms.Label lblTotalReports;

        // Stores the button used to exit the application.
        private System.Windows.Forms.Button btnExit;
    }
}