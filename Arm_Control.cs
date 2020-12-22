using SDKHrobot;
using System;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace HIWIN_Robot
{
    /// <summary>
    /// 上銀機械手臂基本控制。
    /// </summary>
    internal class Arm_Control
    {
        #region - 基本變數與列舉 -

        /// <summary>
        /// 笛卡爾原點絕對坐標。
        /// </summary>
        public double[] position_descartes_zero = { 0, 368, 294, 180, 0, 90 };

        /// <summary>
        /// 關節原點絕對坐標。
        /// </summary>
        public double[] position_joint_zero = { 0, 0, 0, 0, 0, 0 };

        private static HRobot.CallBackFun callback;

        /// <summary>
        /// 手臂連線IP位置。<br/>
        /// 設定錯誤將會無法連線。
        /// </summary>
        private string arm_IP;

        /// <summary>
        /// 連線狀態。true為已連線。false為未連線或未知。
        /// </summary>
        private bool ConnectState = false;

        /// <summary>
        /// 手臂ID。
        /// </summary>
        private int DeviceID;

        private int timecheck = 0;

        private Timer timer = new Timer();

        public Arm_Control()
        {
            // 初始化。
            arm_IP = "192.168.0.3";
            init_timer();
        }

        public Arm_Control(string IP)
        {
            // 初始化。
            arm_IP = IP;
            init_timer();
        }

        /// <summary>
        /// 坐標類型。
        /// </summary>
        public enum Coordinate_Type
        {
            /// <summary>
            /// 絕對坐標。
            /// </summary>
            absolute,

            /// <summary>
            /// 相對坐標。
            /// </summary>
            relative,

            /// <summary>
            /// 未知的類型。
            /// </summary>
            unknown
        }

        /// <summary>
        /// 運動類型。
        /// </summary>
        public enum Motion_Type
        {
            /// <summary>
            /// 直線運動。
            /// </summary>
            linear,

            /// <summary>
            /// 點對點運動。
            /// </summary>
            point_to_point,

            /// <summary>
            /// 圓弧運動。
            /// </summary>
            circle,

            /// <summary>
            /// 未知的類型。
            /// </summary>
            unknown
        }

        /// <summary>
        /// 位置類型。
        /// </summary>
        public enum Position_Type
        {
            /// <summary>
            /// 笛卡爾。
            /// </summary>
            descartes,

            /// <summary>
            /// 關節。
            /// </summary>
            joint,

            /// <summary>
            /// 未知的類型。
            /// </summary>
            unknown
        }

        /// <summary>
        /// 手臂平滑模式。
        /// </summary>
        public enum Smooth_Type
        {
            /// <summary>
            /// 關閉平滑功能。
            /// </summary>
            disable = 0,

            /// <summary>
            /// 貝茲曲線平滑百分比。
            /// </summary>
            bezier_curve_smooth_percent = 1,

            /// <summary>
            /// 貝茲曲線平滑半徑。
            /// </summary>
            bezier_curve_smooth_radius = 2,

            /// <summary>
            /// 依兩線段速度平滑。
            /// </summary>
            two_lines_speed_smooth = 3
        }

        #endregion - 基本變數與列舉 -

        #region - 速度與加速度 -

        /// <summary>
        /// 取得目前手臂加速度比例。
        /// </summary>
        /// <returns>
        /// ● 1~100：目前手臂的加速度比例。<br/>
        /// ● -1：錯誤。
        /// </returns>
        public int get_acceleration()
        {
            int value = HRobot.get_acc_dec_ratio(DeviceID);

            if (value == -1)
            {
                MessageBox.Show("取得手臂加速度時出錯。",
                                "錯誤！",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            return value;
        }

        /// <summary>
        /// 取得目前手臂整體速度比例。
        /// </summary>
        /// <returns>
        /// ● 1~100：目前手臂的整體速度比例。<br/>
        /// ● -1：錯誤。
        /// </returns>
        public int get_speed()
        {
            int value = HRobot.get_override_ratio(DeviceID);

            if (value == -1)
            {
                MessageBox.Show("取得手臂速度時出錯。",
                                "錯誤！",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            return value;
        }

        /// <summary>
        /// 設定手臂加速度比例。<br/>
        /// 引數應為1 ~ 100 (%)。
        /// </summary>
        /// <param name="value"></param>
        public void set_acceletarion(int value)
        {
            if (value > 100 || value < 1)
            {
                MessageBox.Show("手臂加速度應為1% ~ 100%之間。",
                                "錯誤！",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                int return_code = HRobot.set_acc_dec_ratio(DeviceID, value);

                this.is_error_and_show_message(return_code);
            }
        }

        /// <summary>
        /// 設定手臂整體速度比例。<br/>
        /// 引數應為1 ~ 100 (%)。
        /// </summary>
        /// <param name="value"></param>
        public void set_speed(int value)
        {
            if (value > 100 || value < 1)
            {
                MessageBox.Show("手臂速度應為1% ~ 100%之間。",
                                "錯誤！",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                int return_code = HRobot.set_override_ratio(DeviceID, value);

                this.is_error_and_show_message(return_code);
            }
        }

        #endregion - 速度與加速度 -

        #region - 基本運動 -

        /// <summary>
        /// 取得手臂目前的位置。<br/>
        /// 須在引數選擇位置類型是笛卡爾還是關節。
        /// </summary>
        /// <param name="type"></param>
        /// <returns>目前的手臂位置。</returns>
        public double[] get_now_position(Position_Type type)
        {
            double[] position = new double[6];
            int return_code = -1;

            foreach (int k in position)
            {
                if (type == Position_Type.descartes)
                {
                    return_code = HRobot.get_current_position(DeviceID, position);
                }
                else if (type == Position_Type.joint)
                {
                    return_code = HRobot.get_current_joint(DeviceID, position);
                }
                else
                {
                    show_unknown_position_type();
                    break;
                }
            }
            this.is_error_and_show_message(return_code);
            return position;
        }

        /// <summary>
        /// 進行直線運動。<br/>
        /// ● target_position：目標位置。<br/>
        /// ● position_type：位置類型，笛卡爾或關節。<br/>
        /// ● coordinate_type：坐標類型，絕對坐標或相對坐標。預設為絕對坐標。<br/>
        /// ● smooth_type：平滑模式類型。預設為依兩線段速度平滑。<br/>
        /// ● smooth_value：平滑值。預設為50。
        /// </summary>
        /// <param name="target_position"></param>
        /// <param name="position_type"></param>
        /// <param name="coordinate_type"></param>
        /// <param name="smooth_type"></param>
        /// <param name="smooth_value"></param>
        public void motion_linear(double[] target_position,
                                  Position_Type position_type,
                                  Coordinate_Type coordinate_type = Coordinate_Type.absolute,
                                  Smooth_Type smooth_type = Smooth_Type.two_lines_speed_smooth,
                                  double smooth_value = 50)
        {
            int return_code = -1;

            if (coordinate_type == Coordinate_Type.relative)
            {
                target_position = convert_relative_to_adsolute(target_position, position_type);
            }

            switch (position_type)
            {
                case Position_Type.descartes:
                    return_code = HRobot.lin_pos(DeviceID, (int)smooth_type, smooth_value, target_position);
                    break;

                case Position_Type.joint:
                    return_code = HRobot.lin_axis(DeviceID, (int)smooth_type, smooth_value, target_position);
                    break;

                default:
                    show_unknown_position_type();
                    return_code = 0;
                    break;
            }

            if (this.is_error_and_show_message(return_code) == false)
            {
                this.wait_for_action_complete(target_position, position_type);
            }
        }

        /// <summary>
        ///  進行點對點運動。<br/>
        ///  ● target_position：目標位置。<br/>
        ///  ● position_type：位置類型，笛卡爾或關節。<br/>
        ///  ● coordinate_type：坐標類型，絕對坐標或相對坐標。預設為絕對坐標。<br/>
        ///  ● smooth_type：平滑模式類型。預設為依兩線段速度平滑。<br/>
        /// </summary>
        /// <param name="target_position"></param>
        /// <param name="position_type"></param>
        /// <param name="coordinate_type"></param>
        /// <param name="smooth_type"></param>
        public void motion_point_to_point(double[] target_position,
                                          Position_Type position_type,
                                          Coordinate_Type coordinate_type = Coordinate_Type.absolute,
                                          Smooth_Type smooth_type = Smooth_Type.two_lines_speed_smooth)
        {
            int return_code = -1;
            int smooth_type_code = 0;

            if (coordinate_type == Coordinate_Type.relative)
            {
                target_position = convert_relative_to_adsolute(target_position, position_type);
            }

            switch (smooth_type)
            {
                case Smooth_Type.two_lines_speed_smooth:
                    smooth_type_code = 1;
                    break;

                default:
                    smooth_type_code = 0;
                    break;
            }

            switch (position_type)
            {
                case Position_Type.descartes:
                    return_code = HRobot.ptp_pos(DeviceID, smooth_type_code, target_position);
                    break;

                case Position_Type.joint:
                    return_code = HRobot.ptp_axis(DeviceID, smooth_type_code, target_position);
                    break;

                default:
                    show_unknown_position_type();
                    return_code = 0;
                    break;
            }

            if (this.is_error_and_show_message(return_code) == false)
            {
                this.wait_for_action_complete(target_position, position_type);
            }
        }

        public void to_zero(Position_Type type)
        {
            switch (type)
            {
                case Position_Type.descartes:
                    HRobot.ptp_pos(DeviceID, 1, position_descartes_zero);
                    wait_for_action_complete(position_descartes_zero, type);
                    break;

                case Position_Type.joint:
                    HRobot.ptp_axis(DeviceID, 1, position_joint_zero);
                    wait_for_action_complete(position_joint_zero, type);
                    break;

                default:
                    MessageBox.Show("錯誤的位置類型。",
                                    "錯誤！",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    break;
            }
        }

        /// <summary>
        /// 等待手臂運動完成。
        /// </summary>
        /// <param name="target_position"></param>
        /// <param name="type"></param>
        private void wait_for_action_complete(double[] target_position, Position_Type type)
        {
            double[] now_position = new double[6];

            timer.Enabled = true;

            // For無限回圈。
            for (; ; )
            {
                if (timecheck % 1 == 0 && type == Position_Type.descartes)
                {
                    foreach (int k in now_position)
                    {
                        // 取得目前的笛卡爾坐標。
                        HRobot.get_current_position(DeviceID, now_position);
                    }

                    if (Math.Abs(target_position[0] - now_position[0]) < 0.01 &&
                        Math.Abs(target_position[1] - now_position[1]) < 0.01 &&
                        Math.Abs(target_position[2] - now_position[2]) < 0.01 &&
                        Math.Abs(Math.Abs(target_position[3]) - Math.Abs(now_position[3])) < 0.01 &&
                        Math.Abs(Math.Abs(target_position[4]) - Math.Abs(now_position[4])) < 0.01 &&
                        Math.Abs(Math.Abs(target_position[5]) - Math.Abs(now_position[5])) < 0.01)
                    {
                        // 跳出For無限回圈。
                        break;
                    }
                }
                else if (timecheck % 1 == 0 && type == Position_Type.joint)
                {
                    foreach (int k in now_position)
                    {
                        // 取得目前的關節坐標。
                        HRobot.get_current_joint(DeviceID, now_position);
                    }

                    if (Math.Abs(target_position[0] - now_position[0]) < 0.01 &&
                        Math.Abs(target_position[1] - now_position[1]) < 0.01 &&
                        Math.Abs(target_position[2] - now_position[2]) < 0.01 &&
                        Math.Abs(target_position[3] - now_position[3]) < 0.01 &&
                        Math.Abs(target_position[4] - now_position[4]) < 0.01 &&
                        Math.Abs(target_position[5] - now_position[5]) < 0.01)
                    {
                        // 跳出For無限回圈。
                        break;
                    }
                }
            }

            timer.Enabled = false;
            timecheck = 0;
        }

        #endregion - 基本運動 -

        #region - 連線/斷線 -

        /// <summary>
        /// 進行手臂連線、開啟控制器。
        /// </summary>
        public void Connect()
        {
            //接收控制器回傳訊息
            callback = new HRobot.CallBackFun(EventFun);

            //連線設定。測試連線設定:("127.0.0.1", 1, callback);
            DeviceID = HRobot.open_connection(arm_IP, 1, callback);
            Thread.Sleep(500);

            //0 ~ 65535為有效裝置ID
            if (DeviceID >= 0 && DeviceID <= 65535)
            {
                int alarmState;
                int motorState;
                int connectionLevel;

                //清除錯誤
                alarmState = HRobot.clear_alarm(DeviceID);

                //設定控制器: 1為啟動,0為關閉
                HRobot.set_motor_state(DeviceID, 1);
                Thread.Sleep(500);

                //回傳控制器狀態
                motorState = HRobot.get_motor_state(DeviceID);

                connectionLevel = HRobot.get_connection_level(DeviceID);

                MessageBox.Show(string.Format("連線成功!\r\n" +
                                              "手臂ID: {0}\r\n" +
                                              "連線等級 (0爲觀測者，1爲操作者): {1}\r\n" +
                                              "控制器狀態 (0為關閉，1為開啟): {2}\r\n" +
                                              "錯誤代碼: {3}\r\n",
                                              DeviceID,
                                              connectionLevel,
                                              motorState,
                                              alarmState));

                ConnectState = true;
            }
            else
            {
                string message;

                switch (DeviceID)
                {
                    case -1:
                        message = "-1：連線失敗";
                        break;

                    case -2:
                        message = "-2：回傳機制創建失敗";
                        break;

                    case -3:
                        message = "-3：無法連線至Robot";
                        break;

                    case -4:
                        message = "-4：版本不相符";
                        break;

                    default:
                        message = string.Format("未知的錯誤代碼：{0}", DeviceID);
                        break;
                }

                MessageBox.Show("無法連線!\r\n" + message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                ConnectState = false;
            }
        }

        /// <summary>
        /// 進行手臂斷線、關閉控制器。
        /// </summary>
        public void Disconnect()
        {
            int alarmState;
            int motorState;

            //設定控制器: 1為啟動,0為關閉
            HRobot.set_motor_state(DeviceID, 0);
            Thread.Sleep(200);

            //將所有錯誤代碼清除
            alarmState = HRobot.clear_alarm(DeviceID);

            //回傳控制器狀態
            motorState = HRobot.get_motor_state(DeviceID);

            //關閉手臂連線
            HRobot.disconnect(DeviceID);

            MessageBox.Show(string.Format("斷線成功!\r\n" +
                                          "控制器狀態 (0為關閉，1為開啟): {0}\r\n" +
                                          "錯誤代碼: {1}\r\n",
                                          motorState,
                                          alarmState));

            ConnectState = false;
        }

        /// <summary>
        /// 取得手臂連線狀態。
        /// </summary>
        /// <returns>
        /// 手臂是否連線。<br/>
        /// ● true：手臂已連線。<br/>
        /// ● false：手臂未連線或狀態未知。
        /// </returns>
        public bool is_connected()
        {
            return ConnectState;
        }

        /// <summary>
        /// 控制器回傳。
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="rlt"></param>
        /// <param name="Msg"></param>
        /// <param name="len"></param>
        private static void EventFun(UInt16 cmd, UInt16 rlt, ref UInt16 Msg, int len)
        {
            Console.WriteLine("Command: " + cmd + " Resault: " + rlt);

            switch (cmd)
            {
                case 4011:
                    if (rlt != 0)
                    {
                        MessageBox.Show("Update fail. " + rlt,
                                        "HRSS update callback",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning,
                                        MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions.DefaultDesktopOnly);
                    }
                    break;
            }
        }

        #endregion - 連線/斷線 -

        #region - Others -

        /// <summary>
        /// 清除錯誤。
        /// </summary>
        public void clear_alarm()
        {
            int return_code = HRobot.clear_alarm(DeviceID);

            this.is_error_and_show_message(return_code);
        }

        /// <summary>
        /// 將相對坐標以目前位置轉為絕對坐標。
        /// </summary>
        /// <param name="relative_position"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        private double[] convert_relative_to_adsolute(double[] relative_position,
                                                      Position_Type type)
        {
            double[] position = new double[6];
            position = this.get_now_position(type);

            for (int i = 0; i < 6; i++)
            {
                position[i] += relative_position[i];
            }

            return position;
        }

        /// <summary>
        /// 初始化計時器。
        /// </summary>
        private void init_timer()
        {
            timer.Interval = 50;
            timer.Tick += new System.EventHandler(timer_Tick);
        }

        /// <summary>
        /// 如果出現錯誤，顯示錯誤代碼。
        /// </summary>
        /// <param name="code"></param>
        /// <param name="success_code"></param>
        /// <returns>
        /// 是否出現錯誤。<br/>
        /// ● true：出現錯誤。<br/>
        /// ● false：沒有出現錯誤。
        /// </returns>
        private bool is_error_and_show_message(int code, int success_code = 0)
        {
            if (code != success_code)
            {
                // Not successful.
                MessageBox.Show("上銀機械手臂控制錯誤。\r\n錯誤代碼：" + code.ToString(),
                                "錯誤！",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                return true;
            }
            else
            {
                return false;
            }
        }

        private void show_unknown_position_type()
        {
            string text = "錯誤的位置類型。\r\n" +
                          "位置類型應為" +
                          Position_Type.descartes.ToString() + "或是" +
                          Position_Type.joint.ToString() + "。";

            MessageBox.Show(text, "錯誤！", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 計時器計數。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            ++timecheck;
        }

        #endregion - Others -
    }
}