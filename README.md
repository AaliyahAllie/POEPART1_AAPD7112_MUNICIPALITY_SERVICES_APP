South African Municipal Services Application: Part 1 POE
Municipal Services Application Part 1: Report Issues System
AAPD7112 / Programming 3B Portfolio of Evidence (POE)

Project Purpose
The purpose of this application is to provide citizens with a simple desktop application to report municipal issues in South Africa.
For Part 1, users can:
•	Open the Main Menu with 3 options ("Report Issues", "Local Events", "Service Status").
•	Enter the location of an issue.
•	Select an issue category from a dropdown.
•	Type a detailed description.
•	Attach an optional photo or document using `OpenFileDialog`.
•	View dynamic estimated municipal resolution times based on issue category.
•	Submit the issue report and receive a unique reference number (`MS-0001`, `MS-0002`).
GITHUB LINK
https://github.com/AaliyahAllie/POEPART1_AAPD7112_MUNICIPALITY_SERVICES_APP.git
Technologies Used
•	Language: C#
•	Framework: .NET Framework 4.8 (`net48`)
•	UI Platform: Windows Forms Application
•	Data Structure: `List<Issue>`
Prerequisites
•	Windows 10 or Windows 11
•	.NET Framework 4.8 Runtime
•	Visual Studio 2022
How to Open the Project in Visual Studio 
Option A: Clone from GitHub Repository
1.	Open Terminal, Command Prompt, or Git Bash.
2.	Clone the repository to your local machine:
git clone 
https://github.com/AaliyahAllie/POEPART1_AAPD7112_MUNICIPALITY_SERVICES_APP.git
3.	Navigate into the cloned directory:
cd POEPART1_AAPD7112_MUNICIPALITY_SERVICES_APP
Option B: Open in Visual Studio 2022
1.	Launch Visual Studio 2022.
2.	Click Open a project or solution on the start window.
3.	Browse to the project root directory (where you cloned or unzipped the repository).
4.	Select POEPART1_AAPD7112_MUNICIPALITY_SERVICES_APP.csproj and click Open.
How to Compile / Build
In Visual Studio:
•	Select Build > Build Solution (or press Ctrl + Shift + B).
Via Command Line:
•	dotnet build POEPART1_AAPD7112_MUNICIPALITY_SERVICES_APP -c Release
How to Use the Main Menu
 
•	Option 1: Report Issues: Click to open the issue reporting form.
•	Option 2: Local Events and Announcements: Disabled (Enabled = false) for Part 2.
•	Option 3: Service Request Status: Disabled (Enabled = false) for Part 3.
•	Total Issues Reported: Displays total reported issues in the session.
How to Submit an Issue
 
1.	Click Report Issues.
2.	Enter the Location of Issue (e.g. 123 Main Road, Johannesburg).
3.	Select a Category from the dropdown menu.
4.	View the Estimated Response Time (e.g. `~48 Hours (High Road Safety Priority)`).
5.	Type a Description (minimum 10 characters).
6.	Optionally click Attach File... to attach an image or document.
7.	Click Submit Report.
8.	A confirmation message box will pop up displaying the reference number (e.g. MS-0001).
 
How to Attach a File
 
1.	Click Attach File....
2.	Pick a file using OpenFileDialog (.jpg, .png, .pdf, .docx, etc.).
 
3.	The selected filename will appear next to the button.
 
4.	Click Remove to clear the attachment.
 
How Issue Data is Stored
•	Submitted issues are stored in Program.IssueList using a standard C# List<Issue>.
•	Each Issue object contains ReferenceNumber, Location, Category, Description, AttachmentPath, and DateSubmitted.
User Engagement Strategy
 
•	Selected Strategy: Resolution Time Estimate & Impact Preview.
•	How it Works: When a user selects a category (e.g. Roads & Potholes, Water & Utilities, Electricity), the form dynamically displays the expected municipal repair turnaround time (e.g. `~24 Hours` for Water, `~48 Hours` for Roads).
•	Why it Engages: Provides citizens with transparency and clear expectations, making community members feel valued and informed rather than wondering what happens after submission.

 
Validation and Feedback
•	Checks that Location, Category, and Description (at least 10 characters) are entered.
 
 
 
•	Displays MessageBox warnings if fields are missing.
•	Displays a `MessageBox` success confirmation showing the reference number and response estimate.
 
Known Limitations
•	Data is stored in memory (List<Issue>) during the app run and resets when the app is closed.
Future Functionality (Part 2 and Part 3)
 
•	Part 2: Local Events and Announcements.
•	Part 3: Service Request Status tracking and advanced data structures (Trees, Graphs, Heaps).

