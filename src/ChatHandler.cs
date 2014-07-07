using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Diagnostics;

namespace twitch_chat_overlay
{
    class ChatHandler
    {
        private List<ChatMessageInfo> messages;
        private Timer timer;
        private Object lockObj;
        private FileHandler fileHandler;

        public ChatHandler()
        {
            messages = new List<ChatMessageInfo>();
            timer = new Timer();
            lockObj = new Object();
            fileHandler = new FileHandler();
            Program.chat.OnChat += ChatMessage;
            timer.Elapsed += timer_Elapsed;
            timer.Interval = 1000;
            timer.Start();
        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (RemoveOldMessages()) { UpdateChatFile(); }
            //Debug.WriteLine("Timer");
        }

        private void ChatMessage(string text)
        {
            messages.Add(new ChatMessageInfo(text));
            CheckForMessageOverflow();
            UpdateChatFile();
        }

        private void CheckForMessageOverflow()
        {
            while (messages.Count > Properties.Settings.Default.ChatFileLineCount)
            {
                RemoveOldestMessage();
            }
        }

        private void RemoveOldestMessage()
        {
            int lowestValue = int.MaxValue;
            int lowestId = -1;
            lock (lockObj)
            {
                for (int i = 0; i < messages.Count; i++)
                {
                    if (messages[i].tick < lowestValue)
                    {
                        lowestValue = messages[i].tick;
                        lowestId = i;
                    }
                }
            }
            if (lowestId != -1)
            {
                messages.RemoveAt(lowestId);
            }
        }

        private bool RemoveOldMessages()
        {
            if (Properties.Settings.Default.ChatMessageMaxTime == -1) { return false; }
            bool changed = false;
            lock (lockObj)
            {
                for (int i = 0; i < messages.Count; i++)
                {
                    if (messages[i].tick < Environment.TickCount - Properties.Settings.Default.ChatMessageMaxTime)
                    {
                        messages.RemoveAt(i);
                        changed = true;
                    }
                }
            }
            return changed;
        }

        private void UpdateChatFile()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < messages.Count; i++)
            {
                sb.AppendLine(messages[i].message);
            }
            fileHandler.WriteChatFile(sb.ToString());
        }

        public void ClearChat()
        {
            messages.Clear();
            fileHandler.ClearChat();
        }

        public void Dispose()
        {
            fileHandler.Dispose();
            timer.Elapsed -= timer_Elapsed;
            Program.chat.OnChat -= ChatMessage;
            timer.Stop();
            timer.Dispose();
        }

        private class ChatMessageInfo
        {
            public string message;
            public int tick;

            public ChatMessageInfo(string message)
            {
                this.message = message;
                this.tick = Environment.TickCount;
            }
        }
    }
}
