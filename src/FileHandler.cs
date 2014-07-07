using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Timers;
using System.Diagnostics;

namespace twitch_chat_overlay
{
    class FileHandler
    {
        StreamWriter sw;
        StreamReader sr;
        Object lockObj;

        public FileHandler()
        {
            lockObj = new Object();
            ClearChat();
        }

        public void ClearChat()
        {
            lock (lockObj)
            {
                sw = new StreamWriter(Properties.Settings.Default.OutputFileLocation, false);
                sw.Flush();
                sw.Close();
            }
        }

        public void WriteChatFile(string fileText)
        {
            lock (lockObj)
            {
                sw = new StreamWriter(Properties.Settings.Default.OutputFileLocation, false);
                sw.Write(fileText);
                sw.Flush();
                sw.Close();
            }
            
        }

        private void AddToChatFile(string text)
        {
            string[] lines = null;
            if (File.Exists(Properties.Settings.Default.OutputFileLocation))
            {
                sr = new StreamReader(Properties.Settings.Default.OutputFileLocation);
                lines = sr.ReadToEnd().Split("\n\r".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                sr.Close();
            }

            sw = new StreamWriter(Properties.Settings.Default.OutputFileLocation, false);

            if (lines != null)
            {
                if (lines.GetUpperBound(0) + 1 >= Properties.Settings.Default.ChatFileLineCount)
                {
                    string[] newlines;
                    int offSet = (lines.GetUpperBound(0) + 1) - Properties.Settings.Default.ChatFileLineCount + 1;
                    newlines = new string[Properties.Settings.Default.ChatFileLineCount - 1];
                    for (int i = offSet; i <= lines.GetUpperBound(0); i++)
                    {
                        newlines[i - offSet] = lines[i];
                    }
                    lines = newlines;
                }
                for (int i = 0; i <= lines.GetUpperBound(0); i++)
                {
                    sw.WriteLine(lines[i]);
                }
            }
            sw.WriteLine(text);
            sw.Flush();
            sw.Close();
        }

        public void Dispose()
        {
            lockObj = null;
        }
    }
}
