using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Features
{
    /// <summary>
    /// 訊息處理介面。
    /// </summary>
    public interface IMessage
    {
        /// <summary>
        /// Log.
        /// </summary>
        /// <param name="loggingLevel"></param>
        /// <param name="message"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Log(string message, LoggingLevel loggingLevel1);

        /// <summary>
        /// Log.
        /// </summary>
        /// <param name="loggingLevel"></param>
        /// <param name="ex"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Log(Exception ex, LoggingLevel loggingLevel);

        /// <summary>
        /// Show message.
        /// </summary>
        /// <param name="message"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        DialogResult Show(string message,
                          LoggingLevel loggingLevel = LoggingLevel.Trace);

        /// <summary>
        /// Show message.
        /// </summary>
        /// <param name="ex"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        DialogResult Show(Exception ex,
                          LoggingLevel loggingLevel = LoggingLevel.Trace);

        /// <summary>
        /// Show message.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        DialogResult Show(string message,
                          Exception ex,
                          LoggingLevel loggingLevel = LoggingLevel.Trace);

        /// <summary>
        /// Show message.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="caption"></param>
        /// <param name="buttons"></param>
        /// <param name="icon"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        DialogResult Show(string text,
                          string caption,
                          MessageBoxButtons buttons,
                          MessageBoxIcon icon,
                          LoggingLevel loggingLevel = LoggingLevel.Trace);
    }

    /// <summary>
    /// 不執行任何動作的訊息處理實作。
    /// </summary>
    public class EmptyMessage : IMessage
    {
        public void Log(string content, LoggingLevel loggingLevel)
        { }

        public void Log(Exception ex, LoggingLevel loggingLevel)
        { }

        public DialogResult Show(string message, LoggingLevel loggingLevel = LoggingLevel.Trace) => DialogResult.None;

        public DialogResult Show(Exception ex, LoggingLevel loggingLevel = LoggingLevel.Trace) => DialogResult.None;

        public DialogResult Show(string message, Exception ex, LoggingLevel loggingLevel = LoggingLevel.Trace) => DialogResult.None;

        public DialogResult Show(string text,
                                 string caption,
                                 MessageBoxButtons buttons,
                                 MessageBoxIcon icon,
                                 LoggingLevel loggingLevel = LoggingLevel.Trace) => DialogResult.None;
    }

    /// <summary>
    /// 顯示訊息及記錄 Log 檔案的訊息處理實作。
    /// </summary>
    public class NormalMessage : IMessage
    {
        private ILogHandler LogHandler = null;

        public NormalMessage(ILogHandler logHandler)
        {
            LogHandler = logHandler;
        }

        public void Log(string message, LoggingLevel loggingLevel)
        {
            LogHandler.Write(message, loggingLevel);
        }

        public void Log(Exception ex, LoggingLevel loggingLevel)
        {
            LogHandler.Write(ex, loggingLevel);
        }

        public DialogResult Show(string message,
                                 LoggingLevel loggingLevel = LoggingLevel.Trace)
        {
            LogHandler.Write(message, loggingLevel);
            return MessageBox.Show(message,
                                   loggingLevel.ToString(),
                                   MessageBoxButtons.OK,
                                   ConvertLoggingLevelToMessageBoxIcon(loggingLevel));
        }

        public DialogResult Show(Exception ex,
                                 LoggingLevel loggingLevel = LoggingLevel.Trace)
        {
            string text = "未處理的例外。 \r\n\r\n";

            if (ex != null)
            {
                text += $"{ex.Message} \r\n\r\n" +
                        $"{ex.StackTrace}";
            }
            else
            {
                text += "null Exception.";
            }

            LogHandler.Write(text, loggingLevel);
            return MessageBox.Show(text,
                                   loggingLevel.ToString(),
                                   MessageBoxButtons.OK,
                                   ConvertLoggingLevelToMessageBoxIcon(loggingLevel));
        }

        public DialogResult Show(string message,
                                 Exception ex,
                                 LoggingLevel loggingLevel = LoggingLevel.Trace)
        {
            string text = $"{message} \r\n\r\n";

            if (ex != null)
            {
                text += $"{ex.Message} \r\n\r\n" +
                        $"{ex.StackTrace}";
            }
            else
            {
                text += "null Exception.";
            }

            LogHandler.Write(text, loggingLevel);
            return MessageBox.Show(text,
                                   loggingLevel.ToString(),
                                   MessageBoxButtons.OK,
                                   ConvertLoggingLevelToMessageBoxIcon(loggingLevel));
        }

        public DialogResult Show(string text,
                                 string caption,
                                 MessageBoxButtons buttons,
                                 MessageBoxIcon icon,
                                 LoggingLevel loggingLevel = LoggingLevel.Trace)
        {
            LogHandler.Write($"{caption}: {text}", loggingLevel);
            return MessageBox.Show(text, caption, buttons, icon);
        }

        private MessageBoxIcon ConvertLoggingLevelToMessageBoxIcon(LoggingLevel loggingLevel)
        {
            MessageBoxIcon messageBoxIcon;
            switch (loggingLevel)
            {
                case LoggingLevel.Trace:
                    messageBoxIcon = MessageBoxIcon.None;
                    break;

                case LoggingLevel.Info:
                    messageBoxIcon = MessageBoxIcon.Information;
                    break;

                case LoggingLevel.Warn:
                    messageBoxIcon = MessageBoxIcon.Warning;
                    break;

                case LoggingLevel.Error:
                    messageBoxIcon = MessageBoxIcon.Error;
                    break;

                case LoggingLevel.Fatal:
                    messageBoxIcon = MessageBoxIcon.Error;
                    break;

                default:
                    messageBoxIcon = MessageBoxIcon.None;
                    break;
            }
            return messageBoxIcon;
        }
    }
}