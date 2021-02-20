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
        private ICsvHandler CsvHandler = null;
        private IGripperController Gripper = null;

        private ILogHandler LogHandler = null;
        private IMessage Message = null;
        private IPositionHandler PositionHandler = null;

        public Behavior(MainFormDependency mainFormDependency)
        {
            // 依賴注入。
            PositionHandler = mainFormDependency.PositionHandler;
            Arm = mainFormDependency.ArmController;
            ActionFlow = mainFormDependency.ActionFlowHandler;
            CsvHandler = mainFormDependency.CsvHandler;
            Gripper = mainFormDependency.GripperController;
            Message = mainFormDependency.Message;
            BluetoothController = mainFormDependency.BluetoothController;
        }

        private void InitActionFlow()
        {
        }
    }
}