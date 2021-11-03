using System;

namespace MainForm
{
    public partial class MainForm
    {
        /// <summary>
        /// 位置記錄。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_position_recode_Click(object sender, EventArgs e)
        {
            // PositionHandler.Record(textBox_position_record_name.Text,
            //                        GetCoordinateType(),
            //                        GetNowUiPosition(),
            //                        textBox_position_record_comment.Text);
        }

        private void button_position_record_read_Click(object sender, EventArgs e)
        {
            // var type = PositionHandler.GetPositionType();
            // switch (type)
            // {
            //     case CoordinateType.Descartes:
            //         radioButton_coordinate_type_descartes.Checked = true;
            //         break;
            //
            //     case CoordinateType.Joint:
            //         radioButton_coordinate_type_joint.Checked = true;
            //         break;
            //
            //     default:
            //         Message.Show("錯誤的座標類型。", LoggingLevel.Error);
            //         return;
            // }
            //
            // SetTargetPosition(PositionHandler.GetPosition());
            // radioButton_position_type_absolute.Checked = true;
        }

        private void button_position_record_update_list_Click(object sender, EventArgs e)
        {
            // PositionHandler.UpdateFileList();
        }

        private void comboBox_position_record_file_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            // PositionHandler.UpdateListData(comboBox_position_record_file_list.SelectedItem.ToString());
        }
    }
}