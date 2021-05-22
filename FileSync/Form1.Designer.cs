
namespace FileSync
{
    partial class Form1
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
            this.textSourcePath = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.textDestinationPath = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnSourceBrowse = new System.Windows.Forms.Button();
            this.btnDestinationBrowse = new System.Windows.Forms.Button();
            this.labelTotalFiles = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textSourcePath
            // 
            this.textSourcePath.Location = new System.Drawing.Point(126, 180);
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
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(66, 25);
            this.lblSource.TabIndex = 6;
            this.lblSource.Text = "Source";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(919, 132);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(102, 25);
            this.lblDestination.TabIndex = 5;
            this.lblDestination.Text = "Destination";
            // 
            // textDestinationPath
            // 
            this.textDestinationPath.Location = new System.Drawing.Point(919, 179);
            this.textDestinationPath.Name = "textDestinationPath";
            this.textDestinationPath.Size = new System.Drawing.Size(483, 31);
            this.textDestinationPath.TabIndex = 2;
            this.textDestinationPath.Click += new System.EventHandler(this.textDestinationPath_Click);
            this.textDestinationPath.Leave += new System.EventHandler(this.textDestinationPath_Leave);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(1408, 406);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(112, 34);
            this.btnExecute.TabIndex = 4;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnSourceBrowse
            // 
            this.btnSourceBrowse.Location = new System.Drawing.Point(615, 177);
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
            this.btnDestinationBrowse.Name = "btnDestinationBrowse";
            this.btnDestinationBrowse.Size = new System.Drawing.Size(112, 34);
            this.btnDestinationBrowse.TabIndex = 3;
            this.btnDestinationBrowse.Text = "Browse...";
            this.btnDestinationBrowse.UseVisualStyleBackColor = true;
            this.btnDestinationBrowse.Click += new System.EventHandler(this.btnDestinationBrowse_Click);
            // 
            // labelTotalFiles
            // 
            this.labelTotalFiles.AutoSize = true;
            this.labelTotalFiles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTotalFiles.Location = new System.Drawing.Point(282, 415);
            this.labelTotalFiles.Name = "labelTotalFiles";
            this.labelTotalFiles.Size = new System.Drawing.Size(0, 32);
            this.labelTotalFiles.TabIndex = 7;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 927);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(2078, 34);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total Files Checked: ";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.DarkRed;
            this.labelError.Location = new System.Drawing.Point(13, 1100);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 25);
            this.labelError.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2102, 1153);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelTotalFiles);
            this.Controls.Add(this.btnDestinationBrowse);
            this.Controls.Add(this.btnSourceBrowse);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.textDestinationPath);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.textSourcePath);
            this.Name = "Form1";
            this.Text = "FileSync";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
        private System.Windows.Forms.Label labelTotalFiles;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelError;
    }
}

