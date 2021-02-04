using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiwinRobot
{
    /// <summary>
    /// 日誌等級。<br/>
    /// 數值越大表示越嚴重。
    /// </summary>
    public enum LoggingLevel
    {
        Trace = 0,
        Info,
        Warn,
        Error,
        Fatal = 99
    }

    public interface ILogHandler
    {
        string Path { get; set; }

        void Write(LoggingLevel loggingLevel, string content);

        void Write(LoggingLevel loggingLevel, Exception ex);
    }

    public class LogHandler : ILogHandler
    {
        private int Count = 1;

        private string FileName;

        private LoggingLevel LoggingLevel;

        public LogHandler(string path = "",
                          LoggingLevel loggingLevel = LoggingLevel.Trace)
        {
            Path = path;
            LoggingLevel = loggingLevel;
            CreateFile(DateTime.Now);
        }

        public string Path { get; set; }

        public void Write(LoggingLevel loggingLevel, Exception ex)
        {
            Write(loggingLevel, $"{ex.Message}. {ex.StackTrace}");
        }

        public void Write(LoggingLevel loggingLevel, string content)
        {
            if (loggingLevel >= LoggingLevel)
            {
                string text = DateTime.Now.ToString("HH:mm:ss") +
                              $"[{loggingLevel}]" +
                              $"{content.Replace("\r", "").Replace("\n", "").Trim()}";

                var file = MakeStreamWriter();
                file.WriteLine(text);
                file.Close();
            }
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
                var file = MakeStreamWriter();
                file.WriteLine(dateTime.ToString("yyyy-MM-dd_HH:mm:ss") +
                               $"  LogLv: {LoggingLevel}\r\n---");
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