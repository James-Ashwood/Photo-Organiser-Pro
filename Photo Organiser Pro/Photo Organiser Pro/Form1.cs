/*  Program:        Form1.cs
 *  Last Edited:    19/12/2021
 *  Last Editor:    James Ashwood
 *  Version:        N/A
 *  Commented:      Yes
 */

// Using Statements
using MetadataExtractor;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using Tulpep.NotificationWindow;
using System.Drawing;

// Namespace for the project
namespace Photo_Organiser_Pro
{

    // Form Class - Part of the Window1
    public partial class Window1 : Form
    {

        // Initializing
        public Window1()
        {
            InitializeComponent();
        }

        // Setting Up DataGridView DataTables for inserting data
        public DataTable dataTableCurrent = new DataTable();
        public DataTable dataTableNew = new DataTable();

        // SetJson - Custom function that changes and serealizes the JSON required when a default setting is changed
        private void SetJson(string key, string valueString, IList<string> valueList)
        {
            // JSON File Path Definiition
            string jsonFilePath = System.IO.Directory.GetCurrentDirectory() + "\\jsconfig1.json";

            // Read the JSON data and set it to setup
            Settings setup = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(jsonFilePath));

            // Make the change
            if (key == "DefaultCurrentLocation")
            {
                setup.DefaultCurrentLocation = valueString;
            }
            if (key == "DefaultNewLocation")
            {
                setup.DefaultNewLocation = valueString;
            }
            if (key == "DefaultFolder")
            {
                setup.DefaultFolders = valueList;
            }
            if (key == "DefaultNaming")
            {
                setup.DefaultNaming = valueList;
            }

            // Write the change back
            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(setup), Encoding.UTF8);

