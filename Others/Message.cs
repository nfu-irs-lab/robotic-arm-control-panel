using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace HiwinRobot
{
    /// <summary>
    /// 訊息處理介面。
    /// </summary>
    public interface IMessage
    {
        /// <summary>
        /// Show message.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        DialogResult Show();

        /// <summary>
        /// Show message.
        /// </summary>
        /// <param name="message"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        DialogResult Show(string message);

        /// <summary>
        /// Show message.
        /// </summary>
        /// <param name="ex"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        DialogResult Show(Exception ex);

        /// <summary>
        /// Show message.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        DialogResult Show(string message, Exception ex);

        /// <summary>
        /// Show message.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="caption"></param>
        /// <param name="buttons"></param>
        /// <param name="icon"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon);
    }

    /// <summary>
    /// 不執行任何動作的訊息處理實作。
    /// </summary>
    public class EmptyMessage : IMessage
    {
        public DialogResult Show()
            => DialogResult.None;

        public DialogResult Show(string message)
            => DialogResult.None;

        public DialogResult Show(Exception ex)
            => DialogResult.None;

        public DialogResult Show(string message, Exception ex)
            => DialogResult.None;

        public DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
            => DialogResult.None;
    }

    /// <summary>
    /// 顯示錯誤訊息的訊息處理實作。
    /// </summary>
    public class ErrorMessage : IMessage
    {
        private ILogHandler LogHandler = null;

        public ErrorMessage(ILogHandler logHandler)
        {
            LogHandler = logHandler;
        }

        public DialogResult Show()
        {
            LogHandler.Write(LoggingLevel.Trace, "出現錯誤");
            return MessageBox.Show("出現錯誤。",
                             "錯誤！",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
        }

        public DialogResult Show(string message)
        {
            LogHandler.Write(LoggingLevel.Trace, message);
            return MessageBox.Show(message,
                             "錯誤！",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
        }

        public DialogResult Show(Exception ex)
        {
            string text = "出現錯誤。 \r\n\r\n";

            if (ex != null)
            {
                text += $"{ex.Message} \r\n\r\n" +
                        $"{ex.StackTrace}";
            }
            else
            {
                text += "null Exception.";
            }

            LogHandler.Write(LoggingLevel.Trace, text);
            return MessageBox.Show(text,
                               "錯誤！",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
        }

        public DialogResult Show(string message, Exception ex)
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

            LogHandler.Write(LoggingLevel.Trace, text);
            return MessageBox.Show(text,
                            "錯誤！",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        public DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            LogHandler.Write(LoggingLevel.Trace, $"{caption}: {text}");
            return MessageBox.Show(text, caption, buttons, icon);
        }
    }

    /// <summary>
    /// 顯示一般訊息的訊息處理實作。
    /// </summary>
    public class NormalMessage : IMessage
    {
        public DialogResult Show()
        {
            return MessageBox.Show("!!");
        }

        public DialogResult Show(string message)
        {
            return MessageBox.Show(message);
        }

        public DialogResult Show(Exception ex)
        {
            string text = "";

            if (ex != null)
            {
                text += $"{ex.Message} \r\n\r\n" +
                        $"{ex.StackTrace}";
            }
            else
            {
                text += "null Exception.";
            }

            return MessageBox.Show(text);
        }

        public DialogResult Show(string message, Exception ex)
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

            return MessageBox.Show(text);
        }

        public DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return MessageBox.Show(text, caption, buttons, icon);
        }
    }
}