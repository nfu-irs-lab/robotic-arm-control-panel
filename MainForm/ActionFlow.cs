using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public partial class MainForm
    {
        // TODO:

        /// <summary>
        /// 動作流程。
        /// </summary>
        // private IActionFlowHandler ActionFlow = null;

        private void button_actionflow_do_all_Click(object sender, EventArgs e)
        {
            // ActionFlow.DoEach();
        }

        private void button_actionflow_do_selected_Click(object sender, EventArgs e)
        {
            // ActionFlow.DoSelected();
        }

        private void checkBox_actionflow_autoNext_CheckedChanged(object sender, EventArgs e)
        {
            // ActionFlow.AutoNextAction = checkBox_actionflow_autoNext.Checked;
        }

        private void checkBox_actionflow_showMsg_CheckedChanged(object sender, EventArgs e)
        {
            // ActionFlow.ShowMessageBeforeAction = checkBox_actionflow_showMsg.Checked;
        }
    }
}
