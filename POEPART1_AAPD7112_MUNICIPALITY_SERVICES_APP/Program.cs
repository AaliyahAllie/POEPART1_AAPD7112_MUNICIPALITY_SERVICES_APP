using POEPART1_AAPD7112_MUNICIPALITY_SERVICES_APP.Forms;
using POEPART1_AAPD7112_MUNICIPALITY_SERVICES_APP;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace POEPART1_AAPD7112_MUNICIPALITY_SERVICES_APP
{
    static class Program
    {
        // Global List<Issue> required by assignment for storing submitted reports
        public static List<Issue> IssueList = new List<Issue>();

        // Counter to generate unique reference numbers like MS-0001, MS-0002
        public static int IssueCounter = 1;

        /// <summary>
        /// Main entry point of the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenuForm());
        }
    }
}