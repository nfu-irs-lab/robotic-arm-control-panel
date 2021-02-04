//#define CONFIG_1
#define CONFIG_2

#if (CONFIG_1)
#undef CONFIG_2
#endif

namespace HiwinRobot
{
    /// <summary>
    /// 可調整之設定。
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// 手臂連線IP位置。<br/>
        /// 設定錯誤將會無法連線。
        /// </summary>
        public const string ArmIp =
#if (CONFIG_1)
            "192.168.0.3";
#elif (CONFIG_2)
            "192.168.0.3";

#else
            "127.0.0.1";
#endif

        /// <summary>
        /// 藍牙連線COM Port。<br/>
        /// 設定錯誤將會無法連線。
        /// </summary>
        public const string BluetoothComPort =
#if (CONFIG_1)
            "COM21";
#elif (CONFIG_2)
            "COM3";

        /// <summary>
        /// 夾爪連線COM Port。<br/>
        /// 設定錯誤將會無法連線。
        /// </summary>
        public const string GripperComPort =
#if (CONFIG_1)
            "COM12";
#elif (CONFIG_2)
            "COM12";

        /// <summary>
        /// Log 檔案儲存路徑。
        /// </summary>
        public const string LogFilePath =
#if (CONFIG_1)
            "../../../log/";
#elif (CONFIG_2)
            "../../../log/";

#else
            "";
#endif
#else
            "COM2";
#endif
#else
            "COM1";
#endif
    }
}