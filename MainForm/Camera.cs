using RASDK.Vision.IDS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public partial class MainForm
    {
        private IDSCamera Camera;

        private void button_camera_choose_Click(object sender, EventArgs e)
        {
            Camera.ChooseCamera();
        }

        private void button_camera_close_Click(object sender, EventArgs e)
        {
            Camera.Disconnect();
        }

        private void button_camera_open_Click(object sender, EventArgs e)
        {
            Camera.Init();
            var mode = checkBox_camera_freerun.Checked ? CaptureMode.FreeRun : CaptureMode.Stop;
            // Camera.Open(mode);
            Camera.Connect();
        }

        private void button_camera_setting_Click(object sender, EventArgs e)
        {
            Camera.ShowSettingForm();
        }

        private void button_camera_snapshot_Click(object sender, EventArgs e)
        {
            checkBox_camera_freerun.Checked = false;
            Camera.ChangeCaptureMode(CaptureMode.Snapshot);
        }

        private void checkBox_camera_freerun_CheckedChanged(object sender, EventArgs e)
        {
            var mode = checkBox_camera_freerun.Checked ? CaptureMode.FreeRun : CaptureMode.Stop;
            Camera.ChangeCaptureMode(mode);
        }
    }
}
