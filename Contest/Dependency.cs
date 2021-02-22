using System.Collections.Generic;
using Features;

namespace Contest
{
    public struct MainFormDependency
    {
        public IActionFlowHandler ActionFlowHandler;
        public IArmController ArmController;
        public IBluetoothController BluetoothController;
        public List<IDevice> Devices;
        public IGripperController GripperController;
        public IMessage Message;
        public IPositionHandler PositionHandler;
    }
}