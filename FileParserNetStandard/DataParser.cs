using System.Collections.Generic;
using System.Linq;

namespace FileParserNetStandard {
    public class DataParser {
        

        /// <summary>
        /// Strips any whitespace before and after a data value.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<List<string>> StripWhiteSpace(List<List<string>> data) {
            foreach (List<string> stringList in data)
            {
                for (int i = 0; i < stringList.Count; i++)
                { stringList[i] = stringList[i].Trim(); }
            }
            return data;
        }

        /// <summary>
        /// Strips quotes from beginning and end of each data value
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<List<string>> StripQuotes(List<List<string>> data) {
            foreach (List<string> stringList in data)
            {
                for(int i=0;i<stringList.Count;i++)
                { stringList[i]=stringList[i].Trim('"'); }
            }
            return data;
        }

    }
}