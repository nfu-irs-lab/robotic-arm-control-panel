using RASDK.Basic;

namespace MainForm
{
    public partial class MainForm
    {
        /// <summary>
        /// 組織動作流程。
        /// </summary>
        /// <remarks>
        /// 在此依照順序加入動作流程。
        /// </remarks>
        private void OrganizeActionFlow()
        {
            // ActionFlow.Add("Example-1", () => Message.Show("Example message-1."), "Comment is optional.");
            // ActionFlow.Add("Example-2", () => Message.Show("Example message-2."));
        }

        /// <summary>
        /// 組織可連線裝置組。
        /// </summary>
        /// <remarks>
        /// 加入的順序就是連線/斷線的順序。<br/>
        /// 若要禁用某裝置，在下方將其所屬的「 Devices.Add(裝置); 」註解掉即可。
        /// </remarks>
        private void OrganizeConnectableDevices()
        {
            Devices.Clear();

            Devices.Add((IDevice)Arm);
            //Devices.Add(Gripper);
            //Devices.Add(Bluetooth);
        }
    }
}