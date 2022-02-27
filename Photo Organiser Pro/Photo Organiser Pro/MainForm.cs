/*  Program:        MainForm.cs
 *  Last Edited:    04/02/2021
 *  Last Editor:    James Ashwood
 *  Version:        N/A
 *  Commented:      Yes
 */

using MetadataExtractor;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading;
using Tulpep.NotificationWindow;
using System.Drawing;
using MediaDevices;

namespace Photo_Organiser_Pro
{
    public partial class MainForm : Form
    {
        private System.ComponentModel.BackgroundWorker BackgroundWorkerCopying;
        private System.ComponentModel.BackgroundWorker BackgroundWorkerUpdateGrid;

        private bool CurrentMouseDown;                                          // Create a CurrentMouseDown variable to help with the window drags
        private Point MouseLastLocation;                                        // Create a MouseLastLocation variable to help with the window drags

        public DataTable InputDataTable = new DataTable();
        public DataTable OutputDataTable = new DataTable();
        public DataTable RunInputDataTable = new DataTable();
        public DataTable RunOutputDataTable = new DataTable();

        public MainForm()                                                       // Create the MainForms
        {
            InitializeComponent();                                              // Initialize the form
        }

        private void GeneralSetupTrigger(object sender, EventArgs e)
        {
            GeneralSetup();
        }

        public void GeneralSetup()
        {

            this.BackgroundWorkerCopying = new System.ComponentModel.BackgroundWorker();
            this.BackgroundWorkerCopying.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerCopying_DoWork);
            this.BackgroundWorkerCopying.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerCopying_RunWorkerCompleted);

