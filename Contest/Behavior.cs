using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Features;

namespace Contest
{
    public class Behavior
    {
        private IActionFlowHandler ActionFlow = null;

        private IArmController Arm = null;

        private IBluetoothController BluetoothController = null;
        private IGripperController Gripper = null;

        private IMessage Message = null;
        private IPositionHandler PositionHandler = null;

        public Behavior(MainFormDependency mainFormDependency)
        {
            // 依賴注入。
            PositionHandler = mainFormDependency.PositionHandler;
            Arm = mainFormDependency.ArmController;
            ActionFlow = mainFormDependency.ActionFlowHandler;
            Gripper = mainFormDependency.GripperController;
            Message = mainFormDependency.Message;
            BluetoothController = mainFormDependency.BluetoothController;

            InitActionFlow();
        }

        /// <summary>
        /// 初始化動作流程。
        /// </summary>
        private void InitActionFlow()
        {
            ActionFlow.Clear();
            // 在此加入動作流程。
            ActionFlow.Add("Start", () => Message.Show("Action flow start."), "Start.");
            ActionFlow.Add("End", () => Message.Show("Action flow end."), "End.");
            ActionFlow.UpdateListView();
        }
    }
}