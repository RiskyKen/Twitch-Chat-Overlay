using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace twitch_chat_overlay
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Double_J_Design_Diagram_Free_Chat;
            txtFileLocation.Text = Properties.Settings.Default.OutputFileLocation;
            numLineLimit.Value = Properties.Settings.Default.ChatFileLineCount;
            chkTimeStamps.Checked = Properties.Settings.Default.ChatFileTimeStamps;
            txtMessageTime.Text = Properties.Settings.Default.ChatMessageMaxTime.ToString();
            txtHost.Text = Properties.Settings.Default.ServerHost;
            txtPort.Text = Properties.Settings.Default.ServerPort.ToString();
            chkAutoChatChannel.Checked = Properties.Settings.Default.AutoChatChannel;
            updateAutoChatChecked();
            txtChatSoundLocation.Text = Properties.Settings.Default.ChatSoundLocation;
            chkEnableChatSound.Checked = Properties.Settings.Default.ChatSoundEnabled;
        }
        
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.CheckFileExists = false;
            sfd.FileName = txtFileLocation.Text;
            sfd.Filter = "txt files (*.txt)|*.txt";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFileLocation.Text = sfd.FileName;
            }
            sfd.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.OutputFileLocation = txtFileLocation.Text;
            Properties.Settings.Default.ChatFileLineCount = (int)numLineLimit.Value;
            Properties.Settings.Default.ChatFileTimeStamps = chkTimeStamps.Checked;
            try
            {
                Properties.Settings.Default.ChatMessageMaxTime = int.Parse(txtMessageTime.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Chat message time must be a number.");
                return;
            }
            Properties.Settings.Default.ServerHost = txtHost.Text;
            try
            {
                Properties.Settings.Default.ServerPort = int.Parse(txtPort.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Port must be a number.");
                return;
            }
            if (chkAutoChatChannel.Checked)
            {
                Properties.Settings.Default.ChatChannel = "";
                Properties.Settings.Default.AutoChatChannel = true;
            }
            else
            {
                Properties.Settings.Default.ChatChannel = txtChatChannel.Text;
                Properties.Settings.Default.AutoChatChannel = false;
            }

            Properties.Settings.Default.ChatSoundLocation = txtChatSoundLocation.Text;
            Properties.Settings.Default.ChatSoundEnabled = chkEnableChatSound.Checked;

            Properties.Settings.Default.Save();

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnBrowseChatSound_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "wav files (*.wav)|*.wav";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtChatSoundLocation.Text = ofd.FileName;
            }
            ofd.Dispose();
        }

        private void chkAutoChatChannel_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoChatChannel = chkAutoChatChannel.Checked;
            updateAutoChatChecked();
        }

        private void updateAutoChatChecked()
        {
            if (Properties.Settings.Default.AutoChatChannel)
            {
                txtChatChannel.Text = "Auto";
                txtChatChannel.ReadOnly = true;
            }
            else
            {
                txtChatChannel.Text = Properties.Settings.Default.ChatChannel;
                txtChatChannel.ReadOnly = false;
            }
        }
    }
}
