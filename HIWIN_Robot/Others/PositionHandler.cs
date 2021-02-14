using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiwinRobot
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
        /// 記錄位置資訊到 CSV 檔案。
        /// </summary>
        /// <param name="name"></param>
        /// <param name="positionType"></param>
        /// <param name="position"></param>
        /// <param name="comment"></param>
        void Record(string name,
                    PositionType positionType,
                    double[] position,
                    string comment = "--");
    }

    public class PositionHandler : IPositionHandler
    {
        private readonly List<string> CsvColumnName = new List<string>();

        private ICsvHandler CsvHandler = null;

        private int SerialNumber = 0;

        public PositionHandler(ICsvHandler csvHandler)
        {
            CsvHandler = csvHandler;

            CsvColumnName.Clear();

            // 取得該enum的成員數量。https://stackoverflow.com/questions/856154/total-number-of-items-defined-in-an-enum
            var enumCount = Enum.GetNames(typeof(PositionDataFormat)).Length;

            for (int i = 0; i < enumCount; i++)
            {
                // 依照引索來取得enum的項目。https://stackoverflow.com/a/31452191/12005882
                var e = new PositionDataFormat();
                var col = (PositionDataFormat)(Enum.GetValues(e.GetType())).GetValue(i);
                CsvColumnName.Add(col.ToString());
            }
        }

        public void Record(string name,
                           PositionType positionType,
                           double[] position,
                           string comment = "--")
        {
            string filename = "[position_record]" +
                              DateTime.Now.ToString("MMMdd") +
                              ".csv";

            List<List<string>> csvContent = new List<List<string>>()
            {
                new List<string>()
                {
                    SerialNumber.ToString(),
                    name.Trim(),
                    positionType.ToString(),
                    position[0].ToString(),
                    position[1].ToString(),
                    position[2].ToString(),
                    position[3].ToString(),
                    position[4].ToString(),
                    position[5].ToString(),
                    comment.Trim()
                }
            };

            CsvHandler.Write(filename, csvContent, CsvColumnName);
            SerialNumber++;
        }
    }
}