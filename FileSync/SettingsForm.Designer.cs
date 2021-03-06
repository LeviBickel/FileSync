
namespace FileSync
{
    partial class SettingsForm
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
            this.textBoxSettingSourcePath = new System.Windows.Forms.TextBox();
            this.btnSourceBrowse = new System.Windows.Forms.Button();
            this.textBoxDestinationPath = new System.Windows.Forms.TextBox();
            this.buttonBrowseDestination = new System.Windows.Forms.Button();
            this.checkBoxSource = new System.Windows.Forms.CheckBox();
            this.checkBoxDestination = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSettingsSave = new System.Windows.Forms.Button();
            this.buttonSettingsCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxRealTime = new System.Windows.Forms.CheckBox();
            this.textBoxSynchronizationInterval = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSettingSourcePath
            // 
            this.textBoxSettingSourcePath.Location = new System.Drawing.Point(16, 61);
            this.textBoxSettingSourcePath.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSettingSourcePath.Name = "textBoxSettingSourcePath";
            this.textBoxSettingSourcePath.Size = new System.Drawing.Size(239, 31);
            this.textBoxSettingSourcePath.TabIndex = 0;
            this.textBoxSettingSourcePath.Text = "Source Path";
            this.textBoxSettingSourcePath.Click += new System.EventHandler(this.textBoxSettingSourcePath_Click);
            this.textBoxSettingSourcePath.Leave += new System.EventHandler(this.textBoxSettingSourcePath_Leave);
            // 
            // btnSourceBrowse
            // 
            this.btnSourceBrowse.Location = new System.Drawing.Point(265, 58);
            this.btnSourceBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnSourceBrowse.Name = "btnSourceBrowse";
            this.btnSourceBrowse.Size = new System.Drawing.Size(118, 36);
            this.btnSourceBrowse.TabIndex = 1;
            this.btnSourceBrowse.Text = "Browse...";
            this.btnSourceBrowse.UseVisualStyleBackColor = true;
            this.btnSourceBrowse.Click += new System.EventHandler(this.btnSourceBrowse_Click);
            // 
            // textBoxDestinationPath
            // 
            this.textBoxDestinationPath.Location = new System.Drawing.Point(16, 142);
            this.textBoxDestinationPath.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDestinationPath.Name = "textBoxDestinationPath";
            this.textBoxDestinationPath.Size = new System.Drawing.Size(239, 31);
            this.textBoxDestinationPath.TabIndex = 2;
            this.textBoxDestinationPath.Text = "Destination Path";
            this.textBoxDestinationPath.Click += new System.EventHandler(this.textBoxDestinationPath_Click);
            this.textBoxDestinationPath.Leave += new System.EventHandler(this.textBoxDestinationPath_Leave);
            // 
            // buttonBrowseDestination
            // 
            this.buttonBrowseDestination.Location = new System.Drawing.Point(265, 139);
            this.buttonBrowseDestination.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBrowseDestination.Name = "buttonBrowseDestination";
            this.buttonBrowseDestination.Size = new System.Drawing.Size(118, 36);
            this.buttonBrowseDestination.TabIndex = 3;
            this.buttonBrowseDestination.Text = "Browse...";
            this.buttonBrowseDestination.UseVisualStyleBackColor = true;
            this.buttonBrowseDestination.Click += new System.EventHandler(this.buttonBrowseDestination_Click);
            // 
            // checkBoxSource
            // 
            this.checkBoxSource.AutoSize = true;
            this.checkBoxSource.Location = new System.Drawing.Point(15, 271);
            this.checkBoxSource.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxSource.Name = "checkBoxSource";
            this.checkBoxSource.Size = new System.Drawing.Size(92, 29);
            this.checkBoxSource.TabIndex = 4;
            this.checkBoxSource.Text = "Source";
            this.checkBoxSource.UseVisualStyleBackColor = true;
            this.checkBoxSource.CheckedChanged += new System.EventHandler(this.checkBoxSource_CheckedChanged);
            // 
            // checkBoxDestination
            // 
            this.checkBoxDestination.AutoSize = true;
            this.checkBoxDestination.Location = new System.Drawing.Point(149, 271);
            this.checkBoxDestination.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxDestination.Name = "checkBoxDestination";
            this.checkBoxDestination.Size = new System.Drawing.Size(128, 29);
            this.checkBoxDestination.TabIndex = 5;
            this.checkBoxDestination.Text = "Destination";
            this.checkBoxDestination.UseVisualStyleBackColor = true;
            this.checkBoxDestination.CheckedChanged += new System.EventHandler(this.checkBoxDestination_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 226);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Which directory takes precedence?";
            // 
            // buttonSettingsSave
            // 
            this.buttonSettingsSave.Location = new System.Drawing.Point(868, 511);
            this.buttonSettingsSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSettingsSave.Name = "buttonSettingsSave";
            this.buttonSettingsSave.Size = new System.Drawing.Size(118, 36);
            this.buttonSettingsSave.TabIndex = 7;
            this.buttonSettingsSave.Text = "Save";
            this.buttonSettingsSave.UseVisualStyleBackColor = true;
            this.buttonSettingsSave.Click += new System.EventHandler(this.buttonSettingsSave_Click);
            // 
            // buttonSettingsCancel
            // 
            this.buttonSettingsCancel.Location = new System.Drawing.Point(15, 511);
            this.buttonSettingsCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSettingsCancel.Name = "buttonSettingsCancel";
            this.buttonSettingsCancel.Size = new System.Drawing.Size(118, 36);
            this.buttonSettingsCancel.TabIndex = 8;
            this.buttonSettingsCancel.Text = "Cancel";
            this.buttonSettingsCancel.UseVisualStyleBackColor = true;
            this.buttonSettingsCancel.Click += new System.EventHandler(this.buttonSettingsCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 349);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enable RealTime Synchronization?";
            // 
            // checkBoxRealTime
            // 
            this.checkBoxRealTime.AutoSize = true;
            this.checkBoxRealTime.Location = new System.Drawing.Point(16, 398);
            this.checkBoxRealTime.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxRealTime.Name = "checkBoxRealTime";
            this.checkBoxRealTime.Size = new System.Drawing.Size(113, 29);
            this.checkBoxRealTime.TabIndex = 10;
            this.checkBoxRealTime.Text = "Realtime?";
            this.checkBoxRealTime.UseVisualStyleBackColor = true;
            // 
            // textBoxSynchronizationInterval
            // 
            this.textBoxSynchronizationInterval.Location = new System.Drawing.Point(442, 393);
            this.textBoxSynchronizationInterval.MaxLength = 2;
            this.textBoxSynchronizationInterval.Name = "textBoxSynchronizationInterval";
            this.textBoxSynchronizationInterval.Size = new System.Drawing.Size(127, 31);
            this.textBoxSynchronizationInterval.TabIndex = 11;
            this.textBoxSynchronizationInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSynchronizationInterval_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Synchronization Interval (Minutes): ";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSynchronizationInterval);
            this.Controls.Add(this.checkBoxRealTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSettingsCancel);
            this.Controls.Add(this.buttonSettingsSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxDestination);
            this.Controls.Add(this.checkBoxSource);
            this.Controls.Add(this.buttonBrowseDestination);
            this.Controls.Add(this.textBoxDestinationPath);
            this.Controls.Add(this.btnSourceBrowse);
            this.Controls.Add(this.textBoxSettingSourcePath);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSettingSourcePath;
        private System.Windows.Forms.Button btnSourceBrowse;
        private System.Windows.Forms.TextBox textBoxDestinationPath;
        private System.Windows.Forms.Button buttonBrowseDestination;
        private System.Windows.Forms.CheckBox checkBoxSource;
        private System.Windows.Forms.CheckBox checkBoxDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSettingsSave;
        private System.Windows.Forms.Button buttonSettingsCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxRealTime;
        private System.Windows.Forms.TextBox textBoxSynchronizationInterval;
        private System.Windows.Forms.Label label3;
    }
}