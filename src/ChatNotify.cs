using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Media;

namespace twitch_chat_overlay
{
    public class ChatNotify
    {
        public ChatNotify()
        {
            Program.chat.OnChat += chat_OnChat;
        }

        private void chat_OnChat(string text)
        {
            if (Properties.Settings.Default.ChatSoundEnabled)
            {
                if (File.Exists(Properties.Settings.Default.ChatSoundLocation))
                {
                    SoundPlayer chatSound = new SoundPlayer(Properties.Settings.Default.ChatSoundLocation);
                    chatSound.Play();
                    chatSound.Dispose();
                }
            }
        }

        public void Dispose()
        {
            Program.chat.OnChat -= chat_OnChat;
        }
    }
}
