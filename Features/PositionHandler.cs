using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Features
{
    /// <summary>
    /// CSV 位置資料格式。
    /// </summary>
    public enum PositionDataFormat
    {
        Id = 0,
        Name,
        Type,
        J1X,
        J2Y,
        J3Z,
        J4A,
        J5B,
        J6C,
        Comment
    }

    public interface IPositionHandler
    {
        /// <summary>
        /// 取得目前所選取的位置座標。
        /// </summary>
        /// <returns></returns>
        double[] GetPosition();

        /// <summary>
        /// 取得目前所選取的位置類型。
        /// </summary>
        /// <returns></returns>
        CoordinateType GetPositionType();

        /// <summary>
        /// 記錄位置資訊到 CSV 檔案。
        /// </summary>
        /// <param name="name"></param>
        /// <param name="coordinateType"></param>
        /// <param name="position"></param>
        /// <param name="comment"></param>
        void Record(string name,
                    CoordinateType coordinateType,
                    double[] position,
                    string comment = "--");

        /// <summary>
        /// 更新檔案清單。
        /// </summary>
        void UpdateFileList();

        /// <summary>
        /// 更新清單資料。
        /// </summary>
        /// <param name="filenameWithExtension"></param>
        void UpdateListData(string filenameWithExtension);
    }

    public class PositionHandler : IPositionHandler
    {
        private readonly List<string> CsvColumnName = new List<string>();
        private readonly ICsvHandler CsvHandler;
        private readonly ListView DataListView;
        private readonly ComboBox FileList;
        private int SerialNumber = 0;

        public PositionHandler(ListView dataListView,
                               ComboBox fileListComboBox,
                               ICsvHandler csvHandler,
                               IMessage message)
        {
            DataListView = dataListView;
            FileList = fileListComboBox;
            CsvHandler = csvHandler;
            Message = message;

            CsvColumnName.Clear();

            // 取得該enum的成員數量。https://stackoverflow.com/questions/856154/total-number-of-items-defined-in-an-enum
            var enumCount = Enum.GetNames(typeof(PositionDataFormat)).Length;

            for (var i = 0; i < enumCount; i++)
            {
                // 依照引索來取得enum的項目。https://stackoverflow.com/a/31452191/12005882
                var e = new PositionDataFormat();
                var col = (PositionDataFormat)(Enum.GetValues(e.GetType())).GetValue(i);
                CsvColumnName.Add(col.ToString());
            }

            UpdateListColumnName();
            ResizeListColumnWidth();
        }

        private IMessage Message { get; set; }

        public double[] GetPosition()
        {
            Message.Log("PositionHandler:Get position.", LoggingLevel.Trace);

            var position = new double[6];
            for (var i = (int)PositionDataFormat.J1X; i <= (int)PositionDataFormat.J6C; i++)
            {
                try
                {
                    var value = Convert.ToDouble(DataListView.SelectedItems[0].SubItems[i].Text);
                    position[i - (int)PositionDataFormat.J1X] = value;
                }
                catch
                {
                    position = null;
                    break;
                }
            }
            return position;
        }

        public CoordinateType GetPositionType()
        {
            Message.Log("PositionHandler:Get position type.", LoggingLevel.Trace);

            CoordinateType coordinateType;
            var type = DataListView.SelectedItems[0].SubItems[(int)PositionDataFormat.Type].Text;

            if (type.Equals(CoordinateType.Descartes.ToString()))
            {
                coordinateType = CoordinateType.Descartes;
            }
            else if (type.Equals(CoordinateType.Joint.ToString()))
            {
                coordinateType = CoordinateType.Joint;
            }
            else
            {
                coordinateType = CoordinateType.Unknown;
            }

            return coordinateType;
        }

        public void Record(string name,
                           CoordinateType coordinateType,
                           double[] position,
                           string comment = "--")
        {
            Message.Log("PositionHandler:Record.", LoggingLevel.Trace);

            var filename = "[position_record]" +
                           DateTime.Now.ToString("MMMdd") +
                           ".csv";

            var csvContent = new List<List<string>>()
            {
                new List<string>()
                {
                    SerialNumber.ToString(),
                    name.Trim(),
                    coordinateType.ToString(),
                    position[0].ToString(),
                    position[1].ToString(),
                    position[2].ToString(),
                    position[3].ToString(),
                    position[4].ToString(),
                    position[5].ToString(),
                    $"{comment.Trim()}[{DateTime.Now:yyyy-MM-dd_HH:mm:ss}]"
                }
            };

            CsvHandler.Write(filename, csvContent, CsvColumnName);
            SerialNumber++;

            UpdateFileList();
            if (FileList.SelectedItem.ToString() == filename)
            {
                UpdateListData(filename);
            }
        }

        public void UpdateFileList()
        {
            Message.Log("PositionHandler:Update file list.", LoggingLevel.Trace);

            // 記錄最後選擇的項目。
            var lastSelectedItem = "";
            if (FileList.SelectedItem != null)
            {
                lastSelectedItem = FileList.SelectedItem.ToString();
            }

            FileList.Items.Clear();

            var directoryInfo = new DirectoryInfo(CsvHandler.Path);
            try
            {
                foreach (var fi in directoryInfo.GetFiles("*.csv"))
                {
                    FileList.Items.Add(fi.Name);
                }
            }
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory(CsvHandler.Path);
                UpdateFileList();
            }

            if (FileList.Items.Count > 0)
            {
                var index = FileList.Items.IndexOf(lastSelectedItem);
                if (index != -1 && lastSelectedItem != "")
                {
                    FileList.SelectedIndex = index;
                }
                else
                {
                    FileList.SelectedIndex = 0;
                }
            }
        }

        public void UpdateListData(string filenameWithExtension)
        {
            Message.Log("PositionHandler:Update list data.", LoggingLevel.Trace);

            var csvData = CsvHandler.Read(filenameWithExtension);

            DataListView.Items.Clear();
            for (int row = 1; row < csvData.Count; row++)
            {
                var item = new ListViewItem();
                item.SubItems[0].Text = csvData[row][(int)PositionDataFormat.Id];
                item.SubItems.Add(csvData[row][(int)PositionDataFormat.Name]);
                item.SubItems.Add(csvData[row][(int)PositionDataFormat.Type]);
                item.SubItems.Add(csvData[row][(int)PositionDataFormat.J1X]);
                item.SubItems.Add(csvData[row][(int)PositionDataFormat.J2Y]);
                item.SubItems.Add(csvData[row][(int)PositionDataFormat.J3Z]);
                item.SubItems.Add(csvData[row][(int)PositionDataFormat.J4A]);
                item.SubItems.Add(csvData[row][(int)PositionDataFormat.J5B]);
                item.SubItems.Add(csvData[row][(int)PositionDataFormat.J6C]);
                item.SubItems.Add(csvData[row][(int)PositionDataFormat.Comment]);
                DataListView.Items.Add(item);
            }

            // Selected the first item.
            if (DataListView.Items.Count > 0)
            {
                DataListView.Items[0].Selected = true;
            }

            ResizeListColumnWidth();
        }

        private void ResizeListColumnWidth()
        {
            // 若要調整資料行中最長專案的寬度，請將 Width 屬性設定為-1。
            // 若要自動調整為數據行標題的寬度，請將 Width 屬性設定為-2。
            for (var col = 0; col < DataListView.Columns.Count; col++)
            {
                DataListView.Columns[col].Width = -2;
            }
        }

        private void UpdateListColumnName()
        {
            for (var col = 0; col < DataListView.Columns.Count; col++)
            {
                // 依照引索來取得enum的項目。https://stackoverflow.com/a/31452191/12005882
                var e = new PositionDataFormat();
                var type = (PositionDataFormat)(Enum.GetValues(e.GetType())).GetValue(col);
                DataListView.Columns[col].Text = type.ToString();
            }
        }
    }
}