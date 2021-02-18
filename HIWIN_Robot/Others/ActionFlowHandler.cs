using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiwinRobot
{
    public struct ActionStruce
    {
        public Action Action;
        public string Comment;
        public string Name;
    }

    public class ActionFlowHandler
    {
        private List<ActionStruce> Actions = null;

        public ActionFlowHandler(List<ActionStruce> actionStruces)
        {
            Actions = actionStruces;
        }
    }
}