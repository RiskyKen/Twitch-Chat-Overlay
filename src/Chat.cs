using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Meebey.SmartIrc4net;
using System.Diagnostics;
using System.Threading;

namespace twitch_chat_overlay
{
    class Chat
    {
        private IrcClient irc;

        public delegate void ConnectedEventHandler();
        public event ConnectedEventHandler OnConnected;

        public delegate void LoginFailedEventHandler();
        public event LoginFailedEventHandler OnLoginFailed;

        public delegate void ChatEventHandler(string text);
        public event ChatEventHandler OnChat;

        private string userName;

        private Thread listenThread;

        public Chat()
        {
            irc = new IrcClient();
            irc.SendDelay = 2000;
            irc.ActiveChannelSyncing = true;

            irc.OnConnected += new EventHandler(irc_OnConnected);
            irc.OnRegistered += new EventHandler(irc_OnRegistered);
            irc.OnError += new ErrorEventHandler(irc_OnError);
            irc.OnRawMessage += new IrcEventHandler(irc_OnRawMessage);
            irc.OnJoin += new JoinEventHandler(irc_OnJoin);
            irc.OnChannelMessage += new IrcEventHandler(irc_OnChannelMessage);
            irc.OnErrorMessage += new IrcEventHandler(irc_OnErrorMessage);
            irc.OnChannelPassiveSynced += new IrcEventHandler(irc_OnChannelPassiveSynced);
        }

        void irc_OnChannelPassiveSynced(object sender, IrcEventArgs e)
        {
            Debug.WriteLine("Passive Synced: " + e.Data.RawMessage);

            
        }

        void irc_OnRegistered(object sender, EventArgs e)
        {
            Debug.WriteLine("Registered");
            if (OnConnected != null) { OnConnected.Invoke(); }
        }

        void irc_OnErrorMessage(object sender, IrcEventArgs e)
        {
            Debug.WriteLine("Error Message: " + e.Data.Message);
        }

        void irc_OnChannelMessage(object sender, IrcEventArgs e)
        {
            Debug.WriteLine("Chat: " + e.Data.Nick + ":" + e.Data.Message);
            if (OnChat != null) { OnChat.Invoke(e.Data.Nick + ": " + e.Data.Message); }
        }

        void irc_OnJoin(object sender, JoinEventArgs e)
        {
            Debug.WriteLine("Join: " + e.Channel);
        }

        void irc_OnRawMessage(object sender, IrcEventArgs e)
        {
            if (e.Data.Message == "Login unsuccessful") { if (OnLoginFailed != null) { OnLoginFailed.Invoke(); } }
            Debug.WriteLine("Raw Message: " + e.Data.Message);
            Debug.WriteLine("Raw Message: " + e.Data.RawMessage);
        }

        void irc_OnError(object sender, ErrorEventArgs e)
        {
            Debug.WriteLine("Error: " + e.ErrorMessage);
        }

        void irc_OnConnected(object sender, EventArgs e)
        {
            Debug.WriteLine("Connected");
        }

        public void Dispose()
        {
            if (irc.IsConnected)
            {
                listenThread.Abort();
                //irc.Disconnect();
            }
            irc.OnConnected -= irc_OnConnected;
            irc.OnError -= irc_OnError;
            irc.OnRawMessage -= irc_OnRawMessage;
            irc.OnJoin += new JoinEventHandler(irc_OnJoin);
            irc.OnChannelMessage += new IrcEventHandler(irc_OnChannelMessage);
            irc = null;
        }

        public bool Connect(string username, string password, string host, int port)
        {
            try
            {
                irc.Connect(host, port);
            }
            catch (Exception)
            {
                return false;
            }

            this.userName = (string)username.Clone();

            try
            {
                //irc.Login("guest", "guest");
                irc.Login(username, username, 0, username, password);
                irc.RfcJoin("#" + userName.ToLower());
            }
            catch (Exception)
            {
                return false;
            }

            listenThread = new Thread(Listen);
            listenThread.Start();
            return true;
        }

        private void Listen()
        {
            irc.Listen(); 
        }

        public int GetUserCount()
        {
            if (irc.IsConnected)
            {
                return (int)irc.Lag.TotalMilliseconds;
            }
            return 0;
        }
    }
}
