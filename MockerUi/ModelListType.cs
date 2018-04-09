using System;

namespace MockerUi
{
    internal class ModelListType
    {
        private string[] listContents;
        private Random random = new Random();
        private int listItemsCount;

        internal ModelListType(string listContents)
        {
            this.listContents = listContents.Split(';');
            listItemsCount = this.listContents.Length - 1;
        }

        internal string event_RetrieveRandomDataValue()
        {
            int randomLineNumber = random.Next(0, listItemsCount);
            string dataValue = listContents[randomLineNumber];
            if (dataValue.Contains(",")) { dataValue = dataValue.Replace(",", ""); }
            return dataValue;
        }
    }
}