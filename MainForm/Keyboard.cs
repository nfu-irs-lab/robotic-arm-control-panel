//#define DISABLE_KEYBOARD_CONTROL

using System;
using System.Windows.Forms;

namespace MainForm
{
    public partial class MainForm
    {
        /// <summary>
        /// 鍵盤控制。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
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
#endif // (!DISABLE_KEYBOARD_CONTROL)
        }
    }
}
