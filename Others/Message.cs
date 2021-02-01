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
        void Show();

        /// <summary>
        /// Show message.
        /// </summary>
        /// <param name="message"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Show(string message);

        /// <summary>
        /// Show message.
        /// </summary>
        /// <param name="ex"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Show(Exception ex);

        /// <summary>
        /// Show message.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Show(string message, Exception ex);
    }

    /// <summary>
    /// 不執行任何動作的訊息處理實作。
    /// </summary>
    public class EmptyMessage : IMessage
    {
        public void Show()
        {
        }

        public void Show(string message)
        {
        }

        public void Show(Exception ex)
        {
        }

        public void Show(string message, Exception ex)
        {
        }
    }

    /// <summary>
    /// 顯示錯誤訊息的訊息處理實作。
    /// </summary>
    public class ErrorMessage : IMessage
    {
        public void Show()
        {
            MessageBox.Show("出現錯誤。",
                            "錯誤！",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        public void Show(string message)
        {
            MessageBox.Show(message,
                            "錯誤！",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        public void Show(Exception ex)
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

            MessageBox.Show(text,
                            "錯誤！",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        public void Show(string message, Exception ex)
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

            MessageBox.Show(text,
                            "錯誤！",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// 顯示一般訊息的訊息處理實作。
    /// </summary>
    public class NormalMessage : IMessage
    {
        public void Show()
        {
            MessageBox.Show("!!");
        }

        public void Show(string message)
        {
            MessageBox.Show(message);
        }

        public void Show(Exception ex)
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

            MessageBox.Show(text);
        }

        public void Show(string message, Exception ex)
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

            MessageBox.Show(text);
        }
    }
}