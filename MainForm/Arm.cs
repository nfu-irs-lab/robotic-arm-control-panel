using RASDK.Arm;
using RASDK.Arm.Type;
using RASDK.Basic;
using System;
using System.Threading;
using System.Windows.Forms;

namespace MainForm
{
    public partial class MainForm
    {
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

        /// <summary>
        /// 清除手臂錯誤訊息。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_arm_clear_alarm_Click(object sender, EventArgs e)
        {
            // Arm.ClearAlarm();
        }
    }
}