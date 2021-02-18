using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiwinRobot.Others
{
    public struct ActionStruce
    {
        public Action Action;
        public string Comment;
        public string Name;
    }

    public class ActionFlowHandler
    {
        public List<ActionStruce> Actions;

        public ActionFlowHandler()
        {
            Actions = new List<ActionStruce>();
        }
    }
}