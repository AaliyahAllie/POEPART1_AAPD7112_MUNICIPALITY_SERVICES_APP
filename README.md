# 🇿🇦 South African Municipal Services Application — Part 1 POE

### Municipal Services Application: Part 1 — Report Issues System

**Module:** AAPD7112 — Programming 3B
**Assessment:** Portfolio of Evidence (POE)
**Project:** South African Municipal Services Application
**Part:** Part 1

---

## 📌 Project Purpose

The purpose of this application is to provide South African citizens with a simple and user-friendly desktop application for reporting municipal service issues.

For **Part 1**, the application focuses on the **Report Issues** functionality, allowing users to submit municipal complaints or service-related issues and receive a unique reference number.

### Key Features

Users can:

* 🏠 Access the **Main Menu** with three options:

  * Report Issues
  * Local Events and Announcements
  * Service Request Status
* 📍 Enter the location of a reported issue.
* 🏷️ Select an issue category from a dropdown menu.
* 📝 Enter a detailed description of the issue.
* 📎 Attach an optional photo or document using `OpenFileDialog`.
* ⏱️ View a dynamic estimated municipal resolution time based on the selected issue category.
* 📤 Submit an issue report.
* 🔢 Receive a unique issue reference number, such as `MS-0001` or `MS-0002`.
* 📊 View the total number of issues reported during the current application session.

---

## 🔗 GitHub Repository

The source code for this project is available on GitHub:

**Repository:**
https://github.com/AaliyahAllie/POEPART1_AAPD7112_MUNICIPALITY_SERVICES_APP.git

---

## 🛠️ Technologies Used

| Technology             | Description                                            |
| ---------------------- | ------------------------------------------------------ |
| **C#**                 | Primary programming language                           |
| **.NET Framework 4.8** | Application framework                                  |
| **Windows Forms**      | Desktop user interface                                 |
| **Visual Studio 2022** | Development environment                                |
| **`List<Issue>`**      | In-memory data structure used to store reported issues |
| **`OpenFileDialog`**   | Used for optional file attachments                     |

---

## 💻 Prerequisites

Before running the application, ensure the following software is installed:

* Windows 10 or Windows 11
* .NET Framework 4.8 Runtime
* Visual Studio 2022
* Git *(only required if cloning the repository)*

---

## 📥 How to Open the Project

### Option A — Clone from GitHub

1. Open **Terminal**, **Command Prompt**, or **Git Bash**.
2. Clone the repository:

```bash
git clone https://github.com/AaliyahAllie/POEPART1_AAPD7112_MUNICIPALITY_SERVICES_APP.git
```

3. Navigate to the project directory:

```bash
cd POEPART1_AAPD7112_MUNICIPALITY_SERVICES_APP
```

### Option B — Open Directly in Visual Studio 2022

1. Launch **Visual Studio 2022**.
2. Select **Open a project or solution**.
3. Browse to the project directory.
4. Locate:

```text
POEPART1_AAPD7112_MUNICIPALITY_SERVICES_APP.csproj
```

5. Select the `.csproj` file and click **Open**.

---

## 🔨 How to Build the Application

### Using Visual Studio

In Visual Studio:

**Build → Build Solution**

Alternatively, use:

```text
Ctrl + Shift + B
```

### Using the Command Line

From the project directory, run:

```bash
dotnet build POEPART1_AAPD7112_MUNICIPALITY_SERVICES_APP.csproj -c Release
```

> **Note:** The project targets `.NET Framework 4.8`. If the `dotnet build` command does not work in your environment, build the project directly through Visual Studio 2022.

---

# 🏠 Main Menu

When the application starts, users are presented with the main menu.

The menu contains three options:

### 1. Report Issues

This option is **enabled** for Part 1.

Users can access the issue reporting form and submit a municipal service issue.

### 2. Local Events and Announcements

This option is currently **disabled** for Part 1.

```text
Enabled = false
```

This functionality is planned for **Part 2**.

### 3. Service Request Status

This option is currently **disabled** for Part 1.

```text
Enabled = false
```

This functionality is planned for **Part 3**.

### Total Issues Reported

The Main Menu also displays the total number of issues submitted during the current application session.

---

# 📝 How to Submit an Issue

Follow these steps to report a municipal issue:

1. Click **Report Issues** from the Main Menu.
2. Enter the **Location of Issue**.

   Example:

```text
123 Main Road, Johannesburg
```

3. Select an appropriate **Category** from the dropdown menu.
4. Review the dynamically generated **Estimated Response Time**.

   Example:

```text
~48 Hours (High Road Safety Priority)
```

5. Enter a detailed **Description** of the issue.

   The description must contain at least **10 characters**.
6. Optionally click **Attach File...** to upload an image or document.
7. Click **Submit Report**.
8. A confirmation message will appear containing the generated reference number.

