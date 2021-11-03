using RASDK.Gripper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public partial class MainForm
    {
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
    }
}
