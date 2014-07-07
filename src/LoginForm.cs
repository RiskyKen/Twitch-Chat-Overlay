using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace twitch_chat_overlay
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Double_J_Design_Diagram_Free_Chat;
            txtUsername.Text = Properties.Settings.Default.UserName;
            if (Properties.Settings.Default.RememberPassword)
            {
                txtPassword.Text = Properties.Settings.Default.Password;
                chkRememberPassword.Checked = true;
            }
            Program.chat.OnConnected += new Chat.ConnectedEventHandler(chat_OnConnected);
            Program.chat.OnLoginFailed +=new Chat.LoginFailedEventHandler(chat_OnLoginFailed);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUsername.Text) | String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter a username and password.", Application.ProductName, MessageBoxButtons.OK);
                return;
            }

            Properties.Settings.Default.UserName = txtUsername.Text;
            Properties.Settings.Default.RememberPassword = chkRememberPassword.Checked;
            if (chkRememberPassword.Checked)
            { Properties.Settings.Default.Password = txtPassword.Text; }
            else
            { Properties.Settings.Default.Password = ""; }
            Properties.Settings.Default.Save();

            btnLogin.Enabled = false;
            
            if (!Program.chat.Connect(txtUsername.Text, txtPassword.Text, Properties.Settings.Default.ServerHost, Properties.Settings.Default.ServerPort))
            {
                LoginFailed();
            }

        }

        void chat_OnLoginFailed()
        {
            LoginFailed();
        }

        void chat_OnConnected()
        {
            Login();
        }


        public delegate void LoginEventHandler();
        private void Login()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new LoginEventHandler(Login));
                return;
            }
            //ControlHelpers.MaybeInvoke(btnLogin, () => btnLogin.Enabled = true);
            btnLogin.Enabled = true;
            Program.SignedIn = true;

            //Program.ShowLoginOrStatusForm();
            this.Close();
        }

        public delegate void LoginFailedEventHandler();
        private void LoginFailed()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new LoginFailedEventHandler(LoginFailed));
                return;
            }
            MessageBox.Show("Login failed.\n\nPlease check your details.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            btnLogin.Enabled = true;
        }

        private void linkGetToken_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://twitchapps.com/tmi/");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Program.ShowSettingsForm();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.chat.OnConnected -= new Chat.ConnectedEventHandler(chat_OnConnected);
            Program.chat.OnLoginFailed -= new Chat.LoginFailedEventHandler(chat_OnLoginFailed);
        }
    }
}
