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
        /// <param name="message"></param>
        /// <param name="ex"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Show(string message, Exception ex = null);
    }

    /// <summary>
    /// 不執行任何動作的訊息處理實作。
    /// </summary>
    public class EmptyMessage : IMessage
    {
        public void Show(string message, Exception ex)
        {
            // Empty.
        }
    }

    /// <summary>
    /// 顯示錯誤訊息的訊息處理實作。
    /// </summary>
    public class ErrorMessage : IMessage
    {
        public void Show(string message = "Error.", Exception ex = null)
        {
            string text = $"{message} \r\n\r\n";

            if (ex != null)
            {
                text += $"{ex.Message} \r\n\r\n" +
                        $"{ex.StackTrace}";
            }

            MessageBox.Show(text, "錯誤！", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}