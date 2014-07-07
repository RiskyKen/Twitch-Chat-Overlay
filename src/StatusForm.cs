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
    public partial class StatusForm : Form
    {
        public StatusForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Double_J_Design_Diagram_Free_Chat;
            Program.chat.OnChat += new Chat.ChatEventHandler(ChatMessage);
        }

        private void StatusForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.chat.OnChat -= new Chat.ChatEventHandler(ChatMessage);
        }

        private void ChatMessage(string text)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Chat.ChatEventHandler(ChatMessage),new Object[] { text });
                return;
            }
            txtChat.AppendText(DateTime.Now.ToString("HH:mm:ss tt") + " " + text + Environment.NewLine);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblUsers.Text = Program.chat.GetUserCount().ToString() + "Users";
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Program.ShowSettingsForm();
        }
    }
}
