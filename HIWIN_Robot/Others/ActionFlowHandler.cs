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
            ActionsCount = Actions.Count;
        }

        public int ActionsCount { get; private set; }
        public int LastActionIndex { get; private set; } = 0;

        public int Do(int actionIndex)
        {
            Actions[actionIndex].Action();
            LastActionIndex = actionIndex;
            return LastActionIndex;
        }

        public int Do(int startActionIndex, int endActionIndex)
        {
            if (endActionIndex > startActionIndex)
            {
                for (int i = startActionIndex; i <= endActionIndex; i++)
                {
                    Actions[i].Action();
                    LastActionIndex = i;
                }
            }
            return LastActionIndex;
        }

        public int Do(string actionName)
        {
            // TODO: Use LINQ.
            for (int i = 0; i < ActionsCount; i++)
            {
                if (Actions[i].Name.Equals(actionName))
                {
                    Actions[i].Action();
                    LastActionIndex = i;
                    break;
                }
            }
            return LastActionIndex;
        }

        public int DoEach()
        {
            for (int i = 0; i < ActionsCount; i++)
            {
                Actions[i].Action();
                LastActionIndex = i;
            }
            return LastActionIndex;
        }
    }
}