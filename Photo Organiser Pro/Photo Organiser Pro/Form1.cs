using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace Photo_Organiser_Pro
{

    public partial class Window1 : Form
    {

        public Window1()
        {
            InitializeComponent();
        }
        public DataTable dataTableCurrent = new DataTable();
        public DataTable dataTableNew = new DataTable();

        private void SetJson(string key, string valueString, IList<string> valueList)
        {

            Settings setup = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(@"C:\Users\James\Documents\GitHub\Photo-Organiser-Pro\Photo Organiser Pro\Photo Organiser Pro\Files\jsconfig1.json"));
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
            File.WriteAllText(@"C:\Users\James\Documents\GitHub\Photo-Organiser-Pro\Photo Organiser Pro\Photo Organiser Pro\Files\jsconfig1.json", JsonConvert.SerializeObject(setup));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dataTableCurrent.Columns.Add("Current File Name");
            dataTableCurrent.Columns.Add("Current File Subdirectory Path");
            dataGridView1.DataSource = dataTableCurrent;

            dataTableNew.Columns.Add("New File Name");
            dataTableNew.Columns.Add("New File Subdirectory Path");
            dataGridView2.DataSource = dataTableNew;

            dataGridView1.Columns[0].Width = 270;
            dataGridView1.Columns[1].Width = 270;
            dataGridView2.Columns[0].Width = 270;
            dataGridView2.Columns[1].Width = 270;

            Settings setup = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(@"C:\Users\James\Documents\GitHub\Photo-Organiser-Pro\Photo Organiser Pro\Photo Organiser Pro\Files\jsconfig1.json"));

            TextCurrentFolderLocation.Text = setup.DefaultCurrentLocation;
            TextNewFolderLocation.Text = setup.DefaultNewLocation;
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

        private void SetAsDefaultNamingConvention(object sender, EventArgs e)
        {
            List<string> namingBuildList = new List<string>();
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
            SetJson("DefaultNaming", "", namingBuildList);
        }

        private void SetAsDefaultFolderConvention(object sender, EventArgs e)
        {
            List<string> folderBuildList = new List<string>();
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
            SetJson("DefaultFolder", "", folderBuildList);
        }

        private void SetDefaultCurrentFolder(object sender, EventArgs e)
        {
            List<string> empty = new List<string>();
            SetJson("DefaultCurrentLocation", TextCurrentFolderLocation.Text, empty);
        }

        private void SetDefaultNewFolder(object sender, EventArgs e)
        {
            List<string> empty = new List<string>();
            SetJson("DefaultNewLocation", TextNewFolderLocation.Text, empty);
        }

        private void ChangeCurrentDestination(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    TextCurrentFolderLocation.Text = fbd.SelectedPath;
                }
            }
        }

        private void ChangeNewDestination(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    TextNewFolderLocation.Text = fbd.SelectedPath;
                }
            }
        }

        private void ChangedTextBoxNewLocation(object sender, EventArgs e)
        {
            DataRow fileRow = dataTableCurrent.NewRow();

            string fileName, fileLocation;

            int count = dataTableCurrent.Rows.Count;
            for (int i = 1; i <= count; i++)
            {
                fileRow = dataTableNew.NewRow();

                fileName = dataTableCurrent.Rows[i-1]["Current File Name"].ToString();
                fileLocation = dataTableCurrent.Rows[i-1]["Current File Subdirectory Path"].ToString();

                fileRow["New File Name"] = fileName;
                fileRow["New File Subdirectory Path"] = fileLocation;
                dataTableNew.Rows.Add(fileRow);
            }

            dataGridView2.DataSource = dataTableNew;
        }

        private void ChangedTextBoxCurrentLocation(object sender, EventArgs e)
        {
            dataTableCurrent.Rows.Clear();

            DataRow fileRow = dataTableCurrent.NewRow();

            string parentDirectory = TextCurrentFolderLocation.Text;
            foreach (string file in System.IO.Directory.GetFiles(parentDirectory, "*", SearchOption.AllDirectories))
            {
                fileRow = dataTableCurrent.NewRow();
                string tempFileName = file.Replace(parentDirectory + "\\", "");
                string fileLocation = file.Replace(parentDirectory + "\\", "");
                int idx = fileLocation.LastIndexOf("\\");
                if (idx != -1)
                {
                    fileLocation = fileLocation.Substring(0, idx);
                }
                string fileName = tempFileName.Replace(fileLocation + "\\", "");
                fileRow["Current File Name"] = fileName;
                fileRow["Current File Subdirectory Path"] = fileLocation;
                dataTableCurrent.Rows.Add(fileRow);
            }

            dataGridView1.DataSource = dataTableCurrent;
        }

        private void CopyImages(object sender, EventArgs e)
        {
            MessageBox.Show("The Copy Images Button Was Pressed");
        }
    }
    public class Settings
    {
        public IList<string> DefaultNaming { get; set; }
        public IList<string> DefaultFolders { get; set; }
        public string DefaultCurrentLocation { get; set; }
        public string DefaultNewLocation { get; set; }
    }
}
