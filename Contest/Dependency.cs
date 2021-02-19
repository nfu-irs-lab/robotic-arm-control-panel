using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Features;

namespace Contest
{
    public struct MainFormDependency
    {
        public IActionFlowHandler ActionFlowHandler;
        public IArmController ArmController;
        public ICsvHandler CsvHandler;
        public IGripperController GripperController;
        public IMessage Message;
        public IPositionHandler PositionHandler;
    }
}