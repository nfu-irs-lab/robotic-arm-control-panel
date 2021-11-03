//#define DISABLE_SHOW_MESSAGE
//#define DISABLE_FORM_CLOSING

#if (DISABLE_SHOW_MESSAGE)
#warning Message is disabled.
#endif

using RASDK.Basic;
using RASDK.Basic.Message;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MainForm
{
    /// <summary>
    /// 機器手臂控制程式 <br/>
    /// Robotic Arm Control Pael
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // 目標位置控制項集合。
            TargetPosition = new List<NumericUpDown>
            {
                numericUpDown_arm_target_position_j1x,
                numericUpDown_arm_target_position_j2y,
                numericUpDown_arm_target_position_j3z,
                numericUpDown_arm_target_position_j4a,
                numericUpDown_arm_target_position_j5b,
                numericUpDown_arm_target_position_j6c
            };

            // 目前位置控制項集合。
            NowPosition = new List<TextBox>
            {
                textBox_arm_now_position_j1x,
                textBox_arm_now_position_j2y,
                textBox_arm_now_position_j3z,
                textBox_arm_now_position_j4a,
                textBox_arm_now_position_j5b,
                textBox_arm_now_position_j6c
            };

            // 未連線時禁用之按鈕集合。
            Buttons = new List<Button>
            {
                button_arm_homing,
                button_arm_clear_alarm,
                button_update_now_position,
                button_arm_motion_start,
                button_set_speed_acceleration
            };

            // 物件實體化。
            LogHandler = new LogHandler(Config.LogFilePath, LoggingLevel.Trace);
            MessageHandler = new GeneralMessage(LogHandler);
            Arm = new RASDK.Arm.Hiwin.RoboticArm(MessageHandler, Config.ArmIp);
            // Gripper = new GripperController(Configuration.GripperComPort, Message);
            // Bluetooth = new BluetoothArmController(Configuration.BluetoothComPort, Arm, Gripper, Message);
            // CsvHandler = new CsvHandler(Configuration.CsvFilePath);
            // ActionFlow = new ActionFlowHandler(listView_actionflow_actions, Message);
            // PositionHandler = new PositionHandler(listView_position_record,
            //                                       comboBox_position_record_file_list,
            //                                       CsvHandler,
            //                                       Message);
            // Camera = new IDSCamera(Message);

            // 初始化可連線裝置組。
            OrganizeConnectableDevices();

            // 初始化動作流程。
            // ActionFlow.Clear();
            // ActionFlow.Add("Start", () => { }, "The start of Action-Flow. (Empty)");
            // OrganizeActionFlow();
            // ActionFlow.Add("End", () => { }, "The end of Action-Flow. (Empty)");
            // ActionFlow.UpdateListView();

            // 未與手臂連線，禁用部分按鈕。
            //SetButtonsState(false);

            // PositionHandler.UpdateFileList();
        }

        /// <summary>
        /// 視窗關閉事件。
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
#if (!DISABLE_FORM_CLOSING)
            foreach (var device in Devices)
            {
                if (device.Connected)
                {
                    var dr = MessageHandler.Show("手臂或其它裝置似乎還在連線中。\r\n" +
                                                 "是否要斷開連線後再關閉視窗？",
                                                 "關閉視窗",
                                                 MessageBoxButtons.YesNoCancel,
                                                 MessageBoxIcon.Warning,
                                                 LoggingLevel.Warn);
                    switch (dr)
                    {
                        // 斷線後關閉視窗。
                        case DialogResult.Yes:
                            button_disconnect.PerformClick();
                            e.Cancel = false;
                            break;

                        // 直接關閉視窗，不斷線。
                        case DialogResult.No:
                            e.Cancel = false;
                            break;

                        // 取消視窗關閉事件。
                        case DialogResult.Cancel:
                            e.Cancel = true;
                            break;
                    }
                    break;
                }
            }
#endif
        }

        /// <summary>
        /// 設定手臂未連線時禁用的按鈕啓用狀態。
        /// </summary>
        /// <param name="enableButtons"></param>
        private void SetButtonsState(bool enableButtons)
        {
            foreach (var b in Buttons)
            {
                b.Enabled = enableButtons;
            }
        }

        #region - 其它 -

        /// <summary>
        /// 未連線時禁用的按鈕組。
        /// </summary>
        private readonly List<Button> Buttons;

        /// <summary>
        /// 連線裝置組。
        /// </summary>
        private List<IDevice> Devices = new List<IDevice>();

        /// <summary>
        /// UI 目前顯示位置的控制項陣列。
        /// </summary>
        private readonly List<TextBox> NowPosition;

        /// <summary>
        /// UI 目標位置的控制項陣列。
        /// </summary>
        private readonly List<NumericUpDown> TargetPosition;

        /// <summary>
        /// 手臂藍牙控制器。
        /// </summary>
        // private IBluetoothController Bluetooth = null;

        /// <summary>
        /// Log 檔處理器。
        /// </summary>
        private ILogHandler LogHandler;

        /// <summary>
        /// 訊息處理器。
        /// </summary>
        private IMessage MessageHandler;

        /// <summary>
        /// 位置記錄處理器。
        /// </summary>
        // private IPositionHandler PositionHandler = null;

        #endregion - 其它 -
    }
}