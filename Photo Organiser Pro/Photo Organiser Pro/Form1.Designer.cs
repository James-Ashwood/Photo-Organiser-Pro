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
            this.DateImageNumberBoxNamingConvention = new System.Windows.Forms.CheckBox();
            this.DateModifiedBoxNamingConvention = new System.Windows.Forms.CheckBox();
            this.DateCreatedBoxNamingConvention = new System.Windows.Forms.CheckBox();
            this.TimeTakenBoxNamingConvention = new System.Windows.Forms.CheckBox();
            this.CameraModelBoxNamingConvention = new System.Windows.Forms.CheckBox();
            this.FolderConventionBox = new System.Windows.Forms.GroupBox();
            this.SetDefaultFolderConvention = new System.Windows.Forms.Button();
            this.DateImageNumberBoxFolderConvention = new System.Windows.Forms.CheckBox();
            this.DateModifiedBoxFolderConvention = new System.Windows.Forms.CheckBox();
            this.DateCreatedBoxFolderConvention = new System.Windows.Forms.CheckBox();
            this.TimeTakenBoxFolderConvention = new System.Windows.Forms.CheckBox();
            this.CameraModelBoxFolderConvention = new System.Windows.Forms.CheckBox();
            this.DateTakenBoxFolderConvention = new System.Windows.Forms.CheckBox();
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
            this.DateTakenBoxNamingConvention.Location = new System.Drawing.Point(5, 19);
            this.DateTakenBoxNamingConvention.Name = "DateTakenBoxNamingConvention";
            this.DateTakenBoxNamingConvention.Size = new System.Drawing.Size(83, 17);
            this.DateTakenBoxNamingConvention.TabIndex = 0;
            this.DateTakenBoxNamingConvention.Text = "Date Taken";
            this.DateTakenBoxNamingConvention.UseVisualStyleBackColor = true;
            // 
            // NamingConventionBox
            // 
            this.NamingConventionBox.BackColor = System.Drawing.SystemColors.Control;
            this.NamingConventionBox.Controls.Add(this.SetDefaultNamingConvention);
            this.NamingConventionBox.Controls.Add(this.DateImageNumberBoxNamingConvention);
            this.NamingConventionBox.Controls.Add(this.DateModifiedBoxNamingConvention);
            this.NamingConventionBox.Controls.Add(this.DateCreatedBoxNamingConvention);
            this.NamingConventionBox.Controls.Add(this.TimeTakenBoxNamingConvention);
            this.NamingConventionBox.Controls.Add(this.CameraModelBoxNamingConvention);
            this.NamingConventionBox.Controls.Add(this.DateTakenBoxNamingConvention);
            this.NamingConventionBox.Location = new System.Drawing.Point(2, 2);
            this.NamingConventionBox.Name = "NamingConventionBox";
            this.NamingConventionBox.Size = new System.Drawing.Size(1269, 40);
            this.NamingConventionBox.TabIndex = 1;
            this.NamingConventionBox.TabStop = false;
            this.NamingConventionBox.Text = "Naming Convention";
            // 
            // SetDefaultNamingConvention
            // 
            this.SetDefaultNamingConvention.Location = new System.Drawing.Point(1169, 15);
            this.SetDefaultNamingConvention.Name = "SetDefaultNamingConvention";
            this.SetDefaultNamingConvention.Size = new System.Drawing.Size(96, 21);
            this.SetDefaultNamingConvention.TabIndex = 6;
            this.SetDefaultNamingConvention.Text = "Set Default";
            this.SetDefaultNamingConvention.UseVisualStyleBackColor = true;
            this.SetDefaultNamingConvention.Click += new System.EventHandler(this.SetAsDefaultNamingConvention);
            // 
            // DateImageNumberBoxNamingConvention
            // 
            this.DateImageNumberBoxNamingConvention.AutoSize = true;
            this.DateImageNumberBoxNamingConvention.Location = new System.Drawing.Point(525, 19);
            this.DateImageNumberBoxNamingConvention.Name = "DateImageNumberBoxNamingConvention";
            this.DateImageNumberBoxNamingConvention.Size = new System.Drawing.Size(121, 17);
            this.DateImageNumberBoxNamingConvention.TabIndex = 5;
            this.DateImageNumberBoxNamingConvention.Text = "Date Image Number";
            this.DateImageNumberBoxNamingConvention.UseVisualStyleBackColor = true;
            // 
            // DateModifiedBoxNamingConvention
            // 
            this.DateModifiedBoxNamingConvention.AutoSize = true;
            this.DateModifiedBoxNamingConvention.Location = new System.Drawing.Point(418, 19);
            this.DateModifiedBoxNamingConvention.Name = "DateModifiedBoxNamingConvention";
            this.DateModifiedBoxNamingConvention.Size = new System.Drawing.Size(92, 17);
            this.DateModifiedBoxNamingConvention.TabIndex = 4;
            this.DateModifiedBoxNamingConvention.Text = "Date Modified";
            this.DateModifiedBoxNamingConvention.UseVisualStyleBackColor = true;
            // 
            // DateCreatedBoxNamingConvention
            // 
            this.DateCreatedBoxNamingConvention.AutoSize = true;
            this.DateCreatedBoxNamingConvention.Location = new System.Drawing.Point(314, 19);
            this.DateCreatedBoxNamingConvention.Name = "DateCreatedBoxNamingConvention";
            this.DateCreatedBoxNamingConvention.Size = new System.Drawing.Size(89, 17);
            this.DateCreatedBoxNamingConvention.TabIndex = 3;
            this.DateCreatedBoxNamingConvention.Text = "Date Created";
            this.DateCreatedBoxNamingConvention.UseVisualStyleBackColor = true;
            // 
            // TimeTakenBoxNamingConvention
            // 
            this.TimeTakenBoxNamingConvention.AutoSize = true;
            this.TimeTakenBoxNamingConvention.Location = new System.Drawing.Point(107, 19);
            this.TimeTakenBoxNamingConvention.Name = "TimeTakenBoxNamingConvention";
            this.TimeTakenBoxNamingConvention.Size = new System.Drawing.Size(83, 17);
            this.TimeTakenBoxNamingConvention.TabIndex = 2;
            this.TimeTakenBoxNamingConvention.Text = "Time Taken";
            this.TimeTakenBoxNamingConvention.UseVisualStyleBackColor = true;
            // 
            // CameraModelBoxNamingConvention
            // 
            this.CameraModelBoxNamingConvention.AutoSize = true;
            this.CameraModelBoxNamingConvention.Location = new System.Drawing.Point(205, 19);
            this.CameraModelBoxNamingConvention.Name = "CameraModelBoxNamingConvention";
            this.CameraModelBoxNamingConvention.Size = new System.Drawing.Size(94, 17);
            this.CameraModelBoxNamingConvention.TabIndex = 1;
            this.CameraModelBoxNamingConvention.Text = "Camera Model";
            this.CameraModelBoxNamingConvention.UseVisualStyleBackColor = true;
            // 
            // FolderConventionBox
            // 
            this.FolderConventionBox.BackColor = System.Drawing.SystemColors.Control;
            this.FolderConventionBox.Controls.Add(this.SetDefaultFolderConvention);
            this.FolderConventionBox.Controls.Add(this.DateImageNumberBoxFolderConvention);
            this.FolderConventionBox.Controls.Add(this.DateModifiedBoxFolderConvention);
            this.FolderConventionBox.Controls.Add(this.DateCreatedBoxFolderConvention);
            this.FolderConventionBox.Controls.Add(this.TimeTakenBoxFolderConvention);
            this.FolderConventionBox.Controls.Add(this.CameraModelBoxFolderConvention);
            this.FolderConventionBox.Controls.Add(this.DateTakenBoxFolderConvention);
            this.FolderConventionBox.Location = new System.Drawing.Point(2, 44);
            this.FolderConventionBox.Name = "FolderConventionBox";
            this.FolderConventionBox.Size = new System.Drawing.Size(1269, 40);
            this.FolderConventionBox.TabIndex = 7;
            this.FolderConventionBox.TabStop = false;
            this.FolderConventionBox.Text = "Folder Convention";
            // 
            // SetDefaultFolderConvention
            // 
            this.SetDefaultFolderConvention.Location = new System.Drawing.Point(1169, 13);
            this.SetDefaultFolderConvention.Name = "SetDefaultFolderConvention";
            this.SetDefaultFolderConvention.Size = new System.Drawing.Size(96, 21);
            this.SetDefaultFolderConvention.TabIndex = 6;
            this.SetDefaultFolderConvention.Text = "Set Default";
            this.SetDefaultFolderConvention.UseVisualStyleBackColor = true;
            this.SetDefaultFolderConvention.Click += new System.EventHandler(this.SetAsDefaultFolderConvention);
            // 
            // DateImageNumberBoxFolderConvention
            // 
            this.DateImageNumberBoxFolderConvention.AutoSize = true;
            this.DateImageNumberBoxFolderConvention.Location = new System.Drawing.Point(525, 19);
            this.DateImageNumberBoxFolderConvention.Name = "DateImageNumberBoxFolderConvention";
            this.DateImageNumberBoxFolderConvention.Size = new System.Drawing.Size(121, 17);
            this.DateImageNumberBoxFolderConvention.TabIndex = 5;
            this.DateImageNumberBoxFolderConvention.Text = "Date Image Number";
            this.DateImageNumberBoxFolderConvention.UseVisualStyleBackColor = true;
            // 
            // DateModifiedBoxFolderConvention
            // 
            this.DateModifiedBoxFolderConvention.AutoSize = true;
            this.DateModifiedBoxFolderConvention.Location = new System.Drawing.Point(418, 19);
            this.DateModifiedBoxFolderConvention.Name = "DateModifiedBoxFolderConvention";
            this.DateModifiedBoxFolderConvention.Size = new System.Drawing.Size(92, 17);
            this.DateModifiedBoxFolderConvention.TabIndex = 4;
            this.DateModifiedBoxFolderConvention.Text = "Date Modified";
            this.DateModifiedBoxFolderConvention.UseVisualStyleBackColor = true;
            // 
            // DateCreatedBoxFolderConvention
            // 
            this.DateCreatedBoxFolderConvention.AutoSize = true;
            this.DateCreatedBoxFolderConvention.Location = new System.Drawing.Point(314, 19);
            this.DateCreatedBoxFolderConvention.Name = "DateCreatedBoxFolderConvention";
            this.DateCreatedBoxFolderConvention.Size = new System.Drawing.Size(89, 17);
            this.DateCreatedBoxFolderConvention.TabIndex = 3;
            this.DateCreatedBoxFolderConvention.Text = "Date Created";
            this.DateCreatedBoxFolderConvention.UseVisualStyleBackColor = true;
            // 
            // TimeTakenBoxFolderConvention
            // 
            this.TimeTakenBoxFolderConvention.AutoSize = true;
            this.TimeTakenBoxFolderConvention.Location = new System.Drawing.Point(107, 19);
            this.TimeTakenBoxFolderConvention.Name = "TimeTakenBoxFolderConvention";
            this.TimeTakenBoxFolderConvention.Size = new System.Drawing.Size(83, 17);
            this.TimeTakenBoxFolderConvention.TabIndex = 2;
            this.TimeTakenBoxFolderConvention.Text = "Time Taken";
            this.TimeTakenBoxFolderConvention.UseVisualStyleBackColor = true;
            // 
            // CameraModelBoxFolderConvention
            // 
            this.CameraModelBoxFolderConvention.AutoSize = true;
            this.CameraModelBoxFolderConvention.Location = new System.Drawing.Point(205, 19);
            this.CameraModelBoxFolderConvention.Name = "CameraModelBoxFolderConvention";
            this.CameraModelBoxFolderConvention.Size = new System.Drawing.Size(94, 17);
            this.CameraModelBoxFolderConvention.TabIndex = 1;
            this.CameraModelBoxFolderConvention.Text = "Camera Model";
            this.CameraModelBoxFolderConvention.UseVisualStyleBackColor = true;
            // 
            // DateTakenBoxFolderConvention
            // 
            this.DateTakenBoxFolderConvention.AutoSize = true;
            this.DateTakenBoxFolderConvention.Location = new System.Drawing.Point(5, 19);
            this.DateTakenBoxFolderConvention.Name = "DateTakenBoxFolderConvention";
            this.DateTakenBoxFolderConvention.Size = new System.Drawing.Size(83, 17);
            this.DateTakenBoxFolderConvention.TabIndex = 0;
            this.DateTakenBoxFolderConvention.Text = "Date Taken";
            this.DateTakenBoxFolderConvention.UseVisualStyleBackColor = true;
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
            this.FolderLocationBox.Location = new System.Drawing.Point(2, 86);
            this.FolderLocationBox.Name = "FolderLocationBox";
            this.FolderLocationBox.Size = new System.Drawing.Size(1269, 40);
            this.FolderLocationBox.TabIndex = 8;
            this.FolderLocationBox.TabStop = false;
            this.FolderLocationBox.Text = "Folder Locations";
            // 
            // TextNewFolderLocation
            // 
            this.TextNewFolderLocation.Location = new System.Drawing.Point(655, 14);
            this.TextNewFolderLocation.Name = "TextNewFolderLocation";
            this.TextNewFolderLocation.Size = new System.Drawing.Size(385, 20);
            this.TextNewFolderLocation.TabIndex = 12;
            this.TextNewFolderLocation.Text = "Destinaton Folder Location";
            this.TextNewFolderLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextNewFolderLocation.TextChanged += new System.EventHandler(this.ChangedTextBoxNewLocation);
            // 
            // TextCurrentFolderLocation
            // 
            this.TextCurrentFolderLocation.Location = new System.Drawing.Point(230, 14);
            this.TextCurrentFolderLocation.Name = "TextCurrentFolderLocation";
            this.TextCurrentFolderLocation.Size = new System.Drawing.Size(385, 20);
            this.TextCurrentFolderLocation.TabIndex = 11;
            this.TextCurrentFolderLocation.Text = "Current Folder Location";
            this.TextCurrentFolderLocation.TextChanged += new System.EventHandler(this.ChangedTextBoxCurrentLocation);
            // 
            // ChangeCurrrentFolderLocation
            // 
            this.ChangeCurrrentFolderLocation.Location = new System.Drawing.Point(101, 13);
            this.ChangeCurrrentFolderLocation.Name = "ChangeCurrrentFolderLocation";
            this.ChangeCurrrentFolderLocation.Size = new System.Drawing.Size(123, 21);
            this.ChangeCurrrentFolderLocation.TabIndex = 10;
            this.ChangeCurrrentFolderLocation.Text = "Change Current";
            this.ChangeCurrrentFolderLocation.UseVisualStyleBackColor = true;
            this.ChangeCurrrentFolderLocation.Click += new System.EventHandler(this.ChangeCurrentDestination);
            // 
            // ChangeNewFolderLocation
            // 
            this.ChangeNewFolderLocation.Location = new System.Drawing.Point(1043, 13);
            this.ChangeNewFolderLocation.Name = "ChangeNewFolderLocation";
            this.ChangeNewFolderLocation.Size = new System.Drawing.Size(123, 21);
            this.ChangeNewFolderLocation.TabIndex = 9;
            this.ChangeNewFolderLocation.Text = "Change Destination";
            this.ChangeNewFolderLocation.UseVisualStyleBackColor = true;
            this.ChangeNewFolderLocation.Click += new System.EventHandler(this.ChangeNewDestination);
            // 
            // SetDefaultCurrrentFolderLocation
            // 
            this.SetDefaultCurrrentFolderLocation.Location = new System.Drawing.Point(2, 13);
            this.SetDefaultCurrrentFolderLocation.Name = "SetDefaultCurrrentFolderLocation";
            this.SetDefaultCurrrentFolderLocation.Size = new System.Drawing.Size(96, 21);
            this.SetDefaultCurrrentFolderLocation.TabIndex = 7;
            this.SetDefaultCurrrentFolderLocation.Text = "Set Default";
            this.SetDefaultCurrrentFolderLocation.UseVisualStyleBackColor = true;
            this.SetDefaultCurrrentFolderLocation.Click += new System.EventHandler(this.SetDefaultCurrentFolder);
            // 
            // SetDefaultNewFolderLocation
            // 
            this.SetDefaultNewFolderLocation.Location = new System.Drawing.Point(1169, 13);
            this.SetDefaultNewFolderLocation.Name = "SetDefaultNewFolderLocation";
            this.SetDefaultNewFolderLocation.Size = new System.Drawing.Size(96, 21);
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
            this.groupBox2.Location = new System.Drawing.Point(2, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1269, 566);
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
            this.dataGridView2.Location = new System.Drawing.Point(655, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(610, 499);
            this.dataGridView2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(5, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(609, 499);
            this.dataGridView1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1120, 533);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 27);
            this.button3.TabIndex = 0;
            this.button3.Text = "Copy Images";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.CopyImages);
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1276, 693);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.FolderLocationBox);
            this.Controls.Add(this.FolderConventionBox);
            this.Controls.Add(this.NamingConventionBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private CheckBox DateImageNumberBoxNamingConvention;
        private Button SetDefaultNamingConvention;
        private GroupBox FolderConventionBox;
        private Button SetDefaultFolderConvention;
        private CheckBox DateImageNumberBoxFolderConvention;
        private CheckBox DateModifiedBoxFolderConvention;
        private CheckBox DateCreatedBoxFolderConvention;
        private CheckBox TimeTakenBoxFolderConvention;
        private CheckBox CameraModelBoxFolderConvention;
        private CheckBox DateTakenBoxFolderConvention;
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
        private DataGridViewTextBoxColumn CurrentFileName;
    }
}

