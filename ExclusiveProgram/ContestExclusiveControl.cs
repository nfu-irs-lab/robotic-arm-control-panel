using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExclusiveProgram
{
    public partial class ContestExclusiveControl : MainForm.ExclusiveControl
    {

        public RASDK.Arm.RoboticArm Arm;
        public RASDK.Basic.ILogHandler LogHandler;
        public RASDK.Basic.Message.IMessage MessageHandler;

        public ContestExclusiveControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "A")
            { button1.Text = "B"; }
            else
            { button1.Text = "A"; }
        }
    }
}
