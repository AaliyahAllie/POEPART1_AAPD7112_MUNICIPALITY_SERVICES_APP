namespace POEPART1_AAPD7112_MUNICIPALITY_SERVICES_APP.Forms
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.btnLocalEvents = new System.Windows.Forms.Button();
            this.btnServiceStatus = new System.Windows.Forms.Button();
            this.lblTotalReports = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(262, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Municipal Services Application";
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.Location = new System.Drawing.Point(35, 65);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(320, 35);
            this.btnReportIssues.TabIndex = 1;
            this.btnReportIssues.Text = "1. Report Issues";
            this.btnReportIssues.UseVisualStyleBackColor = true;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            // 
            // btnLocalEvents
            // 
            this.btnLocalEvents.Enabled = false;
            this.btnLocalEvents.Location = new System.Drawing.Point(35, 115);
            this.btnLocalEvents.Name = "btnLocalEvents";
            this.btnLocalEvents.Size = new System.Drawing.Size(320, 35);
            this.btnLocalEvents.TabIndex = 2;
            this.btnLocalEvents.Text = "2. Local Events and Announcements (Disabled)";
            this.btnLocalEvents.UseVisualStyleBackColor = true;
            // 
            // btnServiceStatus
            // 
            this.btnServiceStatus.Enabled = false;
            this.btnServiceStatus.Location = new System.Drawing.Point(35, 165);
            this.btnServiceStatus.Name = "btnServiceStatus";
            this.btnServiceStatus.Size = new System.Drawing.Size(320, 35);
            this.btnServiceStatus.TabIndex = 3;
            this.btnServiceStatus.Text = "3. Service Request Status (Disabled)";
            this.btnServiceStatus.UseVisualStyleBackColor = true;
            // 
            // lblTotalReports
            // 
            this.lblTotalReports.AutoSize = true;
            this.lblTotalReports.Location = new System.Drawing.Point(32, 220);
            this.lblTotalReports.Name = "lblTotalReports";
            this.lblTotalReports.Size = new System.Drawing.Size(155, 17);
            this.lblTotalReports.TabIndex = 4;
            this.lblTotalReports.Text = "Total Issues Reported: 0";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(275, 215);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 28);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 265);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTotalReports);
            this.Controls.Add(this.btnServiceStatus);
            this.Controls.Add(this.btnLocalEvents);
            this.Controls.Add(this.btnReportIssues);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button btnLocalEvents;
        private System.Windows.Forms.Button btnServiceStatus;
        private System.Windows.Forms.Label lblTotalReports;
        private System.Windows.Forms.Button btnExit;
    }
}