            this.BackgroundWorkerUpdateGrid = new System.ComponentModel.BackgroundWorker();
            this.BackgroundWorkerUpdateGrid.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerUpdateGrid_DoWork);

            InputDataTable.Columns.Add("Input File Name");
            InputDataTable.Columns.Add("Input File Location");

            OutputDataTable.Columns.Add("Output File Name");
            OutputDataTable.Columns.Add("Output File Location");

            Tab3InputDataGridView.DataSource = InputDataTable;
            Tab3OutputDataGridView.DataSource = OutputDataTable;

            Tab3InputDataGridView.Columns[0].Width = 200;
            Tab3InputDataGridView.Columns[1].Width = 361;
            Tab3OutputDataGridView.Columns[0].Width = 200;
            Tab3OutputDataGridView.Columns[1].Width = 361;

            CopySettings CurrentSettings = MakeCopySettings();
            SetupWithSettings(CurrentSettings);

            if (!BackgroundWorkerUpdateGrid.IsBusy)
            {
                BackgroundWorkerUpdateGrid.RunWorkerAsync(2000);
            }

            RunInputDataTable.Columns.Add("Input File Name");
            RunInputDataTable.Columns.Add("Input File Location");
            RunInputDataTable.Columns.Add("Input File Checksum");
            RunInputDataTable.Columns.Add("Done");

            RunOutputDataTable.Columns.Add("Output File Name");
            RunOutputDataTable.Columns.Add("Output File Location");
            RunOutputDataTable.Columns.Add("Output File Checksum");
            RunOutputDataTable.Columns.Add("Done");

            Tab4InputDataGridView.DataSource = RunInputDataTable;
            Tab4OutputDataGridView.DataSource = RunOutputDataTable;

            Tab4InputDataGridView.Columns[0].Width = 100;
            Tab4InputDataGridView.Columns[1].Width = 300;
            Tab4InputDataGridView.Columns[2].Width = 100;
            Tab4InputDataGridView.Columns[3].Width = 61;
            Tab4OutputDataGridView.Columns[0].Width = 100;
            Tab4OutputDataGridView.Columns[1].Width = 300;
            Tab4OutputDataGridView.Columns[2].Width = 100;
            Tab4OutputDataGridView.Columns[3].Width = 61;
        }

        private void BackgroundWorkerUpdateGrid_DoWork(object sender, DoWorkEventArgs e)
        {
            UpdateGrids();
        }
        private void BackgroundWorkerCopying_DoWork(object sender, DoWorkEventArgs e)
        {
            GoCopy();
        }


        private void CloseProgram(object sender, EventArgs e)                   // CloseProgram --- Closes the current program. (element inputs)
        {
            Application.Exit();                                                 // Close the application
            Environment.Exit(0);
        }

        private void MinimiseProgram(object sender, EventArgs e)                // MinimiseProgram --- Minimises the current program. (element inputs)
        {
            this.WindowState = FormWindowState.Minimized;                       // Minimises the window
        }

        private void MouseDownProgram(object sender, MouseEventArgs e)          // MouseDownProgram --- Updates variables when the mouse is down on the navigation bar. (element inputs)
        {
            MouseLastLocation = e.Location;                                     // Update the MouseLastLocation variable with the current mouse point
            CurrentMouseDown = true;                                            // Update the MouseDown variable to true
        }

        private void MouseUpProgram(object sender, MouseEventArgs e)            // MouseDownProgram --- Updates variables when the mouse is down on the navigation bar. (element inputs)
        {
            CurrentMouseDown = false;                                           // Update the MouseDown variable to true
        }

        private void MouseMoveProgram(object sender, MouseEventArgs e)          // MouseMoveProgram --- Updates window position when the user drags the navigation bar. (element inputs)
        {
            if (CurrentMouseDown == true)                                       // If the mouse is down
            {
                this.Location = new Point(
                        (this.Location.X - MouseLastLocation.X) + e.X,
                        (this.Location.Y - MouseLastLocation.Y) + e.Y
                );                                                              // Set the window location to where it should be
                this.Update();                                                  // Update the window
            }
        }

        private void NextTab(object sender, EventArgs e)                        // NextTab --- Updates the TabControl to the next tab. (element inputs)
        {
            MainTabControl.SelectedIndex++;                                     // Add one to the SelectedIndex of the MainTabControl
        }

        private void BackTab(object sender, EventArgs e)                        // BackTab --- Updates the TabControl to the previous tab. (element inputs)
        {
            MainTabControl.SelectedIndex+=-1;                                   // Subtract one from the SelectedIndex of the MainTabControl
        }
        private void BackToStart(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex = 0;
        }

        public void SetupWithSettings(CopySettings CurrentSetup)
        {
            InputInputFileLocation.Text = CurrentSetup.InputSource;
            InputOutputFileLocation.Text = CurrentSetup.OutputSource;
            InputNamingConvention.Text = CurrentSetup.NamingSetup;
            InputFolderConvention.Text = CurrentSetup.FolderSetup;
        }

        static void WriteSreamToDisk(string filePath, MemoryStream memoryStream)
        {
            using (FileStream file = new FileStream(filePath, FileMode.Create, System.IO.FileAccess.Write))
            {
                byte[] bytes = new byte[memoryStream.Length];
                memoryStream.Read(bytes, 0, (int)memoryStream.Length);
                file.Write(bytes, 0, bytes.Length);
                memoryStream.Close();
            }
        }

        public string GetPhoneData()
        {
            string returnString = "";

            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            userName = userName.Split('\\')[1];

            if (!System.IO.Directory.Exists($@"C:\\Users\\{userName}\\.pop"))
            {
                System.IO.Directory.CreateDirectory($@"C:\Users\{userName}\.pop");
            }

            string folderName = "";
            bool done = false;
            int counter = 1;
            while (done == false)
            {
                folderName = "phoneCopy" + counter.ToString();
                if (!System.IO.Directory.Exists($@"C:\Users\{userName}\.pop\{folderName}\"))
                {
                    System.IO.Directory.CreateDirectory($@"C:\Users\{userName}\.pop\{folderName}\");
                    done = true;
                }
                counter = counter + 1;
            }

            List<MediaDevice> devices = MediaDevice.GetDevices().ToList();
            var device = devices.Find(c => c.FriendlyName.Contains("Apple iPhone"));
            if (device != null)
            {
                device.Connect();
                var photoDir = device.GetDirectoryInfo(@"Internal Storage/DCIM");

                var files = photoDir.EnumerateFiles("*.*", SearchOption.AllDirectories);

                foreach (var file in files)
                {
                    MemoryStream memoryStream = new System.IO.MemoryStream();
                    device.DownloadFile(file.FullName, memoryStream);
                    memoryStream.Position = 0;
                    WriteSreamToDisk($@"C:\Users\{userName}\.pop\{folderName}\{file.Name}", memoryStream);
                    Debug.WriteLine($@"Reading from {file.Name} on {device.FriendlyName}");
                }

                device.Disconnect();

                returnString = $@"C:\Users\{userName}\.pop\{folderName}";

                return returnString;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Error - Problem with accessing images. Check your phone is correctly connected (preferably via USB), and if that does not work, report a bug on our GitHub page.");
                return "Error";
            }
        }

        public void GoCopy()
        {
            Debug.WriteLine("Engage Copying");

            int correct = 0;

            for (int i = 0; i < InputDataTable.Rows.Count; i++)
            {
                int progress = (int)((double)i/ InputDataTable.Rows.Count * 100);

                if (Tab4ProgressBar.InvokeRequired)
                {
                    Tab4ProgressBar.Invoke(new MethodInvoker(delegate {
                        Tab4ProgressBar.Value = progress;
                    }));
                }

                DataRow oldRowData = InputDataTable.Rows[i];
                string name = oldRowData[0].ToString();
                string location = oldRowData[1].ToString();
                string checksum = GetMD5Checksum(InputInputFileLocation.Text + "\\" + location + "\\" + name);
                string originalChecksum = checksum;
                string done = "❌";

                string sourceFile;
                if (InputInputFileLocation.Text != "Phone")
                {
                    sourceFile = InputInputFileLocation.Text + "\\" + location + "\\" + name;
                }
                else
                {
                    sourceFile = GetPhoneData() + "\\" + location + "\\" + name;
                }

                DataRow newRowData = OutputDataTable.Rows[i];
                string newName = newRowData[0].ToString();
                string newLocation = newRowData[1].ToString();

                string locationWork = InputOutputFileLocation.Text + newLocation + "\\";
                string nameWork = newName.ToString();

                string destinationFile = locationWork + nameWork;

                if (CheckCleanPaths(locationWork) && "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray().Any(locationWork.Contains))
                {
                    try
                    {
                        Debug.WriteLine(destinationFile);
                        System.IO.Directory.CreateDirectory(locationWork);
                        File.Copy(sourceFile, destinationFile, true);
                        checksum = GetMD5Checksum(destinationFile);
                        if (checksum == originalChecksum)
                        {
                            correct++;
                            done = "✔";
                        }
                        if (checksum != originalChecksum)
                        {
                            done = "❌";
                        }
                    }
                    catch (IOException)
                    {
                        checksum = "Error";
                        done = "❌";
                    }
                    catch (ArgumentException)
                    {
                        checksum = "Error";
                        done = "❌";
                    }
                }
                else
                {
                    checksum = "Error";
                    done = "❌";
                }

                RunInputDataTable.Rows.Add(name, location, checksum, done);
                RunOutputDataTable.Rows.Add(newName, newLocation, checksum, done);
                if (Tab4InputDataGridView.InvokeRequired)
                {
                    Tab4InputDataGridView.Invoke(new MethodInvoker(delegate {
                        Tab4InputDataGridView.Update();
                        Tab4InputDataGridView.Refresh();
                    }));
                }
                if (Tab4OutputDataGridView.InvokeRequired)
                {
                    Tab4OutputDataGridView.Invoke(new MethodInvoker(delegate {
                        Tab4OutputDataGridView.Update();
                        Tab4OutputDataGridView.Refresh();
                    }));
                }
            }
            if (InputDataTable.Rows.Count != 0)
            {
                int result = correct / InputDataTable.Rows.Count * 100;
                string resultMessage = "Success Rate: " + result.ToString() + "%";
                if (Tab4SuccessRate.InvokeRequired)
                {
                    Tab4SuccessRate.Invoke(new MethodInvoker(delegate
                    {
                        Tab4SuccessRate.Text = resultMessage;
                    }));
                }

                if (Tab4InputDataGridView.InvokeRequired)
                {
                    Tab4InputDataGridView.Invoke(new MethodInvoker(delegate
                    {
                        Tab4InputDataGridView.DataSource = RunInputDataTable;
                        Tab4InputDataGridView.Update();
                        Tab4InputDataGridView.Refresh();
                    }));
                }
                if (Tab4OutputDataGridView.InvokeRequired)
                {
                    Tab4OutputDataGridView.Invoke(new MethodInvoker(delegate
                    {
                        Tab4OutputDataGridView.DataSource = RunOutputDataTable;
                        Tab4OutputDataGridView.Update();
                        Tab4OutputDataGridView.Refresh();
                    }));
                }
            }
        }

        private void UpdateSettings(object sender, EventArgs e)
        {
            CopySettings NewSetup = new CopySettings(InputInputFileLocation.Text, InputOutputFileLocation.Text, InputNamingConvention.Text, InputFolderConvention.Text);
            NewSetup.WriteToDefault(System.IO.Directory.GetCurrentDirectory() + "\\jsconfig1.json");
        }

        public CopySettings MakeCopySettings()
        {
            string basicText = "{\n    \"InputSource\": \"\",\n    \"OnputSource\": \"\",\n    \"NamingSetup\": \"\",\n    \"FolderSetup\": \"\"\n    }";

            string JSONFilePath = System.IO.Directory.GetCurrentDirectory() + "\\jsconfig1.json";

            if (File.Exists(JSONFilePath) == false)
            {
                System.IO.File.Create(JSONFilePath);
                File.WriteAllText(JSONFilePath, basicText);
            }

            CopySettings setting = JsonConvert.DeserializeObject<CopySettings>(File.ReadAllText(JSONFilePath));

            return setting;
        }

        private void SetPhoneAsInput(object sender, EventArgs e)
        {
            InputInputFileLocation.Text = "Phone";
        }

        private void SetInputFolderDialog(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    InputInputFileLocation.Text = fbd.SelectedPath;
                }
            }
        }

        private void SetOutputFolderDialog(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    InputOutputFileLocation.Text = fbd.SelectedPath;
                }
            }
        }
        public static string GetMD5Checksum(string filename)
        {
            string filePath = filename.Replace($@"\\", $@"\");

            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                using (var stream = System.IO.File.OpenRead(filePath))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "");
                }
            }
        }

        private Boolean CheckCleanPaths(string filePath)
        {
            if (filePath == "")
            {
                return false;
            }
            else if (filePath == "Phone")
            {
                return true;
            }
            else if (filePath.Contains("\\") || filePath.Contains(":"))
            {
                return true;
            }
            return false;
        }

        private void UpdateGrids()
        {
            if (InputInputFileLocation2.InvokeRequired)
            {
                InputInputFileLocation2.Invoke(new MethodInvoker(delegate {
                    InputInputFileLocation2.Text = InputInputFileLocation.Text;
                }));
            }
            if (InputOutputFileLocation2.InvokeRequired)
            {
                InputOutputFileLocation2.Invoke(new MethodInvoker(delegate {
                    InputOutputFileLocation2.Text = InputOutputFileLocation.Text;
                }));
            }
            ConventionOptions NamingConvention = new ConventionOptions(InputNamingConvention.Text);
            ConventionOptions FolderConvention = new ConventionOptions(InputFolderConvention.Text);

            if ((CheckCleanPaths(InputInputFileLocation.Text) && CheckCleanPaths(InputOutputFileLocation.Text)) || InputInputFileLocation.Text == "Phone")
            {
                InputDataTable.Rows.Clear();
                OutputDataTable.Rows.Clear();
                DataRow InputFileRow, OutputFileRow;

                string dataPlace;
                if (InputInputFileLocation.Text == "Phone")
                {
                    dataPlace = GetPhoneData();
                }
                else
                {
                    dataPlace = InputInputFileLocation.Text;
                }

                if (dataPlace != "Error")
                {
                    try
                    {
                        string[] files = System.IO.Directory.GetFiles(dataPlace, "*", SearchOption.AllDirectories);
                        foreach (var file in files)
                        {
                            InputInputFileLocation.ForeColor = Color.Green;
                            string fileName = file.Split('\\')[file.Split('\\').Length - 1];
                            string filePath = file.Replace(fileName, "").Replace(dataPlace, "");
                            string fileEnding = fileName.Split('.')[fileName.Split('.').Length - 1];
                            List<string> validFileEndings = new List<string>() { "PNG", "JPEG", "JPG", "RAW", "FRAW", "CR2", "TIFF", "ARW", "WEBP" };
                            if (validFileEndings.Contains(fileEnding.ToUpper()))
                            {
                                InputFileRow = InputDataTable.NewRow();
                                InputFileRow["Input File Name"] = fileName;
                                InputFileRow["Input File Location"] = filePath;

                                InputDataTable.Rows.Add(InputFileRow);

                                OutputFileRow = OutputDataTable.NewRow();
                                OutputFileRow["Output File Name"] = NamingConvention.GetNewFileName(file) + "." + fileEnding;
                                OutputFileRow["Output File Location"] = FolderConvention.GetNewFileName(file);

                                OutputDataTable.Rows.Add(OutputFileRow);

                                if (Tab3InputDataGridView.InvokeRequired)
                                {
                                    Tab3InputDataGridView.Invoke(new MethodInvoker(delegate
                                    {
                                        Tab3InputDataGridView.DataSource = InputDataTable;
                                        Tab3InputDataGridView.Update();
                                        Tab3InputDataGridView.Refresh();
                                    }));
                                }
                                if (Tab3OutputDataGridView.InvokeRequired)
                                {
                                    Tab3OutputDataGridView.Invoke(new MethodInvoker(delegate
                                    {
                                        Tab3OutputDataGridView.DataSource = OutputDataTable;
                                        Tab3OutputDataGridView.Update();
                                        Tab3OutputDataGridView.Refresh();
                                    }));
                                }
                            }
                        }
                    }
                    catch (System.IO.DirectoryNotFoundException)
                    {
                        InputInputFileLocation.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void UpdateGridsTrigger(object sender, EventArgs e)
        {
            if (!BackgroundWorkerUpdateGrid.IsBusy)
            {
                BackgroundWorkerUpdateGrid.RunWorkerAsync(2000);
            }
        }

        public void CheckRunReport()
        {
            if (MainTabControl.SelectedIndex == 3)
            {
                if (!BackgroundWorkerCopying.IsBusy)
                {
                    Tab4InputDataGridView.DataSource = RunInputDataTable;
                    Tab4OutputDataGridView.DataSource = RunOutputDataTable;

                    RunInputDataTable.Clear();
                    RunOutputDataTable.Clear();

                    Tab4InputDataGridView.Update();
                    Tab4InputDataGridView.Refresh();
                    Tab4OutputDataGridView.Update();
                    Tab4OutputDataGridView.Refresh();

                    BackgroundWorkerCopying.RunWorkerAsync(2000);
                }
            }
        }

        private void BackgroundWorkerCopying_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Tab4ProgressBar.Value = 100;

            Tab4InputDataGridView.Sort(Tab4InputDataGridView.Columns[3], ListSortDirection.Descending);
            Tab4OutputDataGridView.Sort(Tab4OutputDataGridView.Columns[3], ListSortDirection.Descending);
        }

        private void CheckRunReportProc(object sender, EventArgs e)
        {
            CheckRunReport();
        }

        private void Tab2Link1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink()
        {
            Tab2Link1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/James-Ashwood/Photo-Organiser-Pro/blob/main/Project%20Files/ConventionOptions.md");
        }
    }
}