            // Alert the user of the success
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Seetings Saved";
            popup.ContentText = "Updateded settings saved successfully";
            popup.Popup();
        }

        // ExtractMetadata - Custom function that gets the metadata out of the images
        private string ExtractMetadata(string key, string filePath)
        {
            // Gets all of the directories (i.e. substets of data) that the image has
            var directories = ImageMetadataReader.ReadMetadata(filePath);

            // Loops throuhg them
            foreach (var directory in directories)
            {
                // Loops through each individual data point in the directory
                foreach (var tag in directory.Tags)
                {
                    // Checks if the data point is the one that we want
                    if (tag.Name == key)
                    {
                        // If so, returns that value
                        return tag.Description;
                    }
                }
            }
            // If we cant find any data, return "NoData"
            return "NoData";
        }

        // CopyImageBackgroundWorker_DoWork - Worker function that calls the copy function
        private void CopyImageBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Run the CopyFunction
            CopyFunction();
        }

        // ResizeForm - Custom function that resizes the datagrids in the form
        private void ResizeForm()
        {

            // Update the grids width to be a certain percentage of the screens width.
            dataGridView1.Width = Convert.ToInt32(this.Width * 0.47);
            dataGridView2.Width = Convert.ToInt32(this.Width * 0.47);

            // Update the grids location
            dataGridView1.Left = 15;
            dataGridView2.Left = Convert.ToInt32(this.Width - this.Width * 0.47 - 35);

            // Update the grids width to be a certain percentage of the screens width.
            TextCurrentFolderLocation.Width = Convert.ToInt32((this.Width - 454)*0.47);
            TextNewFolderLocation.Width = Convert.ToInt32((this.Width-454)*0.47);

            // Update the grids location
            TextCurrentFolderLocation.Left = 232;
            TextNewFolderLocation.Left = Convert.ToInt32(this.Width - ((this.Width - 454) * 0.47) - 252);

            // Set the column width for the DataGrids
            if (dataGridView1.Columns.Contains("Current File Name") == true)
            {
                dataGridView1.Columns[0].Width = Convert.ToInt32((this.Width * 0.47) * 0.26);
                dataGridView1.Columns[1].Width = Convert.ToInt32((this.Width * 0.47) * 0.26);
                dataGridView1.Columns[2].Width = Convert.ToInt32((this.Width * 0.47) * 0.46);
                dataGridView2.Columns[0].Width = Convert.ToInt32((this.Width * 0.47) * 0.23);
                dataGridView2.Columns[1].Width = Convert.ToInt32((this.Width * 0.47) * 0.23);
                dataGridView2.Columns[2].Width = Convert.ToInt32((this.Width * 0.47) * 0.42);
                dataGridView2.Columns[3].Width = Convert.ToInt32((this.Width * 0.47) * 0.09);
            }
        }

        // Form1_Load - Winforms function to setup screen when the form 1 is resized
        private void Form1_Resize(object sender, EventArgs e)
        {
            ResizeForm();
        }

        // Form1_Load - Winforms function to setup screen when the form 1 is loaded
        private void Form1_Load(object sender, EventArgs e)
        {

            // Background Worker
            copyImageBackgroundWorker.DoWork += CopyImageBackgroundWorker_DoWork;

            // Add the columns to the dataTableCurrent, and update the DataGridView
            dataTableCurrent.Columns.Add("Current File Name");
            dataTableCurrent.Columns.Add("Current File Subdirectory Path");
            dataTableCurrent.Columns.Add("Current File Checksum");
            dataGridView1.DataSource = dataTableCurrent;

            // Add the columns to the dataTableNew, and update the DataGridView
            dataTableNew.Columns.Add("New File Name");
            dataTableNew.Columns.Add("New File Subdirectory Path");
            dataTableNew.Columns.Add("New File Checksum");
            dataTableNew.Columns.Add("Done");
            dataGridView2.DataSource = dataTableNew;

            // Size the window and create the data grid columns
            ResizeForm();

            // Get the settings properties
            Settings setup = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(System.IO.Directory.GetCurrentDirectory() + "\\jsconfig1.json"));

            // Update the text values based on the default settings
            TextCurrentFolderLocation.Text = setup.DefaultCurrentLocation;
            TextNewFolderLocation.Text = setup.DefaultNewLocation;

            // Loop through each possible naming convention, and if in the setup it is checked, then it checks that in the app
            foreach (string namingConvention in setup.DefaultNaming)
            {
                if (namingConvention == "DateTaken")
                {
                    DateTakenBoxNamingConvention.Checked = true;
                }
                if (namingConvention == "TimeTaken")
                {
                    TimeTakenBoxNamingConvention.Checked = true;
                }
                if (namingConvention == "CameraModel")
                {
                    CameraModelBoxNamingConvention.Checked = true;
                }
                if (namingConvention == "DateCreated")
                {
                    DateCreatedBoxNamingConvention.Checked = true;
                }
                if (namingConvention == "DateModified")
                {
                    DateModifiedBoxNamingConvention.Checked = true;
                }
                if (namingConvention == "OriginalName")
                {
                    OrignalNameBoxNamingConvention.Checked = true;
                }
            }

            // Loop through each possible folder convention, and if in the setup it is checked, then it checks that in the app
            foreach (string folderConvention in setup.DefaultFolders)
            {
                if (folderConvention == "DateTaken")
                {
                    DateTakenFolderConvention.Checked = true;
                }
                if (folderConvention == "DateTimeTaken")
                {
                    DateTimeTakenFolderConvention.Checked = true;
                }
                if (folderConvention == "DateTimeCameraModel")
                {
                    DateTimeCameraTakenFolderConvention.Checked = true;
                }
                if (folderConvention == "DateCreated")
                {
                    DateCreatedFolderConvention.Checked = true;
                }
                if (folderConvention == "DateModified")
                {
                    DateModifiedFolderConvention.Checked = true;
                }
                if (folderConvention == "OriginalName")
                {
                    OrignalNameFolderConvention.Checked = true;
                }
            }

            if (TextCurrentFolderLocation.Text != "") {
                UpdateRightGrid();
            }
        }

        // SetAsDefaultNamingConvention - Button function that sets the default naming convention when the button is clicked
        private void SetAsDefaultNamingConvention(object sender, EventArgs e)
        {
            // Set up a list for the naming convention settings to go into
            List<string> namingBuildList = new List<string>();

            // Check if that info is created, if so then add it to the setup
            if (DateTakenBoxNamingConvention.Checked == true)
            {
                namingBuildList.Add("DateTaken");
            }
            if (TimeTakenBoxNamingConvention.Checked == true)
            {
                namingBuildList.Add("TimeTaken");
            }
            if (CameraModelBoxNamingConvention.Checked == true)
            {
                namingBuildList.Add("CameraModel");
            }
            if (DateCreatedBoxNamingConvention.Checked == true)
            {
                namingBuildList.Add("DateCreated");
            }
            if (DateModifiedBoxNamingConvention.Checked == true)
            {
                namingBuildList.Add("DateModified");
            }
            if (OrignalNameBoxNamingConvention.Checked == true)
            {
                namingBuildList.Add("OriginalName");
            }

            // Pass this new data through to the SetJson function
            SetJson("DefaultNaming", "", namingBuildList);
        }

        // SetAsDefaultFolderConvention - Button function that sets the default folder convention when the button is clicked
        private void SetAsDefaultFolderConvention(object sender, EventArgs e)
        {
            // Set up a list for the naming convention settings to go into
            List<string> folderBuildList = new List<string>();

            // Check if that info is created, if so then add it to the setup
            if (DateTakenFolderConvention.Checked == true)
            {
                folderBuildList.Add("DateTaken");
            }
            if (DateTimeTakenFolderConvention.Checked == true)
            {
                folderBuildList.Add("DateTimeTaken");
            }
            if (DateTimeCameraTakenFolderConvention.Checked == true)
            {
                folderBuildList.Add("DateTimeCameraModel");
            }
            if (DateCreatedFolderConvention.Checked == true)
            {
                folderBuildList.Add("DateCreated");
            }
            if (DateModifiedFolderConvention.Checked == true)
            {
                folderBuildList.Add("DateModified");
            }
            if (OrignalNameFolderConvention.Checked == true)
            {
                folderBuildList.Add("OriginalName");
            }

            // Pass this new data through to the SetJson function
            SetJson("DefaultFolder", "", folderBuildList);
        }

        // SetAsDefaultFolder - Button function that sets the default folder when the button is clicked
        private void SetDefaultCurrentFolder(object sender, EventArgs e)
        {
            // Makes an empty list (required for the function)
            List<string> empty = new List<string>();

            // Runs the SetJson functions with the data
            SetJson("DefaultCurrentLocation", TextCurrentFolderLocation.Text, empty);
        }

        // SetAsDefaultFolder - Button function that sets the default folder when the button is clicked
        private void SetDefaultNewFolder(object sender, EventArgs e)
        {
            // Makes an empty list (required for the function)
            List<string> empty = new List<string>();

            // Runs the SetJson functions with the data
            SetJson("DefaultNewLocation", TextNewFolderLocation.Text, empty);
        }

        // ChangeCurrentDestination - Button function that springs up a choose folder dialog to select the current destination
        private void ChangeCurrentDestination(object sender, EventArgs e)
        {
            // Using fbd as the folder browser dialog
            using (var fbd = new FolderBrowserDialog())
            {
                // Get the result and asign it to the variable "result" 
                DialogResult result = fbd.ShowDialog();

                // If the result passes a few basic tests, to make sure it is a valid path
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    // It gets assigned to the current folder text, triggering thats change function and updating the dataGridView
                    TextCurrentFolderLocation.Text = fbd.SelectedPath;
                }
            }
        }

        // ChangeNewDestination - Button function that springs up a choose folder dialog to select the new destination
        private void ChangeNewDestination(object sender, EventArgs e)
        {
            // Using fbd as the folder browser dialog
            using (var fbd = new FolderBrowserDialog())
            {
                // Get the result and asign it to the variable "result" 
                DialogResult result = fbd.ShowDialog();

                // If the result passes a few basic tests, to make sure it is a valid path
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    // It gets assigned to the new folder text, triggering thats change function and updating the dataGridView
                    TextNewFolderLocation.Text = fbd.SelectedPath;
                }
            }
        }

        // Numerify - Custom function that turns the month code into the number
        private string Numberify(string data)
        {
            // Take a list of the months
            List<string> months = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            // Finds the index in the list above, adds one (due to 0 starting list indexes), then turns into a string
            string returnData = (months.FindIndex(a => a.Contains(data))+1).ToString();

            // If the string is only one digit, add a 0 into the front.
            if (returnData.Length == 1)
            {
                returnData = "0" + returnData;
            }

            // Return the data
            return returnData;
        }

        // GetDisplayData - Custom function that takes in an image path and a data value and turns it into the string that we need to display
        private string GetDisplayData(string key, string currentFilePath, string currentFileName, string oldFileName, string oldFilePath, string oldFileEnding, string seperator)
        {
            // Set the original return value
            string value = "";

            // Get the original files path
            string filePath = TextCurrentFolderLocation.Text + "\\" + oldFilePath + "\\" + oldFileName;

            // If we are looking for the date taken
            if (key == "DateTaken")
            {
                // If the metadata we can extract is not NoData
                if (ExtractMetadata("Date/Time Original", filePath) != "NoData")
                {
                    // Take the metadata and format it
                    value = ExtractMetadata("Date/Time Original", filePath).Split(' ')[0].Replace(":", seperator);
                }
                else
                {
                    // Otherwise return "NoData"
                    value = "NoData";
                }
            }
            // If we are looking for the time taken
            else if (key == "TimeTaken")
            {
                // If the metadata we can extract is not NoData
                if (ExtractMetadata("Date/Time Original", filePath) != "NoData")
                {
                    // Take the metadata and format it
                    value = ExtractMetadata("Date/Time Original", filePath).Split(' ')[1].Replace(":", seperator);
                }
                else
                {
                    // Otherwise return "NoData"
                    value = "NoData";
                }
            }
            // If we are looking for the camera model
            else if (key == "CameraModel")
            {
                // Take the metadata and format it
                value = ExtractMetadata("Make", filePath) + "-" + ExtractMetadata("Model", filePath);
            }
            // If we are looking for the date and time taken
            else if (key == "DateTimeTaken")
            {
                // If the metadata we can extract is not NoData
                if (ExtractMetadata("Date/Time Original", filePath) != "NoData")
                {
                    // Take the metadata and format it
                    value = GetDisplayData("DateTaken", currentFilePath, currentFileName, oldFileName, oldFilePath, oldFileEnding, seperator) + ExtractMetadata("Date/Time Original", filePath).Split(' ')[1].Replace(":", seperator);
                }
                else
                {
                    // Otherwise return "NoData"
                    value = "NoData";
                }
            }
            // If we are looking for the date, time and camera taken
            else if (key == "DateTimeCameraTaken")
            {
                // Take the metadata and format it
                value = GetDisplayData("DateTimeTaken", currentFilePath, currentFileName, oldFileName, oldFilePath, oldFileEnding, seperator) + ExtractMetadata("Make", filePath) + "-" + ExtractMetadata("Model", filePath);
            }
            // If we are looking for the date created
            else if (key == "DateCreated")
            {
                // If the metadata we can extract is not NoData
                if (ExtractMetadata("Date/Time Digitized", filePath) != "NoData")
                {
                    // Take the metadata and format it
                    value = ExtractMetadata("Date/Time Digitized", filePath).Split(' ')[0].Replace(":", seperator);
                }
                else
                {
                    // Otherwise return "NoData"
                    value = "NoData";
                }
            }
            // If we are looking for the date modified
            else if (key == "DateModified")
            {
                // Take the metadata and format it
                string data = ExtractMetadata("File Modified Date", filePath);
                value = data.Split(' ')[5] + seperator + Numberify(data.Split(' ')[1]) + seperator + data.Split(' ')[2];
            }
            // If we are looking for the original name
            else if (key == "OrginalName")
            {
                // Take the metadata and format it
                value = oldFileName;
                value = value.Replace(oldFileEnding, "");
            }
            // If we are looking for the original path
            else if (key == "OriginalPath")
            {
                // Take the metadata and format it
                value = oldFilePath;
            }

            // Return the value and the seporator
            return value + seperator;
        }

        // GetNewName - Custom function that gets the new name of a file
        private string GetNewName(string currentFilePath, string currentFileName)
        {
            // Get the paths for the image
            string newFileName = "";
            string oldFileName = currentFileName;
            string oldFilePath = currentFilePath;

            // Get the file name
            string fileEnding = currentFileName.Substring(currentFileName.IndexOf("."));

            // Go through all of the naming convention boxes, if its is check then call GetDisplayData and add it to the name
            if (DateTakenBoxNamingConvention.Checked == true)
            {
                newFileName += GetDisplayData("DateTaken", currentFilePath, currentFileName, oldFileName, oldFilePath, fileEnding, "-");
            }
            if (TimeTakenBoxNamingConvention.Checked == true)
            {
                newFileName += GetDisplayData("TimeTaken", currentFilePath, currentFileName, oldFileName, oldFilePath, fileEnding, "-");
            }
            if (CameraModelBoxNamingConvention.Checked == true)
            {
                newFileName += GetDisplayData("CameraModel", currentFilePath, currentFileName, oldFileName, oldFilePath, fileEnding, "-");
            }
            if (DateCreatedBoxNamingConvention.Checked == true)
            {
                newFileName += GetDisplayData("DateCreated", currentFilePath, currentFileName, oldFileName, oldFilePath, fileEnding, "-");
            }
            if (DateModifiedBoxNamingConvention.Checked == true)
            {
                newFileName += GetDisplayData("DateModified", currentFilePath, currentFileName, oldFileName, oldFilePath, fileEnding, "-");
            }
            if (OrignalNameBoxNamingConvention.Checked == true)
            {
                newFileName += GetDisplayData("OrginalName", currentFilePath, currentFileName, oldFileName, oldFilePath, fileEnding, "-");
            }

            // If there is a name there
            if (newFileName.Length > 0)
            {
                // Remove the last "-" on the name
                newFileName = newFileName.Remove(newFileName.Length - 1, 1);
            }
            else
            {
                // Otherwise name it "NoDataAvailable"
                newFileName = "NoDataAvailable";
            }

            // Return the new name and the file ending
            return newFileName + fileEnding;
        }


        // GetNewName - Custom function that gets the new name of a file
        private string GetNewPath(string currentFilePath, string currentFileName)
        {
            // Get the paths for the image
            string newFilePath = "";
            string oldFileName = currentFileName;
            string oldFilePath = currentFilePath;

            // Set the file ending to an empty string (used for the function calling)
            string fileEnding = "";

            // Go through all of the folder convention boxes, if its is check then call GetDisplayData and add it to the name
            if (DateTakenFolderConvention.Checked == true)
            {
                newFilePath += GetDisplayData("DateTaken", currentFilePath, currentFileName, oldFileName, oldFilePath, fileEnding, "\\");
            }
            if (DateTimeTakenFolderConvention.Checked == true)
            {
                newFilePath += GetDisplayData("DateTimeTaken", currentFilePath, currentFileName, oldFileName, oldFilePath, fileEnding, "\\");
            }
            if (DateTimeCameraTakenFolderConvention.Checked == true)
            {
                newFilePath += GetDisplayData("DateTimeCameraTaken", currentFilePath, currentFileName, oldFileName, oldFilePath, fileEnding, "\\");
            }
            if (DateCreatedFolderConvention.Checked == true)
            {
                newFilePath += GetDisplayData("DateCreated", currentFilePath, currentFileName, oldFileName, oldFilePath, fileEnding, "\\");
            }
            if (DateModifiedFolderConvention.Checked == true)
            {
                newFilePath += GetDisplayData("DateModified", currentFilePath, currentFileName, oldFileName, oldFilePath, fileEnding, "\\");
            }
            if (OrignalNameFolderConvention.Checked == true)
            {
                newFilePath += GetDisplayData("OriginalPath", currentFilePath, currentFileName, oldFileName, oldFilePath, fileEnding, "\\");
            }

            // If there is a path there
            if (newFilePath.Length > 0)
            {
                // Remove the last "/" on the path
                newFilePath = newFilePath.Remove(newFilePath.Length - 1, 1);
            }
            else
            {
                // Otherwise name it "NoDataAvailable"
                newFilePath = "NoData";
            }

            // Return the new path
            return newFilePath;
        }

        // UpdateRightGrid - Functionallity function thay updates the right grid
        private void UpdateRightGrid()
        {
            if (TextCurrentFolderLocation.Text != "" && TextNewFolderLocation.Text != "")
            {

                // Clear the current dataTableNew
                dataTableNew.Rows.Clear();

                // Create the fileRow variable as a new row
                DataRow fileRow = dataTableCurrent.NewRow();

                // Create some strings used later
                string oldFileName, oldFileLocation, fileName, fileLocation;

                // Create a counter and loop through the amount of rows in the dataTableCurrent grid
                int count = dataTableCurrent.Rows.Count;

                // Loop through the list
                for (int i = 1; i <= count; i++)
                {
                    // Make sure the fileRow variable is back to default
                    fileRow = dataTableNew.NewRow();

                    // Is this file and invalid file
                    if (ShowInvalidFiles().Contains(i-1))
                    {
                        // Assign these variables to the new rows values
                        fileRow["New File Name"] = "N/A";
                        fileRow["New File Subdirectory Path"] = "N/A";

                        // Add this row to dataTableNew data grid
                        dataTableNew.Rows.Add(fileRow);

                        // Make this grid row red
                        dataGridView2.Rows[i - 1].DefaultCellStyle.ForeColor = Color.Red;
                    }
                    else
                    {

                        // Get the values from the left side
                        oldFileName = dataTableCurrent.Rows[i - 1]["Current File Name"].ToString();
                        oldFileLocation = dataTableCurrent.Rows[i - 1]["Current File Subdirectory Path"].ToString();

                        fileName = GetNewName(oldFileLocation, oldFileName);
                        fileLocation = GetNewPath(oldFileLocation, oldFileName);

                        // Assign these variables to the new rows values
                        fileRow["New File Name"] = fileName;
                        fileRow["New File Subdirectory Path"] = fileLocation;

                        // Add this row to dataTableNew data grid
                        dataTableNew.Rows.Add(fileRow);
                    }
                }

                // Assign this to dataGridView2
                dataGridView2.DataSource = dataTableNew;
            }
        }

        private List<int> ShowInvalidFiles()
        {

            string currentFileName, currentFileEnding;
            List<int> returnNumbers = new List<int>();

            int count = dataTableCurrent.Rows.Count;
            for (int i = 1; i <= count; i++)
            {
                // Get the values from the left side
                currentFileName = dataTableCurrent.Rows[i - 1]["Current File Name"].ToString();
                currentFileEnding = currentFileName.Substring(currentFileName.IndexOf(".") + 1);

                List<string> allowedFileEndings = new List<string>() { "JPG", "JPEG", "PNG", "RAW", "ARW", "CR2", "TIFF", "FRAW" };
                if (allowedFileEndings.Contains(currentFileEnding.ToUpper()) == false)
                {
                    returnNumbers.Add(i-1);
                    dataGridView1.Rows[i-1].DefaultCellStyle.ForeColor = Color.Red;
                }
            }

            return returnNumbers;
        }

        // ChangedTextBoxCurrentLocation - Button function that updates the currentDataTable on the left, so that it can contain all the correct information
        private void ChangedTextBoxCurrentLocation(object sender, EventArgs e)
        {
            // If the TextBox is not empty
            if (TextCurrentFolderLocation.Text != "")
            {

                // Clear the current table
                dataTableCurrent.Rows.Clear();

                // Create the empty file row
                DataRow fileRow;

                // Loop recursively, through all directories and subdirecotories using the path in the textbox
                foreach (string file in System.IO.Directory.GetFiles(TextCurrentFolderLocation.Text, "*", SearchOption.AllDirectories))
                {
                    // Get the file ending
                    string fileEnding = file.Substring(file.IndexOf(".")+1);
                    
                    // Make sure the fileRow variable is back to default
                    fileRow = dataTableCurrent.NewRow();

                    // Remove the already know part of the path
                    string fileName = file.Replace(TextCurrentFolderLocation.Text + "\\", "");
                    string fileLocation = fileName;

                    // Find the first section of the path (i.e. the subdirectory) and assign that to fileLocation (i.e subDirectories = wholePath - pathGiven - fileName)
                    if (fileName.LastIndexOf("\\") != -1)
                    {
                        fileName = fileName.Substring(fileName.LastIndexOf("\\") + 1);
                    }

                    // Now cut this from the original fileName value and allocate this to the fileName (i.e fileName = wholePath - pathGiven - subdirectories)
                    fileLocation = fileLocation.Replace(fileName, "");

                    // Assign these to the row value
                    fileRow["Current File Name"] = fileName;
                    fileRow["Current File Subdirectory Path"] = fileLocation;

                    fileRow["Current File Checksum"] = GetMD5Checksum(file);

                    // Assign this to dataGridView1
                    dataTableCurrent.Rows.Add(fileRow);
                }

                // Assign this to dataGridView1
                dataGridView1.DataSource = dataTableCurrent;

                // Colour the grid
                ShowInvalidFiles();

                // Update the new files grid
                UpdateRightGrid();

            }
        }

        // ChangedTextBoxNewLocation - Button funct ion that just calls the update right grid code, as that code is used in many areas
        private void ChangedTextBoxNewLocation(object sender, EventArgs e)
        {
            // Call UpdateRightGrid
            UpdateRightGrid();
        }

        // GetMD5Checksum - Custom function that gets the MD5 checksum
        public static string GetMD5Checksum(string filename)
        {
            // Using the cryptography MD5 variable
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                // Using the file
                using (var stream = System.IO.File.OpenRead(filename))
                {
                    // Create a hash and return the checksum from the hash
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "");
                }
            }
        }

        // SetRows - Custom
        private void SetRows(int rowNum, string rowTable, string rowColumn, string rowValue)
        {
            // If the rowTable is new, then use the dataTableNew
            if (rowTable == "New")
            {
                dataTableNew.Rows[rowNum][rowColumn] = rowValue;
            }
            // If the rowTable is current, then use the dataTableCurrent
            if (rowTable == "Current")
            {
                dataTableCurrent.Rows[rowNum][rowColumn] = rowValue;
            }
        }

        // CopyFunction - Custom function that copies over the files
        private void CopyFunction()
        {
            // Create some strings used later
            string currentFileName, currentFileLocation, newFileName, newFileLocation, source, destination;

            // Create a counter and loop through the amount of rows in the dataTableCurrent grid
            int count = dataTableCurrent.Rows.Count;
            for (int i = 1; i <= count; i++)
            {
                // Get the values from the left side
                currentFileName = dataTableCurrent.Rows[i - 1]["Current File Name"].ToString();
                currentFileLocation = dataTableCurrent.Rows[i - 1]["Current File Subdirectory Path"].ToString();

                // Get the values from the left side
                newFileName = dataTableNew.Rows[i - 1]["New File Name"].ToString();
                newFileLocation = dataTableNew.Rows[i - 1]["New File Subdirectory Path"].ToString();

                // Is this file and invalid file
                if (ShowInvalidFiles().Contains(i - 1))
                {
                    // Assign these variables to the new rows values
                    SetRows(i - 1, "New", "New File Checksum", "N/A");
                    SetRows(i - 1, "New", "Done", "Error");

                    // Make this grid row red
                    dataGridView2.Rows[i - 1].DefaultCellStyle.ForeColor = Color.Red;
                }
                else
                {

                    // Get source and destination locations
                    source = TextCurrentFolderLocation.Text + "\\" + currentFileLocation + "\\" + currentFileName;
                    destination = TextNewFolderLocation.Text + "\\" + newFileLocation + "\\" + newFileName;

                    // Make any required directories
                    if (!System.IO.Directory.Exists(TextNewFolderLocation.Text + "\\" + newFileLocation))
                    {
                        System.IO.Directory.CreateDirectory(TextNewFolderLocation.Text + "\\" + newFileLocation);
                    }

                    // Copy the files
                    System.IO.File.Copy(source, destination, true);

                    // Check the destination files exist and both checksums are equal and display output data
                    if (File.Exists(destination))
                    {
                        if (GetMD5Checksum(source) == GetMD5Checksum(destination))
                        {
                            SetRows(i - 1, "New", "New File Checksum", GetMD5Checksum(destination));
                            SetRows(i - 1, "New", "Done", "Yes");
                        }
                        else
                        {
                            SetRows(i - 1, "New", "New File Checksum", GetMD5Checksum(destination));
                            SetRows(i - 1, "New", "Done", "Error");

                            dataGridView2.Rows[i - 1].DefaultCellStyle.ForeColor = Color.Red;
                        }
                    }
                }
            }
        }

        // ChangedTextBoxNewLocation - Button function that copies over the files in the background
        private void CopyImages(object sender, EventArgs e)
        {
            // Run the background worker for the copying files
            copyImageBackgroundWorker.RunWorkerAsync(2000);
        }

        // UpdatedFolderConvention - Button function that updates the right grid when the folder convention changes
        private void UpdatedFolderConvention(object sender, EventArgs e)
        {
            // Call UpdateRightGrid
            UpdateRightGrid();
        }

        // UpdatedNamingConvention - Button function that updates the right grid when the naming convention changes
        private void UpdatedNamingConvention(object sender, EventArgs e)
        {
            // Call UpdateRightGrid
            UpdateRightGrid();
        }
        
        private void LeftGridClicked(object sender, EventArgs e)
        {
            ShowInvalidFiles();
        }
    }

    // Settings Class - Stores the users default setup
    public class Settings
    {
        // A list of the default naming and then default folders, as well as the default current location and new location
        public IList<string> DefaultNaming { get; set; }
        public IList<string> DefaultFolders { get; set; }
        public string DefaultCurrentLocation { get; set; }
        public string DefaultNewLocation { get; set; }
    }
}
