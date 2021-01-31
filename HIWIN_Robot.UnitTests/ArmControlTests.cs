using NUnit.Framework;
using NSubstitute;
using HiwinRobot;

namespace HIWIN_Robot.UnitTests
{
    [TestFixture]
    public class ArmControlTests
    {
        [Test]
        public void ClearAlarm_WhenCall_Returns0()
        {
            // Arrange.
            IArmIntermediateLayer fakeArmIntermediateLayer = Substitute.For<IArmIntermediateLayer>();
            fakeArmIntermediateLayer.clear_alarm(0).Returns<int>(0);

            ArmControl armControl = new ArmControl("", fakeArmIntermediateLayer);

            // Act.
            armControl.ClearAlarm();

            // Assert.
            Assert.Pass();
        }

        /// <summary>
        /// 假的上銀手臂 SDK 中介層實作。<br/>
        /// </summary>
        private class FakeArmIntermediateLayer : ArmIntermediateLayer
        {
            public override int clear_alarm(int robot) => 0;

            public override void disconnect(int a)
            {
            }

            public override int get_acc_dec_ratio(int robot) => 0;

            public override int get_connection_level(int robot) => 0;

            public override int get_current_joint(int robot, double[] value)
            {
                value = new double[] { 0, 0, 0, 0, 0, 0 };
                return 0;
            }

            public override int get_current_position(int robot, double[] value)
            {
                value = new double[] { 0, 0, 0, 0, 0, 0 };
                return 0;
            }

            public override int get_motion_state(int robot) => 0;

            public override int get_motor_state(int robot) => 0;

            public override int get_override_ratio(int robot) => 0;

            public override int lin_axis(int robot, int mode, double smooth_value, double[] point) => 0;

            public override int lin_pos(int robot, int mode, double smooth_value, double[] point) => 0;

            public override int lin_rel_axis(int robot, int mode, double smooth_value, double[] point) => 0;

            public override int lin_rel_pos(int robot, int mode, double smooth_value, double[] point) => 0;

            public override int open_connection(string a, int mode, SDKHrobot.HRobot.CallBackFun func) => 0;

            public override int ptp_axis(int robot, int mode, double[] point) => 0;

            public override int ptp_pos(int robot, int mode, double[] point) => 0;

            public override int ptp_rel_axis(int robot, int mode, double[] point) => 0;

            public override int ptp_rel_pos(int robot, int mode, double[] point) => 0;

            public override int set_acc_dec_ratio(int robot, int v) => 0;

            public override int set_motor_state(int robot, int onOff) => 0;

            public override int set_override_ratio(int robot, int v) => 0;
        }
    }
}