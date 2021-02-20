using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    /// <summary>
    /// 日誌等級。<br/>
    /// 數值越大表示越嚴重。
    /// </summary>
    public enum LoggingLevel : byte
    {
        /// <summary>
        /// 蹤跡。
        /// </summary>
        Trace = 0,

        /// <summary>
        /// 資訊。
        /// </summary>
        Info,

        /// <summary>
        /// 警告。
        /// </summary>
        Warn,

        /// <summary>
        /// 錯誤。
        /// </summary>
        Error,

        /// <summary>
        /// 致命。
        /// </summary>
        Fatal = byte.MaxValue
    }

    public interface ILogHandler
    {
        string Path { get; set; }

        void Write(string message, LoggingLevel loggingLevel);

        void Write(Exception ex, LoggingLevel loggingLevel);
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

        ~LogHandler()
        {
            Write("LogHandler Destruct.", LoggingLevel.Fatal);
        }

        public string Path { get; set; }

        public void Write(Exception ex, LoggingLevel loggingLevel)
        {
            Write($"{ex.Message}. {ex.StackTrace}", loggingLevel);
        }

        public void Write(string message, LoggingLevel loggingLevel)
        {
            if (loggingLevel >= LoggingLevel)
            {
                string text = DateTime.Now.ToString("HH:mm:ss") +
                              $"[{loggingLevel}]" +
                              $"{message.Replace("\r", "").Replace("\n", ";").Trim()}";

                var file = MakeStreamWriter();
                file.WriteLine(text);
                file.Close();
            }
        }

        private void CreateFile(DateTime dateTime)
        {
            string targetFileName = $"{dateTime:MMMdd-HH}_{Count}.log";

            if (File.Exists(Path + targetFileName))
            {
                // TODO: 改善目標檔名已經存在時，更新檔名的寫法。目前的方式是一個一個找。
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
            try
            {
                return File.AppendText(Path + FileName);
            }
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory(Path);
                return File.AppendText(Path + FileName);
            }
        }
    }
}