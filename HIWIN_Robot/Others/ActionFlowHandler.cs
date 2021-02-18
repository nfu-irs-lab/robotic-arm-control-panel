using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiwinRobot
{
    public interface IActionFlowHandler
    {
        /// <summary>
        /// 最後一個執行的動作索引值。
        /// </summary>
        int LastActionIndex { get; }

        /// <summary>
        /// 是否在每一個動作之前顯示確認訊息。
        /// </summary>
        bool ShowMessageBoforeAction { get; set; }

        /// <summary>
        /// 增加動作。增加的順序就是索引、執行的順序。
        /// </summary>
        /// <param name="name"></param>
        /// <param name="action"></param>
        /// <param name="comment"></param>
        void Add(string name, Action action, string comment = "--");

        /// <summary>
        /// 清空所有動作。
        /// </summary>
        void Clear();

        /// <summary>
        /// 執行動作。
        /// </summary>
        /// <param name="actionIndex"></param>
        /// <returns>最後一個執行的動作索引值。</returns>
        int Do(int actionIndex);

        /// <summary>
        /// 執行動作。
        /// </summary>
        /// <param name="startActionIndex"></param>
        /// <param name="endActionIndex"></param>
        /// <returns>最後一個執行的動作索引值。</returns>
        int Do(int startActionIndex, int endActionIndex);

        /// <summary>
        /// 執行動作。
        /// </summary>
        /// <param name="actionName"></param>
        /// <returns>最後一個執行的動作索引值。</returns>
        int Do(string actionName);

        /// <summary>
        /// 執行所有動作。
        /// </summary>
        /// <returns>最後一個執行的動作索引值。</returns>
        int DoEach();
    }

    public struct ActionStruce
    {
        public Action Action;

        public string Comment;

        public string Name;
    }

    public class ActionFlowHandler : IActionFlowHandler
    {
        private readonly IMessage Message = null;
        private List<ActionStruce> Actions = new List<ActionStruce>();

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