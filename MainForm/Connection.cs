using RASDK.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public partial class MainForm
    {
        /// <summary>
        /// 進行連線。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_connect_Click(object sender, EventArgs e)
        {
            MessageHandler.Log("Connect click", LoggingLevel.Trace);

            for (var i = 0; i < Devices.Count; i++)
            {
                Devices[i].Connect();
            }

            if (Arm.Connected)
            {
                Arm.Speed = GetUiSpeed();
                Arm.Acceleration = GetUiAcceleration();
                UpdateNowPosition();

                SetButtonsState(true);
            }
        }

        /// <summary>
        /// 進行斷線。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_disconnect_Click(object sender, EventArgs e)
        {
            MessageHandler.Log("Disconnect click", LoggingLevel.Trace);

            for (var i = 0; i < Devices.Count; i++)
            {
                Devices[i].Disconnect();
            }

            SetButtonsState(false);
        }
    }
}