Example:

```text
MS-0001
```

---

# 📎 How to Attach a File

Users can optionally attach supporting evidence to their issue report.

### Steps

1. Click **Attach File...**
2. Select a file using the `OpenFileDialog`.
3. Supported file types may include:

```text
.jpg
.png
.pdf
.docx
```

4. The selected filename will be displayed next to the attachment button.
5. To remove the attachment, click **Remove**.

The attachment is optional and is not required to submit an issue.

---

# 💾 Issue Data Storage

Submitted issues are stored in memory using a standard C#:

```csharp
List<Issue>
```

The list is maintained through:

```csharp
Program.IssueList
```

Each `Issue` object stores information associated with the submitted report.

### Issue Properties

| Property          | Description                                   |
| ----------------- | --------------------------------------------- |
| `ReferenceNumber` | Unique reference number assigned to the issue |
| `Location`        | Location where the issue occurred             |
| `Category`        | Selected municipal issue category             |
| `Description`     | Detailed description provided by the user     |
| `AttachmentPath`  | Path of the optional attached file            |
| `DateSubmitted`   | Date and time the issue was submitted         |

### Example Reference Numbers

```text
MS-0001
MS-0002
MS-0003
```

Each submitted issue receives a unique reference number during the application session.

---

# 👥 User Engagement Strategy

## Resolution Time Estimate & Impact Preview

The selected user engagement strategy for Part 1 is:

> **Resolution Time Estimate & Impact Preview**

When a user selects an issue category, the application dynamically displays an estimated municipal response or resolution time.

For example:

| Issue Category    | Example Estimated Response  |
| ----------------- | --------------------------- |
| Roads & Potholes  | ~48 Hours                   |
| Water & Utilities | ~24 Hours                   |
| Electricity       | Category-dependent estimate |

The application can also provide additional context, such as:

```text
~48 Hours (High Road Safety Priority)
```

### Why This Engages Users

Providing an estimated response time gives citizens greater transparency regarding what happens after submitting an issue.

Instead of submitting a complaint without knowing what to expect, users receive immediate feedback about the expected response period.

This helps users feel:

* Informed
* Valued
* Engaged with the municipality
* More confident that their issue has been recorded

---

# ✅ Validation and Feedback

The application includes input validation to ensure that users provide the required information before submitting an issue.

### Required Fields

The following fields must be completed:

* **Location**
* **Category**
* **Description**

The description must contain at least:

```text
10 characters
```

### Validation Feedback

If required information is missing, the application displays a `MessageBox` warning informing the user which information needs to be completed.

### Successful Submission

When an issue is successfully submitted, the application displays a confirmation `MessageBox` containing:

* The unique issue reference number
* The estimated response time

Example:

```text
Issue submitted successfully!

Reference Number: MS-0001
Estimated Response: ~48 Hours
```

---

# ⚠️ Known Limitations

The current Part 1 implementation has the following limitation:

### In-Memory Data Storage

Issue data is stored using:

```csharp
List<Issue>
```

This means that submitted reports only exist while the application is running.

When the application is closed:

```text
All submitted issue data is cleared.
```

A permanent database or file-based storage solution is not currently implemented in Part 1.

---

# 🚀 Future Functionality

The project will be expanded in future parts of the POE.

## Part 2 — Local Events and Announcements

Part 2 will introduce functionality for:

* Local municipal events
* Community announcements
* Viewing upcoming events
* Additional citizen engagement functionality

The **Local Events and Announcements** option on the Main Menu will be enabled.

---

## Part 3 — Service Request Status

Part 3 will introduce:

* Service request tracking
* Issue status updates
* Advanced data structures
* Improved issue management

Planned advanced data structures include:

* 🌳 Trees
* 🕸️ Graphs
* ⛰️ Heaps

The **Service Request Status** option on the Main Menu will be enabled.

---

# 📂 Project Structure

A simplified representation of the project structure is:

```text
POEPART1_AAPD7112_MUNICIPALITY_SERVICES_APP/
│
├── Program.cs
├── Issue.cs
├── MainMenu.cs
├── ReportIssue.cs
│
├── Properties/
│
├── Resources/
│
├── App.config
│
└── POEPART1_AAPD7112_MUNICIPALITY_SERVICES_APP.csproj
```

> The exact structure may vary depending on the current implementation of the project.

---

# 📄 Part 1 Summary

Part 1 implements the core **Report Issues** functionality of the South African Municipal Services Application.

Citizens can submit municipal issues by providing a location, selecting a category, entering a description, and optionally attaching supporting documentation. The system provides dynamic response-time estimates and generates a unique reference number for each submitted issue.

The implementation establishes the foundation for the additional functionality planned for **Part 2 and Part 3**.
