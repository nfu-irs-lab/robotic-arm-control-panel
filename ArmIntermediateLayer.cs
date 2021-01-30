using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDKHrobot;

namespace HiwinRobot
{
    /// <summary>
    /// 上銀手臂 SDK 中介層介面。<br/>
    /// 此中介層 interface 用來幫助達成 Unit Test 的隔離。
    /// </summary>
    interface IArmIntermediateLayer
    {
        //int ptp_axis(int robot, int mode, double[] point);

        #region - Speed and Acceleration -
        int set_acc_dec_ratio(int robot, int v);
        int set_override_ratio(int robot, int v);
        int get_acc_dec_ratio(int robot);
        int get_override_ratio(int robot);
        #endregion - Speed and Acceleration -
    }

    /// <summary>
    /// 上銀手臂 SDK 中介層實作。<br/>
    /// 此中介層 class 用來幫助達成 Unit Test 的隔離。透過 override 此中介層的各 virtual method，再利用依賴注入來達成隔離。
    /// </summary>
    class ArmIntermediateLayer : IArmIntermediateLayer
    {
        public virtual int ptp_axis(int robot, int mode, double[] point) => HRobot.ptp_axis(robot, mode, point);

        #region - Speed and Acceleration -
        public virtual int set_acc_dec_ratio(int robot, int v) => HRobot.set_acc_dec_ratio(robot, v);
        public virtual int set_override_ratio(int robot, int v) => HRobot.set_override_ratio(robot, v);
        public virtual int get_acc_dec_ratio(int robot) => HRobot.get_acc_dec_ratio(robot);
        public virtual int get_override_ratio(int robot) => HRobot.get_override_ratio(robot);
        #endregion - Speed and Acceleration -
    }
}
