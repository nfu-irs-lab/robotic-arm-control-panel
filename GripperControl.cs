#define DISABLE_SHOW_MESSAGE

#if (DISABLE_SHOW_MESSAGE)
#warning Message is disabled.
#endif

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace HIWIN_Robot
{
    /// <summary>
    /// 夾爪控制。
    /// </summary>
    internal class GripperControl : SerialPortDevice
    {
        /// <summary>
        /// 夾爪模式：絕對位置。
        /// </summary>
        private byte Direction = 2;

        public GripperControl(string COM_port)
            : base(new SerialPort { PortName = COM_port, BaudRate = 115200, DataBits = 8 })
        {
            Direction = 2;
        }

        /// <summary>
        /// 夾爪控制。<br/>
        /// ● position：夾爪張開距離。單位為10μm，如2000代表20mm。<br/>
        /// ● speed：夾爪張開速度。單位為mm/s。<br/>
        /// ● force：夾爪張開力量。單位為%。
        /// </summary>
        /// <param name="position"></param>
        /// <param name="speed"></param>
        /// <param name="force"></param>
        /// <param name="CJog"></param>
        /// <param name="PushVel"></param>
        /// <param name="PushPosStk"></param>
        /// <returns></returns>
        public string Control(int position,
                              int speed = 50,
                              int force = 70,
                              int CJog = 0,
                              int PushVel = 0,
                              int PushPosStk = 0)
        {
            speed *= 100;

            try
            {
                long num = 0L;

                List<byte> list = new List<byte>();
                list.Add((byte)250);
                list.Add((byte)0xfb);
                list.Add((byte)0xf3);
                list.Add((byte)((position & 0xff00) >> 8));
                list.Add((byte)(position & 0xff));
                list.Add((byte)((speed & 0xff00) >> 8));
                list.Add((byte)(speed & 0xff));
                list.Add((byte)0);
                list.Add((byte)((CJog * 4) + Direction));
                list.Add((byte)0);
                list.Add((byte)0);
                list.Add((byte)((force & 0xff00) >> 8));
                list.Add((byte)(force & 0xff));
                list.Add((byte)0);
                list.Add((byte)0);
                list.Add((byte)((PushVel & 0xff00) >> 8));
                list.Add((byte)(PushVel & 0xff));
                list.Add((byte)((PushPosStk & 0xff00) >> 8));
                list.Add((byte)(PushPosStk & 0xff));
                for (int i = 3; i < (list.Count - 1); i++)
                {
                    num += Convert.ToByte(list[i]);
                }
                list.Add((byte)(num & 0xffL));
                list.Add((byte)0xfe);
                byte[] buffer = (byte[])list.ToArray();
                sp.Write(buffer, 0, buffer.Length);
                return BitConverter.ToString(buffer).Replace("-", " ");
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error.", ex);
                return "";
            }
        }

        /// <summary>
        /// 重置夾爪。
        /// </summary>
        public void Reset()
        {
            SendIndexCmd(sp, (byte)0x1f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected override void ShowErrorMessage(string message = "Error.", Exception ex = null)
        {
#if (!DISABLE_SHOW_MESSAGE)
            base.ShowErrorMessage(message, ex);
#endif
        }

        /// <summary>
        /// 夾爪命令封包。
        /// </summary>
        /// <param name="Comm1"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        private string SendIndexCmd(SerialPort Comm1, byte index)
        {
            try
            {
                long num = 0L;
                ArrayList list = new ArrayList();
                list.Add((byte)250);
                list.Add((byte)0xfc);
                list.Add((byte)0xe2);
                list.Add(index);
                list.Add((byte)0xef);
                for (int i = 3; i < list.Count; i++)
                {
                    num += Convert.ToByte(list[i]);
                }
                list.Add((byte)(num & 0xffL));
                list.Add((byte)0xfe);
                byte[] buffer = (byte[])list.ToArray(typeof(byte));
                Comm1.Write(buffer, 0, buffer.Length);
                return BitConverter.ToString(buffer).Replace("-", " ");
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error.", ex);
                return "";
            }
        }
    }
}