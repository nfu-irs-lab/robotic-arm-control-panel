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
        #region - Others -

        private IActionFlowHandler ActionFlow = null;

        private IArmController Arm = null;

        private IBluetoothController BluetoothController = null;

        private List<IDevice> Devices = null;

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
            Devices = mainFormDependency.Devices;

            // 初始化可連線裝置組。
            Devices.Clear();
            OrganizeConnectableDevices();

            // 初始化動作流程。
            ActionFlow.Clear();
            ActionFlow.Add("Start", () => { }, "The start of Action-Flow. (Empty)");
            OrganizeActionFlow();
            ActionFlow.Add("End", () => { }, "The end of Action-Flow. (Empty)");
            ActionFlow.UpdateListView();
        }

        #endregion - Others -

        /// <summary>
        /// 組織動作流程。
        /// </summary>
        private void OrganizeActionFlow()
        {
            // 在此依照順序加入動作流程。
            ActionFlow.Add("Example-1", () => Message.Show("Example message-1."), "Example comment-1 (optional).");
            ActionFlow.Add("Example-2", () => Message.Show("Example message-2."), "Example comment-2 (optional).");
        }

        /// <summary>
        /// 組織可連線裝置組。
        /// </summary>
        private void OrganizeConnectableDevices()
        {
            // 加入的順序就是連線/斷線的順序。
            // 若要禁用某裝置，在下方將其所屬的「 Devices.Add(裝置); 」註解掉即可。
            Devices.Add(Arm);
            //Devices.Add(Gripper);
            //Devices.Add(BluetoothController);
        }
    }
}