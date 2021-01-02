//#define DISABLE_SHOW_MESSAGE
#define USE_SDK_RELATIVE
#define USE_MOTION_STATE_WAIT

#if (DISABLE_SHOW_MESSAGE)
#warning Message is disabled.
#endif

using SDKHrobot;
using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace HIWIN_Robot
{
    #region - 列舉 enum -

    /// <summary>
    /// 坐標類型。
    /// </summary>
    public enum CoordinateType
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
    public enum MotionType
    {
        /// <summary>
        /// 直線運動。
        /// </summary>
        linear,

        /// <summary>
        /// 點對點運動。
        /// </summary>
        pointToPoint,

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
    public enum PositionType
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
    public enum SmoothType
    {
        /// <summary>
        /// 關閉平滑功能。
        /// </summary>
        disable = 0,

        /// <summary>
        /// 貝茲曲線平滑百分比。
        /// </summary>
        bezierCurveSmoothPercent = 1,

        /// <summary>
        /// 貝茲曲線平滑半徑。
        /// </summary>
        bezierCurveSmoothRadius = 2,

        /// <summary>
        /// 依兩線段速度平滑。
        /// </summary>
        twoLinesSpeedSmooth = 3
    }

    #endregion - 列舉 enum -

    internal interface IArmControl : IDevice
    {
        int Acceleration { get; set; }
        int ID { get; set; }
        string IP { set; }
        int Speed { get; set; }

        void ClearAlarm();

        double[] GetPosition(PositionType positionType = PositionType.descartes);

        #region - Motion -

        void MotionGoHome(PositionType positionType = PositionType.descartes);

        void MotionLinear(double[] targetPosition,
                          PositionType positionType = PositionType.descartes,
                          CoordinateType coordinateType = CoordinateType.absolute,
                          SmoothType smoothType = SmoothType.twoLinesSpeedSmooth,
                          double smoothValue = 50);

        void MotionPointToPoint(double[] targetPosition,
                                PositionType positionType = PositionType.descartes,
                                CoordinateType coordinateType = CoordinateType.absolute,
                                SmoothType smoothType = SmoothType.twoLinesSpeedSmooth);

        #endregion - Motion -
    }

    /// <summary>
    /// 上銀機械手臂基本控制。
    /// </summary>
    internal class ArmControl : IDevice
    {
        public ArmControl(string IP, int deviceID = 0)
        {
            // 初始化。
            ArmIP = IP;
            DeviceID = deviceID;
            InitTimer();
        }

        #region - 基本屬性 -

        /// <summary>
        /// 笛卡爾原點絕對坐標。
        /// </summary>
        public readonly double[] positionDescartesHome = { 0, 368, 294, 180, 0, 90 };

        /// <summary>
        /// 關節原點絕對坐標。
        /// </summary>
        public readonly double[] positionJointHome = { 0, 0, 0, 0, 0, 0 };

        private static HRobot.CallBackFun callback;

        private string ArmIP;

        private IErrorMessage ErrorMessage = new ErrorMessage();

        private int TimeCheck = 0;

        private Timer timer = new Timer();

        public bool Connected { get; private set; } = false;

        /// <summary>
        /// 手臂ID。
        /// </summary>
        public int DeviceID { get; set; }

        #endregion - 基本屬性 -

        #region - 速度與加速度 -

        /// <summary>
        /// 取得目前手臂加速度比例。
        /// </summary>
        /// <returns>
        /// ● 1~100：目前手臂的加速度比例。<br/>
        /// ● -1：錯誤。
        /// </returns>
        public int GetAcceleration()
        {
            int value = HRobot.get_acc_dec_ratio(DeviceID);

            if (value == -1)
            {
                ErrorMessage.Show("取得手臂加速度時出錯。");
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
        public int GetSpeed()
        {
            int value = HRobot.get_override_ratio(DeviceID);

            if (value == -1)
            {
                ErrorMessage.Show("取得手臂速度時出錯。");
            }

            return value;
        }

        /// <summary>
        /// 設定手臂加速度比例。<br/>
        /// 引數應為1 ~ 100 (%)。
        /// </summary>
        /// <param name="value"></param>
        public void SetAcceletarion(int value)
        {
            if (value > 100 || value < 1)
            {
                ErrorMessage.Show("手臂加速度應為1% ~ 100%之間。");
            }
            else
            {
                int retuenCode = HRobot.set_acc_dec_ratio(DeviceID, value);

                //執行HRobot.set_acc_dec_ratio時會固定回傳錯誤代碼4000
                IsErrorAndHandler(retuenCode, 0, 4000);
            }
        }

        /// <summary>
        /// 設定手臂整體速度比例。<br/>
        /// 引數應為1 ~ 100 (%)。
        /// </summary>
        /// <param name="value"></param>
        public void SetSpeed(int value)
        {
            if (value > 100 || value < 1)
            {
                ErrorMessage.Show("手臂速度應為1% ~ 100%之間。");
            }
            else
            {
                int retuenCode = HRobot.set_override_ratio(DeviceID, value);

                IsErrorAndHandler(retuenCode);
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
        public double[] GetNowPosition(PositionType type)
        {
            double[] position = new double[6];
            int retuenCode = -1;

            foreach (int k in position)
            {
                if (type == PositionType.descartes)
                {
                    retuenCode = HRobot.get_current_position(DeviceID, position);
                }
                else if (type == PositionType.joint)
                {
                    retuenCode = HRobot.get_current_joint(DeviceID, position);
                }
                else
                {
                    ShowUnknownPositionType();
                    return position;
                }
            }
            IsErrorAndHandler(retuenCode);
            return position;
        }

        public void GoHome(PositionType type)
        {
            switch (type)
            {
                case PositionType.descartes:
                    HRobot.ptp_pos(DeviceID, 1, positionDescartesHome);
                    WaitForMotionComplete(positionDescartesHome, type);
                    break;

                case PositionType.joint:
                    HRobot.ptp_axis(DeviceID, 1, positionJointHome);
                    WaitForMotionComplete(positionJointHome, type);
                    break;

                default:
                    ShowUnknownPositionType();
                    return;
            }
        }

        /// <summary>
        /// 進行直線運動。<br/>
        /// ● targetPosition：目標位置。<br/>
        /// ● positionType：位置類型，笛卡爾或關節。<br/>
        /// ● coordinateType：坐標類型，絕對坐標或相對坐標。預設為絕對坐標。<br/>
        /// ● smoothType：平滑模式類型。預設為依兩線段速度平滑。<br/>
        /// ● smoothValue：平滑值。預設為50。
        /// </summary>
        /// <param name="targetPosition"></param>
        /// <param name="positionType"></param>
        /// <param name="coordinateType"></param>
        /// <param name="smoothType"></param>
        /// <param name="smoothValue"></param>
        public void MotionLinear(double[] targetPosition,
                                  PositionType positionType,
                                  CoordinateType coordinateType = CoordinateType.absolute,
                                  SmoothType smoothType = SmoothType.twoLinesSpeedSmooth,
                                  double smoothValue = 50)
        {
            int retuenCode = 0;

#if (USE_SDK_RELATIVE)
            if (coordinateType == CoordinateType.absolute)
            {
                switch (positionType)
                {
                    case PositionType.descartes:
                        retuenCode = HRobot.lin_pos(DeviceID, (int)smoothType, smoothValue, targetPosition);
                        break;

                    case PositionType.joint:
                        retuenCode = HRobot.lin_axis(DeviceID, (int)smoothType, smoothValue, targetPosition);
                        break;

                    default:
                        ShowUnknownPositionType();
                        return;
                }
            }
            else if (coordinateType == CoordinateType.relative)
            {
                switch (positionType)
                {
                    case PositionType.descartes:
                        retuenCode = HRobot.lin_rel_pos(DeviceID, (int)smoothType, smoothValue, targetPosition);
                        break;

                    case PositionType.joint:
                        retuenCode = HRobot.lin_rel_axis(DeviceID, (int)smoothType, smoothValue, targetPosition);
                        break;

                    default:
                        ShowUnknownPositionType();
                        return;
                }
            }
#else
            if (coordinateType == CoordinateType.relative)
            {
                targetPosition = ConvertRelativeToAdsolute(targetPosition, positionType);
            }

            switch (positionType)
            {
                case PositionType.descartes:
                    retuenCode = HRobot.lin_pos(DeviceID, (int)smoothType, smoothValue, targetPosition);
                    break;

                case PositionType.joint:
                    retuenCode = HRobot.lin_axis(DeviceID, (int)smoothType, smoothValue, targetPosition);
                    break;

                default:
                    ShowUnknownPositionType();
                    return;
            }
#endif

            if (IsErrorAndHandler(retuenCode) == false)
            {
                WaitForMotionComplete(targetPosition, positionType);
            }
        }

        /// <summary>
        ///  進行點對點運動。<br/>
        ///  ● targetPosition：目標位置。<br/>
        ///  ● positionType：位置類型，笛卡爾或關節。<br/>
        ///  ● coordinateType：坐標類型，絕對坐標或相對坐標。預設為絕對坐標。<br/>
        ///  ● smoothType：平滑模式類型。預設為依兩線段速度平滑。<br/>
        /// </summary>
        /// <param name="targetPosition"></param>
        /// <param name="positionType"></param>
        /// <param name="coordinateType"></param>
        /// <param name="smoothType"></param>
        public void MotionPointToPoint(double[] targetPosition,
                                          PositionType positionType,
                                          CoordinateType coordinateType = CoordinateType.absolute,
                                          SmoothType smoothType = SmoothType.twoLinesSpeedSmooth)
        {
            int retuenCode = 0;
            int smoothTypeCode;

            switch (smoothType)
            {
                case SmoothType.twoLinesSpeedSmooth:
                    smoothTypeCode = 1;
                    break;

                default:
                    smoothTypeCode = 0;
                    break;
            }

#if (USE_SDK_RELATIVE)
            if (coordinateType == CoordinateType.absolute)
            {
                switch (positionType)
                {
                    case PositionType.descartes:
                        retuenCode = HRobot.ptp_pos(DeviceID, smoothTypeCode, targetPosition);
                        break;

                    case PositionType.joint:
                        retuenCode = HRobot.ptp_axis(DeviceID, smoothTypeCode, targetPosition);
                        break;

                    default:
                        ShowUnknownPositionType();
                        return;
                }
            }
            else if (coordinateType == CoordinateType.relative)
            {
                switch (positionType)
                {
                    case PositionType.descartes:
                        retuenCode = HRobot.ptp_rel_pos(DeviceID, smoothTypeCode, targetPosition);
                        break;

                    case PositionType.joint:
                        retuenCode = HRobot.ptp_rel_axis(DeviceID, smoothTypeCode, targetPosition);
                        break;

                    default:
                        ShowUnknownPositionType();
                        return;
                }
            }
#else
            if (coordinateType == CoordinateType.relative)
            {
                targetPosition = ConvertRelativeToAdsolute(targetPosition, positionType);
            }

            switch (positionType)
            {
                case PositionType.descartes:
                    retuenCode = HRobot.ptp_pos(DeviceID, smoothTypeCode, targetPosition);
                    break;

                case PositionType.joint:
                    retuenCode = HRobot.ptp_axis(DeviceID, smoothTypeCode, targetPosition);
                    break;

                default:
                    ShowUnknownPositionType();
                    retuen;
            }
#endif

            if (IsErrorAndHandler(retuenCode) == false)
            {
                WaitForMotionComplete(targetPosition, positionType);
            }
        }

        /// <summary>
        /// 等待手臂運動完成。
        /// </summary>
        /// <param name="targetPosition"></param>
        /// <param name="type"></param>
        private void WaitForMotionComplete(double[] targetPosition, PositionType type)
        {
#if (USE_MOTION_STATE_WAIT)
            while (true)
            {
                // motion_state = 1: Idle.
                if (HRobot.get_motion_state(DeviceID) != 1)
                {
                    Thread.Sleep(200);
                }
                else
                {
                    break;
                }
            }
#else
            double[] nowPosition = new double[6];

            timer.Enabled = true;

            // For無限回圈。
            for (; ; )
            {
                if (TimeCheck % 1 == 0 && type == PositionType.descartes)
                {
                    foreach (int k in nowPosition)
                    {
                        // 取得目前的笛卡爾坐標。
                        HRobot.get_current_position(DeviceID, nowPosition);
                    }

                    if (Math.Abs(targetPosition[0] - nowPosition[0]) < 0.01 &&
                        Math.Abs(targetPosition[1] - nowPosition[1]) < 0.01 &&
                        Math.Abs(targetPosition[2] - nowPosition[2]) < 0.01 &&
                        Math.Abs(Math.Abs(targetPosition[3]) - Math.Abs(nowPosition[3])) < 0.01 &&
                        Math.Abs(Math.Abs(targetPosition[4]) - Math.Abs(nowPosition[4])) < 0.01 &&
                        Math.Abs(Math.Abs(targetPosition[5]) - Math.Abs(nowPosition[5])) < 0.01)
                    {
                        // 跳出For無限回圈。
                        break;
                    }
                }
                else if (TimeCheck % 1 == 0 && type == PositionType.joint)
                {
                    foreach (int k in nowPosition)
                    {
                        // 取得目前的關節坐標。
                        HRobot.get_current_joint(DeviceID, nowPosition);
                    }

                    if (Math.Abs(targetPosition[0] - nowPosition[0]) < 0.01 &&
                        Math.Abs(targetPosition[1] - nowPosition[1]) < 0.01 &&
                        Math.Abs(targetPosition[2] - nowPosition[2]) < 0.01 &&
                        Math.Abs(targetPosition[3] - nowPosition[3]) < 0.01 &&
                        Math.Abs(targetPosition[4] - nowPosition[4]) < 0.01 &&
                        Math.Abs(targetPosition[5] - nowPosition[5]) < 0.01)
                    {
                        // 跳出For無限回圈。
                        break;
                    }
                }
            }

            timer.Enabled = false;
            TimeCheck = 0;
#endif
        }

        #endregion - 基本運動 -

        #region - 連線/斷線 -

        /// <summary>
        /// 進行手臂連線、開啟控制器。
        /// </summary>
        public bool Connect()
        {
            //接收控制器回傳訊息
            callback = new HRobot.CallBackFun(EventFun);

            //連線設定。測試連線設定:("127.0.0.1", 1, callback);
            DeviceID = HRobot.open_connection(ArmIP, 1, callback);
            Thread.Sleep(500);

            //0 ~ 65535為有效裝置ID
            if (DeviceID >= 0 && DeviceID <= 65535)
            {
                int alarmState;
                int motorState;
                int connectionLevel;

                //清除錯誤
                alarmState = HRobot.clear_alarm(DeviceID);

                //錯誤代碼300代表沒有警報，無法清除警報
                if (alarmState == 300)
                {
                    alarmState = 0;
                }

                //設定控制器: 1為啟動,0為關閉
                HRobot.set_motor_state(DeviceID, 1);
                Thread.Sleep(500);

                //回傳控制器狀態
                motorState = HRobot.get_motor_state(DeviceID);

                connectionLevel = HRobot.get_connection_level(DeviceID);

#if (!DISABLE_SHOW_MESSAGE)
                MessageBox.Show(string.Format("連線成功!\r\n" +
                                              "手臂ID: {0}\r\n" +
                                              "連線等級: {1}\r\n" +
                                              "控制器狀態: {2}\r\n" +
                                              "錯誤代碼: {3}\r\n",
                                              DeviceID,
                                              (connectionLevel == 0) ? "觀測者" : "操作者",
                                              (motorState == 0) ? "關閉" : "開啟",
                                              alarmState));
#endif

                Connected = true;
                return true;
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

#if (!DISABLE_SHOW_MESSAGE)
                MessageBox.Show("無法連線!\r\n" + message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
#endif

                Connected = false;
                return false;
            }
        }

        /// <summary>
        /// 進行手臂斷線、關閉控制器。
        /// </summary>
        public bool Disconnect()
        {
            int alarmState;
            int motorState;

            //設定控制器: 1為啟動,0為關閉
            HRobot.set_motor_state(DeviceID, 0);
            Thread.Sleep(200);

            //將所有錯誤代碼清除
            alarmState = HRobot.clear_alarm(DeviceID);

            //錯誤代碼300代表沒有警報，無法清除警報
            if (alarmState == 300)
            {
                alarmState = 0;
            }

            //回傳控制器狀態
            motorState = HRobot.get_motor_state(DeviceID);

            //關閉手臂連線
            HRobot.disconnect(DeviceID);

#if (!DISABLE_SHOW_MESSAGE)
            MessageBox.Show(string.Format("斷線成功!\r\n" +
                                          "控制器狀態: {0}\r\n" +
                                          "錯誤代碼: {1}\r\n",
                                          (motorState == 0) ? "關閉" : "開啟",
                                          alarmState));
#endif

            Connected = false;
            return true;
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
#if (!DISABLE_SHOW_MESSAGE)
                        MessageBox.Show("Update fail. " + rlt,
                                        "HRSS update callback",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning,
                                        MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions.DefaultDesktopOnly);
#endif
                    }
                    break;
            }
        }

        #endregion - 連線/斷線 -

        #region - Others -

        /// <summary>
        /// 清除錯誤。
        /// </summary>
        public void ClearAlarm()
        {
            int retuenCode = HRobot.clear_alarm(DeviceID);

            //錯誤代碼300代表沒有警報，無法清除警報
            IsErrorAndHandler(retuenCode, 0, 300);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int GetID()
        {
            return DeviceID;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetID(int id)
        {
            DeviceID = id;
        }

        //        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        //        protected override void ShowErrorMessage(string message = "Error.", Exception ex = null)
        //        {
        //#if (!DISABLE_SHOW_MESSAGE)
        //            base.ShowErrorMessage(message, ex);
        //#endif
        //        }

        /// <summary>
        /// 將相對坐標以目前位置轉為絕對坐標。
        /// </summary>
        /// <param name="relativePosition"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private double[] ConvertRelativeToAdsolute(double[] relativePosition,
                                                   PositionType type)
        {
            double[] position = GetNowPosition(type);

            for (int i = 0; i < 6; i++)
            {
                position[i] += relativePosition[i];
            }

            return position;
        }

        /// <summary>
        /// 初始化計時器。
        /// </summary>
        private void InitTimer()
        {
            timer.Interval = 50;
            timer.Tick += new EventHandler(timer_Tick);
        }

        /// <summary>
        /// 如果出現錯誤，顯示錯誤代碼。
        /// </summary>
        /// <param name="code"></param>
        /// <param name="successCode"></param>
        /// <param name="ignoreCode"></param>
        /// <returns>
        /// 是否出現錯誤。<br/>
        /// ● true：出現錯誤。<br/>
        /// ● false：沒有出現錯誤。
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private bool IsErrorAndHandler(int code, int successCode = 0, int ignoreCode = 0)
        {
            if (code == successCode || code == ignoreCode)
            {
                // Successful.
                return false;
            }
            else
            {
                // Not successful.
                ErrorMessage.Show($"上銀機械手臂控制錯誤。\r\n錯誤代碼：{code}");
                return true;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void ShowUnknownPositionType()
        {
            ErrorMessage.Show($"錯誤的位置類型。\r\n" +
                             $"位置類型應為：{PositionType.descartes} 或是 {PositionType.joint}");
        }

        /// <summary>
        /// 計時器計數。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            ++TimeCheck;
        }

        #endregion - Others -
    }
}