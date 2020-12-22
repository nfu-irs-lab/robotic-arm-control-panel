using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;

namespace HIWIN_Robot
{
    /// <summary>
    /// 夾爪控制。
    /// </summary>
    internal class GripperControl
    {
        /// <summary>
        /// 夾爪模式：絕對位置。
        /// </summary>
        private byte direction = 2;

        /// <summary>
        /// 夾爪串列埠。
        /// </summary>
        private SerialPort gripper = new SerialPort();

        /// <summary>
        /// 夾爪連線COM Port。<br/>
        /// 設定錯誤將會無法連線。
        /// </summary>
        private string gripper_com_port;

        public GripperControl()
        {
            // 初始化。
            gripper_com_port = SerialPort.GetPortNames()[0];
            init_gripper();
        }

        public GripperControl(string COM_port)
        {
            // 初始化。
            gripper_com_port = COM_port;
            init_gripper();
        }

        /// <summary>
        /// 連線。
        /// </summary>
        public void connect()
        {
            try
            {
                if (gripper.IsOpen == false)
                {
                    gripper.Open();
                }
            }
            catch (Exception ex)
            {
                string text = "無法與夾爪進行連線。\r\n請檢查COM Port等設定。\r\n\r\n" +
                              ex.Message + "\r\n\r\n" +
                              ex.StackTrace;

                MessageBox.Show(text, "錯誤！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        public string control(int position,
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
                list.Add((byte)((CJog * 4) + direction));
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
                gripper.Write(buffer, 0, buffer.Length);
                return BitConverter.ToString(buffer).Replace("-", " ");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return "";
            }
        }

        /// <summary>
        /// 斷線。
        /// </summary>
        public void disconnect()
        {
            //關閉夾爪連線
            try
            {
                if (gripper.IsOpen)
                {
                    gripper.Close();
                }
            }
            catch (Exception ex)
            {
                string text = "無法與夾爪進行斷線。\r\n請檢查COM Port等設定。\r\n\r\n" +
                              ex.Message + "\r\n\r\n" +
                              ex.StackTrace;

                MessageBox.Show(text, "錯誤！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 夾爪是否已連線。
        /// </summary>
        /// <returns>是否已經連線。</returns>
        public bool is_connected()
        {
            try
            {
                return gripper.IsOpen;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 重置夾爪。
        /// </summary>
        public void reset()
        {
            byte gResetNum = 0x1f;
            SendIndexCmd(gripper, gResetNum);
        }

        /// <summary>
        /// 初始化夾爪。
        /// </summary>
        private void init_gripper()
        {
            gripper.PortName = gripper_com_port;
            gripper.BaudRate = 115200;
            gripper.DataBits = 8;

            direction = 2;
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
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return "";
            }
        }
    }
}