using RASDK.Arm;
using RASDK.Arm.Type;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace MainForm
{
    public partial class MainForm
    {
        /// <summary>
        /// X/J1=0, Y/J2=1 ... C/J6=5.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="indexOfAxis"></param>
        private void JogStart(double value, int indexOfAxis)
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

        private void JogStop()
        {
            Arm.Abort();
            Thread.Sleep(150);
            UpdateNowPosition();
        }

        #region X

        private void button_inching_negative_x_MouseDown(object sender, MouseEventArgs e)
            => JogStart(-Convert.ToDouble(numericUpDown_inching_xy.Value), 0);

        private void button_inching_negative_x_MouseUp(object sender, MouseEventArgs e)
            => JogStop();

        private void button_inching_positive_x_MouseDown(object sender, MouseEventArgs e)
            => JogStart(Convert.ToDouble(numericUpDown_inching_xy.Value), 0);

        private void button_inching_positive_x_MouseUp(object sender, MouseEventArgs e)
            => JogStop();

        #endregion X

        #region Y

        private void button_inching_negative_y_MouseDown(object sender, MouseEventArgs e)
            => JogStart(-Convert.ToDouble(numericUpDown_inching_xy.Value), 1);

        private void button_inching_negative_y_MouseUp(object sender, MouseEventArgs e)
            => JogStop();

        private void button_inching_positive_y_MouseDown(object sender, MouseEventArgs e)
            => JogStart(Convert.ToDouble(numericUpDown_inching_xy.Value), 1);

        private void button_inching_positive_y_MouseUp(object sender, MouseEventArgs e)
            => JogStop();

        #endregion Y

        #region Z

        private void button_inching_negative_z_MouseDown(object sender, MouseEventArgs e)
            => JogStart(-Convert.ToDouble(numericUpDown_inching_z.Value), 2);

        private void button_inching_negative_z_MouseUp(object sender, MouseEventArgs e)
            => JogStop();

        private void button_inching_positive_z_MouseDown(object sender, MouseEventArgs e)
            => JogStart(Convert.ToDouble(numericUpDown_inching_z.Value), 2);

        private void button_inching_positive_z_MouseUp(object sender, MouseEventArgs e)
            => JogStop();

        #endregion Z
    }
}
