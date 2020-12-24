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
        public const string ArmIP = "192.168.0.3";

        /// <summary>
        /// 夾爪連線COM Port。<br/>
        /// 設定錯誤將會無法連線。
        /// </summary>
        public const string GripperCOMPort = "COM12";
    }
}