
namespace Photo_Organiser_Pro
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.WindowTitle = new System.Windows.Forms.Label();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.InputAndOutputAreas = new System.Windows.Forms.TabPage();
            this.Tab1ExitButton = new System.Windows.Forms.Button();
            this.Tab1NextButton = new System.Windows.Forms.Button();
            this.SetAsDefaultOutputButton = new System.Windows.Forms.Button();
            this.SetOutputButton = new System.Windows.Forms.Button();
            this.InputOutputFileLocation = new System.Windows.Forms.TextBox();
            this.SetAsDefaultInputButton = new System.Windows.Forms.Button();
            this.UsePhoneButton = new System.Windows.Forms.Button();
            this.SetInputButton = new System.Windows.Forms.Button();
            this.InputInputFileLocation = new System.Windows.Forms.TextBox();
            this.Tab1Subheading2 = new System.Windows.Forms.Label();
            this.Tab1Subheading1 = new System.Windows.Forms.Label();
            this.Tab1Title = new System.Windows.Forms.Label();
            this.NamingConventions = new System.Windows.Forms.TabPage();
            this.Tab2SetDefault2 = new System.Windows.Forms.Button();
            this.Tab2SetDefault1 = new System.Windows.Forms.Button();
            this.InputFolderConvention = new System.Windows.Forms.TextBox();
            this.Tab2Subheading2 = new System.Windows.Forms.Label();
            this.Tab2BackButton = new System.Windows.Forms.Button();
            this.Tab2NextButton = new System.Windows.Forms.Button();
            this.InputNamingConvention = new System.Windows.Forms.TextBox();
            this.Tab2Subheading1 = new System.Windows.Forms.Label();
            this.Tab2Title = new System.Windows.Forms.Label();
            this.Summary = new System.Windows.Forms.TabPage();
            this.Tab3BackButton = new System.Windows.Forms.Button();
            this.Tab3NextButton = new System.Windows.Forms.Button();
            this.Tab3OutputDataGridView = new System.Windows.Forms.DataGridView();
            this.Tab3InputDataGridView = new System.Windows.Forms.DataGridView();
            this.InputOutputFileLocation2 = new System.Windows.Forms.TextBox();
            this.InputInputFileLocation2 = new System.Windows.Forms.TextBox();
            this.Tab3Title = new System.Windows.Forms.Label();
            this.Report = new System.Windows.Forms.TabPage();
            this.Tab4CompletionLabel = new System.Windows.Forms.Label();
            this.Tab4ProgressBar = new System.Windows.Forms.ProgressBar();
            this.Tab4AnotherOneButton = new System.Windows.Forms.Button();
            this.Tab4ExitButton = new System.Windows.Forms.Button();
            this.Tab4OutputDataGridView = new System.Windows.Forms.DataGridView();
            this.Tab4InputDataGridView = new System.Windows.Forms.DataGridView();
            this.Tab4SuccessRate = new System.Windows.Forms.Label();
            this.Tab4Title = new System.Windows.Forms.Label();
            this.NavigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.MainTabControl.SuspendLayout();
            this.InputAndOutputAreas.SuspendLayout();
            this.NamingConventions.SuspendLayout();
            this.Summary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab3OutputDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tab3InputDataGridView)).BeginInit();
            this.Report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab4OutputDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tab4InputDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(54)))));
            this.NavigationPanel.Controls.Add(this.label1);
            this.NavigationPanel.Controls.Add(this.CloseButton);
            this.NavigationPanel.Controls.Add(this.Logo);
            this.NavigationPanel.Controls.Add(this.WindowTitle);
            this.NavigationPanel.Location = new System.Drawing.Point(0, -1);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(1323, 60);
            this.NavigationPanel.TabIndex = 0;
            this.NavigationPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownProgram);
            this.NavigationPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveProgram);
            this.NavigationPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpProgram);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1259, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "-";
            this.label1.Click += new System.EventHandler(this.MinimiseProgram);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(1287, 13);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(27, 26);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseProgram);
            // 
            // Logo
            // 
            this.Logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Logo.ErrorImage")));
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo.InitialImage")));
            this.Logo.Location = new System.Drawing.Point(9, 11);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(43, 35);
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            // 
            // WindowTitle
            // 
            this.WindowTitle.AutoSize = true;
            this.WindowTitle.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.WindowTitle.ForeColor = System.Drawing.Color.White;
            this.WindowTitle.Location = new System.Drawing.Point(58, 19);
            this.WindowTitle.Name = "WindowTitle";
            this.WindowTitle.Size = new System.Drawing.Size(202, 23);
            this.WindowTitle.TabIndex = 1;
            this.WindowTitle.Text = "Photo Organiser Pro";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.InputAndOutputAreas);
            this.MainTabControl.Controls.Add(this.NamingConventions);
            this.MainTabControl.Controls.Add(this.Summary);
            this.MainTabControl.Controls.Add(this.Report);
            this.MainTabControl.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.MainTabControl.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainTabControl.Location = new System.Drawing.Point(0, 57);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1323, 773);
            this.MainTabControl.TabIndex = 1;
            this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.CheckRunReportProc);
            // 
            // InputAndOutputAreas
            // 
            this.InputAndOutputAreas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.InputAndOutputAreas.Controls.Add(this.Tab1ExitButton);
            this.InputAndOutputAreas.Controls.Add(this.Tab1NextButton);
            this.InputAndOutputAreas.Controls.Add(this.SetAsDefaultOutputButton);
            this.InputAndOutputAreas.Controls.Add(this.SetOutputButton);
            this.InputAndOutputAreas.Controls.Add(this.InputOutputFileLocation);
            this.InputAndOutputAreas.Controls.Add(this.SetAsDefaultInputButton);
            this.InputAndOutputAreas.Controls.Add(this.UsePhoneButton);
            this.InputAndOutputAreas.Controls.Add(this.SetInputButton);
            this.InputAndOutputAreas.Controls.Add(this.InputInputFileLocation);
            this.InputAndOutputAreas.Controls.Add(this.Tab1Subheading2);
            this.InputAndOutputAreas.Controls.Add(this.Tab1Subheading1);
            this.InputAndOutputAreas.Controls.Add(this.Tab1Title);
            this.InputAndOutputAreas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputAndOutputAreas.ForeColor = System.Drawing.Color.Black;
            this.InputAndOutputAreas.Location = new System.Drawing.Point(4, 26);
            this.InputAndOutputAreas.Name = "InputAndOutputAreas";
            this.InputAndOutputAreas.Padding = new System.Windows.Forms.Padding(3);
            this.InputAndOutputAreas.Size = new System.Drawing.Size(1315, 743);
            this.InputAndOutputAreas.TabIndex = 0;
            this.InputAndOutputAreas.Text = "Input and Output Areas";
            // 
            // Tab1ExitButton
            // 
            this.Tab1ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(209)))), ((int)(((byte)(142)))));
            this.Tab1ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(98)))));
            this.Tab1ExitButton.Location = new System.Drawing.Point(856, 683);
            this.Tab1ExitButton.Name = "Tab1ExitButton";
            this.Tab1ExitButton.Size = new System.Drawing.Size(200, 39);
            this.Tab1ExitButton.TabIndex = 12;
            this.Tab1ExitButton.Text = "Exit";
            this.Tab1ExitButton.UseVisualStyleBackColor = false;
            this.Tab1ExitButton.Click += new System.EventHandler(this.CloseProgram);
            // 
            // Tab1NextButton
            // 
            this.Tab1NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(209)))), ((int)(((byte)(142)))));
            this.Tab1NextButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(98)))));
            this.Tab1NextButton.Location = new System.Drawing.Point(1081, 683);
            this.Tab1NextButton.Name = "Tab1NextButton";
            this.Tab1NextButton.Size = new System.Drawing.Size(200, 39);
            this.Tab1NextButton.TabIndex = 11;
            this.Tab1NextButton.Text = "Next";
            this.Tab1NextButton.UseVisualStyleBackColor = false;
            this.Tab1NextButton.Click += new System.EventHandler(this.NextTab);
            // 
            // SetAsDefaultOutputButton
            // 
            this.SetAsDefaultOutputButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.SetAsDefaultOutputButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(98)))));
            this.SetAsDefaultOutputButton.Location = new System.Drawing.Point(696, 389);
            this.SetAsDefaultOutputButton.Name = "SetAsDefaultOutputButton";
            this.SetAsDefaultOutputButton.Size = new System.Drawing.Size(379, 39);
            this.SetAsDefaultOutputButton.TabIndex = 10;
            this.SetAsDefaultOutputButton.Text = "Set As Default";
            this.SetAsDefaultOutputButton.UseVisualStyleBackColor = false;
            this.SetAsDefaultOutputButton.Click += new System.EventHandler(this.UpdateSettings);
            // 
            // SetOutputButton
            // 
            this.SetOutputButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.SetOutputButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(98)))));
            this.SetOutputButton.Location = new System.Drawing.Point(209, 389);
            this.SetOutputButton.Name = "SetOutputButton";
            this.SetOutputButton.Size = new System.Drawing.Size(379, 39);
            this.SetOutputButton.TabIndex = 8;
            this.SetOutputButton.Text = "Set Output";
            this.SetOutputButton.UseVisualStyleBackColor = false;
            this.SetOutputButton.Click += new System.EventHandler(this.SetOutputFolderDialog);
            // 
            // InputOutputFileLocation
            // 
            this.InputOutputFileLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.InputOutputFileLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(98)))));
            this.InputOutputFileLocation.Location = new System.Drawing.Point(33, 329);
            this.InputOutputFileLocation.Name = "InputOutputFileLocation";
            this.InputOutputFileLocation.Size = new System.Drawing.Size(1248, 27);
            this.InputOutputFileLocation.TabIndex = 7;
            this.InputOutputFileLocation.Text = "Output File Location";
            this.InputOutputFileLocation.TextChanged += new System.EventHandler(this.UpdateGridsTrigger);
            // 
            // SetAsDefaultInputButton
            // 
            this.SetAsDefaultInputButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.SetAsDefaultInputButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(98)))));
            this.SetAsDefaultInputButton.Location = new System.Drawing.Point(900, 197);
            this.SetAsDefaultInputButton.Name = "SetAsDefaultInputButton";
            this.SetAsDefaultInputButton.Size = new System.Drawing.Size(379, 39);
            this.SetAsDefaultInputButton.TabIndex = 6;
            this.SetAsDefaultInputButton.Text = "Set As Default";
            this.SetAsDefaultInputButton.UseVisualStyleBackColor = false;
            this.SetAsDefaultInputButton.Click += new System.EventHandler(this.UpdateSettings);
            // 
            // UsePhoneButton
            // 
            this.UsePhoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.UsePhoneButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(98)))));
            this.UsePhoneButton.Location = new System.Drawing.Point(467, 197);
            this.UsePhoneButton.Name = "UsePhoneButton";
            this.UsePhoneButton.Size = new System.Drawing.Size(379, 39);
            this.UsePhoneButton.TabIndex = 5;
            this.UsePhoneButton.Text = "Use Phone";
            this.UsePhoneButton.UseVisualStyleBackColor = false;
            this.UsePhoneButton.Click += new System.EventHandler(this.SetPhoneAsInput);
            // 
            // SetInputButton
            // 
            this.SetInputButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.SetInputButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(98)))));
            this.SetInputButton.Location = new System.Drawing.Point(31, 197);
            this.SetInputButton.Name = "SetInputButton";
            this.SetInputButton.Size = new System.Drawing.Size(379, 39);
            this.SetInputButton.TabIndex = 4;
            this.SetInputButton.Text = "Set Input";
            this.SetInputButton.UseVisualStyleBackColor = false;
            this.SetInputButton.Click += new System.EventHandler(this.SetInputFolderDialog);
            // 
            // InputInputFileLocation
            // 
            this.InputInputFileLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.InputInputFileLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(98)))));
            this.InputInputFileLocation.Location = new System.Drawing.Point(31, 137);
            this.InputInputFileLocation.Name = "InputInputFileLocation";
            this.InputInputFileLocation.Size = new System.Drawing.Size(1248, 27);
            this.InputInputFileLocation.TabIndex = 3;
            this.InputInputFileLocation.Text = "Input File Location";
            this.InputInputFileLocation.TextChanged += new System.EventHandler(this.UpdateGridsTrigger);
            // 
            // Tab1Subheading2
            // 
            this.Tab1Subheading2.AutoSize = true;
            this.Tab1Subheading2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab1Subheading2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(54)))));
            this.Tab1Subheading2.Location = new System.Drawing.Point(22, 271);
            this.Tab1Subheading2.Name = "Tab1Subheading2";
            this.Tab1Subheading2.Size = new System.Drawing.Size(128, 24);
            this.Tab1Subheading2.TabIndex = 2;
            this.Tab1Subheading2.Text = "Output Files";
            // 
            // Tab1Subheading1
            // 
            this.Tab1Subheading1.AutoSize = true;
            this.Tab1Subheading1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab1Subheading1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(54)))));
            this.Tab1Subheading1.Location = new System.Drawing.Point(22, 79);
            this.Tab1Subheading1.Name = "Tab1Subheading1";
            this.Tab1Subheading1.Size = new System.Drawing.Size(108, 24);
            this.Tab1Subheading1.TabIndex = 1;
            this.Tab1Subheading1.Text = "Input Files";
            // 
            // Tab1Title
            // 
            this.Tab1Title.AutoSize = true;
            this.Tab1Title.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(54)))));
            this.Tab1Title.Location = new System.Drawing.Point(20, 19);
            this.Tab1Title.Name = "Tab1Title";
            this.Tab1Title.Size = new System.Drawing.Size(321, 33);
            this.Tab1Title.TabIndex = 0;
            this.Tab1Title.Text = "Input and Output Areas";
            // 
            // NamingConventions
            // 
            this.NamingConventions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.NamingConventions.Controls.Add(this.Tab2SetDefault2);
            this.NamingConventions.Controls.Add(this.Tab2SetDefault1);
            this.NamingConventions.Controls.Add(this.InputFolderConvention);
            this.NamingConventions.Controls.Add(this.Tab2Subheading2);
            this.NamingConventions.Controls.Add(this.Tab2BackButton);
            this.NamingConventions.Controls.Add(this.Tab2NextButton);
            this.NamingConventions.Controls.Add(this.InputNamingConvention);
            this.NamingConventions.Controls.Add(this.Tab2Subheading1);
            this.NamingConventions.Controls.Add(this.Tab2Title);
            this.NamingConventions.Location = new System.Drawing.Point(4, 26);
            this.NamingConventions.Name = "NamingConventions";
            this.NamingConventions.Padding = new System.Windows.Forms.Padding(3);
            this.NamingConventions.Size = new System.Drawing.Size(1315, 743);
            this.NamingConventions.TabIndex = 1;
            this.NamingConventions.Text = "Naming Conventions";
            // 
            // Tab2SetDefault2
            // 
            this.Tab2SetDefault2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.Tab2SetDefault2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(98)))));
            this.Tab2SetDefault2.Location = new System.Drawing.Point(1088, 406);
            this.Tab2SetDefault2.Name = "Tab2SetDefault2";
            this.Tab2SetDefault2.Size = new System.Drawing.Size(218, 27);
            this.Tab2SetDefault2.TabIndex = 30;
            this.Tab2SetDefault2.Text = "Set As Default";
            this.Tab2SetDefault2.UseVisualStyleBackColor = false;
            this.Tab2SetDefault2.Click += new System.EventHandler(this.UpdateSettings);
            // 
            // Tab2SetDefault1
            // 
            this.Tab2SetDefault1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.Tab2SetDefault1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(98)))));
            this.Tab2SetDefault1.Location = new System.Drawing.Point(1088, 137);
            this.Tab2SetDefault1.Name = "Tab2SetDefault1";
            this.Tab2SetDefault1.Size = new System.Drawing.Size(218, 27);
            this.Tab2SetDefault1.TabIndex = 29;
            this.Tab2SetDefault1.Text = "Set As Default";
            this.Tab2SetDefault1.UseVisualStyleBackColor = false;
            this.Tab2SetDefault1.Click += new System.EventHandler(this.UpdateSettings);
            // 
            // InputFolderConvention
            // 
            this.InputFolderConvention.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.InputFolderConvention.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputFolderConvention.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(98)))));
            this.InputFolderConvention.Location = new System.Drawing.Point(38, 406);
            this.InputFolderConvention.Name = "InputFolderConvention";
            this.InputFolderConvention.Size = new System.Drawing.Size(1044, 27);
            this.InputFolderConvention.TabIndex = 22;
            this.InputFolderConvention.Text = "Folder Convention Syntax Here";
            this.InputFolderConvention.TextChanged += new System.EventHandler(this.UpdateGridsTrigger);
            // 
            // Tab2Subheading2
            // 
            this.Tab2Subheading2.AutoSize = true;
            this.Tab2Subheading2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab2Subheading2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(54)))));
            this.Tab2Subheading2.Location = new System.Drawing.Point(29, 348);
            this.Tab2Subheading2.Name = "Tab2Subheading2";
            this.Tab2Subheading2.Size = new System.Drawing.Size(200, 24);
            this.Tab2Subheading2.TabIndex = 21;
            this.Tab2Subheading2.Text = "Folder Convention";
            // 
            // Tab2BackButton
            // 
            this.Tab2BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(209)))), ((int)(((byte)(142)))));
            this.Tab2BackButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Tab2BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(98)))));
            this.Tab2BackButton.Location = new System.Drawing.Point(856, 683);
            this.Tab2BackButton.Name = "Tab2BackButton";
            this.Tab2BackButton.Size = new System.Drawing.Size(200, 39);
            this.Tab2BackButton.TabIndex = 14;
            this.Tab2BackButton.Text = "Back";
            this.Tab2BackButton.UseVisualStyleBackColor = false;
            this.Tab2BackButton.Click += new System.EventHandler(this.BackTab);
            // 
            // Tab2NextButton
            // 
            this.Tab2NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(209)))), ((int)(((byte)(142)))));
            this.Tab2NextButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Tab2NextButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(98)))));
            this.Tab2NextButton.Location = new System.Drawing.Point(1081, 683);
            this.Tab2NextButton.Name = "Tab2NextButton";
            this.Tab2NextButton.Size = new System.Drawing.Size(200, 39);
            this.Tab2NextButton.TabIndex = 13;
            this.Tab2NextButton.Text = "Next";
            this.Tab2NextButton.UseVisualStyleBackColor = false;
            this.Tab2NextButton.Click += new System.EventHandler(this.NextTab);
            // 
            // InputNamingConvention
            // 
            this.InputNamingConvention.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.InputNamingConvention.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputNamingConvention.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(98)))));
            this.InputNamingConvention.Location = new System.Drawing.Point(31, 137);
            this.InputNamingConvention.Name = "InputNamingConvention";
            this.InputNamingConvention.Size = new System.Drawing.Size(1051, 27);
            this.InputNamingConvention.TabIndex = 6;
            this.InputNamingConvention.Text = "Naming Convention Syntax Here";
            this.InputNamingConvention.TextChanged += new System.EventHandler(this.UpdateGridsTrigger);
            // 
            // Tab2Subheading1
            // 
            this.Tab2Subheading1.AutoSize = true;
            this.Tab2Subheading1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab2Subheading1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(54)))));
            this.Tab2Subheading1.Location = new System.Drawing.Point(22, 79);
            this.Tab2Subheading1.Name = "Tab2Subheading1";
            this.Tab2Subheading1.Size = new System.Drawing.Size(218, 24);
            this.Tab2Subheading1.TabIndex = 5;
            this.Tab2Subheading1.Text = "Naming Convention";
            // 
            // Tab2Title
            // 
            this.Tab2Title.AutoSize = true;
            this.Tab2Title.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(54)))));
            this.Tab2Title.Location = new System.Drawing.Point(20, 19);
            this.Tab2Title.Name = "Tab2Title";
            this.Tab2Title.Size = new System.Drawing.Size(293, 33);
            this.Tab2Title.TabIndex = 4;
            this.Tab2Title.Text = "Naming Conventions";
            // 
            // Summary
            // 
            this.Summary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Summary.Controls.Add(this.Tab3BackButton);
            this.Summary.Controls.Add(this.Tab3NextButton);
            this.Summary.Controls.Add(this.Tab3OutputDataGridView);
            this.Summary.Controls.Add(this.Tab3InputDataGridView);
            this.Summary.Controls.Add(this.InputOutputFileLocation2);
            this.Summary.Controls.Add(this.InputInputFileLocation2);
            this.Summary.Controls.Add(this.Tab3Title);
            this.Summary.Location = new System.Drawing.Point(4, 26);
            this.Summary.Name = "Summary";
            this.Summary.Padding = new System.Windows.Forms.Padding(3);
            this.Summary.Size = new System.Drawing.Size(1315, 743);
            this.Summary.TabIndex = 2;
            this.Summary.Text = "Summary";
            // 
            // Tab3BackButton
            // 
            this.Tab3BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(209)))), ((int)(((byte)(142)))));
            this.Tab3BackButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Tab3BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(98)))));
            this.Tab3BackButton.Location = new System.Drawing.Point(856, 683);
            this.Tab3BackButton.Name = "Tab3BackButton";
            this.Tab3BackButton.Size = new System.Drawing.Size(200, 39);
            this.Tab3BackButton.TabIndex = 16;
            this.Tab3BackButton.Text = "Back";
            this.Tab3BackButton.UseVisualStyleBackColor = false;
            this.Tab3BackButton.Click += new System.EventHandler(this.BackTab);
            // 
            // Tab3NextButton
            // 
            this.Tab3NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(209)))), ((int)(((byte)(142)))));
            this.Tab3NextButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Tab3NextButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(98)))));
            this.Tab3NextButton.Location = new System.Drawing.Point(1081, 683);
            this.Tab3NextButton.Name = "Tab3NextButton";
            this.Tab3NextButton.Size = new System.Drawing.Size(200, 39);
            this.Tab3NextButton.TabIndex = 15;
            this.Tab3NextButton.Text = "Run";
            this.Tab3NextButton.UseVisualStyleBackColor = false;
            this.Tab3NextButton.Click += new System.EventHandler(this.NextTab);
            // 
            // Tab3OutputDataGridView
            // 
            this.Tab3OutputDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Tab3OutputDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tab3OutputDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.Tab3OutputDataGridView.Location = new System.Drawing.Point(705, 110);
            this.Tab3OutputDataGridView.Name = "Tab3OutputDataGridView";
            this.Tab3OutputDataGridView.RowHeadersVisible = false;
            this.Tab3OutputDataGridView.Size = new System.Drawing.Size(576, 536);
            this.Tab3OutputDataGridView.TabIndex = 10;
            // 
            // Tab3InputDataGridView
            // 
            this.Tab3InputDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Tab3InputDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tab3InputDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.Tab3InputDataGridView.Location = new System.Drawing.Point(26, 110);
            this.Tab3InputDataGridView.Name = "Tab3InputDataGridView";
            this.Tab3InputDataGridView.RowHeadersVisible = false;
            this.Tab3InputDataGridView.Size = new System.Drawing.Size(582, 536);
            this.Tab3InputDataGridView.TabIndex = 9;
            // 
            // InputOutputFileLocation2
            // 
            this.InputOutputFileLocation2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.InputOutputFileLocation2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputOutputFileLocation2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(98)))));
            this.InputOutputFileLocation2.Location = new System.Drawing.Point(705, 67);
            this.InputOutputFileLocation2.Name = "InputOutputFileLocation2";
            this.InputOutputFileLocation2.Size = new System.Drawing.Size(576, 27);
            this.InputOutputFileLocation2.TabIndex = 8;
            this.InputOutputFileLocation2.Text = "Output File Location";
            this.InputOutputFileLocation2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InputInputFileLocation2
            // 
            this.InputInputFileLocation2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.InputInputFileLocation2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputInputFileLocation2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(98)))));
            this.InputInputFileLocation2.Location = new System.Drawing.Point(26, 67);
            this.InputInputFileLocation2.Name = "InputInputFileLocation2";
            this.InputInputFileLocation2.Size = new System.Drawing.Size(582, 27);
            this.InputInputFileLocation2.TabIndex = 7;
            this.InputInputFileLocation2.Text = "Input File Location";
            // 
            // Tab3Title
            // 
            this.Tab3Title.AutoSize = true;
            this.Tab3Title.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab3Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(54)))));
            this.Tab3Title.Location = new System.Drawing.Point(20, 19);
            this.Tab3Title.Name = "Tab3Title";
            this.Tab3Title.Size = new System.Drawing.Size(137, 33);
            this.Tab3Title.TabIndex = 5;
            this.Tab3Title.Text = "Summary";
            // 
            // Report
            // 
            this.Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Report.Controls.Add(this.Tab4CompletionLabel);
            this.Report.Controls.Add(this.Tab4ProgressBar);
            this.Report.Controls.Add(this.Tab4AnotherOneButton);
            this.Report.Controls.Add(this.Tab4ExitButton);
            this.Report.Controls.Add(this.Tab4OutputDataGridView);
            this.Report.Controls.Add(this.Tab4InputDataGridView);
            this.Report.Controls.Add(this.Tab4SuccessRate);
            this.Report.Controls.Add(this.Tab4Title);
            this.Report.Location = new System.Drawing.Point(4, 26);
            this.Report.Name = "Report";
            this.Report.Padding = new System.Windows.Forms.Padding(3);
            this.Report.Size = new System.Drawing.Size(1315, 743);
            this.Report.TabIndex = 3;
            this.Report.Text = "Report";
            // 
            // Tab4CompletionLabel
            // 
            this.Tab4CompletionLabel.AutoSize = true;
            this.Tab4CompletionLabel.Location = new System.Drawing.Point(1191, 19);
            this.Tab4CompletionLabel.Name = "Tab4CompletionLabel";
            this.Tab4CompletionLabel.Size = new System.Drawing.Size(90, 19);
            this.Tab4CompletionLabel.TabIndex = 20;
            this.Tab4CompletionLabel.Text = "Completion";
            // 
            // Tab4ProgressBar
            // 
            this.Tab4ProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(209)))), ((int)(((byte)(142)))));
            this.Tab4ProgressBar.Location = new System.Drawing.Point(278, 44);
            this.Tab4ProgressBar.Name = "Tab4ProgressBar";
            this.Tab4ProgressBar.Size = new System.Drawing.Size(1003, 39);
            this.Tab4ProgressBar.TabIndex = 19;
            // 
            // Tab4AnotherOneButton
            // 
            this.Tab4AnotherOneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(209)))), ((int)(((byte)(142)))));
            this.Tab4AnotherOneButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Tab4AnotherOneButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(98)))));
            this.Tab4AnotherOneButton.Location = new System.Drawing.Point(856, 683);
            this.Tab4AnotherOneButton.Name = "Tab4AnotherOneButton";
            this.Tab4AnotherOneButton.Size = new System.Drawing.Size(200, 39);
            this.Tab4AnotherOneButton.TabIndex = 18;
            this.Tab4AnotherOneButton.Text = "Another One";
            this.Tab4AnotherOneButton.UseVisualStyleBackColor = false;
            this.Tab4AnotherOneButton.Click += new System.EventHandler(this.BackToStart);
            // 
            // Tab4ExitButton
            // 
            this.Tab4ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(209)))), ((int)(((byte)(142)))));
            this.Tab4ExitButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Tab4ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(83)))), ((int)(((byte)(98)))));
            this.Tab4ExitButton.Location = new System.Drawing.Point(1081, 683);
            this.Tab4ExitButton.Name = "Tab4ExitButton";
            this.Tab4ExitButton.Size = new System.Drawing.Size(200, 39);
            this.Tab4ExitButton.TabIndex = 17;
            this.Tab4ExitButton.Text = "Exit";
            this.Tab4ExitButton.UseVisualStyleBackColor = false;
            this.Tab4ExitButton.Click += new System.EventHandler(this.CloseProgram);
            // 
            // Tab4OutputDataGridView
            // 
            this.Tab4OutputDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Tab4OutputDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tab4OutputDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.Tab4OutputDataGridView.Location = new System.Drawing.Point(705, 110);
            this.Tab4OutputDataGridView.Name = "Tab4OutputDataGridView";
            this.Tab4OutputDataGridView.RowHeadersVisible = false;
            this.Tab4OutputDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tab4OutputDataGridView.Size = new System.Drawing.Size(576, 536);
            this.Tab4OutputDataGridView.TabIndex = 12;
            // 
            // Tab4InputDataGridView
            // 
            this.Tab4InputDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Tab4InputDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tab4InputDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.Tab4InputDataGridView.Location = new System.Drawing.Point(26, 110);
            this.Tab4InputDataGridView.Name = "Tab4InputDataGridView";
            this.Tab4InputDataGridView.RowHeadersVisible = false;
            this.Tab4InputDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tab4InputDataGridView.Size = new System.Drawing.Size(582, 536);
            this.Tab4InputDataGridView.TabIndex = 11;
            // 
            // Tab4SuccessRate
            // 
            this.Tab4SuccessRate.AutoSize = true;
            this.Tab4SuccessRate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab4SuccessRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(54)))));
            this.Tab4SuccessRate.Location = new System.Drawing.Point(22, 62);
            this.Tab4SuccessRate.Name = "Tab4SuccessRate";
            this.Tab4SuccessRate.Size = new System.Drawing.Size(152, 21);
            this.Tab4SuccessRate.TabIndex = 7;
            this.Tab4SuccessRate.Text = "Success Rate: N/A";
            // 
            // Tab4Title
            // 
            this.Tab4Title.AutoSize = true;
            this.Tab4Title.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab4Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(54)))));
            this.Tab4Title.Location = new System.Drawing.Point(20, 19);
            this.Tab4Title.Name = "Tab4Title";
            this.Tab4Title.Size = new System.Drawing.Size(103, 33);
            this.Tab4Title.TabIndex = 6;
            this.Tab4Title.Text = "Report";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 832);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.NavigationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Photo Organiser Pro";
            this.Load += new System.EventHandler(this.GeneralSetupTrigger);
            this.NavigationPanel.ResumeLayout(false);
            this.NavigationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.MainTabControl.ResumeLayout(false);
            this.InputAndOutputAreas.ResumeLayout(false);
            this.InputAndOutputAreas.PerformLayout();
            this.NamingConventions.ResumeLayout(false);
            this.NamingConventions.PerformLayout();
            this.Summary.ResumeLayout(false);
            this.Summary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab3OutputDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tab3InputDataGridView)).EndInit();
            this.Report.ResumeLayout(false);
            this.Report.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab4OutputDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tab4InputDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Label WindowTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage InputAndOutputAreas;
        private System.Windows.Forms.TabPage NamingConventions;
        private System.Windows.Forms.TabPage Summary;
        private System.Windows.Forms.TabPage Report;
        private System.Windows.Forms.Label Tab1Title;
        private System.Windows.Forms.Button SetInputButton;
        private System.Windows.Forms.TextBox InputInputFileLocation;
        private System.Windows.Forms.Label Tab1Subheading2;
        private System.Windows.Forms.Label Tab1Subheading1;
        private System.Windows.Forms.Button SetAsDefaultInputButton;
        private System.Windows.Forms.Button UsePhoneButton;
        private System.Windows.Forms.Button SetAsDefaultOutputButton;
        private System.Windows.Forms.Button SetOutputButton;
        private System.Windows.Forms.TextBox InputOutputFileLocation;
        private System.Windows.Forms.Button Tab1ExitButton;
        private System.Windows.Forms.Button Tab1NextButton;
        private System.Windows.Forms.TextBox InputNamingConvention;
        private System.Windows.Forms.Label Tab2Subheading1;
        private System.Windows.Forms.Label Tab2Title;
        private System.Windows.Forms.Button Tab2BackButton;
        private System.Windows.Forms.Button Tab2NextButton;
        private System.Windows.Forms.TextBox InputFolderConvention;
        private System.Windows.Forms.Label Tab2Subheading2;
        private System.Windows.Forms.TextBox InputOutputFileLocation2;
        private System.Windows.Forms.TextBox InputInputFileLocation2;
        private System.Windows.Forms.Label Tab3Title;
        private System.Windows.Forms.Button Tab3BackButton;
        private System.Windows.Forms.Button Tab3NextButton;
        private System.Windows.Forms.DataGridView Tab3OutputDataGridView;
        private System.Windows.Forms.DataGridView Tab3InputDataGridView;
        private System.Windows.Forms.Label Tab4Title;
        private System.Windows.Forms.Label Tab4SuccessRate;
        private System.Windows.Forms.Button Tab4AnotherOneButton;
        private System.Windows.Forms.Button Tab4ExitButton;
        private System.Windows.Forms.DataGridView Tab4OutputDataGridView;
        private System.Windows.Forms.DataGridView Tab4InputDataGridView;
        private System.Windows.Forms.Button Tab2SetDefault2;
        private System.Windows.Forms.Button Tab2SetDefault1;
        private System.Windows.Forms.Label Tab4CompletionLabel;
        private System.Windows.Forms.ProgressBar Tab4ProgressBar;
    }
}