using System;
using System.Windows.Forms;

namespace MainForm
{
    public partial class ExclusiveControl : UserControl
    {
        public RASDK.Arm.RoboticArm Arm;
        public RASDK.Basic.ILogHandler LogHandler;
        public RASDK.Basic.Message.IMessage MessageHandler;

        public ExclusiveControl()
        {
            InitializeComponent();
        }
    }
}
