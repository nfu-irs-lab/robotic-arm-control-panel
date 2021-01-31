//#define DISABLE_SHOW_MESSAGE

#if (DISABLE_SHOW_MESSAGE)
#warning Message is disabled.
#endif

using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiwinRobot
{
    public interface IDevice
    {
        /// <summary>
        /// Connect state. <br/>
        /// • true: Connected. <br/>
        /// • false: Disconnected or unknown. <br/>
        /// </summary>
        bool Connected { get; }

        /// <summary>
        /// Connect.<br/>
        /// </summary>
        /// <returns>
        /// true: Connection successful.<br/>
        /// false: Connection unsuccessful.
        /// </returns>
        bool Connect();

        /// <summary>
        /// Disconnect.<br/>
        /// </summary>
        /// <returns>
        /// true: Disconnection successful.<br/>
        /// false: Disconnection unsuccessful.
        /// </returns>
        bool Disconnect();
    }

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
    /// 不執行任何動作的訊息處理。
    /// </summary>
    public class EmptyMessage : IMessage
    {
        public void Show(string message, Exception ex)
        {
            // Empty.
        }
    }

    /// <summary>
    /// 顯示錯誤訊息的訊息處理。
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

    public abstract class SerialPortDevice : IDevice
    {
        protected IMessage ErrorMessage = new ErrorMessage();
        protected SerialPort SerialPort = null;

        public SerialPortDevice(SerialPort serialPort)
        {
            // XXX 此處沒有使用深層複製，需注意指標(pointer)的問題。
            SerialPort = serialPort;
        }

        public SerialPortDevice(string comPort)
        {
            SerialPort = new SerialPort(comPort);
        }

        public bool Connected { get; protected set; } = false;

        public virtual bool Connect()
        {
            if (!SerialPort.IsOpen)
            {
                try
                {
                    SerialPort.Open();
                    Thread.Sleep(50);
                    if (SerialPort.IsOpen)
                    {
                        Connected = true;
                        return true;
                    }
                    else
                    {
                        Connected = false;
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    ErrorMessage.Show("無法進行連線。\r\n請檢查COM Port等設定。", ex);
                    return false;
                }
            }
            else
            {
                Connected = true;
                return true;
            }
        }

        public virtual bool Disconnect()
        {
            if (SerialPort.IsOpen)
            {
                try
                {
                    SerialPort.Close();
                    Thread.Sleep(50);
                    if (SerialPort.IsOpen)
                    {
                        Connected = true;
                        return false;
                    }
                    else
                    {
                        Connected = false;
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    ErrorMessage.Show("無法進行斷線。\r\n請檢查COM Port等設定。", ex);
                    return false;
                }
            }
            else
            {
                Connected = false;
                return true;
            }
        }
    }
}