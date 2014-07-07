using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;

namespace twitch_chat_overlay
{
    static class Program
    {
        private static TrayIcon trayIcon;

        public static Chat chat;

        private static ChatHandler chatHandler;

        private static LoginForm loginForm = null;

        private static SettingsForm settingsForm = null;

        private static StatusForm statusForm = null;

        private static ChatNotify chatNotify;

        public static bool SignedIn = false;
        /// <summary>
        /// The main entry point for the application.
        /// http://help.twitch.tv/customer/portal/articles/1302780-twitch-irc
        /// http://twitchapps.com/tmi/
        /// </summary>
        [STAThread]
        static void Main()
        {
            Assembly asm = Assembly.GetAssembly(typeof(Program));
            if (asm != null)
            {
                AssemblyName asmName = asm.GetName();
                byte[] key = asmName.GetPublicKey();
                bool isSignedAsm = key.Length > 0;
                Console.WriteLine("IsSignedAssembly={0}", isSignedAsm);
                Console.WriteLine("PublicKey={0}", key.ToString());
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CheckOutputFileSetting();
            chat = new Chat();
            chatNotify = new ChatNotify();
            chatHandler = new ChatHandler();
            trayIcon = new TrayIcon();
            ShowLoginOrStatusForm();
            if (SignedIn) { Application.Run(); }
            trayIcon.Dispose();
            chatHandler.Dispose();
            chatNotify.Dispose();
            chat.Dispose();
        }

        public static void ShowLoginForm()
        {
            if (loginForm == null)
            {
                loginForm = new LoginForm();
                loginForm.ShowDialog();
                loginForm.Dispose();
                loginForm = null;
            }
            else
            {
                loginForm.Activate();
            }
        }

        public static void ShowSettingsForm()
        {
            if (settingsForm == null)
            {
                settingsForm = new SettingsForm();
                settingsForm.ShowDialog();
                settingsForm.Dispose();
                settingsForm = null;
            }
            else
            {
                settingsForm.Activate();
            }
        }

        public static void ShowStatusForm()
        {
            if (statusForm == null)
            {
                statusForm = new StatusForm();
                statusForm.ShowDialog();
                statusForm.Dispose();
                statusForm = null;
            }
            else
            {
                statusForm.Activate();
            }
        }

        public static void ShowLoginOrStatusForm()
        {
            if (SignedIn) { ShowStatusForm(); }
            else { ShowLoginForm(); }
        }

        public static void ClearChat()
        {
            chatHandler.ClearChat();
        }

        public static void CheckOutputFileSetting()
        {
            if (String.IsNullOrWhiteSpace(Properties.Settings.Default.OutputFileLocation))
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\twitch chat.txt";
                Properties.Settings.Default.OutputFileLocation = path;
                Properties.Settings.Default.Save();
            }
        }
    }
}
