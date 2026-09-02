using System;

namespace POEPART1_AAPD7112_MUNICIPALITY_SERVICES_APP
{
    // Simple Issue class to store reported issue details
    public class Issue
    {
        public string ReferenceNumber { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string AttachmentPath { get; set; }
        public DateTime DateSubmitted { get; set; }

        // Constructor
        public Issue(string refNum, string location, string category, string description, string attachment)
        {
            ReferenceNumber = refNum;
            Location = location;
            Category = category;
            Description = description;
            AttachmentPath = attachment;
            DateSubmitted = DateTime.Now;
        }

        // Helper method to display attachment filename
        public string GetAttachmentFileName()
        {
            if (string.IsNullOrEmpty(AttachmentPath))
            {
                return "None";
            }
            return System.IO.Path.GetFileName(AttachmentPath);
        }
    }
}