//#define DISABLE_SHOW_MESSAGE
//#define DISABLE_FORM_CLOSING

#if (DISABLE_SHOW_MESSAGE)
#warning Message is disabled.
#endif

using RASDK.Arm;
using RASDK.Arm.Type;
using RASDK.Basic;
using RASDK.Basic.Message;
using RASDK.Gripper;
using RASDK.Vision.IDS;
using System;
using System.Collections.Generic;
using System.Threading;
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

        #region - 手臂 -

        /// <summary>
        /// 手臂控制器。
        /// </summary>
        private readonly RASDK.Arm.RoboticArm Arm;

        // #region 位置

        /// <summary>
        /// 複製目前顯示的位置到目標位置或歸零目標位置。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_arm_copy_position_from_now_to_target_Click(object sender, EventArgs e)
        {
            switch (GetPositionType())
            {
                case PositionType.Absolute:
                    SetTargetPosition(GetNowUiPosition());
                    break;

                case PositionType.Relative:
                    SetTargetPosition(new double[] { 0, 0, 0, 0, 0, 0 });
                    break;
            }
        }

        /// <summary>
        /// 更新顯示目前的動作。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_update_now_position_Click(object sender, EventArgs e)
        {
            UpdateNowPosition();
        }

        /// <summary>
        /// 取得目前顯示的位置。
        /// </summary>
        /// <returns>目前顯示的位置。</returns>
        private double[] GetNowUiPosition()
        {
            var position = new double[6];
            try
            {
                for (var i = 0; i < 6; i++)
                {
                    position[i] = Convert.ToDouble(NowPosition[i].Text);
                }
            }
            catch (Exception ex)
            {
                MessageHandler.Show(ex, LoggingLevel.Error);
            }
            return position;
        }

        /// <summary>
        /// 取得目標位置。
        /// </summary>
        /// <returns>目標位置。</returns>
        private double[] GetTargetPosition()
        {
            var position = new double[6];
            try
            {
                for (var i = 0; i < 6; i++)
                {
                    position[i] = Convert.ToDouble(TargetPosition[i].Value);
                }
            }
            catch (Exception ex)
            {
                MessageHandler.Show(ex, LoggingLevel.Error);
            }
            return position;
        }

        /// <summary>
        /// 設定目前 UI 顯示的位置。
        /// </summary>
        /// <param name="position"></param>
        private void SetNowPosition(double[] position)
        {
            if (position != null)
            {
                for (var i = 0; i < 6; i++)
                {
                    try
                    {
                        NowPosition[i].Text = Convert.ToString(position[i]);
                    }
                    catch (Exception)
                    { }
                }
            }
        }

        /// <summary>
        /// 設定目標位置。
        /// </summary>
        /// <param name="position"></param>
        private void SetTargetPosition(double[] position)
        {
            try
            {
                for (var i = 0; i < 6; i++)
                {
                    TargetPosition[i].Value = Convert.ToDecimal(position[i]);
                }
            }
            catch (Exception ex)
            {
                MessageHandler.Show(ex, LoggingLevel.Error);
            }
        }

        /// <summary>
        /// 更新目前 UI 顯示的位置。
        /// </summary>
        private void UpdateNowPosition()
        {
            SetNowPosition(Arm.GetNowPosition(GetCoordinateType()));
        }

        #endregion - 手臂 -

        #region 動作

        /// <summary>
        /// 手臂回到原點。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_arm_homing_Click(object sender, EventArgs e)
        {
            Arm.Homing(checkBox_arm_to_zero_slow.Checked, GetCoordinateType());
            UpdateNowPosition();
        }

        /// <summary>
        /// 依照目前所選之設定進行手臂動作。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_arm_motion_start_Click(object sender, EventArgs e)
        {
            switch (GetPositionType())
            {
                case PositionType.Absolute:
                    Arm.MoveAbsolute(GetTargetPosition(),
                                     new AdditionalMotionParameters
                                     {
                                         MotionType = GetMotionType(),
                                         CoordinateType = GetCoordinateType()
                                     });
                    break;

                case PositionType.Relative:
                    Arm.MoveRelative(GetTargetPosition(),
                                     new AdditionalMotionParameters
                                     {
                                         MotionType = GetMotionType(),
                                         CoordinateType = GetCoordinateType()
                                     });
                    break;

                default:
                    MessageHandler.Show("未知的位置類型。", LoggingLevel.Warn);
                    break;
            }

            UpdateNowPosition();
        }

        #endregion 動作

        #region 位置、座標、動作類型

        /// <summary>
        /// 所選的座標類型改變。
        /// </summary>
        private void CoordinateTypeChange()
        {
            if (radioButton_position_type_relative.Checked)
            {
                SetTargetPosition(new double[] { 0, 0, 0, 0, 0, 0 });
            }
            else if (Arm.Connected)
            {
                var coordinateType = GetCoordinateType();
                var nowPosition = Arm.GetNowPosition(coordinateType);
                SetTargetPosition(nowPosition);
                SetNowPosition(GetTargetPosition());
            }
            else
            {
                if (radioButton_coordinate_type_descartes.Checked)
                {
                    // TODO:
                    // SetTargetPosition(ArmController.DescartesHomePosition);
                }
                else if (radioButton_coordinate_type_joint.Checked)
                {
                    // TODO:
                    // SetTargetPosition(ArmController.JointHomePosition);
                }

                foreach (var p in NowPosition)
                {
                    p.Text = "--";
                }
            }
        }

        /// <summary>
        /// 取得目前所選的座標類型。
        /// </summary>
        /// <returns>目前所選的座標類型。</returns>
        private CoordinateType GetCoordinateType()
        {
            CoordinateType type;
            if (radioButton_coordinate_type_descartes.Checked)
            {
                type = CoordinateType.Descartes;
            }
            else if (radioButton_coordinate_type_joint.Checked)
            {
                type = CoordinateType.Joint;
            }
            else
            {
                type = CoordinateType.Unknown;
            }
            return type;
        }

        /// <summary>
        /// 取得目前所選的運動類型。
        /// </summary>
        /// <returns>目前所選的運動類型。</returns>
        private MotionType GetMotionType()
        {
            MotionType type;
            if (radioButton_motion_type_linear.Checked)
            {
                type = MotionType.Linear;
            }
            else if (radioButton_motion_type_point_to_point.Checked)
            {
                type = MotionType.PointToPoint;
            }
            else
            {
                type = MotionType.Unknown;
            }
            return type;
        }

        /// <summary>
        /// 取得目前所選的位置類型。
        /// </summary>
        /// <returns>目前所選的位置類型。</returns>
        private PositionType GetPositionType()
        {
            PositionType type;
            if (radioButton_position_type_absolute.Checked)
            {
                type = PositionType.Absolute;
            }
            else if (radioButton_position_type_relative.Checked)
            {
                type = PositionType.Relative;
            }
            else
            {
                type = PositionType.Unknown;
            }
            return type;
        }

        /// <summary>
        /// 所選的位置類型改變。
        /// </summary>
        private void PositionTypeChange()
        {
            if (radioButton_position_type_absolute.Checked)
            {
                button_arm_copy_position_from_now_to_target.Text = "複製";
                SetTargetPosition(GetNowUiPosition());
            }
            else if (radioButton_position_type_relative.Checked)
            {
                button_arm_copy_position_from_now_to_target.Text = "歸零";
                SetTargetPosition(new double[] { 0, 0, 0, 0, 0, 0 });
            }
        }

        private void radioButton_coordinate_type_descartes_CheckedChanged(object sender, EventArgs e)
        {
            CoordinateTypeChange();
        }

        private void radioButton_coordinate_type_joint_CheckedChanged(object sender, EventArgs e)
        {
            CoordinateTypeChange();
        }

        private void radioButton_position_type_absolute_CheckedChanged(object sender, EventArgs e)
        {
            PositionTypeChange();
        }

        private void radioButton_position_type_relative_CheckedChanged(object sender, EventArgs e)
        {
            PositionTypeChange();
        }

        #endregion 位置、座標、動作類型

        #region 速度與加速度

        /// <summary>
        /// 依照 UI 之數值設定手臂速度與加速度。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_set_speed_acceleration_Click(object sender, EventArgs e)
        {
            Arm.Speed = GetUiSpeed();
            Arm.Acceleration = GetUiAcceleration();

            Thread.Sleep(300);

            MessageHandler.Show($"　目前整體速度： {Arm.Speed} %\r\n" +
                         $"目前整體加速度： {Arm.Acceleration} %",
                         "速度與加速度",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.None);
        }

        /// <summary>
        /// 取得 UI 所顯示的手臂加速度。
        /// </summary>
        /// <returns>目前所顯示的手臂加速度。</returns>
        private int GetUiAcceleration()
        {
            var value = -1;
            try
            {
                value = Convert.ToInt32(numericUpDown_arm_acceleration.Value);
            }
            catch (Exception ex)
            {
                MessageHandler.Show(ex, LoggingLevel.Error);
            }
            return value;
        }

        /// <summary>
        /// 取得 UI 所顯示的手臂速度。
        /// </summary>
        /// <returns>目前所顯示的手臂速度。</returns>
        private int GetUiSpeed()
        {
            var value = -1;
            try
            {
                value = Convert.ToInt32(numericUpDown_arm_speed.Value);
            }
            catch (Exception ex)
            {
                MessageHandler.Show(ex, LoggingLevel.Error);
            }
            return value;
        }

        #endregion 速度與加速度

        #region - Others -

        /// <summary>
        /// 清除手臂錯誤訊息。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_arm_clear_alarm_Click(object sender, EventArgs e)
        {
            // Arm.ClearAlarm();
        }

        #endregion - Others -

        #region - 夾爪 -

        /// <summary>
        /// 夾爪控制器。
        /// </summary>
        private IGripperController Gripper;

        /// <summary>
        /// 進行夾爪動作。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_gripper_action_Click(object sender, EventArgs e)
        {
            Gripper.Control(Convert.ToInt32(numericUpDown_gripper_position.Value),
                            Convert.ToInt32(numericUpDown_gripper_speed.Value),
                            Convert.ToInt32(numericUpDown_gripper_force.Value));
        }

        /// <summary>
        /// 重置夾爪。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_gripper_reset_Click(object sender, EventArgs e)
        {
            Gripper.Reset();
        }

        #endregion - 夾爪 -

        #region - 連線與斷線 -

        /// <summary>
        /// 進行連線。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_connect_Click(object sender, EventArgs e)
        {
            MessageHandler.Log("Connect click", LoggingLevel.Trace);

            for (var i = 0; i < Devices.Count; i++)
            {
                Devices[i].Connect();
            }

            if (Arm.Connected)
            {
                Arm.Speed = GetUiSpeed();
                Arm.Acceleration = GetUiAcceleration();
                UpdateNowPosition();

                SetButtonsState(true);
            }
        }

        /// <summary>
        /// 進行斷線。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_disconnect_Click(object sender, EventArgs e)
        {
            MessageHandler.Log("Disconnect click", LoggingLevel.Trace);

            for (var i = 0; i < Devices.Count; i++)
            {
                Devices[i].Disconnect();
            }

            SetButtonsState(false);
        }

        #endregion - 連線與斷線 -

        #region - 位置記錄 -

        /// <summary>
        /// 位置記錄。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_position_recode_Click(object sender, EventArgs e)
        {
            // PositionHandler.Record(textBox_position_record_name.Text,
            //                        GetCoordinateType(),
            //                        GetNowUiPosition(),
            //                        textBox_position_record_comment.Text);
        }

        private void button_position_record_read_Click(object sender, EventArgs e)
        {
            // var type = PositionHandler.GetPositionType();
            // switch (type)
            // {
            //     case CoordinateType.Descartes:
            //         radioButton_coordinate_type_descartes.Checked = true;
            //         break;
            //
            //     case CoordinateType.Joint:
            //         radioButton_coordinate_type_joint.Checked = true;
            //         break;
            //
            //     default:
            //         Message.Show("錯誤的座標類型。", LoggingLevel.Error);
            //         return;
            // }
            //
            // SetTargetPosition(PositionHandler.GetPosition());
            // radioButton_position_type_absolute.Checked = true;
        }

        private void button_position_record_update_list_Click(object sender, EventArgs e)
        {
            // PositionHandler.UpdateFileList();
        }

        private void comboBox_position_record_file_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            // PositionHandler.UpdateListData(comboBox_position_record_file_list.SelectedItem.ToString());
        }

        #endregion - 位置記錄 -

        #region - 動作流程 -

        // TODO:

        /// <summary>
        /// 動作流程。
        /// </summary>
        // private IActionFlowHandler ActionFlow = null;

        private void button_actionflow_do_all_Click(object sender, EventArgs e)
        {
            // ActionFlow.DoEach();
        }

        private void button_actionflow_do_selected_Click(object sender, EventArgs e)
        {
            // ActionFlow.DoSelected();
        }

        private void checkBox_actionflow_autoNext_CheckedChanged(object sender, EventArgs e)
        {
            // ActionFlow.AutoNextAction = checkBox_actionflow_autoNext.Checked;
        }

        private void checkBox_actionflow_showMsg_CheckedChanged(object sender, EventArgs e)
        {
            // ActionFlow.ShowMessageBeforeAction = checkBox_actionflow_showMsg.Checked;
        }

        #endregion - 動作流程 -

        #region - 寸動微調 -

        #region X

        private void button_inching_negative_x_MouseDown(object sender, MouseEventArgs e)
            => InchingStart(-Convert.ToDouble(numericUpDown_inching_xy.Value), 0);

        private void button_inching_negative_x_MouseUp(object sender, MouseEventArgs e)
            => InchingStop();

        private void button_inching_positive_x_MouseDown(object sender, MouseEventArgs e)
            => InchingStart(Convert.ToDouble(numericUpDown_inching_xy.Value), 0);

        private void button_inching_positive_x_MouseUp(object sender, MouseEventArgs e)
            => InchingStop();

        #endregion X

        #region Y

        private void button_inching_negative_y_MouseDown(object sender, MouseEventArgs e)
            => InchingStart(-Convert.ToDouble(numericUpDown_inching_xy.Value), 1);

        private void button_inching_negative_y_MouseUp(object sender, MouseEventArgs e)
            => InchingStop();

        private void button_inching_positive_y_MouseDown(object sender, MouseEventArgs e)
            => InchingStart(Convert.ToDouble(numericUpDown_inching_xy.Value), 1);

        private void button_inching_positive_y_MouseUp(object sender, MouseEventArgs e)
            => InchingStop();

        #endregion Y

        #region Z

        private void button_inching_negative_z_MouseDown(object sender, MouseEventArgs e)
            => InchingStart(-Convert.ToDouble(numericUpDown_inching_z.Value), 2);

        private void button_inching_negative_z_MouseUp(object sender, MouseEventArgs e)
            => InchingStop();

        private void button_inching_positive_z_MouseDown(object sender, MouseEventArgs e)
            => InchingStart(Convert.ToDouble(numericUpDown_inching_z.Value), 2);

        private void button_inching_positive_z_MouseUp(object sender, MouseEventArgs e)
            => InchingStop();

        #endregion Z

        /// <summary>
        /// X/J1=0, Y/J2=1 ... C/J6=5.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="indexOfAxis"></param>
        private void InchingStart(double value, int indexOfAxis)
        {
            if (radioButtonInchingModeContinuousWide.Checked)
            {
                var dir = value >= 0 ? '+' : '-';
                Arm.Jog($"{dir}{indexOfAxis}");
            }
            else
            {
                var pos = new double[] { 0, 0, 0, 0, 0, 0 };
                bool wait = true;

                if (radioButtonInchingModeSingle.Checked)
                {
                    pos[indexOfAxis] = value;
                    wait = true;
                }
                else if (radioButtonInchingModeContinuousNarrow.Checked)
                {
                    pos[indexOfAxis] = value;
                    wait = false;
                }

                Arm.MoveRelative(pos,
                                 new AdditionalMotionParameters
                                 {
                                     NeedWait = wait,
                                     CoordinateType = CoordinateType.Descartes,
                                     MotionType = MotionType.Linear
                                 });
            }
        }

        private void InchingStop()
        {
            Arm.Abort();
            Thread.Sleep(150);
            UpdateNowPosition();
        }

        #endregion - 寸動微調 -

        #region - 攝影機 -

        private IDSCamera Camera;

        private void button_camera_choose_Click(object sender, EventArgs e)
        {
            Camera.ChooseCamera();
        }

        private void button_camera_close_Click(object sender, EventArgs e)
        {
            Camera.Disconnect();
        }

        private void button_camera_open_Click(object sender, EventArgs e)
        {
            Camera.Init();
            var mode = checkBox_camera_freerun.Checked ? CaptureMode.FreeRun : CaptureMode.Stop;
            // Camera.Open(mode);
            Camera.Connect();
        }

        private void button_camera_setting_Click(object sender, EventArgs e)
        {
            Camera.ShowSettingForm();
        }

        private void button_camera_snapshot_Click(object sender, EventArgs e)
        {
            checkBox_camera_freerun.Checked = false;
            Camera.ChangeCaptureMode(CaptureMode.Snapshot);
        }

        private void checkBox_camera_freerun_CheckedChanged(object sender, EventArgs e)
        {
            var mode = checkBox_camera_freerun.Checked ? CaptureMode.FreeRun : CaptureMode.Stop;
            Camera.ChangeCaptureMode(mode);
        }

        #endregion - 攝影機 -

        #region - 其它 -

        /// <summary>
        /// 未連線時禁用的按鈕組。
        /// </summary>
        private readonly List<Button> Buttons;

        /// <summary>
        /// 連線裝置組。
        /// </summary>
        private  List<IDevice> Devices = new List<IDevice>();

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

        #endregion - 其它 -
    }
}