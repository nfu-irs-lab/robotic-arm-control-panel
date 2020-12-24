using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIWIN_Robot
{
    public abstract class Device
    {
        public string Address;

        public bool IsConnect;

        public abstract bool Connect();

        public abstract bool Disconnect();
    }

    internal class SerialPortDevice : Device
    {
        /// <summary>
        /// Connect state. <br/> true: Connected; false: Unconnected or Unknown.
        /// </summary>
        public new bool IsConnect = false;

        /// <summary>
        /// COM Port name. Like: COM1.
        /// </summary>
        private new readonly string Address = "COM1";

        private readonly SerialPort sp = new SerialPort();

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
                        IsConnect = true;
                        return true;
                    }
                    else
                    {
                        IsConnect = false;
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
                IsConnect = true;
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
                        IsConnect = true;
                        return false;
                    }
                    else
                    {
                        IsConnect = false;
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
                IsConnect = false;
                return true;
            }
        }
    }
}