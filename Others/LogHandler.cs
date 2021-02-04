using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiwinRobot.Others
{
    public interface ILogHandler
    {
        string Path { get; set; }

        void Write(string content);
    }

    public class LogHandler : ILogHandler
    {
        private int Count = 1;

        private string FileName;

        public LogHandler()
        {
            Path = "";
            CreateFile(new DateTime());
        }

        public LogHandler(string path)
        {
            Path = path;
            CreateFile(new DateTime());
        }

        public string Path { get; set; }

        public void Write(string content)
        {
            var file = MakeStreamWriter();
            file.WriteLine(content.Trim());
            file.Close();
        }

        private void CreateFile(DateTime dateTime)
        {
            string targetFileName = $"{dateTime.ToString("MMM")}{dateTime.Date}_{Count}.log";

            if (File.Exists(Path + targetFileName))
            {
                Count++;
                CreateFile(dateTime);
            }
            else
            {
                FileName = targetFileName;
                var file = MakeStreamWriter();
                file.WriteLine(
                    dateTime.ToString("yyyy-MM-dd_HH:mm:ss") + "\r\n-----");
                file.Close();
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