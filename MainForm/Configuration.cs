namespace MainForm
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
        public const string ArmIp = "192.168.0.3";

        /// <summary>
        /// 夾爪連線COM Port。<br/>
        /// 設定錯誤將會無法連線。
        /// </summary>
        public const string GripperComPort = "COM12";

        /// <summary>
        /// 藍牙連線COM Port。<br/>
        /// 設定錯誤將會無法連線。
        /// </summary>
        public const string BluetoothComPort = "COM21";

        /// <summary>
        /// CSV 檔案儲存路徑。
        /// </summary>
        public const string CsvFilePath = "../../../../csv/";

        /// <summary>
        /// Log 檔案儲存路徑。
        /// </summary>
        public const string LogFilePath = "../../../../log/";
    }
}