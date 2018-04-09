using System;
using System.Collections;

namespace MockerUi
{
    internal class ModelFileType
    {
        private ArrayList fileContents;
        private Random random = new Random();
        private int lineCount;

        internal ModelFileType(string filePath)
        {
            Common common = new Common();
            this.fileContents = common.event_RetrieveFileContents(filePath);
            lineCount = this.fileContents.Count - 1;
        }

        internal string event_RetrieveRandomDataValue()
        {
            int randomLineNumber = random.Next(0, lineCount);
            string dataValue = (string)fileContents[randomLineNumber];
            if (dataValue.Contains(",")) { dataValue = dataValue.Replace(",", ""); }
            return dataValue;
        }
    }
}