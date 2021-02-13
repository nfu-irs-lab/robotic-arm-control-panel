using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiwinRobot
{
    public interface ICsvHandler
    {
        /// <summary>
        /// CSV 檔案路徑。需以「 / 」結尾。
        /// </summary>
        string Path { get; set; }

        /// <summary>
        /// CSV 檔案分割符號。預設爲「 , 」。
        /// </summary>
        char SymbolSeparated { get; set; }

        /// <summary>
        /// CSV 檔案字串符號。預設爲「 " 」。
        /// </summary>
        char SymbolStringDelimiter { get; set; }

        void Write(string filenameWithExtension,
                   List<List<string>> rowColumnData,
                   List<string> columnName = null);
    }

    public class CsvHandler : ICsvHandler
    {
        public CsvHandler(string path,
                          char symbolSeparated = ',',
                          char symbolStringDelimiter = '\"')
        {
            Path = path;
            SymbolSeparated = symbolSeparated;
            SymbolStringDelimiter = symbolStringDelimiter;
        }

        public string Path { get; set; }

        public char SymbolSeparated { get; set; }

        public char SymbolStringDelimiter { get; set; }

        public void Write(string filenameWithExtension,
                          List<List<string>> rowColumnData,
                          List<string> columnName = null)
        {
            bool fileAlreadyExists = false;
            if (File.Exists(Path + filenameWithExtension))
            {
                fileAlreadyExists = true;
            }

            var file = MakeStreamWriter(filenameWithExtension);

            // Write column name.
            if (!columnName.Equals(null) && !fileAlreadyExists)
            {
                string rowData = "";
                for (int col = 0; col < columnName.Count; col++)
                {
                    rowData += $"{columnName[col]}{SymbolSeparated}";
                }
                rowData = rowData.TrimEnd(SymbolSeparated).Trim();
                file.WriteLine(rowData);
            }

            // Write date.
            for (int row = 0; row < rowColumnData.Count; row++)
            {
                string rowData = "";
                for (int col = 0; col < rowColumnData[row].Count; col++)
                {
                    rowData += $"{rowColumnData[row][col]}{SymbolSeparated}";
                }
                rowData = rowData.TrimEnd(SymbolSeparated).Trim();
                file.WriteLine(rowData);
            }

            file.Close();
        }

        /// <summary>
        /// Factory pattern。
        /// </summary>
        /// <returns></returns>
        private StreamWriter MakeStreamWriter(string filenameWithExtension)
        {
            try
            {
                return File.AppendText(Path + filenameWithExtension);
            }
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory(Path);
                return File.AppendText(Path + filenameWithExtension);
            }
        }
    }
}