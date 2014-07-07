using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace twitch_chat_overlay
{
    class TrayIcon
    {
        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;
        public TrayIcon()
        {
            trayIcon = new NotifyIcon();
            trayIcon.Icon = Properties.Resources.Double_J_Design_Diagram_Free_Chat;
            trayIcon.Text = "Twitch Chat Overlay";
            AddMenuItems();
            trayIcon.Visible = true;
        }

        private void AddMenuItems()
        {
            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Show");
            trayMenu.MenuItems.Add("-");
            trayMenu.MenuItems.Add("Clear Chat");
            trayMenu.MenuItems.Add("Settings");
            trayMenu.MenuItems.Add("-");
            trayMenu.MenuItems.Add("Exit");
            trayMenu.MenuItems[0].DefaultItem = true;

            trayMenu.MenuItems[0].Click += new EventHandler(TrayIcon_Show_Click);
            trayMenu.MenuItems[2].Click += new EventHandler(TrayIcon_Clear_Chat_Click);
            trayMenu.MenuItems[3].Click += new EventHandler(TrayIcon_Settings_Click);
            trayMenu.MenuItems[5].Click += new EventHandler(TrayIcon_Exit_Click);

            trayIcon.DoubleClick += new EventHandler(trayIcon_DoubleClick);

            trayIcon.ContextMenu = trayMenu;
        }

        void trayIcon_DoubleClick(object sender, EventArgs e)
        {
            Program.ShowLoginOrStatusForm();
        }

        void TrayIcon_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void TrayIcon_Settings_Click(object sender, EventArgs e)
        {
            Program.ShowSettingsForm();
        }

        void TrayIcon_Clear_Chat_Click(object sender, EventArgs e)
        {
            Program.ClearChat();
        }

        void TrayIcon_Show_Click(object sender, EventArgs e)
        {
            Program.ShowLoginOrStatusForm();
        }

        public void Dispose()
        {
            trayIcon.Visible = false;
            trayIcon.Dispose();
            trayMenu.Dispose();
        }
    }
}
