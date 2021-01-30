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
    internal interface IArmIntermediateLayer
    {
        int clear_alarm(int robot);

        void disconnect(int a);

        int get_acc_dec_ratio(int robot);

        int get_connection_level(int robot);

        int get_current_joint(int robot, double[] value);

        int get_current_position(int robot, double[] value);

        int get_motino_state(int robot);

        int get_motor_state(int robot);

        int get_override_ratio(int robot);

        int lin_axis(int robot, int mode, double smooth_value, double[] point);

        int lin_pos(int robot, int mode, double smooth_value, double[] point);

        int lin_rel_axis(int robot, int mode, double smooth_value, double[] point);

        int lin_rel_pos(int robot, int mode, double smooth_value, double[] point);

        int open_connection(string a, int mode, HRobot.CallBackFun func);

        int ptp_axis(int robot, int mode, double[] point);

        int ptp_pos(int robot, int mode, double[] point);

        int ptp_rel_axis(int robot, int mode, double[] point);

        int ptp_rel_pos(int robot, int mode, double[] point);

        int set_acc_dec_ratio(int robot, int v);

        int set_motor_state(int robot, int onOff);

        int set_override_ratio(int robot, int v);
    }

    /// <summary>
    /// 上銀手臂 SDK 中介層實作。<br/>
    /// 此中介層 class 用來幫助達成 Unit Test 的隔離。透過 override 此中介層的各 virtual method，再利用依賴注入來達成隔離。
    /// </summary>
    internal class ArmIntermediateLayer : IArmIntermediateLayer
    {
        public virtual int clear_alarm(int robot) => HRobot.clear_alarm(robot);

        public virtual void disconnect(int a) => HRobot.disconnect(a);

        public virtual int get_acc_dec_ratio(int robot)
            => HRobot.get_acc_dec_ratio(robot);

        public virtual int get_connection_level(int robot)
            => HRobot.get_connection_level(robot);

        public virtual int get_current_joint(int robot, double[] value)
            => HRobot.get_current_joint(robot, value);

        public virtual int get_current_position(int robot, double[] value)
            => HRobot.get_current_position(robot, value);

        public virtual int get_motino_state(int robot)
            => HRobot.get_motion_state(robot);

        public virtual int get_motor_state(int robot)
            => HRobot.get_motor_state(robot);

        public virtual int get_override_ratio(int robot)
            => HRobot.get_override_ratio(robot);

        public virtual int lin_axis(int robot, int mode, double smooth_value, double[] point)
            => HRobot.lin_axis(robot, mode, smooth_value, point);

        public virtual int lin_pos(int robot, int mode, double smooth_value, double[] point)
            => HRobot.lin_pos(robot, mode, smooth_value, point);

        public virtual int lin_rel_axis(int robot, int mode, double smooth_value, double[] point)
            => HRobot.lin_rel_axis(robot, mode, smooth_value, point);

        public virtual int lin_rel_pos(int robot, int mode, double smooth_value, double[] point)
            => HRobot.lin_rel_pos(robot, mode, smooth_value, point);

        public virtual int open_connection(string a, int mode, HRobot.CallBackFun func)
            => HRobot.open_connection(a, mode, func);

        public virtual int ptp_axis(int robot, int mode, double[] point)
            => HRobot.ptp_axis(robot, mode, point);

        public virtual int ptp_pos(int robot, int mode, double[] point)
            => HRobot.ptp_pos(robot, mode, point);

        public virtual int ptp_rel_axis(int robot, int mode, double[] point)
            => HRobot.ptp_rel_axis(robot, mode, point);

        public virtual int ptp_rel_pos(int robot, int mode, double[] point)
            => HRobot.ptp_rel_pos(robot, mode, point);

        public virtual int set_acc_dec_ratio(int robot, int v)
            => HRobot.set_acc_dec_ratio(robot, v);

        public virtual int set_motor_state(int robot, int onOff)
            => HRobot.set_motor_state(robot, onOff);

        public virtual int set_override_ratio(int robot, int v)
            => HRobot.set_override_ratio(robot, v);
    }
}