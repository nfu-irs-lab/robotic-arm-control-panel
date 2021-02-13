using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiwinRobot
{
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
        private readonly List<string> CsvColumnName = new List<string>()
        {
            "id",
            "name",
            "type",
            "j1x",
            "j2y",
            "j3z",
            "j4a",
            "j5b",
            "j6c",
            "comment"
        };

        private ICsvHandler CsvHandler = null;

        private int SerialNumber = 0;

        public PositionHandler(ICsvHandler csvHandler)
        {
            CsvHandler = csvHandler;
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