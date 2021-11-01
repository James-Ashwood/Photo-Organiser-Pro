/*  Program:        Form1.cs
 *  Last Edited:    01/11/2021
 *  Last Editor:    James Ashwood
 *  Version:        N/A
 *  Commented:      Yes
 */

// Using Statements
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Data;

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

        // SetJson - Functionallity function that changes and serealizes the JSON required when a default setting is changed
        private void SetJson(string key, string valueString, IList<string> valueList)
        {

            // Read the JSON data and set it to setup
            Settings setup = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(@"C:\Users\James\Documents\GitHub\Photo-Organiser-Pro\Photo Organiser Pro\Photo Organiser Pro\Files\jsconfig1.json"));
            
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
            File.WriteAllText(@"C:\Users\James\Documents\GitHub\Photo-Organiser-Pro\Photo Organiser Pro\Photo Organiser Pro\Files\jsconfig1.json", JsonConvert.SerializeObject(setup));
        }

        // Form1_Load - Winforms function to setup screen when the form 1 is loaded
        private void Form1_Load(object sender, EventArgs e)
        {

            // Add the columns to the dataTableCurrent, and update the DataGridView
            dataTableCurrent.Columns.Add("Current File Name");
            dataTableCurrent.Columns.Add("Current File Subdirectory Path");
            dataGridView1.DataSource = dataTableCurrent;

            // Add the columns to the dataTableNew, and update the DataGridView
            dataTableNew.Columns.Add("New File Name");
            dataTableNew.Columns.Add("New File Subdirectory Path");
            dataGridView2.DataSource = dataTableNew;

            // Set the column width for UX
            dataGridView1.Columns[0].Width = 270;
            dataGridView1.Columns[1].Width = 270;
            dataGridView2.Columns[0].Width = 270;
            dataGridView2.Columns[1].Width = 270;

            // Get the settings properties
            Settings setup = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(@"C:\Users\James\Documents\GitHub\Photo-Organiser-Pro\Photo Organiser Pro\Photo Organiser Pro\Files\jsconfig1.json"));

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
                if (namingConvention == "DateImageNumber")
                {
                    DateImageNumberBoxNamingConvention.Checked = true;
                }
            }

            // Loop through each possible folder convention, and if in the setup it is checked, then it checks that in the app
            foreach (string folderConvention in setup.DefaultFolders)
            {
                if (folderConvention == "DateTaken")
                {
                    DateTakenBoxFolderConvention.Checked = true;
                }
                if (folderConvention == "TimeTaken")
                {
                    TimeTakenBoxFolderConvention.Checked = true;
                }
                if (folderConvention == "CameraModel")
                {
                    CameraModelBoxFolderConvention.Checked = true;
                }
                if (folderConvention == "DateCreated")
                {
                    DateCreatedBoxFolderConvention.Checked = true;
                }
                if (folderConvention == "DateModified")
                {
                    DateModifiedBoxFolderConvention.Checked = true;
                }
                if (folderConvention == "DateImageNumber")
                {
                    DateImageNumberBoxFolderConvention.Checked = true;
                }
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
            if (DateImageNumberBoxNamingConvention.Checked == true)
            {
                namingBuildList.Add("DateImageNumber");
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
            if (DateTakenBoxFolderConvention.Checked == true)
            {
                folderBuildList.Add("DateTaken");
            }
            if (TimeTakenBoxFolderConvention.Checked == true)
            {
                folderBuildList.Add("TimeTaken");
            }
            if (CameraModelBoxFolderConvention.Checked == true)
            {
                folderBuildList.Add("CameraModel");
            }
            if (DateCreatedBoxFolderConvention.Checked == true)
            {
                folderBuildList.Add("DateCreated");
            }
            if (DateModifiedBoxFolderConvention.Checked == true)
            {
                folderBuildList.Add("DateModified");
            }
            if (DateImageNumberBoxFolderConvention.Checked == true)
            {
                folderBuildList.Add("DateImageNumber");
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

        // UpdateRightGrid - Functionallity function that springs up a choose folder dialog to select the new destination
        private void UpdateRightGrid()
        {
            // Clear the current dataTableNew
            dataTableNew.Rows.Clear();

            // Create the fileRow variable as a new row
            DataRow fileRow = dataTableCurrent.NewRow();

            // Create some strings used later
            string fileName, fileLocation;

            // Create a counter and loop through the amount of rows in the dataTableCurrent grid
            int count = dataTableCurrent.Rows.Count;
            for (int i = 1; i <= count; i++)
            {
                // Make sure the fileRow variable is back to default
                fileRow = dataTableNew.NewRow();

                // Get the values from the left side
                fileName = dataTableCurrent.Rows[i - 1]["Current File Name"].ToString();
                fileLocation = dataTableCurrent.Rows[i - 1]["Current File Subdirectory Path"].ToString();

                // Assign these variables to the new rows values
                fileRow["New File Name"] = fileName;
                fileRow["New File Subdirectory Path"] = fileLocation;

                // Add this row to dataTableNew data grid
                dataTableNew.Rows.Add(fileRow);
            }

            // Assign this to dataGridView2
            dataGridView2.DataSource = dataTableNew;
        }

        // ChangedTextBoxCurrentLocation - Button function that updates the currentDataTable on the left, so that it can contain 
        private void ChangedTextBoxCurrentLocation(object sender, EventArgs e)
        {
            // Clear the current table
            dataTableCurrent.Rows.Clear();

            // Create the empty file row
            DataRow fileRow = dataTableCurrent.NewRow();

            // Loop recursively, through all directories and subdirecotories using the path in the textbox
            foreach (string file in System.IO.Directory.GetFiles(TextCurrentFolderLocation.Text, "*", SearchOption.AllDirectories))
            {
                // Make sure the fileRow variable is back to default
                fileRow = dataTableCurrent.NewRow();

                // Remove the already know part of the path
                string tempFileName = file.Replace(TextCurrentFolderLocation.Text + "\\", "");
                string fileLocation = file.Replace(TextCurrentFolderLocation.Text + "\\", "");

                // Find the first section of the path (i.e. the subdirectory) and assign that to fileLocation (i.e subDirectories = wholePath - pathGiven - fileName)
                if (fileLocation.LastIndexOf("\\") != -1)
                {
                    fileLocation = fileLocation.Substring(0, fileLocation.LastIndexOf("\\"));
                }

                // Now cut this from the original fileName value and allocate this to the fileName (i.e fileName = wholePath - pathGiven - subdirectories)
                string fileName = tempFileName.Replace(fileLocation + "\\", "");

                // Assign these to the row value
                fileRow["Current File Name"] = fileName;
                fileRow["Current File Subdirectory Path"] = fileLocation;

                // Assign this to dataGridView1
                dataTableCurrent.Rows.Add(fileRow);
            }

            // Assign this to dataGridView1
            dataGridView1.DataSource = dataTableCurrent;

            // Update the new files grid
            UpdateRightGrid();
        }

        // ChangedTextBoxNewLocation - Button function that just calls the update right grid code, as that code is used in many areas
        private void ChangedTextBoxNewLocation(object sender, EventArgs e)
        {
            // Call UpdateRightGrid
            UpdateRightGrid();
        }

        // ChangedTextBoxNewLocation - Button function that should copy over the files
        private void CopyImages(object sender, EventArgs e)
        {
            MessageBox.Show("The Copy Images Button Was Pressed");
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
