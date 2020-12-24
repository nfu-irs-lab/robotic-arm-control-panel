using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIWIN_Robot
{
    public abstract class Device
    {
        protected string Address;

        protected bool ConnectState;

        public abstract bool Connect();

        public abstract bool Disconnect();

        /// <summary>
        /// Get connect state.<br/>
        /// </summary>
        /// <returns>
        /// true: Connected. <br/>
        /// false: Unconnected or unknown.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsConnect()
        {
            return ConnectState;
        }
    }

    internal class SerialPortDevice : Device
    {
        protected readonly SerialPort sp = new SerialPort();

        /// <summary>
        /// Serial port device.
        /// </summary>
        /// <param name="comPort"></param>
        /// <param name="baudRate"></param>
        public SerialPortDevice(string comPort, int baudRate = 9600)
        {
            Address = comPort;
            sp.PortName = comPort;
            sp.BaudRate = baudRate;
        }

        /// <summary>
        /// Serial port device. <br/>
        /// 請注意指標的問題。
        /// </summary>
        /// <param name="serialPort"></param>
        public SerialPortDevice(SerialPort serialPort)
        {
            Address = serialPort.PortName;

            // XXX 此處沒有使用深層複製，需注意指標(pointer)的問題。
            sp = serialPort;
        }

        /// <summary>
        /// Connect.<br/>
        /// </summary>
        /// <returns>
        /// true: Connection successful.<br/>
        /// false: Connection unsuccessful.
        /// </returns>
        public override bool Connect()
        {
            if (!sp.IsOpen)
            {
                try
                {
                    sp.Open();
                    Thread.Sleep(50);
                    if (sp.IsOpen)
                    {
                        ConnectState = true;
                        return true;
                    }
                    else
                    {
                        ConnectState = false;
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    string text = "無法進行連線。\r\n請檢查COM Port等設定。\r\n\r\n" +
                                  ex.Message + "\r\n\r\n" +
                                  ex.StackTrace;

                    MessageBox.Show(text, "錯誤！", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
            else
            {
                ConnectState = true;
                return true;
            }
        }

        /// <summary>
        /// Disconnect.<br/>
        /// </summary>
        /// <returns>
        /// true: Disconnection successful.<br/>
        /// false: Disconnection unsuccessful.
        /// </returns>
        public override bool Disconnect()
        {
            if (sp.IsOpen)
            {
                try
                {
                    sp.Close();
                    Thread.Sleep(50);
                    if (sp.IsOpen)
                    {
                        ConnectState = true;
                        return false;
                    }
                    else
                    {
                        ConnectState = false;
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    string text = "無法進行斷線。\r\n請檢查COM Port等設定。\r\n\r\n" +
                                  ex.Message + "\r\n\r\n" +
                                  ex.StackTrace;

                    MessageBox.Show(text, "錯誤！", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
            else
            {
                ConnectState = false;
                return true;
            }
        }
    }
}