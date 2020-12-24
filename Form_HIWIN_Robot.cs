using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace HIWIN_Robot
{
    /// <summary>
    /// 【 上銀機器手臂控制 範例程式 】<br/>
    /// HIWIN Robot Control<br/>
    /// <br/>
    /// 最後更新日期：2020/July/24
    /// </summary>
    public partial class Form_HIWIN_Robot : Form
    {
        public Form_HIWIN_Robot()
        {
            InitializeComponent();

            init_control_collection();
        }

        #region - 手臂 -

        /// <summary>
        /// 手臂控制。
        /// </summary>
        private ArmControl arm = new ArmControl(Configuration.armIP);

        #region 位置

        /// <summary>
        /// 目前顯示位置的控制項陣列。
        /// </summary>
        private List<TextBox> positino_now = new List<TextBox>();

        /// <summary>
        /// 目標位置的控制項陣列。
        /// </summary>
        private List<NumericUpDown> positino_target = new List<NumericUpDown>();

        /// <summary>
        /// 複製目前顯示的位置到目標位置。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_arm_copy_position_from_now_to_target_Click(object sender, EventArgs e)
        {
            set_postion_target(get_postion_now());
        }

        /// <summary>
        /// 取得目前顯示的位置。
        /// </summary>
        /// <returns>目前顯示的位置。</returns>
        private double[] get_postion_now()
        {
            double[] position = new double[6];
            try
            {
                for (int i = 0; i < 6; i++)
                {
                    position[i] = Convert.ToDouble(positino_now[i].Text);
                }
            }
            catch (Exception ex)
            {
                show_error_messages(ex);
            }
            return position;
        }

        /// <summary>
        /// 取得目標位置。
        /// </summary>
        /// <returns>目標位置。</returns>
        private double[] get_postion_target()
        {
            double[] position = new double[6];
            try
            {
                for (int i = 0; i < 6; i++)
                {
                    position[i] = Convert.ToDouble(positino_target[i].Value);
                }
            }
            catch (Exception ex)
            {
                show_error_messages(ex);
            }
            return position;
        }

        /// <summary>
        /// 初始化控制項集合。
        /// </summary>
        private void init_control_collection()
        {
            positino_target.Clear();
            positino_target.Add(this.numericUpDown_arm_target_position_j1x);
            positino_target.Add(this.numericUpDown_arm_target_position_j2y);
            positino_target.Add(this.numericUpDown_arm_target_position_j3z);
            positino_target.Add(this.numericUpDown_arm_target_position_j4a);
            positino_target.Add(this.numericUpDown_arm_target_position_j5b);
            positino_target.Add(this.numericUpDown_arm_target_position_j6c);

            positino_now.Clear();
            positino_now.Add(this.textBox_arm_now_position_j1x);
            positino_now.Add(this.textBox_arm_now_position_j2y);
            positino_now.Add(this.textBox_arm_now_position_j3z);
            positino_now.Add(this.textBox_arm_now_position_j4a);
            positino_now.Add(this.textBox_arm_now_position_j5b);
            positino_now.Add(this.textBox_arm_now_position_j6c);
        }

        /// <summary>
        /// 設定目前顯示的位置。
        /// </summary>
        /// <param name="new_position"></param>
        private void set_postion_now(double[] new_position)
        {
            for (int i = 0; i < 6; i++)
            {
                positino_now[i].Text = Convert.ToString(new_position[i]);
            }
        }

        /// <summary>
        /// 設定目標位置。
        /// </summary>
        /// <param name="new_position"></param>
        private void set_postion_target(double[] new_position)
        {
            try
            {
                for (int i = 0; i < 6; i++)
                {
                    positino_target[i].Value = Convert.ToDecimal(new_position[i]);
                }
            }
            catch (Exception ex)
            {
                show_error_messages(ex);
            }
        }

        /// <summary>
        /// 更新目前顯示的位置。
        /// </summary>
        private void update_now_position()
        {
            set_postion_now(arm.GetNowPosition(get_positino_type()));
        }

        #endregion 位置

        #region 動作

        /// <summary>
        /// 依照目前所選之設定進行手臂動作。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_arm_motion_start_Click(object sender, EventArgs e)
        {
            switch (get_motion_type())
            {
                case ArmControl.MotionType.linear:
                    arm.MotionLinear(get_postion_target(), get_positino_type(), get_coordinate_type());
                    break;

                case ArmControl.MotionType.pointToPoint:
                    arm.MotionPointToPoint(get_postion_target(), get_positino_type(), get_coordinate_type());
                    break;

                default:
                    MessageBox.Show("未知的運動類型。", "錯誤！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            update_now_position();
        }

        /// <summary>
        /// 手臂回到原點。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_arm_to_zero_Click(object sender, EventArgs e)
        {
            if (checkBox_arm_to_zero_slow.Checked)
            {
                arm.SetSpeed(5);
                arm.SetAcceletarion(10);

                Thread.Sleep(300);

                arm.GoHome(get_positino_type());
                update_now_position();

                arm.SetSpeed(get_speed());
                arm.SetAcceletarion(get_asseleration());
            }
            else
            {
                arm.GoHome(get_positino_type());
                update_now_position();
            }
        }

        /// <summary>
        /// 更新顯示目前的動作。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_update_now_position_Click(object sender, EventArgs e)
        {
            update_now_position();
        }

        #region 位置、坐標、動作類型

        /// <summary>
        /// 所選的坐標類型改變。
        /// </summary>
        private void coorrdinate_type_change()
        {
            if (radioButton_coordinate_type_absolute.Checked)
            {
                set_postion_target(get_postion_now());
            }
            else if (radioButton_coordinate_type_relative.Checked)
            {
                double[] position = new double[6] { 0, 0, 0, 0, 0, 0 };
                set_postion_target(position);
            }
        }

        /// <summary>
        /// 取得目前所選的坐標類型。
        /// </summary>
        /// <returns>目前所選的坐標類型。</returns>
        private ArmControl.CoordinateType get_coordinate_type()
        {
            ArmControl.CoordinateType type = ArmControl.CoordinateType.unknown;
            if (radioButton_coordinate_type_absolute.Checked)
            {
                type = ArmControl.CoordinateType.absolute;
            }
            else if (radioButton_coordinate_type_relative.Checked)
            {
                type = ArmControl.CoordinateType.relative;
            }
            else
            {
                type = ArmControl.CoordinateType.unknown;
            }
            return type;
        }

        /// <summary>
        /// 取得目前所選的運動類型。
        /// </summary>
        /// <returns>目前所選的運動類型。</returns>
        private ArmControl.MotionType get_motion_type()
        {
            ArmControl.MotionType type = ArmControl.MotionType.unknown;
            if (radioButton_motion_type_linear.Checked)
            {
                type = ArmControl.MotionType.linear;
            }
            else if (radioButton_motion_type_point_to_point.Checked)
            {
                type = ArmControl.MotionType.pointToPoint;
            }
            else
            {
                type = ArmControl.MotionType.unknown;
            }
            return type;
        }

        /// <summary>
        /// 取得目前所選的位置類型。
        /// </summary>
        /// <returns>目前所選的位置類型。</returns>
        private ArmControl.PositionType get_positino_type()
        {
            ArmControl.PositionType type = ArmControl.PositionType.unknown;
            if (radioButton_position_type_descartes.Checked)
            {
                type = ArmControl.PositionType.descartes;
            }
            else if (radioButton_position_type_joint.Checked)
            {
                type = ArmControl.PositionType.joint;
            }
            else
            {
                type = ArmControl.PositionType.unknown;
            }
            return type;
        }

        /// <summary>
        /// 所選的位置類型改變。
        /// </summary>
        private void position_type_change()
        {
            if (arm.IsConnect())
            {
                if (radioButton_position_type_descartes.Checked)
                {
                    set_postion_target(arm.GetNowPosition(ArmControl.PositionType.descartes));
                }
                else if (radioButton_position_type_joint.Checked)
                {
                    set_postion_target(arm.GetNowPosition(ArmControl.PositionType.joint));
                }
            }
            else
            {
                if (radioButton_position_type_descartes.Checked)
                {
                    double[] postion = { 0, 368, 294, 180, 0, 90 };
                    set_postion_target(postion);
                }
                else if (radioButton_position_type_joint.Checked)
                {
                    double[] postion = { 0, 0, 0, 0, 0, 0 };
                    set_postion_target(postion);
                }
            }
        }

        private void radioButton_coordinate_type_absolute_CheckedChanged(object sender, EventArgs e)
        {
            coorrdinate_type_change();
        }

        private void radioButton_coordinate_type_relative_CheckedChanged(object sender, EventArgs e)
        {
            coorrdinate_type_change();
        }

        private void radioButton_position_type_descartes_CheckedChanged(object sender, EventArgs e)
        {
            position_type_change();
        }

        private void radioButton_position_type_joint_CheckedChanged(object sender, EventArgs e)
        {
            position_type_change();
        }

        #endregion 位置、坐標、動作類型

        #endregion 動作

        #region - 速度與加速度 -

        /// <summary>
        /// 依照設定之數值設定手臂速度與加速度。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_set_speed_acceleration_Click(object sender, EventArgs e)
        {
            arm.SetSpeed(get_speed());
            arm.SetAcceletarion(get_asseleration());

            Thread.Sleep(300);

            MessageBox.Show("　目前速度：" + arm.GetSpeed().ToString() + " %\r\n" +
                            "目前加速度：" + arm.GetSpeed().ToString() + " %");
        }

        /// <summary>
        /// 取得所顯示的手臂加速度。
        /// </summary>
        /// <returns>目前所顯示的手臂加速度。</returns>
        private int get_asseleration()
        {
            int value = -1;
            try
            {
                value = Convert.ToInt32(numericUpDown_arm_acceleration.Value);
            }
            catch (Exception ex)
            {
                show_error_messages(ex);
            }
            return value;
        }

        /// <summary>
        /// 取得目前所顯示的手臂速度。
        /// </summary>
        /// <returns>目前所顯示的手臂速度。</returns>
        private int get_speed()
        {
            int value = -1;
            try
            {
                value = Convert.ToInt32(numericUpDown_arm_speed.Value);
            }
            catch (Exception ex)
            {
                show_error_messages(ex);
            }
            return value;
        }

        #endregion - 速度與加速度 -

        #endregion - 手臂 -

        #region - 夾爪 -

        /// <summary>
        /// 夾爪控制。
        /// </summary>
        private GripperControl XEG32 = new GripperControl(Configuration.gripperCOMPort);

        /// <summary>
        /// 進行夾爪動作。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_gripper_action_Click(object sender, EventArgs e)
        {
            XEG32.control(Convert.ToInt32(numericUpDown_gripper_position.Value),
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
            XEG32.reset();
        }

        #endregion - 夾爪 -

        #region - 連線與斷線 -

        /// <summary>
        /// 清除手臂錯誤訊息。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_arm_clear_alarm_Click(object sender, EventArgs e)
        {
            arm.ClearAlarm();
        }

        /// <summary>
        /// 進行連線。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_connect_Click(object sender, EventArgs e)
        {
            arm.Connect();
            if (arm.IsConnect())
            {
                arm.SetSpeed(get_speed());
                arm.SetAcceletarion(get_asseleration());
                update_now_position();
            }
            XEG32.connect();
        }

        /// <summary>
        /// 進行斷線。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_disconnect_Click(object sender, EventArgs e)
        {
            arm.Disconnect();

            XEG32.disconnect();
        }

        #endregion - 連線與斷線 -

        #region - 其它 -

        /// <summary>
        /// 視窗關閉事件。
        /// </summary>
        private void Form_HIWIN_Robot_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (arm.IsConnect() || XEG32.is_connected())
            {
                DialogResult dr = MessageBox.Show("手臂或夾爪似乎還在連線中。\r\n是否要斷開連線後關閉視窗？",
                                                  "關閉視窗",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    arm.Disconnect();
                    XEG32.disconnect();
                    e.Cancel = false;
                }
                else if (dr == DialogResult.No)
                {
                    e.Cancel = false;
                }
                else if (dr == DialogResult.Cancel)
                {
                    // 取消視窗關閉事件。
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// 顯示例外狀況錯誤訊息。
        /// </summary>
        /// <param name="ex"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void show_error_messages(Exception ex)
        {
            MessageBox.Show("出現錯誤：" + ex.Message + "\r\n\r\n" + ex.StackTrace,
                            "錯誤！",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        #endregion - 其它 -
    }
}