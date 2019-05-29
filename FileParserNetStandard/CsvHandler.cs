using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using FileParserNetStandard;

namespace Delegate_Exercise {
    
    
    public class CsvHandler {

        /// <summary>
        /// Takes a list of list of strings applies datahandling via dataHandler delegate and writes result as csv to writeFile.
        /// </summary>
        /// <param name="readFile"></param>
        /// <param name="writeFile"></param>
        /// <param name="dataHandler"></param>
        public void ProcessCsv(string readFile, string writeFile, Func<List<List<string>>, List<List<string>>> dataHandler) {   }
        


        public delegate void DataHandler(List<List<string>> strings);
        
        static void WriteFile(List<List<string>> rows)
        {
            string filePath = "";
            File.WriteAllText(filePath, "");
            foreach (List<string> list in rows)
            {
                string line = "";
                foreach (string data in list)
                {
                    line = line + data + ",";
                }
                line = line.TrimEnd(',');
                using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(filePath, true))
                {
                    file.Write(line);
                    file.Write(file.NewLine);
                }

            }

        }

    }

}
}//"C:/Users/102103545/Documents/csv.csv"