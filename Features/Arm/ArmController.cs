//#define DISABLE_SHOW_MESSAGE

// 選擇一種等待手臂動作完成的做法，都不選就是使用預設方法。
#define USE_CALLBACK_MOTION_STATE_WAIT
// #define USE_MOTION_STATE_WAIT

#if (DISABLE_SHOW_MESSAGE)
#warning Message is disabled.
#endif

using SDKHrobot;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Features
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
        Absolute,

        /// <summary>
        /// 相對坐標。
        /// </summary>
        Relative,

        /// <summary>
        /// 未知的類型。
        /// </summary>
        Unknown
    }

    /// <summary>
    /// 運動類型。
    /// </summary>
    public enum MotionType
    {
        /// <summary>
        /// 直線運動。
        /// </summary>
        Linear,

        /// <summary>
        /// 點對點運動。
        /// </summary>
        PointToPoint,

        /// <summary>
        /// 圓弧運動。
        /// </summary>
        Circle,

        /// <summary>
        /// 未知的類型。
        /// </summary>
        Unknown
    }

    /// <summary>
    /// 位置類型。
    /// </summary>
    public enum PositionType
    {
        /// <summary>
        /// 笛卡爾。
        /// </summary>
        Descartes,

        /// <summary>
        /// 關節。
        /// </summary>
        Joint,

        /// <summary>
        /// 未知的類型。
        /// </summary>
        Unknown
    }

    /// <summary>
    /// 手臂平滑模式。
    /// </summary>
    public enum SmoothType
    {
        /// <summary>
        /// 關閉平滑功能。
        /// </summary>
        Disable = 0,

        /// <summary>
        /// 貝茲曲線平滑百分比。
        /// </summary>
        BezierCurveSmoothPercent = 1,

        /// <summary>
        /// 貝茲曲線平滑半徑。
        /// </summary>
        BezierCurveSmoothRadius = 2,

        /// <summary>
        /// 依兩線段速度平滑。
        /// </summary>
        TwoLinesSpeedSmooth = 3
    }

    #endregion - 列舉 enum -

    /// <summary>
    /// 上銀機械手臂控制介面。
    /// </summary>
    public interface IArmController : IDevice
    {
        /// <summary>
        /// 手臂ID。
        /// </summary>
        int Id { get; }

        /// <summary>
        /// 手臂IP。
        /// </summary>
        string Ip { get; }

        #region - Default Position -

        /// <summary>
        /// 笛卡爾原點絕對坐標。
        /// </summary>
        double[] DescartesHomePosition { get; }

        /// <summary>
        /// 關節原點絕對坐標。
        /// </summary>
        double[] JointHomePosition { get; }

        #endregion - Default Position -

        #region - Speed and Acceleration -

        /// <summary>
        /// 整體加速度比例。<br/>
        /// 正常數值爲 1 ~ 100，-1 代表取得數值時出錯。
        /// </summary>
        int Acceleration { get; set; }

        /// <summary>
        /// 整體速度比例。<br/>
        /// 正常數值爲 1 ~ 100，-1 代表取得數值時出錯。
        /// </summary>
        int Speed { get; set; }

        #endregion - Speed and Acceleration -

        #region - Motion -

        /// <summary>
        /// 回到指定座標系的原點。預設爲笛卡爾。
        /// </summary>
        /// <param name="positionType"></param>
        /// <param name="waitForMotion"></param>
        void Homing(PositionType positionType = PositionType.Descartes,
                    bool waitForMotion = true);

        /// <summary>
        /// 進行直線運動。<br/>
        /// ● targetPosition：目標位置。<br/>
        /// ● positionType：位置類型，笛卡爾或關節。預設爲笛卡爾。<br/>
        /// ● coordinateType：坐標類型，絕對坐標或相對坐標。預設為絕對坐標。<br/>
        /// ● smoothType：平滑模式類型。預設為依兩線段速度平滑。<br/>
        /// ● smoothValue：平滑值。預設為50。<br/>
        /// ● waitForMotion：是否等待動作完成。預設為true。
        /// </summary>
        /// <param name="targetPosition"></param>
        /// <param name="coordinateType"></param>
        /// <param name="positionType"></param>
        /// <param name="smoothType"></param>
        /// <param name="smoothValue"></param>
        /// <param name="waitForMotion"></param>
        void MoveLinear(double[] targetPosition,
                        CoordinateType coordinateType = CoordinateType.Absolute,
                        PositionType positionType = PositionType.Descartes,
                        SmoothType smoothType = SmoothType.TwoLinesSpeedSmooth,
                        double smoothValue = 50,
                        bool waitForMotion = true);

        /// <summary>
        /// 進行點對點運動。<br/>
        /// ● targetPosition：目標位置。<br/>
        /// ● positionType：位置類型，笛卡爾或關節。預設爲笛卡爾。<br/>
        /// ● coordinateType：坐標類型，絕對坐標或相對坐標。預設為絕對坐標。<br/>
        /// ● smoothType：平滑模式類型。預設為依兩線段速度平滑。<br/>
        /// ● waitForMotion：是否等待動作完成。預設為true。
        /// </summary>
        /// <param name="targetPosition"></param>
        /// <param name="coordinateType"></param>
        /// <param name="positionType"></param>
        /// <param name="smoothType"></param>
        /// <param name="waitForMotion"></param>
        void MovePointToPoint(double[] targetPosition,
                              CoordinateType coordinateType = CoordinateType.Absolute,
                              PositionType positionType = PositionType.Descartes,
                              SmoothType smoothType = SmoothType.TwoLinesSpeedSmooth,
                              bool waitForMotion = true);

        #endregion - Motion -

        #region - Others -

        /// <summary>
        /// 清除警報。
        /// </summary>
        void ClearAlarm();

        /// <summary>
        /// 取得手臂目前的位置座標數值。<br/>
        /// 須在引數選擇位置類型是笛卡爾還是關節。預設爲笛卡爾。
        /// </summary>
        /// <param name="positionType"></param>
        /// <returns>目前的手臂位置座標數值。</returns>
        double[] GetPosition(PositionType positionType = PositionType.Descartes);

        #endregion - Others -
    }

    /// <summary>
    /// 上銀機械手臂控制實作。
    /// </summary>
    public class ArmController : IArmController
    {
#if (USE_CALLBACK_MOTION_STATE_WAIT)
        private static bool Waiting = false;
#endif

        public ArmController(string armIp, IMessage message)
        {
            Ip = armIp;
            Message = message;

#if (!USE_MOTION_STATE_WAIT && !USE_CALLBACK_MOTION_STATE_WAIT)
            InitTimer();
#endif
        }

        public int Id { get; private set; }
        public string Ip { get; private set; }

        #region - Default Position -

        public double[] DescartesHomePosition { get; } = { 0, 368, 294, 180, 0, 90 };

        public double[] JointHomePosition { get; } = { 0, 0, 0, 0, 0, 0 };

        #endregion - Default Position -

        #region - Speed and Acceleration -

        public int Acceleration
        {
            get
            {
                int acc;
                if (Connected)
                {
                    acc = HRobot.get_acc_dec_ratio(Id);
                    if (acc == -1)
                    {
                        Message.Show("取得手臂加速度時出錯。", LoggingLevel.Error);
                    }
                }
                else
                {
                    acc = -1;
                    Message.Show("手臂未連線。", LoggingLevel.Info);
                }
                return acc;
            }

            set
            {
                if (value > 100 || value < 1)
                {
                    Message.Show($"手臂加速度應為1% ~ 100%之間。輸入值為： {value}",
                                 LoggingLevel.Warn);
                }
                else
                {
                    if (Connected)
                    {
                        var returnCode = HRobot.set_acc_dec_ratio(Id, value);

                        // 執行HRobot.set_acc_dec_ratio時會固定回傳錯誤代碼4000。
                        IsErrorAndHandler(returnCode, 4000);
                    }
                    else
                    {
                        Message.Show("手臂未連線。", LoggingLevel.Info);
                    }
                }
            }
        }

        public int Speed
        {
            get
            {
                int speed;
                if (Connected)
                {
                    speed = HRobot.get_override_ratio(Id);
                    if (speed == -1)
                    {
                        Message.Show("取得手臂速度時出錯。", LoggingLevel.Error);
                    }
                }
                else
                {
                    speed = -1;
                    Message.Show("手臂未連線。", LoggingLevel.Info);
                }
                return speed;
            }

            set
            {
                if (value > 100 || value < 1)
                {
                    Message.Show($"手臂速度應為1% ~ 100%之間。輸入值為： {value}",
                                 LoggingLevel.Warn);
                }
                else
                {
                    if (Connected)
                    {
                        var returnCode = HRobot.set_override_ratio(Id, value);
                        IsErrorAndHandler(returnCode);
                    }
                    else
                    {
                        Message.Show("手臂未連線。", LoggingLevel.Info);
                    }
                }
            }
        }

        #endregion - Speed and Acceleration -

        #region - Motion -

        public void Homing(PositionType positionType = PositionType.Descartes,
                           bool waitForMotion = true)
        {
            Message.Log($"Arm-Homing.Type:{positionType}, Wait:{waitForMotion}",
                        LoggingLevel.Trace);

            int returnCode;
            switch (positionType)
            {
                case PositionType.Descartes:
                    returnCode = HRobot.ptp_pos(Id,
                                                (int)SmoothType.Disable,
                                                DescartesHomePosition);
                    if ((returnCode >= 0) && waitForMotion)
                    {
                        WaitForMotionComplete(DescartesHomePosition, positionType);
                    }
                    break;

                case PositionType.Joint:
                    returnCode = HRobot.ptp_axis(Id,
                                                 (int)SmoothType.Disable,
                                                 JointHomePosition);
                    if ((returnCode >= 0) && waitForMotion)
                    {
                        WaitForMotionComplete(JointHomePosition, positionType);
                    }
                    break;

                default:
                    ShowUnknownPositionType();
                    return;
            }
        }

        public void MoveLinear(double[] targetPosition,
                               CoordinateType coordinateType = CoordinateType.Absolute,
                               PositionType positionType = PositionType.Descartes,
                               SmoothType smoothType = SmoothType.TwoLinesSpeedSmooth,
                               double smoothValue = 50,
                               bool waitForMotion = true)
        {
            Message.Log($"Arm-Linear." +
                        $"Pos:{GetTextPosition(targetPosition)}," +
                        $"Type:{positionType};{coordinateType}," +
                        $"Smo:{smoothType};{smoothValue}," +
                        $"Wait:{waitForMotion}",
                        LoggingLevel.Trace);

            int returnCode;
            Func<int, int, double, double[], int> action;

            switch (positionType)
            {
                case PositionType.Descartes when coordinateType == CoordinateType.Absolute:
                    action = HRobot.lin_pos;
                    break;

                case PositionType.Descartes when coordinateType == CoordinateType.Relative:
                    action = HRobot.lin_rel_pos;
                    break;

                case PositionType.Joint when coordinateType == CoordinateType.Absolute:
                    action = HRobot.lin_axis;
                    break;

                case PositionType.Joint when coordinateType == CoordinateType.Relative:
                    action = HRobot.lin_rel_axis;
                    break;

                case PositionType.Unknown:
                    ShowUnknownPositionType();
                    return;

                default:
                    return;
            }
            returnCode = action(Id, (int)smoothType, smoothValue, targetPosition);

            if (!IsErrorAndHandler(returnCode) && waitForMotion)
            {
                WaitForMotionComplete(targetPosition, positionType);
            }
        }

        public void MovePointToPoint(double[] targetPosition,
                                     CoordinateType coordinateType = CoordinateType.Absolute,
                                     PositionType positionType = PositionType.Descartes,
                                     SmoothType smoothType = SmoothType.TwoLinesSpeedSmooth,
                                     bool waitForMotion = true)
        {
            Message.Log($"Arm-PointToPoint." +
                        $"Pos:{GetTextPosition(targetPosition)}," +
                        $"Type:{positionType};{coordinateType}," +
                        $"Smo:{smoothType}," +
                        $"Wait:{waitForMotion}",
                        LoggingLevel.Trace);

            int returnCode;
            int smoothTypeCode = (smoothType == SmoothType.TwoLinesSpeedSmooth) ? 1 : 0;
            Func<int, int, double[], int> action;

            switch (positionType)
            {
                case PositionType.Descartes when coordinateType == CoordinateType.Absolute:
                    action = HRobot.ptp_pos;
                    break;

                case PositionType.Descartes when coordinateType == CoordinateType.Relative:
                    action = HRobot.ptp_rel_pos;
                    break;

                case PositionType.Joint when coordinateType == CoordinateType.Absolute:
                    action = HRobot.ptp_axis;
                    break;

                case PositionType.Joint when coordinateType == CoordinateType.Relative:
                    action = HRobot.ptp_rel_axis;
                    break;

                case PositionType.Unknown:
                    ShowUnknownPositionType();
                    return;

                default:
                    return;
            }
            returnCode = action(Id, smoothTypeCode, targetPosition);

            if (!IsErrorAndHandler(returnCode) && waitForMotion)
            {
                WaitForMotionComplete(targetPosition, positionType);
            }
        }

        private string GetTextPosition(double[] position)
        {
            return "\"" +
                   $"{position[0]}," +
                   $"{position[1]}," +
                   $"{position[2]}," +
                   $"{position[3]}," +
                   $"{position[4]}," +
                   $"{position[5]}" +
                   "\"";
        }

        /// <summary>
        /// 等待手臂運動完成。
        /// </summary>
        /// <param name="targetPosition"></param>
        /// <param name="positionType"></param>
        private void WaitForMotionComplete(double[] targetPosition, PositionType positionType)
        {
#if (USE_CALLBACK_MOTION_STATE_WAIT)
            // 使用 HRSDK 中的 delegate CallBackFun 來接收從手臂回傳的資訊，
            // 並從中取得 motion_state 來判斷手臂是否還在運動中。

            Waiting = true;
            while (Waiting)
            {
                // 等待 EventFun() 將 Waiting 的值改成 false 即跳出迴圈。
                // 此 Thread.Sleep() 不一定要有。
                Thread.Sleep(50);
            }
#elif (USE_MOTION_STATE_WAIT)
            // 使用 HRSDK 中的 method get_motion_state() 來取得手臂 motion_state 來判斷手臂是否還在運動中。

            // motion_state = 1: Idle.
            while (HRobot.get_motion_state(Id) != 1)
            {
                Thread.Sleep(200);
            }
#else
            // 使用比較目標座標及手臂目前的座標來判斷手臂是否還在運動中。

            double[] nowPosition = new double[6];

            ActionTimer.Enabled = true;

            // For無限回圈。
            for (; ; )
            {
                if (TimeCheck % 1 == 0 && positionType == PositionType.Descartes)
                {
                    foreach (int k in nowPosition)
                    {
                        // 取得目前的笛卡爾坐標。
                        HRobot.get_current_position(Id, nowPosition);
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
                else if (TimeCheck % 1 == 0 && positionType == PositionType.Joint)
                {
                    foreach (int k in nowPosition)
                    {
                        // 取得目前的關節坐標。
                        HRobot.get_current_joint(Id, nowPosition);
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

            ActionTimer.Enabled = false;
            TimeCheck = 0;
#endif
        }

        #endregion - Motion -

        #region - Connect and Disconnect -

        /// <summary>
        /// 此 delegate 必須要是 static，否則手臂動作有可能會出現問題。
        /// </summary>
        private static HRobot.CallBackFun CallBackFun;

        public bool Connected { get; private set; } = false;

        public bool Connect()
        {
            // 接收控制器回傳訊息
            CallBackFun = EventFun;

            // 連線設定。測試連線設定:("127.0.0.1", 1, CallBackFun);
            Id = HRobot.open_connection(Ip, 1, CallBackFun);
            Thread.Sleep(500);

            //0 ~ 65535為有效裝置ID
            if (Id >= 0 && Id <= 65535)
            {
                int alarmState;
                int motorState;
                int connectionLevel;

                // 清除錯誤
                alarmState = HRobot.clear_alarm(Id);

                //錯誤代碼300代表沒有警報，無法清除警報
                if (alarmState == 300)
                {
                    alarmState = 0;
                }

                //設定控制器: 1為啟動,0為關閉
                HRobot.set_motor_state(Id, 1);
                Thread.Sleep(500);

                //回傳控制器狀態
                motorState = HRobot.get_motor_state(Id);

                connectionLevel = HRobot.get_connection_level(Id);

                var text = "連線成功!\r\n" +
                           $"手臂ID: {Id}\r\n" +
                           $"連線等級: {(connectionLevel == 0 ? "觀測者" : "操作者")}\r\n" +
                           $"控制器狀態: {(motorState == 0 ? "關閉" : "開啟")}\r\n" +
                           $"錯誤代碼: {alarmState}";

                Message.Show(text, "連線", MessageBoxButtons.OK, MessageBoxIcon.None);

                Connected = true;
                return true;
            }
            else
            {
                string message;

                switch (Id)
                {
                    case -1:
                        message = "-1：連線失敗。";
                        break;

                    case -2:
                        message = "-2：回傳機制創建失敗。";
                        break;

                    case -3:
                        message = "-3：無法連線至Robot。";
                        break;

                    case -4:
                        message = "-4：版本不相符。";
                        break;

                    default:
                        message = $"未知的錯誤代碼： {Id}";
                        break;
                }

                Message.Show($"無法連線!\r\n{message}", LoggingLevel.Error);

                Connected = false;
                return false;
            }
        }

        public bool Disconnect()
        {
            int alarmState;
            int motorState;

            //設定控制器: 1為啟動,0為關閉
            HRobot.set_motor_state(Id, 0);
            Thread.Sleep(500);

            //將所有錯誤代碼清除
            alarmState = HRobot.clear_alarm(Id);

            //錯誤代碼300代表沒有警報，無法清除警報
            if (alarmState == 300)
            {
                alarmState = 0;
            }

            //回傳控制器狀態
            motorState = HRobot.get_motor_state(Id);

            //關閉手臂連線
            HRobot.disconnect(Id);

            var text = "斷線成功!\r\n" +
                       $"控制器狀態: {(motorState == 0 ? "關閉" : "開啟")}\r\n" +
                       $"錯誤代碼: {alarmState}";

            Message.Show(text, "斷線", MessageBoxButtons.OK, MessageBoxIcon.None);

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
            // 該 Method 的內容請參考 HRSDK-SampleCode： 11.CallbackNotify。
            // 此處不受 IMessage 影響。

            // Get into.
            String info = "";
            unsafe
            {
                fixed (UInt16* p = &Msg)
                {
                    for (int i = 0; i < len; i++)
                    {
                        info += (char)p[i];
                    }
                }
            }
            var infos = info.Split(',');

            // Show in Console.
            Console.WriteLine($"Command:{cmd}, Result:{rlt}");
            switch (cmd)
            {
                case 0 when rlt == 4702:
                    Console.WriteLine($"HRSS Mode:{infos[0]}\r\n" +
                                      $"Operation Mode:{infos[1]}\r\n" +
                                      $"Override Ratio:{infos[2]}\r\n" +
                                      $"Motor State:{infos[3]}\r\n" +
                                      $"Exe File Name:{infos[4]}\r\n" +
                                      $"Function Output:{infos[5]}\r\n" +
                                      $"Alarm Count:{infos[6]}\r\n" +
                                      $"Keep Alive:{infos[7]}\r\n" +
                                      $"Motion Status:{infos[8]}\r\n" +
                                      $"Payload:{infos[9]}\r\n" +
                                      $"Speed:{infos[10]}\r\n" +
                                      $"Position:{infos[11]}\r\n" +
                                      $"Coor:{infos[14]},{infos[15]},{infos[16]},{infos[17]},{infos[18]},{infos[19]}\r\n" +
                                      $"Joint:{infos[20]},{infos[21]},{infos[22]},{infos[23]},{infos[24]},{infos[25]}\r\n");

#if (USE_CALLBACK_MOTION_STATE_WAIT)
                    // Motion state=1: Idle.
                    Waiting = infos[8] == "1" ? false : true;
#endif
                    break;

                case 4011 when rlt != 0:
#if (!DISABLE_SHOW_MESSAGE)
                    MessageBox.Show("Update fail. " + rlt,
                                    "HRSS update callback",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning,
                                    MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.DefaultDesktopOnly);
#endif
                    break;
            }
        }

        #endregion - Connect and Disconnect -

        #region - Timer -

        private Timer ActionTimer = null;
        private int TimeCheck = 0;

        /// <summary>
        /// 初始化計時器。
        /// </summary>
        private void InitTimer()
        {
            ActionTimer = new Timer
            {
                Interval = 50,
                Enabled = false
            };
            ActionTimer.Tick += (s, e) => ++TimeCheck;
        }

        #endregion - Timer -

        #region - Message -

        private IMessage Message { get; set; }

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
        private bool IsErrorAndHandler(int code, int ignoreCode = 0, int successCode = 0)
        {
            if (code == successCode || code == ignoreCode)
            {
                // Successful.
                return false;
            }
            else
            {
                // Not successful.
                Message.Show($"上銀機械手臂控制錯誤。\r\n錯誤代碼：{code}", LoggingLevel.Error);
                return true;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void ShowUnknownPositionType()
        {
            Message.Show($"錯誤的位置類型。\r\n" +
                         $"位置類型應為：{PositionType.Descartes} 或是 {PositionType.Joint}",
                         LoggingLevel.Warn);
        }

        #endregion - Message -

        #region - Others -

        public void ClearAlarm()
        {
            var returnCode = HRobot.clear_alarm(Id);

            // 錯誤代碼300代表沒有警報，無法清除警報
            IsErrorAndHandler(returnCode, 300);
        }

        public double[] GetPosition(PositionType type = PositionType.Descartes)
        {
            var position = new double[6];
            int returnCode;
            Func<int, double[], int> action;

            switch (type)
            {
                case PositionType.Descartes:
                    action = HRobot.get_current_position;
                    break;

                case PositionType.Joint:
                    action = HRobot.get_current_joint;
                    break;

                default:
                    ShowUnknownPositionType();
                    return position;
            }

            returnCode = action(Id, position);
            IsErrorAndHandler(returnCode);
            return position;
        }

        #endregion - Others -
    }
}