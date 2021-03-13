using System.Collections.Generic;
using NFUIRSL.HRTK;

namespace Contest
{
    public class Behavior
    {
        /// <summary>
        /// 組織動作流程。
        /// </summary>
        private void OrganizeActionFlow()
        {
            // 在此依照順序加入動作流程。
            ActionFlow.Add("Example-1", () => Message.Show("Example message-1."), "Comment is optional.");
            ActionFlow.Add("Example-2", () => Message.Show("Example message-2."));
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

        #region - Others -

        private readonly IActionFlowHandler ActionFlow;

        private readonly IArmController Arm;

        private readonly List<IDevice> Devices;
        private readonly IMessage Message;
        private IBluetoothController BluetoothController;
        private IGripperController Gripper;
        private IPositionHandler PositionHandler;

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
    }
}