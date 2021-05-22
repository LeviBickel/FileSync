using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSync
{
    public partial class SettingsForm : Form
    {
        string initialSourcePathText = "Source Path";
        string initialDestinationText = "Destination Path";
        public SettingsForm()
        {
            InitializeComponent();
            if (Properties.Settings.Default["SourcePath"].ToString() != "")
            {
                textBoxSettingSourcePath.Text = Properties.Settings.Default["SourcePath"].ToString();
            }
            if (Properties.Settings.Default["DestinationPath"].ToString() != "")
            {
                textBoxDestinationPath.Text = Properties.Settings.Default["DestinationPath"].ToString();
            }

            if (Properties.Settings.Default["FolderPreference"].ToString() == "Source")
            {
                checkBoxSource.Checked = true;
                checkBoxDestination.Checked = false;
            }
            else
            {
                checkBoxSource.Checked = false;
                checkBoxDestination.Checked = true;
            }

            if(Properties.Settings.Default["RealtimeSync"].ToString().ToLower() == "false")
            {
                checkBoxRealTime.Checked = false;
            }
            else
            {
                checkBoxRealTime.Checked = true;
            }

        }

        private void textBoxSettingSourcePath_Click(object sender, EventArgs e)
        {
            if(textBoxSettingSourcePath.Text != initialSourcePathText)
            {
                return;
            }
            textBoxSettingSourcePath.Text = "";
        }

        private void textBoxSettingSourcePath_Leave(object sender, EventArgs e)
        {
            if (textBoxSettingSourcePath.Text != initialSourcePathText && textBoxSettingSourcePath.Text != "")
            {
                return;
            }
            textBoxSettingSourcePath.Text = initialSourcePathText;
        }

        private void textBoxDestinationPath_Click(object sender, EventArgs e)
        {
            if (textBoxDestinationPath.Text != initialDestinationText)
            {
                return;
            }
            textBoxDestinationPath.Text = "";
        }

        private void textBoxDestinationPath_Leave(object sender, EventArgs e)
        {
            if (textBoxDestinationPath.Text != initialDestinationText && textBoxDestinationPath.Text != "")
            {
                return;
            }
            textBoxDestinationPath.Text = initialDestinationText;
        }

        private void btnSourceBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxSettingSourcePath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonBrowseDestination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxDestinationPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void checkBoxSource_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSource.Checked)
            {
                if (checkBoxDestination.Checked)
                {
                    checkBoxDestination.Checked = false;
                }
                Properties.Settings.Default["FolderPreference"] = "Source";
            }
        }

        private void checkBoxDestination_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDestination.Checked)
            {
                if (checkBoxSource.Checked)
                {
                    checkBoxSource.Checked = false;
                }
                Properties.Settings.Default["FolderPreference"] = "Destination";
            }
        }

        private void buttonSettingsCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSettingsSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["SourcePath"] = textBoxSettingSourcePath.Text;
            Properties.Settings.Default["DestinationPath"] = textBoxDestinationPath.Text;
            Properties.Settings.Default["RealtimeSync"] = checkBoxRealTime.Checked;
            try
            {
                Properties.Settings.Default.Save();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
            
        }
    }
}
