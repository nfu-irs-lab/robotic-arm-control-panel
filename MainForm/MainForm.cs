//#define DISABLE_SHOW_MESSAGE
//#define DISABLE_FORM_CLOSING
//#define DISABLE_KEYBOARD_CONTROL

#if (DISABLE_SHOW_MESSAGE)
#warning Message is disabled.
#endif

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Features;
using Contest;

namespace MainForm
{
    /// <summary>
    /// 【 上銀機器手臂控制程式 】<br/>
    /// HIWIN Robot Control
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitBasic();
        }

        #region - 手臂 -

        /// <summary>
        /// 手臂控制器。
        /// </summary>
        private IArmController Arm = null;

        #region 位置

        /// <summary>
        /// 複製目前顯示的位置到目標位置或歸零目標位置。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_arm_copy_position_from_now_to_target_Click(object sender, EventArgs e)
        {
            var type = GetCoordinateType();
            switch (type)
            {
                case CoordinateType.Absolute:
                    SetTargetPosition(GetNowUiPosition());
                    break;

                case CoordinateType.Relative:
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
            catch (FormatException)
            {
                var type = GetPositionType();
                switch (type)
                {
                    case PositionType.Descartes:
                        position = Arm.DescartesHomePosition;
                        break;

                    case PositionType.Joint:
                        position = Arm.JointHomePosition;
                        break;
                }
            }
            catch (Exception ex)
            {
                Message.Show(ex, LoggingLevel.Error);
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
                Message.Show(ex, LoggingLevel.Error);
            }
            return position;
        }

        /// <summary>
        /// 設定目前 UI 顯示的位置。
        /// </summary>
        /// <param name="position"></param>
        private void SetNowPosition(double[] position)
        {
            for (var i = 0; i < 6; i++)
            {
                NowPosition[i].Text = Convert.ToString(position[i]);
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
                Message.Show(ex, LoggingLevel.Error);
            }
        }

        /// <summary>
        /// 更新目前 UI 顯示的位置。
        /// </summary>
        private void UpdateNowPosition()
        {
            SetNowPosition(Arm.GetPosition(GetPositionType()));
        }

        #endregion 位置

        #region 動作

        /// <summary>
        /// 手臂回到原點。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_arm_homing_Click(object sender, EventArgs e)
        {
            if (checkBox_arm_to_zero_slow.Checked)
            {
                Arm.Speed = 5;
                Arm.Acceleration = 10;

                Thread.Sleep(300);

                Arm.Homing(GetPositionType(), true);
                UpdateNowPosition();

                Arm.Speed = GetUiSpeed();
                Arm.Acceleration = GetUiAcceleration();
            }
            else
            {
                Arm.Homing(GetPositionType(), true);
                UpdateNowPosition();
            }
        }

        /// <summary>
        /// 依照目前所選之設定進行手臂動作。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_arm_motion_start_Click(object sender, EventArgs e)
        {
            switch (GetMotionType())
            {
                case MotionType.Linear:
                    Arm.MoveLinear(GetTargetPosition(),
                                   GetCoordinateType(),
                                   GetPositionType());
                    break;

                case MotionType.PointToPoint:
                    Arm.MovePointToPoint(GetTargetPosition(),
                                         GetCoordinateType(),
                                         GetPositionType());
                    break;

                default:
                    Message.Show("未知的運動類型。", LoggingLevel.Warn);
                    break;
            }

            UpdateNowPosition();
        }

        #endregion 動作

        #region 位置、坐標、動作類型

        /// <summary>
        /// 所選的坐標類型改變。
        /// </summary>
        private void CoordinateTypeChange()
        {
            if (radioButton_coordinate_type_absolute.Checked)
            {
                button_arm_copy_position_from_now_to_target.Text = "複製";
                SetTargetPosition(GetNowUiPosition());
            }
            else if (radioButton_coordinate_type_relative.Checked)
            {
                button_arm_copy_position_from_now_to_target.Text = "歸零";
                SetTargetPosition(new double[] { 0, 0, 0, 0, 0, 0 });
            }
        }

        /// <summary>
        /// 取得目前所選的坐標類型。
        /// </summary>
        /// <returns>目前所選的坐標類型。</returns>
        private CoordinateType GetCoordinateType()
        {
            CoordinateType type;
            if (radioButton_coordinate_type_absolute.Checked)
            {
                type = CoordinateType.Absolute;
            }
            else if (radioButton_coordinate_type_relative.Checked)
            {
                type = CoordinateType.Relative;
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
            if (radioButton_position_type_descartes.Checked)
            {
                type = PositionType.Descartes;
            }
            else if (radioButton_position_type_joint.Checked)
            {
                type = PositionType.Joint;
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
            if (radioButton_coordinate_type_relative.Checked)
            {
                SetTargetPosition(new double[] { 0, 0, 0, 0, 0, 0 });
            }
            else if (Arm.Connected)
            {
                var positionType = GetPositionType();
                var nowPosition = Arm.GetPosition(positionType);
                SetTargetPosition(nowPosition);
                SetNowPosition(GetTargetPosition());
            }
            else
            {
                if (radioButton_position_type_descartes.Checked)
                {
                    SetTargetPosition(Arm.DescartesHomePosition);
                }
                else if (radioButton_position_type_joint.Checked)
                {
                    SetTargetPosition(Arm.JointHomePosition);
                }

                foreach (var p in NowPosition)
                {
                    p.Text = "--";
                }
            }
        }

        private void radioButton_coordinate_type_absolute_CheckedChanged(object sender, EventArgs e)
        {
            CoordinateTypeChange();
        }

        private void radioButton_coordinate_type_relative_CheckedChanged(object sender, EventArgs e)
        {
            CoordinateTypeChange();
        }

        private void radioButton_position_type_descartes_CheckedChanged(object sender, EventArgs e)
        {
            PositionTypeChange();
        }

        private void radioButton_position_type_joint_CheckedChanged(object sender, EventArgs e)
        {
            PositionTypeChange();
        }

        #endregion 位置、坐標、動作類型

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

            Message.Show($"　目前整體速度： {Arm.Speed} %\r\n" +
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
                Message.Show(ex, LoggingLevel.Error);
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
                Message.Show(ex, LoggingLevel.Error);
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
            Arm.ClearAlarm();
        }

        #endregion - Others -

        #endregion - 手臂 -

        #region - 夾爪 -

        /// <summary>
        /// 夾爪控制器。
        /// </summary>
        private IGripperController Gripper = null;

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
            Message.Log("Connect click", LoggingLevel.Trace);

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
            Message.Log("Disconnect click", LoggingLevel.Trace);

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
            PositionHandler.Record(textBox_position_record_name.Text,
                                   GetPositionType(),
                                   GetNowUiPosition(),
                                   textBox_position_record_comment.Text);
        }

        private void button_position_record_read_Click(object sender, EventArgs e)
        {
            var type = PositionHandler.GetPositionType();
            switch (type)
            {
                case PositionType.Descartes:
                    radioButton_position_type_descartes.Checked = true;
                    break;

                case PositionType.Joint:
                    radioButton_position_type_joint.Checked = true;
                    break;

                default:
                    Message.Show("錯誤的位置類型。", LoggingLevel.Error);
                    return;
            }

            SetTargetPosition(PositionHandler.GetPosition());
            radioButton_coordinate_type_absolute.Checked = true;
        }

        private void button_position_record_update_list_Click(object sender, EventArgs e)
        {
            PositionHandler.UpdateFileList();
        }

        private void comboBox_position_record_file_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            PositionHandler.UpdateListData(comboBox_position_record_file_list.SelectedItem.ToString());
        }

        #endregion - 位置記錄 -

        #region - 動作流程 -

        /// <summary>
        /// 動作流程。
        /// </summary>
        private IActionFlowHandler ActionFlow = null;

        private void button_actionflow_do_all_Click(object sender, EventArgs e)
        {
            ActionFlow.DoEach();
        }

        private void button_actionflow_do_selected_Click(object sender, EventArgs e)
        {
            var index = listView_actionflow_actions.SelectedItems[0].Index;
            ActionFlow.Do(index);
        }

        #endregion - 動作流程 -

        #region - 其它 -

        private Behavior Behavior = null;

        /// <summary>
        /// 手臂藍牙控制器。
        /// </summary>
        private IBluetoothController Bluetooth = null;

        /// <summary>
        /// 未連線時禁用的按鈕組。
        /// </summary>
        private readonly List<Button> Buttons = new List<Button>();

        /// <summary>
        /// CSV 檔處理器。
        /// </summary>
        private ICsvHandler CsvHandler = null;

        /// <summary>
        /// 連線裝置組。
        /// </summary>
        private readonly List<IDevice> Devices = new List<IDevice>();

        /// <summary>
        /// Log 檔處理器。
        /// </summary>
        private ILogHandler LogHandler = null;

        /// <summary>
        /// 訊息處理器。
        /// </summary>
        private IMessage Message = null;

        /// <summary>
        /// UI 目前顯示位置的控制項陣列。
        /// </summary>
        private readonly List<TextBox> NowPosition = new List<TextBox>();

        /// <summary>
        /// 位置記錄處理器。
        /// </summary>
        private IPositionHandler PositionHandler = null;

        /// <summary>
        /// UI 目標位置的控制項陣列。
        /// </summary>
        private readonly List<NumericUpDown> TargetPosition = new List<NumericUpDown>();

        /// <summary>
        /// 視窗關閉事件。
        /// </summary>
        private void Form_HIWIN_Robot_FormClosing(object sender, FormClosingEventArgs e)
        {
#if (!DISABLE_FORM_CLOSING)
            foreach (var d in Devices)
            {
                if (d.Connected)
                {
                    var dr = Message.Show("手臂或其它裝置似乎還在連線中。\r\n是否要斷開連線後關閉視窗？",
                                          "關閉視窗",
                                          MessageBoxButtons.YesNoCancel,
                                          MessageBoxIcon.Warning,
                                          LoggingLevel.Warn);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            button_disconnect.PerformClick();
                            e.Cancel = false;
                            break;

                        case DialogResult.No:
                            e.Cancel = false;
                            break;

                        case DialogResult.Cancel:
                            // 取消視窗關閉事件。
                            e.Cancel = true;
                            break;
                    }
                    break;
                }
            }
#endif
        }

        /// <summary>
        /// 鍵盤控制。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_HIWIN_Robot_KeyDown(object sender, KeyEventArgs e)
        {
#if (!DISABLE_KEYBOARD_CONTROL)
            switch (e.KeyCode)
            {
                // F1: 選擇 J1/X 數字欄。
                case Keys.F1:
                    if (TargetPosition[0].Focused)
                    {
                        TargetPosition[0].ResetText();
                    }
                    else
                    {
                        TargetPosition[0].Focus();
                    }
                    break;

                // F2: 選擇 J2/Y 數字欄。
                case Keys.F2:
                    if (TargetPosition[1].Focused)
                    {
                        TargetPosition[1].ResetText();
                    }
                    else
                    {
                        TargetPosition[1].Focus();
                    }
                    break;

                // F3: 選擇 J3/Z 數字欄。
                case Keys.F3:
                    if (TargetPosition[2].Focused)
                    {
                        TargetPosition[2].ResetText();
                    }
                    else
                    {
                        TargetPosition[2].Focus();
                    }
                    break;

                // F4: 執行「進行動作」。
                case Keys.F4:
                    button_arm_motion_start.PerformClick();
                    break;

                // F5: 更新目前位置。
                case Keys.F5:
                    UpdateNowPosition();
                    break;

                // F6: 執行「複製目前位置到目標位置/歸零目標位置」。
                case Keys.F6:
                    button_arm_copy_position_from_now_to_target.PerformClick();
                    break;

                // PageUp: 增加數值。
                case Keys.PageUp:
                    for (int i = 0; i < TargetPosition.Count; i++)
                    {
                        if (TargetPosition[i].Focused)
                        {
                            decimal value;
                            if (!e.Control && e.Shift && !e.Alt)
                            {
                                value = 1;
                            }
                            else if (!e.Control && !e.Shift && e.Alt)
                            {
                                value = (decimal)0.1;
                            }
                            else if (!e.Control && e.Shift && e.Alt)
                            {
                                value = (decimal)0.05;
                            }
                            else
                            {
                                value = 10;
                            }
                            TargetPosition[i].Value += value;
                            break;
                        }
                    }
                    break;

                // PageDown: 減少數值。
                case Keys.PageDown:
                    for (int i = 0; i < TargetPosition.Count; i++)
                    {
                        if (TargetPosition[i].Focused)
                        {
                            decimal value;
                            if (!e.Control && e.Shift && !e.Alt)
                            {
                                value = 1;
                            }
                            else if (!e.Control && !e.Shift && e.Alt)
                            {
                                value = (decimal)0.1;
                            }
                            else if (!e.Control && e.Shift && e.Alt)
                            {
                                value = (decimal)0.05;
                            }
                            else
                            {
                                value = 10;
                            }
                            TargetPosition[i].Value -= value;
                            break;
                        }
                    }
                    break;

                // Home: 執行「手臂回到原點」。
                case Keys.Home:
                    button_arm_homing.PerformClick();
                    break;

                // End: 執行「連線或斷線」。
                case Keys.End:
                    if (Arm.Connected)
                    {
                        button_disconnect.PerformClick();
                    }
                    else
                    {
                        button_connect.PerformClick();
                    }
                    break;

                default:
                    break;
            }
#endif
        }

        /// <summary>
        /// 基本初始化。
        /// </summary>
        private void InitBasic()
        {
            // 目標位置控制項集合。
            TargetPosition.Clear();
            TargetPosition.Add(numericUpDown_arm_target_position_j1x);
            TargetPosition.Add(numericUpDown_arm_target_position_j2y);
            TargetPosition.Add(numericUpDown_arm_target_position_j3z);
            TargetPosition.Add(numericUpDown_arm_target_position_j4a);
            TargetPosition.Add(numericUpDown_arm_target_position_j5b);
            TargetPosition.Add(numericUpDown_arm_target_position_j6c);

            // 目前位置控制項集合。
            NowPosition.Clear();
            NowPosition.Add(textBox_arm_now_position_j1x);
            NowPosition.Add(textBox_arm_now_position_j2y);
            NowPosition.Add(textBox_arm_now_position_j3z);
            NowPosition.Add(textBox_arm_now_position_j4a);
            NowPosition.Add(textBox_arm_now_position_j5b);
            NowPosition.Add(textBox_arm_now_position_j6c);

            // 未連線時禁用之按鈕集合。
            Buttons.Clear();
            Buttons.Add(button_arm_homing);
            Buttons.Add(button_arm_clear_alarm);
            Buttons.Add(button_update_now_position);
            Buttons.Add(button_arm_motion_start);
            Buttons.Add(button_set_speed_acceleration);

            // 物件具象化，依賴注入。
            LogHandler = new LogHandler(Configuration.LogFilePath, LoggingLevel.Trace);
            Message = new NormalMessage(LogHandler);
            Arm = new ArmController(Configuration.ArmIp, Message);
            Gripper = new GripperController(Configuration.GripperComPort, Message);
            Bluetooth = new BluetoothArmController(Configuration.BluetoothComPort, Arm, Message);
            CsvHandler = new CsvHandler(Configuration.CsvFilePath);
            ActionFlow = new ActionFlowHandler(listView_actionflow_actions, Message);
            PositionHandler = new PositionHandler(listView_position_record,
                                                  comboBox_position_record_file_list,
                                                  CsvHandler,
                                                  Message);
            Behavior = new Behavior(new MainFormDependency()
            {
                PositionHandler = PositionHandler,
                ActionFlowHandler = ActionFlow,
                ArmController = Arm,
                GripperController = Gripper,
                BluetoothController = Bluetooth,
                Message = Message,
                Devices = Devices
            });

            // 未與手臂連線，禁用部分按鈕。
            SetButtonsState(false);

            PositionHandler.UpdateFileList();
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