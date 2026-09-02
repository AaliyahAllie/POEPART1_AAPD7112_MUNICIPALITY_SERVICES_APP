using System;

namespace POEPART1_AAPD7112_MUNICIPALITY_SERVICES_APP
{
    /** The Issue class represents a municipal service issue reported by a user.
        It stores all the information related to a reported issue.**/
    public class Issue
    {
        // Stores the unique reference number assigned to the reported issue.
        public string ReferenceNumber { get; set; }

        // Stores the location where the municipal issue occurred.
        public string Location { get; set; }

        /** Stores the category of the issue, such as electricity, water,
        sanitation, roads, or other municipal services.**/
        public string Category { get; set; }

        // Stores the detailed description provided by the user about the issue.
        public string Description { get; set; }

        /** Stores the file path of an attachment uploaded by the user.
        This can be used to provide supporting evidence for the reported issue.**/
        public string AttachmentPath { get; set; }

        // Stores the date and time when the issue was submitted.
        public DateTime DateSubmitted { get; set; }


        /** Constructor used to create a new Issue object.
        It receives the main details entered by the user and assigns
        them to the appropriate properties.**/
        public Issue(string refNum, string location, string category,
                     string description, string attachment)
        {
            // Assigns the generated reference number to the issue.
            ReferenceNumber = refNum;

            // Stores the location entered by the user.
            Location = location;

            // Stores the selected issue category.
            Category = category;

            // Stores the user's description of the municipal issue.
            Description = description;

            // Stores the path of the selected attachment.
            AttachmentPath = attachment;

            /** Automatically records the current date and time when
            the issue object is created/submitted.**/
            DateSubmitted = DateTime.Now;
        }


        /** Helper method used to return only the filename of an attachment.
        This prevents the full file path from having to be displayed to the user.**/
        public string GetAttachmentFileName()
        {
            // Checks whether an attachment path is empty or has not been provided.
            if (string.IsNullOrEmpty(AttachmentPath))
            {
                // Returns "None" when the user did not provide an attachment.
                return "None";
            }

            // Extracts and returns only the filename from the stored file path.
            return System.IO.Path.GetFileName(AttachmentPath);
        }
    }
}