
using System;

namespace FileSync
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textSourcePath = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.textDestinationPath = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnSourceBrowse = new System.Windows.Forms.Button();
            this.btnDestinationBrowse = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Settings = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.progressbarToolstrip = new System.Windows.Forms.ToolStripProgressBar();
            this.labelFilesChecked = new System.Windows.Forms.ToolStripLabel();
            this.labelTotalFiles = new System.Windows.Forms.ToolStripLabel();
            this.labelError = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.SynchronizeNow = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuSettingsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textSourcePath
            // 
            this.textSourcePath.Location = new System.Drawing.Point(126, 180);
            this.textSourcePath.Margin = new System.Windows.Forms.Padding(2);
            this.textSourcePath.Name = "textSourcePath";
            this.textSourcePath.Size = new System.Drawing.Size(483, 31);
            this.textSourcePath.TabIndex = 0;
            this.textSourcePath.Click += new System.EventHandler(this.textSourcePath_Click);
            this.textSourcePath.Leave += new System.EventHandler(this.textSourcePath_Leave);
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(126, 132);
            this.lblSource.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(66, 25);
            this.lblSource.TabIndex = 6;
            this.lblSource.Text = "Source";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(919, 132);
            this.lblDestination.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(102, 25);
            this.lblDestination.TabIndex = 5;
            this.lblDestination.Text = "Destination";
            // 
            // textDestinationPath
            // 
            this.textDestinationPath.Location = new System.Drawing.Point(919, 179);
            this.textDestinationPath.Margin = new System.Windows.Forms.Padding(2);
            this.textDestinationPath.Name = "textDestinationPath";
            this.textDestinationPath.Size = new System.Drawing.Size(483, 31);
            this.textDestinationPath.TabIndex = 2;
            this.textDestinationPath.Click += new System.EventHandler(this.textDestinationPath_Click);
            this.textDestinationPath.Leave += new System.EventHandler(this.textDestinationPath_Leave);
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExecute.Location = new System.Drawing.Point(1408, 406);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(2);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(128, 48);
            this.btnExecute.TabIndex = 4;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnSourceBrowse
            // 
            this.btnSourceBrowse.Location = new System.Drawing.Point(615, 178);
            this.btnSourceBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnSourceBrowse.Name = "btnSourceBrowse";
            this.btnSourceBrowse.Size = new System.Drawing.Size(112, 34);
            this.btnSourceBrowse.TabIndex = 1;
            this.btnSourceBrowse.Text = "Browse...";
            this.btnSourceBrowse.UseVisualStyleBackColor = true;
            this.btnSourceBrowse.Click += new System.EventHandler(this.btnSourceBrowse_Click);
            // 
            // btnDestinationBrowse
            // 
            this.btnDestinationBrowse.Location = new System.Drawing.Point(1408, 178);
            this.btnDestinationBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnDestinationBrowse.Name = "btnDestinationBrowse";
            this.btnDestinationBrowse.Size = new System.Drawing.Size(112, 34);
            this.btnDestinationBrowse.TabIndex = 3;
            this.btnDestinationBrowse.Text = "Browse...";
            this.btnDestinationBrowse.UseVisualStyleBackColor = true;
            this.btnDestinationBrowse.Click += new System.EventHandler(this.btnDestinationBrowse_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Settings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1924, 34);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // Settings
            // 
            this.Settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(80, 29);
            this.Settings.Text = "Settings";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressbarToolstrip,
            this.labelFilesChecked,
            this.labelTotalFiles});
            this.toolStrip2.Location = new System.Drawing.Point(0, 1122);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1924, 30);
            this.toolStrip2.TabIndex = 12;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // progressbarToolstrip
            // 
            this.progressbarToolstrip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progressbarToolstrip.Name = "progressbarToolstrip";
            this.progressbarToolstrip.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.progressbarToolstrip.Size = new System.Drawing.Size(500, 25);
            this.progressbarToolstrip.Step = 1;
            // 
            // labelFilesChecked
            // 
            this.labelFilesChecked.Name = "labelFilesChecked";
            this.labelFilesChecked.Size = new System.Drawing.Size(169, 25);
            this.labelFilesChecked.Text = "Total Files Checked: ";
            // 
            // labelTotalFiles
            // 
            this.labelTotalFiles.Name = "labelTotalFiles";
            this.labelTotalFiles.Size = new System.Drawing.Size(0, 25);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.DarkRed;
            this.labelError.Location = new System.Drawing.Point(12, 1071);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(49, 25);
            this.labelError.TabIndex = 13;
            this.labelError.Text = "label";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "FileSync";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Open
            // 
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(32, 19);
            // 
            // SynchronizeNow
            // 
            this.SynchronizeNow.Name = "SynchronizeNow";
            this.SynchronizeNow.Size = new System.Drawing.Size(32, 19);
            // 
            // ContextMenuSettingsButton
            // 
            this.ContextMenuSettingsButton.Name = "ContextMenuSettingsButton";
            this.ContextMenuSettingsButton.Size = new System.Drawing.Size(32, 19);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(32, 19);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1152);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnDestinationBrowse);
            this.Controls.Add(this.btnSourceBrowse);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.textDestinationPath);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.textSourcePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "FileSync";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSourcePath;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox textDestinationPath;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnSourceBrowse;
        private System.Windows.Forms.Button btnDestinationBrowse;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Settings;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripProgressBar progressbarToolstrip;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.ToolStripLabel labelFilesChecked;
        private System.Windows.Forms.ToolStripLabel labelTotalFiles;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripMenuItem SynchronizeNow;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuSettingsButton;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

