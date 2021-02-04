using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiwinRobot
{
    public interface ILogHandler
    {
        string Path { get; set; }

        void Write(string content, bool includeTimestamp = true);
    }

    public class LogHandler : ILogHandler
    {
        private int Count = 1;

        private string FileName;

        public LogHandler(string path = "")
        {
            Path = path;
            CreateFile(DateTime.Now);
        }

        public string Path { get; set; }

        public void Write(string content, bool includeTimestamp = true)
        {
            string text;
            text = includeTimestamp ? DateTime.Now.ToString("HH:mm:ss-") : "";
            text += content.Trim();

            var file = MakeStreamWriter();
            file.WriteLine(text);
            file.Close();
        }

        private void CreateFile(DateTime dateTime)
        {
            string targetFileName = $"{dateTime:MMMdd}_{Count}.log";

            if (File.Exists(Path + targetFileName))
            {
                Count++;
                CreateFile(dateTime);
            }
            else
            {
                FileName = targetFileName;
                Write(dateTime.ToString("yyyy-MM-dd_HH:mm:ss\r\n---"),
                      false);
            }
        }

        /// <summary>
        /// Factory pattern。
        /// </summary>
        /// <returns></returns>
        private StreamWriter MakeStreamWriter()
        {
            return File.AppendText(Path + FileName);
        }
    }
}