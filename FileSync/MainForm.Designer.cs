
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
            this.ExitButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.progressbarToolstrip = new System.Windows.Forms.ToolStripProgressBar();
            this.labelFilesChecked = new System.Windows.Forms.ToolStripLabel();
            this.labelTotalFiles = new System.Windows.Forms.ToolStripLabel();
            this.labelError = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textSourcePath
            // 
            this.textSourcePath.Location = new System.Drawing.Point(101, 144);
            this.textSourcePath.Margin = new System.Windows.Forms.Padding(2);
            this.textSourcePath.Name = "textSourcePath";
            this.textSourcePath.Size = new System.Drawing.Size(387, 27);
            this.textSourcePath.TabIndex = 0;
            this.textSourcePath.Click += new System.EventHandler(this.textSourcePath_Click);
            this.textSourcePath.Leave += new System.EventHandler(this.textSourcePath_Leave);
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(101, 106);
            this.lblSource.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(54, 20);
            this.lblSource.TabIndex = 6;
            this.lblSource.Text = "Source";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(735, 106);
            this.lblDestination.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(85, 20);
            this.lblDestination.TabIndex = 5;
            this.lblDestination.Text = "Destination";
            // 
            // textDestinationPath
            // 
            this.textDestinationPath.Location = new System.Drawing.Point(735, 143);
            this.textDestinationPath.Margin = new System.Windows.Forms.Padding(2);
            this.textDestinationPath.Name = "textDestinationPath";
            this.textDestinationPath.Size = new System.Drawing.Size(387, 27);
            this.textDestinationPath.TabIndex = 2;
            this.textDestinationPath.Click += new System.EventHandler(this.textDestinationPath_Click);
            this.textDestinationPath.Leave += new System.EventHandler(this.textDestinationPath_Leave);
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExecute.Location = new System.Drawing.Point(1126, 325);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(2);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(102, 38);
            this.btnExecute.TabIndex = 4;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnSourceBrowse
            // 
            this.btnSourceBrowse.Location = new System.Drawing.Point(492, 142);
            this.btnSourceBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnSourceBrowse.Name = "btnSourceBrowse";
            this.btnSourceBrowse.Size = new System.Drawing.Size(90, 27);
            this.btnSourceBrowse.TabIndex = 1;
            this.btnSourceBrowse.Text = "Browse...";
            this.btnSourceBrowse.UseVisualStyleBackColor = true;
            this.btnSourceBrowse.Click += new System.EventHandler(this.btnSourceBrowse_Click);
            // 
            // btnDestinationBrowse
            // 
            this.btnDestinationBrowse.Location = new System.Drawing.Point(1126, 142);
            this.btnDestinationBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnDestinationBrowse.Name = "btnDestinationBrowse";
            this.btnDestinationBrowse.Size = new System.Drawing.Size(90, 27);
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
            this.Settings,
            this.ExitButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1539, 27);
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
            this.Settings.Size = new System.Drawing.Size(66, 24);
            this.Settings.Text = "Settings";
            // 
            // ExitButton
            // 
            this.ExitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(37, 24);
            this.ExitButton.Text = "Exit";
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
            this.toolStrip2.Location = new System.Drawing.Point(0, 897);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1539, 25);
            this.toolStrip2.TabIndex = 12;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // progressbarToolstrip
            // 
            this.progressbarToolstrip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progressbarToolstrip.Name = "progressbarToolstrip";
            this.progressbarToolstrip.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.progressbarToolstrip.Size = new System.Drawing.Size(450, 22);
            this.progressbarToolstrip.Step = 1;
            // 
            // labelFilesChecked
            // 
            this.labelFilesChecked.Name = "labelFilesChecked";
            this.labelFilesChecked.Size = new System.Drawing.Size(142, 22);
            this.labelFilesChecked.Text = "Total Files Checked: ";
            // 
            // labelTotalFiles
            // 
            this.labelTotalFiles.Name = "labelTotalFiles";
            this.labelTotalFiles.Size = new System.Drawing.Size(0, 22);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.DarkRed;
            this.labelError.Location = new System.Drawing.Point(10, 857);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(42, 20);
            this.labelError.TabIndex = 13;
            this.labelError.Text = "label";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 922);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "FileSync";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
        private System.Windows.Forms.ToolStripButton ExitButton;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripProgressBar progressbarToolstrip;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.ToolStripLabel labelFilesChecked;
        private System.Windows.Forms.ToolStripLabel labelTotalFiles;
    }
}

