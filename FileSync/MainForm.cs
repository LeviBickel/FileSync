using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace FileSync
{
    public partial class MainForm : Form
    {
        string defaultSourcePath = "Source Path...";
        string defaultDestinationPath = "Destination Path...";
        bool ballonTipShown = false;
        int interval;

        public MainForm()
        {
            InitializeComponent();

            //Set initial settings here from the settings file.

            if (Properties.Settings.Default["SourcePath"].ToString() != "")
            {
                textSourcePath.Text = Properties.Settings.Default["SourcePath"].ToString();
            }
            else
            {
                textSourcePath.Text = defaultSourcePath;
            }
            
            if (Properties.Settings.Default["DestinationPath"].ToString() != "")
            {
                textDestinationPath.Text = Properties.Settings.Default["DestinationPath"].ToString();
            }
            else
            {
                textDestinationPath.Text = defaultDestinationPath;
            }
            
            labelError.Text = "";
            notifyIcon.Icon = Properties.Resources.AppIcon;
            notifyIcon.ContextMenuStrip.Items.Add("Open", Properties.Resources.Open1, Open_Click);
            notifyIcon.ContextMenuStrip.Items.Add("Start Synchronization", Properties.Resources.Synchronize, SynchronizeNow_Click);
            notifyIcon.ContextMenuStrip.Items.Add("Settings", Properties.Resources.Settings1, ContextMenuSettingsButton_Click);
            notifyIcon.ContextMenuStrip.Items.Add("Exit", Properties.Resources.Exit1, Exit_Click);
            notifyIcon.Visible = true;

            backgroundWorker1.DoWork += StartTaskingTimer;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void StartTaskingTimer(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            interval = SetInterval();
            // Create an AutoResetEvent to signal the timeout threshold in the
            // timer callback has been reached.
            var autoEvent = new AutoResetEvent(false);
            //var statusChecker = new StatusChecker(5);

            // creates a Timer to call CheckStatus() with autoEvent as argument,
            // starting with 1 minute delay and calling every 5 minutes.
            var stateTimer = new System.Threading.Timer(CallFileSync, autoEvent, 60000, interval);
            autoEvent.WaitOne();
        }
        public int SetInterval()
        {
            var syncInterval = Properties.Settings.Default["SyncInterval"].ToString();
            interval = Convert.ToInt32(syncInterval);
            interval = interval * 60000;
            return interval;
        }

        private void CallFileSync(Object stateInfo)
        {
            SetInterval();
            if(Properties.Settings.Default["RealtimeSync"].ToString().ToLower() == "true")
            {
                FileComparison();
            }
            else { return; }
            
        }

        private void btnSourceBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                textSourcePath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnDestinationBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                textDestinationPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            FileComparison(true);
        }

        private void textSourcePath_Click(object sender, EventArgs e)
        {
            if(textSourcePath.Text == defaultSourcePath)
            {
                textSourcePath.Text = "";
            }
        }

        private void textDestinationPath_Click(object sender, EventArgs e)
        {
            if (textDestinationPath.Text == defaultDestinationPath)
            {
                textDestinationPath.Text = "";
            }
        }

        private void textDestinationPath_Leave(object sender, EventArgs e)
        {
            if(textDestinationPath.Text != defaultDestinationPath && textDestinationPath.Text != "")
            {
                return;
            }

            textDestinationPath.Text = defaultDestinationPath;
        }

        private void textSourcePath_Leave(object sender, EventArgs e)
        {
            if (textSourcePath.Text != defaultSourcePath && textSourcePath.Text != "")
            {
                return;
            }

            textSourcePath.Text = defaultSourcePath;
        }
        
        private void FileComparison(bool isGUI = false)
        {
            var sourcePath = "";
            var destinationPath = "";
            try
            {
                if (!isGUI)
                {
                    if(Properties.Settings.Default["SourcePath"].ToString() == "" || Properties.Settings.Default["DestinationPath"].ToString() == "")
                    {
                        SetMessages("Source Path and Destination Path not set in the settings.");
                        return;
                    }
                    sourcePath = Properties.Settings.Default["SourcePath"].ToString();
                    destinationPath = Properties.Settings.Default["DestinationPath"].ToString();

                }
                else
                {
                    sourcePath = textSourcePath.Text;
                    destinationPath = textDestinationPath.Text;
                }
                if (!Directory.Exists(sourcePath))
                {
                    SetMessages("Source directory doesn't exist", isGUI);
                    return;
                }
                if (!Directory.Exists(destinationPath))
                {
                    SetMessages("Destination directory doesn't exist", isGUI);
                    return;
                }
                if(sourcePath == destinationPath)
                {
                    SetMessages("Source and Destination Directories can't match", isGUI);
                    return;
                }
                bool keepSource = true;
                if (Properties.Settings.Default["FolderPreference"].ToString() == "Destination")
                {
                    keepSource = false;
                }
                List<string> sourceFiles = Directory.GetFiles(sourcePath, "*", SearchOption.AllDirectories).ToList();
                List<string> destinationFiles = Directory.GetFiles(destinationPath, "*", SearchOption.AllDirectories).ToList();


                var totalFilesToCheck = sourceFiles.Count;
                var totalFilesLeftToCheck = sourceFiles.Count;
                
                var currentFile = 0;
                if (isGUI)
                {
                    labelTotalFiles.Text = sourceFiles.Count.ToString();
                }

                
                //Loop through each file source file and compare to the destination file.
                for (int i = 0; i < sourceFiles.Count; i++)
                {
                    bool fileAlreadyChecked = false;
                    currentFile++;
                    var fileSource = File.ReadAllBytes(sourceFiles[i]);
                    byte[] fileDestinationBytes = new byte[] { };
                    var fileDestination = "";
                    //Get the destination file for comparison.
                    foreach (var file in destinationFiles)
                    {
                        if (file.Contains(sourceFiles[i].Substring(sourceFiles[i].LastIndexOf(@"\"))))
                        {
                            fileDestination = file;
                            fileDestinationBytes = File.ReadAllBytes(file);
                        }
                    }

                    //If the file doesn't exist at the destination, copy it.
                    if (fileDestination == "")
                    {
                        //Handle the location to copy to.
                        var fileDestinationPath = destinationPath + sourceFiles[i].Remove(0, sourcePath.Length);
                        var destinationDirectory = fileDestinationPath.Remove(fileDestinationPath.LastIndexOf(@"\"));
                        if (!Directory.Exists(destinationDirectory))
                        {
                            Directory.CreateDirectory(destinationDirectory);
                        }
                        File.Copy(sourceFiles[i], fileDestinationPath);
                        fileDestination = fileDestinationPath;
                        fileAlreadyChecked = true;
                    }

                    if (!fileAlreadyChecked)
                    {
                        //Compare the files
                        if (fileSource.Length == fileDestinationBytes.Length)
                        {
                            for (int x = 0; x < fileSource.Length; x++)
                            {
                                if (fileSource[x] != fileDestinationBytes[x])
                                {
                                    //Contents are not equal. Move the source to destination if newer.
                                    if (keepSource)
                                    {
                                        if (File.GetLastWriteTimeUtc(sourceFiles[i]) > File.GetLastWriteTimeUtc(fileDestination))
                                        {
                                            //The source file is newer... Lets move the file.
                                            File.Copy(sourceFiles[i], fileDestination,true);
                                        }
                                    }
                                    fileAlreadyChecked = true;

                                }


                            }
                            //Files are the same. we can skip this file.
                            fileAlreadyChecked = true;

                        }
                        //File length is not the same. Check if the source is newer, if so, move the source to the destination.
                        if (File.GetLastWriteTimeUtc(sourceFiles[i]) > File.GetLastWriteTimeUtc(fileDestination) && !fileAlreadyChecked)
                        {
                            //The source file is newer... Lets move the file.
                            if (keepSource)
                            {
                                File.Copy(sourceFiles[i], fileDestination, true);
                            }
                            fileAlreadyChecked = true;
                        }
                    }

                    totalFilesLeftToCheck--;
                    //update the progressbar
                    if (isGUI)
                    {
                        int increase = currentFile - totalFilesLeftToCheck;
                        
                        progressbarToolstrip.Value = increase / totalFilesToCheck * 100;
                    }
                }
                SetMessages("Successfully synchronized, "+sourcePath+" with " + destinationPath+". "+totalFilesToCheck+" files compared.", isGUI, EventLogEntryType.Information);
            }
            catch(Exception ex)
            {
                SetMessages(ex.ToString(), isGUI);
            }
            
            
        }

        private void SetMessages(string errorMessage, bool isGUI = false, EventLogEntryType eventLogEntryType = EventLogEntryType.Error)
        {
            if (isGUI)
            {
                if(eventLogEntryType == EventLogEntryType.Information)
                {
                    labelError.ForeColor = Color.DarkGreen;
                }

                labelError.Text = errorMessage;

            }

            //Send the error to the event log.

            // Create an instance of EventLog
            EventLog eventLog = new EventLog();

            // Check if the event source exists. If not create it.
            if (!EventLog.SourceExists("FileSync"))
            {
                EventLog.CreateEventSource("FileSync", "Application");
            }

            // Set the source name for writing log entries.
            eventLog.Source = "FileSync";

            // Create an event ID to add to the event log
            int eventID = 8;

            // Write an entry to the event log.
            eventLog.WriteEntry(errorMessage, eventLogEntryType, eventID);

            // Close the Event Log
            eventLog.Close();
        }

        private void ShowSettings()
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem == Settings)
            {
                ShowSettings();
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            bool MousePointerNotOnTaskbar = Screen.GetWorkingArea(this).Contains(Cursor.Position);

            if(this.WindowState == FormWindowState.Minimized && MousePointerNotOnTaskbar)
            {
                if (!ballonTipShown)
                {
                    notifyIcon.BalloonTipText = "FileSync will continue synchronizing in the background.";
                    notifyIcon.ShowBalloonTip(500);
                    ballonTipShown = true;
                }
                this.ShowInTaskbar = false;
                //notifyIcon.Visible = true;

            }


        }

        private void Exit_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            backgroundWorker1.Dispose();
            Application.Exit();
        }
        private void ContextMenuSettingsButton_Click(object sender, EventArgs e)
        {
            ShowSettings();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void SynchronizeNow_Click(object sender, EventArgs e)
        {
            FileComparison();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
