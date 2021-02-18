using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private List<ActionStruce> Actions = new List<ActionStruce>();
        private IMessage Message = null;

        public ActionFlowHandler(IMessage message)
        {
            Message = message;
        }

        public int LastActionIndex { get; private set; } = 0;
        public bool ShowMessageBoforeAction { get; set; } = true;

        public void Add(string name, Action action, string comment = "--")
        {
            ActionStruce actionStruce = new ActionStruce()
            {
                Action = action,
                Name = name,
                Comment = comment
            };
            Actions.Add(actionStruce);
        }

        public void Clear()
        {
            Actions.Clear();
        }

        public int Do(int actionIndex)
        {
            var act = Actions[actionIndex];
            if (ShowActionMessageAndContinue(actionIndex, act))
            {
                act.Action();
                LastActionIndex = actionIndex;
            }
            return LastActionIndex;
        }

        public int Do(int startActionIndex, int endActionIndex)
        {
            if (endActionIndex > startActionIndex)
            {
                for (int i = startActionIndex; i <= endActionIndex; i++)
                {
                    var act = Actions[i];
                    if (ShowActionMessageAndContinue(i, act))
                    {
                        act.Action();
                        LastActionIndex = i;
                    }
                    else
                    {
                        return LastActionIndex;
                    }
                }
            }
            return LastActionIndex;
        }

        public int Do(string actionName)
        {
            // TODO: Use LINQ.
            int actCount = Actions.Count;
            for (int i = 0; i < actCount; i++)
            {
                if (Actions[i].Name.Equals(actionName))
                {
                    var act = Actions[i];
                    if (ShowActionMessageAndContinue(i, act))
                    {
                        act.Action();
                        LastActionIndex = i;
                    }
                    else
                    {
                        return LastActionIndex;
                    }
                    break;
                }
            }
            return LastActionIndex;
        }

        public int DoEach()
        {
            int actCount = Actions.Count;
            for (int i = 0; i < actCount; i++)
            {
                var act = Actions[i];
                if (ShowActionMessageAndContinue(i, act))
                {
                    act.Action();
                    LastActionIndex = i;
                }
                else
                {
                    return LastActionIndex;
                }
            }
            return LastActionIndex;
        }

        /// <summary>
        /// Show action messgae if enable, and return continue or not.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="actionStruce"></param>
        /// <returns>true: Continue; false: Not continue.</returns>
        private bool ShowActionMessageAndContinue(int index, ActionStruce actionStruce)
        {
            if (ShowMessageBoforeAction)
            {
                var text = $"•Index: {index}\r\n" +
                           $"•Name: {actionStruce.Name}\r\n" +
                           $"•Comment: {actionStruce.Comment}";

                var result = Message.Show(text,
                                          "Next Action",
                                          MessageBoxButtons.OKCancel,
                                          MessageBoxIcon.None);

                if (result == DialogResult.Cancel)
                {
                    return false;
                }
            }
            return true;
        }
    }
}