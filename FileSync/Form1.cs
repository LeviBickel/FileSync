using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace FileSync
{
    public partial class Form1 : Form
    {
        string defaultSourcePath = "Source Path...";
        string defaultDestinationPath = "Destination Path...";
        public Form1()
        {
            InitializeComponent();
            textDestinationPath.Text = defaultDestinationPath;
            textSourcePath.Text = defaultSourcePath;
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
            try
            {
                if (!Directory.Exists(textSourcePath.Text))
                {
                    SetMessages("Source directory doesn't exist", isGUI);
                    return;
                }
                if (!Directory.Exists(textDestinationPath.Text))
                {
                    SetMessages("Destination directory doesn't exist", isGUI);
                    return;
                }


                var sourceFiles = Directory.GetFiles(textSourcePath.Text);
                var destinationFiles = Directory.GetFiles(textDestinationPath.Text);
                var totalFilesToCheck = sourceFiles.Length;
                var totalFilesLeftToCheck = sourceFiles.Length;
                bool fileAlreadyChecked = false;
                var currentFile = 0;
                if (isGUI)
                {
                    labelTotalFiles.Text = sourceFiles.Length.ToString();
                }


                //Loop through each file source file and compare to the destination file.
                for (int i = 0; i < sourceFiles.Length; i++)
                {
                    currentFile++;
                    var fileSource = File.ReadAllBytes(sourceFiles[i]);
                    byte[] fileDestinationBytes = null;
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
                    if (fileDestination == "" && !fileAlreadyChecked)
                    {
                        File.Copy(sourceFiles[i], textDestinationPath.Text + sourceFiles[i].Substring(sourceFiles[i].LastIndexOf(@"\")));
                        fileAlreadyChecked = true;
                    }

                    //Compare the files
                    if (fileSource.Length == fileDestinationBytes.Length && !fileAlreadyChecked)
                    {
                        for (int x = 0; x < fileSource.Length; x++)
                        {
                            if (fileSource[x] != fileDestinationBytes[x])
                            {
                                //Contents are not equal. Move the source to destination if newer.

                                if (File.GetLastWriteTimeUtc(sourceFiles[i]) > File.GetLastWriteTimeUtc(fileDestination))
                                {
                                    //The source file is newer... Lets move the file.
                                    File.Delete(fileDestination);
                                    File.Copy(sourceFiles[i], fileDestination);
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

                        File.Delete(fileDestination);
                        File.Copy(sourceFiles[i], fileDestination);
                        fileAlreadyChecked = true;
                    }


                    totalFilesLeftToCheck--;
                    //update the progressbar
                    if (isGUI)
                    {
                        int increase = currentFile - totalFilesLeftToCheck;
                        progressBar.Value = increase / totalFilesToCheck * 100;
                    }
                }
                SetMessages("Successfully synchronized, "+textSourcePath.Text+" with " + textDestinationPath.Text+". "+totalFilesToCheck+" files compared.", isGUI, EventLogEntryType.Information);
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Kill any threads here if created:

            Application.Exit(); //Remove this once we move to a background worker that keeps the folders synchronized.
        }
    }
}
