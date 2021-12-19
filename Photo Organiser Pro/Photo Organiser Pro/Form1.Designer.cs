/*  Program:        Form1.Designer.cs
 *  Last Edited:    01/11/2021
 *  Last Editor:    James Ashwood
 *  Version:        N/A
 *  Commented:      Automatically
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Photo_Organiser_Pro
{
    partial class Window1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window1));
            this.DateTakenBoxNamingConvention = new System.Windows.Forms.CheckBox();
            this.NamingConventionBox = new System.Windows.Forms.GroupBox();
            this.SetDefaultNamingConvention = new System.Windows.Forms.Button();
            this.OrignalNameBoxNamingConvention = new System.Windows.Forms.CheckBox();
            this.DateModifiedBoxNamingConvention = new System.Windows.Forms.CheckBox();
            this.DateCreatedBoxNamingConvention = new System.Windows.Forms.CheckBox();
            this.TimeTakenBoxNamingConvention = new System.Windows.Forms.CheckBox();
            this.CameraModelBoxNamingConvention = new System.Windows.Forms.CheckBox();
            this.FolderConventionBox = new System.Windows.Forms.GroupBox();
            this.OrignalNameFolderConvention = new System.Windows.Forms.RadioButton();
            this.DateModifiedFolderConvention = new System.Windows.Forms.RadioButton();
            this.DateCreatedFolderConvention = new System.Windows.Forms.RadioButton();
            this.DateTimeCameraTakenFolderConvention = new System.Windows.Forms.RadioButton();
            this.DateTimeTakenFolderConvention = new System.Windows.Forms.RadioButton();
            this.DateTakenFolderConvention = new System.Windows.Forms.RadioButton();
            this.SetDefaultFolderConvention = new System.Windows.Forms.Button();
            this.FolderLocationBox = new System.Windows.Forms.GroupBox();
            this.TextNewFolderLocation = new System.Windows.Forms.TextBox();
            this.TextCurrentFolderLocation = new System.Windows.Forms.TextBox();
            this.ChangeCurrrentFolderLocation = new System.Windows.Forms.Button();
            this.ChangeNewFolderLocation = new System.Windows.Forms.Button();
            this.SetDefaultCurrrentFolderLocation = new System.Windows.Forms.Button();
            this.SetDefaultNewFolderLocation = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.copyImageBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.NamingConventionBox.SuspendLayout();
            this.FolderConventionBox.SuspendLayout();
            this.FolderLocationBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTakenBoxNamingConvention
            // 
            this.DateTakenBoxNamingConvention.AutoSize = true;
            this.DateTakenBoxNamingConvention.Location = new System.Drawing.Point(8, 29);
            this.DateTakenBoxNamingConvention.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateTakenBoxNamingConvention.Name = "DateTakenBoxNamingConvention";
            this.DateTakenBoxNamingConvention.Size = new System.Drawing.Size(117, 24);
            this.DateTakenBoxNamingConvention.TabIndex = 0;
            this.DateTakenBoxNamingConvention.Text = "Date Taken";
            this.DateTakenBoxNamingConvention.UseVisualStyleBackColor = true;
            this.DateTakenBoxNamingConvention.CheckedChanged += new System.EventHandler(this.UpdatedNamingConvention);
            // 
            // NamingConventionBox
            // 
            this.NamingConventionBox.BackColor = System.Drawing.SystemColors.Control;
            this.NamingConventionBox.Controls.Add(this.SetDefaultNamingConvention);
            this.NamingConventionBox.Controls.Add(this.OrignalNameBoxNamingConvention);
            this.NamingConventionBox.Controls.Add(this.DateModifiedBoxNamingConvention);
            this.NamingConventionBox.Controls.Add(this.DateCreatedBoxNamingConvention);
            this.NamingConventionBox.Controls.Add(this.TimeTakenBoxNamingConvention);
            this.NamingConventionBox.Controls.Add(this.CameraModelBoxNamingConvention);
            this.NamingConventionBox.Controls.Add(this.DateTakenBoxNamingConvention);
            this.NamingConventionBox.Location = new System.Drawing.Point(3, 3);
            this.NamingConventionBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NamingConventionBox.MinimumSize = new System.Drawing.Size(1904, 62);
            this.NamingConventionBox.Name = "NamingConventionBox";
            this.NamingConventionBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NamingConventionBox.Size = new System.Drawing.Size(1904, 62);
            this.NamingConventionBox.TabIndex = 1;
            this.NamingConventionBox.TabStop = false;
            this.NamingConventionBox.Text = "Naming Convention";
            // 
            // SetDefaultNamingConvention
            // 
            this.SetDefaultNamingConvention.Location = new System.Drawing.Point(1754, 23);
            this.SetDefaultNamingConvention.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SetDefaultNamingConvention.Name = "SetDefaultNamingConvention";
            this.SetDefaultNamingConvention.Size = new System.Drawing.Size(144, 32);
            this.SetDefaultNamingConvention.TabIndex = 6;
            this.SetDefaultNamingConvention.Text = "Set Default";
            this.SetDefaultNamingConvention.UseVisualStyleBackColor = true;
            this.SetDefaultNamingConvention.Click += new System.EventHandler(this.SetAsDefaultNamingConvention);
            // 
            // OrignalNameBoxNamingConvention
            // 
            this.OrignalNameBoxNamingConvention.AutoSize = true;
            this.OrignalNameBoxNamingConvention.Location = new System.Drawing.Point(788, 29);
            this.OrignalNameBoxNamingConvention.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrignalNameBoxNamingConvention.Name = "OrignalNameBoxNamingConvention";
            this.OrignalNameBoxNamingConvention.Size = new System.Drawing.Size(138, 24);
            this.OrignalNameBoxNamingConvention.TabIndex = 5;
            this.OrignalNameBoxNamingConvention.Text = "Original Name";
            this.OrignalNameBoxNamingConvention.UseVisualStyleBackColor = true;
            this.OrignalNameBoxNamingConvention.CheckedChanged += new System.EventHandler(this.UpdatedNamingConvention);
            // 
            // DateModifiedBoxNamingConvention
            // 
            this.DateModifiedBoxNamingConvention.AutoSize = true;
            this.DateModifiedBoxNamingConvention.Location = new System.Drawing.Point(627, 29);
            this.DateModifiedBoxNamingConvention.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateModifiedBoxNamingConvention.Name = "DateModifiedBoxNamingConvention";
            this.DateModifiedBoxNamingConvention.Size = new System.Drawing.Size(135, 24);
            this.DateModifiedBoxNamingConvention.TabIndex = 4;
            this.DateModifiedBoxNamingConvention.Text = "Date Modified";
            this.DateModifiedBoxNamingConvention.UseVisualStyleBackColor = true;
            this.DateModifiedBoxNamingConvention.CheckedChanged += new System.EventHandler(this.UpdatedNamingConvention);
            // 
            // DateCreatedBoxNamingConvention
            // 
            this.DateCreatedBoxNamingConvention.AutoSize = true;
            this.DateCreatedBoxNamingConvention.Location = new System.Drawing.Point(471, 29);
            this.DateCreatedBoxNamingConvention.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateCreatedBoxNamingConvention.Name = "DateCreatedBoxNamingConvention";
            this.DateCreatedBoxNamingConvention.Size = new System.Drawing.Size(131, 24);
            this.DateCreatedBoxNamingConvention.TabIndex = 3;
            this.DateCreatedBoxNamingConvention.Text = "Date Created";
            this.DateCreatedBoxNamingConvention.UseVisualStyleBackColor = true;
            this.DateCreatedBoxNamingConvention.CheckedChanged += new System.EventHandler(this.UpdatedNamingConvention);
            // 
            // TimeTakenBoxNamingConvention
            // 
            this.TimeTakenBoxNamingConvention.AutoSize = true;
            this.TimeTakenBoxNamingConvention.Location = new System.Drawing.Point(160, 29);
            this.TimeTakenBoxNamingConvention.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TimeTakenBoxNamingConvention.Name = "TimeTakenBoxNamingConvention";
            this.TimeTakenBoxNamingConvention.Size = new System.Drawing.Size(118, 24);
            this.TimeTakenBoxNamingConvention.TabIndex = 2;
            this.TimeTakenBoxNamingConvention.Text = "Time Taken";
            this.TimeTakenBoxNamingConvention.UseVisualStyleBackColor = true;
            this.TimeTakenBoxNamingConvention.CheckedChanged += new System.EventHandler(this.UpdatedNamingConvention);
            // 
            // CameraModelBoxNamingConvention
            // 
            this.CameraModelBoxNamingConvention.AutoSize = true;
            this.CameraModelBoxNamingConvention.Location = new System.Drawing.Point(308, 29);
            this.CameraModelBoxNamingConvention.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CameraModelBoxNamingConvention.Name = "CameraModelBoxNamingConvention";
            this.CameraModelBoxNamingConvention.Size = new System.Drawing.Size(140, 24);
            this.CameraModelBoxNamingConvention.TabIndex = 1;
            this.CameraModelBoxNamingConvention.Text = "Camera Model";
            this.CameraModelBoxNamingConvention.UseVisualStyleBackColor = true;
            this.CameraModelBoxNamingConvention.CheckedChanged += new System.EventHandler(this.UpdatedNamingConvention);
            // 
            // FolderConventionBox
            // 
            this.FolderConventionBox.BackColor = System.Drawing.SystemColors.Control;
            this.FolderConventionBox.Controls.Add(this.OrignalNameFolderConvention);
            this.FolderConventionBox.Controls.Add(this.DateModifiedFolderConvention);
            this.FolderConventionBox.Controls.Add(this.DateCreatedFolderConvention);
            this.FolderConventionBox.Controls.Add(this.DateTimeCameraTakenFolderConvention);
            this.FolderConventionBox.Controls.Add(this.DateTimeTakenFolderConvention);
            this.FolderConventionBox.Controls.Add(this.DateTakenFolderConvention);
            this.FolderConventionBox.Controls.Add(this.SetDefaultFolderConvention);
            this.FolderConventionBox.Location = new System.Drawing.Point(3, 68);
            this.FolderConventionBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FolderConventionBox.MinimumSize = new System.Drawing.Size(1904, 62);
            this.FolderConventionBox.Name = "FolderConventionBox";
            this.FolderConventionBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FolderConventionBox.Size = new System.Drawing.Size(1904, 62);
            this.FolderConventionBox.TabIndex = 7;
            this.FolderConventionBox.TabStop = false;
            this.FolderConventionBox.Text = "Folder Convention";
            // 
            // OrignalNameFolderConvention
            // 
            this.OrignalNameFolderConvention.AutoSize = true;
            this.OrignalNameFolderConvention.Location = new System.Drawing.Point(1009, 29);
            this.OrignalNameFolderConvention.Name = "OrignalNameFolderConvention";
            this.OrignalNameFolderConvention.Size = new System.Drawing.Size(214, 24);
            this.OrignalNameFolderConvention.TabIndex = 12;
            this.OrignalNameFolderConvention.TabStop = true;
            this.OrignalNameFolderConvention.Text = "Original Folder Structure";
            this.OrignalNameFolderConvention.UseVisualStyleBackColor = true;
            this.OrignalNameFolderConvention.CheckedChanged += new System.EventHandler(this.UpdatedFolderConvention);
            // 
            // DateModifiedFolderConvention
            // 
            this.DateModifiedFolderConvention.AutoSize = true;
            this.DateModifiedFolderConvention.Location = new System.Drawing.Point(844, 29);
            this.DateModifiedFolderConvention.Name = "DateModifiedFolderConvention";
            this.DateModifiedFolderConvention.Size = new System.Drawing.Size(134, 24);
            this.DateModifiedFolderConvention.TabIndex = 11;
            this.DateModifiedFolderConvention.TabStop = true;
            this.DateModifiedFolderConvention.Text = "Date Modified";
            this.DateModifiedFolderConvention.UseVisualStyleBackColor = true;
            this.DateModifiedFolderConvention.CheckedChanged += new System.EventHandler(this.UpdatedFolderConvention);
            // 
            // DateCreatedFolderConvention
            // 
            this.DateCreatedFolderConvention.AutoSize = true;
            this.DateCreatedFolderConvention.Location = new System.Drawing.Point(679, 29);
            this.DateCreatedFolderConvention.Name = "DateCreatedFolderConvention";
            this.DateCreatedFolderConvention.Size = new System.Drawing.Size(130, 24);
            this.DateCreatedFolderConvention.TabIndex = 10;
            this.DateCreatedFolderConvention.TabStop = true;
            this.DateCreatedFolderConvention.Text = "Date Created";
            this.DateCreatedFolderConvention.UseVisualStyleBackColor = true;
            this.DateCreatedFolderConvention.CheckedChanged += new System.EventHandler(this.UpdatedFolderConvention);
            // 
            // DateTimeCameraTakenFolderConvention
            // 
            this.DateTimeCameraTakenFolderConvention.AutoSize = true;
            this.DateTimeCameraTakenFolderConvention.Location = new System.Drawing.Point(386, 29);
            this.DateTimeCameraTakenFolderConvention.Name = "DateTimeCameraTakenFolderConvention";
            this.DateTimeCameraTakenFolderConvention.Size = new System.Drawing.Size(258, 24);
            this.DateTimeCameraTakenFolderConvention.TabIndex = 9;
            this.DateTimeCameraTakenFolderConvention.TabStop = true;
            this.DateTimeCameraTakenFolderConvention.Text = "Date, Time and Camera Taken";
            this.DateTimeCameraTakenFolderConvention.UseVisualStyleBackColor = true;
            this.DateTimeCameraTakenFolderConvention.CheckedChanged += new System.EventHandler(this.UpdatedFolderConvention);
            // 
            // DateTimeTakenFolderConvention
            // 
            this.DateTimeTakenFolderConvention.AutoSize = true;
            this.DateTimeTakenFolderConvention.Location = new System.Drawing.Point(160, 29);
            this.DateTimeTakenFolderConvention.Name = "DateTimeTakenFolderConvention";
            this.DateTimeTakenFolderConvention.Size = new System.Drawing.Size(192, 24);
            this.DateTimeTakenFolderConvention.TabIndex = 8;
            this.DateTimeTakenFolderConvention.TabStop = true;
            this.DateTimeTakenFolderConvention.Text = "Date And Time Taken";
            this.DateTimeTakenFolderConvention.UseVisualStyleBackColor = true;
            this.DateTimeTakenFolderConvention.CheckedChanged += new System.EventHandler(this.UpdatedFolderConvention);
            // 
            // DateTakenFolderConvention
            // 
            this.DateTakenFolderConvention.AutoSize = true;
            this.DateTakenFolderConvention.Location = new System.Drawing.Point(8, 29);
            this.DateTakenFolderConvention.Name = "DateTakenFolderConvention";
            this.DateTakenFolderConvention.Size = new System.Drawing.Size(116, 24);
            this.DateTakenFolderConvention.TabIndex = 7;
            this.DateTakenFolderConvention.TabStop = true;
            this.DateTakenFolderConvention.Text = "Date Taken";
            this.DateTakenFolderConvention.UseVisualStyleBackColor = true;
            this.DateTakenFolderConvention.CheckedChanged += new System.EventHandler(this.UpdatedFolderConvention);
            // 
            // SetDefaultFolderConvention
            // 
            this.SetDefaultFolderConvention.Location = new System.Drawing.Point(1754, 20);
            this.SetDefaultFolderConvention.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SetDefaultFolderConvention.Name = "SetDefaultFolderConvention";
            this.SetDefaultFolderConvention.Size = new System.Drawing.Size(144, 32);
            this.SetDefaultFolderConvention.TabIndex = 6;
            this.SetDefaultFolderConvention.Text = "Set Default";
            this.SetDefaultFolderConvention.UseVisualStyleBackColor = true;
            this.SetDefaultFolderConvention.Click += new System.EventHandler(this.SetAsDefaultFolderConvention);
            // 
            // FolderLocationBox
            // 
            this.FolderLocationBox.BackColor = System.Drawing.SystemColors.Control;
            this.FolderLocationBox.Controls.Add(this.TextNewFolderLocation);
            this.FolderLocationBox.Controls.Add(this.TextCurrentFolderLocation);
            this.FolderLocationBox.Controls.Add(this.ChangeCurrrentFolderLocation);
            this.FolderLocationBox.Controls.Add(this.ChangeNewFolderLocation);
            this.FolderLocationBox.Controls.Add(this.SetDefaultCurrrentFolderLocation);
            this.FolderLocationBox.Controls.Add(this.SetDefaultNewFolderLocation);
            this.FolderLocationBox.Location = new System.Drawing.Point(3, 132);
            this.FolderLocationBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FolderLocationBox.MinimumSize = new System.Drawing.Size(1904, 62);
            this.FolderLocationBox.Name = "FolderLocationBox";
            this.FolderLocationBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FolderLocationBox.Size = new System.Drawing.Size(1904, 62);
            this.FolderLocationBox.TabIndex = 8;
            this.FolderLocationBox.TabStop = false;
            this.FolderLocationBox.Text = "Folder Locations";
            // 
            // TextNewFolderLocation
            // 
            this.TextNewFolderLocation.Location = new System.Drawing.Point(982, 22);
            this.TextNewFolderLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextNewFolderLocation.Name = "TextNewFolderLocation";
            this.TextNewFolderLocation.Size = new System.Drawing.Size(576, 26);
            this.TextNewFolderLocation.TabIndex = 12;
            this.TextNewFolderLocation.Text = "Destinaton Folder Location";
            this.TextNewFolderLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextNewFolderLocation.TextChanged += new System.EventHandler(this.ChangedTextBoxNewLocation);
            // 
            // TextCurrentFolderLocation
            // 
            this.TextCurrentFolderLocation.Location = new System.Drawing.Point(345, 22);
            this.TextCurrentFolderLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextCurrentFolderLocation.Name = "TextCurrentFolderLocation";
            this.TextCurrentFolderLocation.Size = new System.Drawing.Size(576, 26);
            this.TextCurrentFolderLocation.TabIndex = 11;
            this.TextCurrentFolderLocation.Text = "Current Folder Location";
            this.TextCurrentFolderLocation.TextChanged += new System.EventHandler(this.ChangedTextBoxCurrentLocation);
            // 
            // ChangeCurrrentFolderLocation
            // 
            this.ChangeCurrrentFolderLocation.Location = new System.Drawing.Point(152, 20);
            this.ChangeCurrrentFolderLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChangeCurrrentFolderLocation.Name = "ChangeCurrrentFolderLocation";
            this.ChangeCurrrentFolderLocation.Size = new System.Drawing.Size(184, 32);
            this.ChangeCurrrentFolderLocation.TabIndex = 10;
            this.ChangeCurrrentFolderLocation.Text = "Change Current";
            this.ChangeCurrrentFolderLocation.UseVisualStyleBackColor = true;
            this.ChangeCurrrentFolderLocation.Click += new System.EventHandler(this.ChangeCurrentDestination);
            // 
            // ChangeNewFolderLocation
            // 
            this.ChangeNewFolderLocation.Location = new System.Drawing.Point(1564, 20);
            this.ChangeNewFolderLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChangeNewFolderLocation.Name = "ChangeNewFolderLocation";
            this.ChangeNewFolderLocation.Size = new System.Drawing.Size(184, 32);
            this.ChangeNewFolderLocation.TabIndex = 9;
            this.ChangeNewFolderLocation.Text = "Change Destination";
            this.ChangeNewFolderLocation.UseVisualStyleBackColor = true;
            this.ChangeNewFolderLocation.Click += new System.EventHandler(this.ChangeNewDestination);
            // 
            // SetDefaultCurrrentFolderLocation
            // 
            this.SetDefaultCurrrentFolderLocation.Location = new System.Drawing.Point(3, 20);
            this.SetDefaultCurrrentFolderLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SetDefaultCurrrentFolderLocation.Name = "SetDefaultCurrrentFolderLocation";
            this.SetDefaultCurrrentFolderLocation.Size = new System.Drawing.Size(144, 32);
            this.SetDefaultCurrrentFolderLocation.TabIndex = 7;
            this.SetDefaultCurrrentFolderLocation.Text = "Set Default";
            this.SetDefaultCurrrentFolderLocation.UseVisualStyleBackColor = true;
            this.SetDefaultCurrrentFolderLocation.Click += new System.EventHandler(this.SetDefaultCurrentFolder);
            // 
            // SetDefaultNewFolderLocation
            // 
            this.SetDefaultNewFolderLocation.Location = new System.Drawing.Point(1754, 20);
            this.SetDefaultNewFolderLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SetDefaultNewFolderLocation.Name = "SetDefaultNewFolderLocation";
            this.SetDefaultNewFolderLocation.Size = new System.Drawing.Size(144, 32);
            this.SetDefaultNewFolderLocation.TabIndex = 6;
            this.SetDefaultNewFolderLocation.Text = "Set Default";
            this.SetDefaultNewFolderLocation.UseVisualStyleBackColor = true;
            this.SetDefaultNewFolderLocation.Click += new System.EventHandler(this.SetDefaultNewFolder);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(3, 194);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.MinimumSize = new System.Drawing.Size(1904, 871);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1904, 871);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView2.Location = new System.Drawing.Point(982, 43);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(915, 768);
            this.dataGridView2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(8, 43);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(914, 768);
            this.dataGridView1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1680, 820);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 42);
            this.button3.TabIndex = 0;
            this.button3.Text = "Copy Images";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.CopyImages);
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1914, 1066);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.FolderLocationBox);
            this.Controls.Add(this.FolderConventionBox);
            this.Controls.Add(this.NamingConventionBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Window1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Organiser Pro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NamingConventionBox.ResumeLayout(false);
            this.NamingConventionBox.PerformLayout();
            this.FolderConventionBox.ResumeLayout(false);
            this.FolderConventionBox.PerformLayout();
            this.FolderLocationBox.ResumeLayout(false);
            this.FolderLocationBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CheckBox DateTakenBoxNamingConvention;
        private GroupBox NamingConventionBox;
        private CheckBox DateModifiedBoxNamingConvention;
        private CheckBox DateCreatedBoxNamingConvention;
        private CheckBox TimeTakenBoxNamingConvention;
        private CheckBox CameraModelBoxNamingConvention;
        private CheckBox OrignalNameBoxNamingConvention;
        private Button SetDefaultNamingConvention;
        private GroupBox FolderConventionBox;
        private Button SetDefaultFolderConvention;
        private GroupBox FolderLocationBox;
        private Button SetDefaultCurrrentFolderLocation;
        private Button SetDefaultNewFolderLocation;
        private Button ChangeCurrrentFolderLocation;
        private Button ChangeNewFolderLocation;
        private GroupBox groupBox2;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TextBox TextNewFolderLocation;
        private TextBox TextCurrentFolderLocation;
        private System.ComponentModel.BackgroundWorker copyImageBackgroundWorker;
        private RadioButton DateTimeTakenFolderConvention;
        private RadioButton DateTakenFolderConvention;
        private RadioButton OrignalNameFolderConvention;
        private RadioButton DateModifiedFolderConvention;
        private RadioButton DateCreatedFolderConvention;
        private RadioButton DateTimeCameraTakenFolderConvention;
    }
}

