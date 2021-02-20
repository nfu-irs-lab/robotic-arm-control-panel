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
        #region - Properties -

        private IActionFlowHandler ActionFlow = null;

        private IArmController Arm = null;

        private IBluetoothController BluetoothController = null;

        private List<IDevice> Devices = null;
        private IGripperController Gripper = null;

        private IMessage Message = null;

        private IPositionHandler PositionHandler = null;

        #endregion - Properties -

        #region - Constructor -

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

            InitConnectableDevices();
            InitActionFlow();
        }

        #endregion - Constructor -

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

        /// <summary>
        /// 初始化可連線裝置組。
        /// </summary>
        private void InitConnectableDevices()
        {
            // 組織連線裝置組。加入的順序就是連線/斷線的順序。
            // 若要禁用某裝置，在下方將其所屬的「 Devices.Add(裝置); 」註解掉即可。
            Devices.Clear();
            Devices.Add(Arm);
            //Devices.Add(Gripper);
            //Devices.Add(BluetoothController);
        }
    }
}