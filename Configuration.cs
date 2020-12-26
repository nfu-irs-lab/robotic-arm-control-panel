//#define CONFIG_1
#define CONFIG_2

namespace HIWIN_Robot
{
    /// <summary>
    /// 可調整之設定。
    /// </summary>
    internal class Configuration
    {
        /// <summary>
        /// 手臂連線IP位置。<br/>
        /// 設定錯誤將會無法連線。
        /// </summary>
        public const string ArmIP =
#if (CONFIG_1)
            "192.168.0.3";
#elif (CONFIG_2)
            "192.168.0.3";

#endif

        /// <summary>
        /// 藍牙連線COM Port。<br/>
        /// 設定錯誤將會無法連線。
        /// </summary>
        public const string BluetoothCOMPort =
#if (CONFIG_1)
            "COM21";
#elif (CONFIG_2)
            "COM3";

#endif

        /// <summary>
        /// 夾爪連線COM Port。<br/>
        /// 設定錯誤將會無法連線。
        /// </summary>
        public const string GripperCOMPort =
#if (CONFIG_1)
            "COM12";
#elif (CONFIG_2)
            "COM12";

#endif
    }
}