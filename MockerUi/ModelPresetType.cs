using System;
using System.Collections;

namespace MockerUi
{
    internal class ModelPresetType
    {
        private DatabaseConnector database;
        private Random random = new Random();

        private DateTime startDate;
        private int dateRange;

        private ArrayList booleanValues;
        private ArrayList genderValues;

        private string tableName;
        private string columnName;
        private int maxId;

        internal ModelPresetType(DatabaseConnector database, string tableName, string columnName, int maxId)
        {
            this.database = database;
            this.tableName = tableName.ToUpper();
            this.columnName = columnName.ToUpper();
            this.maxId = maxId;

            startDate = new DateTime(1900, 1, 1);
            dateRange = (DateTime.Today - startDate).Days;

            booleanValues = new ArrayList();
            booleanValues.Add("True");
            booleanValues.Add("False");

            genderValues = new ArrayList();
            genderValues.Add("Female");
            genderValues.Add("Male");
        }

        internal string event_RetrieveRandomDataValue()
        {
            string dataValue;

            switch (columnName) {

                case "APPLICATIONVERSION":
                    dataValue = event_RandomApplicationVersion();
                    break;

                case "BOOLEAN":
                    dataValue = event_RandomBoolean();
                    break;

                case "DATE":
                    dataValue = event_RandomDate();
                    break;

                case "DECIMAL":
                    dataValue = event_RandomDecimal();
                    break;

                case "GENDER":
                    dataValue = event_RandomGender();
                    break;

                case "INTEGER":
                    dataValue = event_RandomInteger();
                    break;

                case "LATITUDE":
                    dataValue = event_RandomLatitude();
                    break;

                case "LONGITUDE":
                    dataValue = event_RandomLongitude();
                    break;

                case "MILITARYTIME":
                    dataValue = event_RandomMilitaryTime();
                    break;

                case "TIME":
                    dataValue = event_RandomTime();
                    break;

                default:
                    dataValue = event_RandomDataValueFromDatabase();
                    break;
            }

            if (dataValue.Contains(",")) { dataValue = dataValue.Replace(",", ""); }
            return dataValue;
        }

        //****************************************************************************************************
        //****************************************************************************************************

        private string event_RandomApplicationVersion()
        {
            int major = event_GenerateRandomInteger(0, 10);
            int minor = event_GenerateRandomInteger(0, 100);
            int build = event_GenerateRandomInteger(0, 1000);
            string applicationVersion = major + "." + minor + "." + build;

            return applicationVersion;
        }

        private string event_RandomBoolean()
        {
            string booleanValue = (string)booleanValues[random.Next(booleanValues.Count)];
            return booleanValue;
        }

        private string event_RandomDate()
        {
            string randomDate = startDate.AddDays(random.Next(dateRange)).ToString("MM/dd/yyyy");
            return randomDate;
        }

        private string event_RandomDecimal()
        {
            double randomDecimal = event_GenerateRandomDouble(1.00, 500.00);
            return randomDecimal.ToString();
        }

        private string event_RandomGender()
        {
            string genderValue = (string)genderValues[random.Next(genderValues.Count)];
            return genderValue;
        }

        private string event_RandomInteger()
        {
            int randomInteger = event_GenerateRandomInteger(1, 1000);
            return randomInteger.ToString();
        }

        private string event_RandomLatitude()
        {
            double randomLatitude = event_GenerateRandomDouble(0.000, 90.000);
            return randomLatitude.ToString();
        }

        private string event_RandomLongitude()
        {
            double randomLongitude = event_GenerateRandomDouble(0.000, 180.000);
            return randomLongitude.ToString();
        }

        private string event_RandomMilitaryTime()
        {
            string hour = random.Next(0, 24).ToString();
            string minute = random.Next(0, 60).ToString();
            string second = random.Next(0, 60).ToString();

            if (hour.Length == 1) { hour = "0" + hour; }
            if (minute.Length == 1) { minute = "0" + minute; }
            if (second.Length == 1) { second = "0" + second; }

            string randomMilitaryTime = hour + ":" + minute + ":" + second;
            return randomMilitaryTime;
        }

        private string event_RandomTime()
        {
            string hour = random.Next(0, 12).ToString();
            string minute = random.Next(0, 60).ToString();
            string second = random.Next(0, 60).ToString();

            if (hour.Length == 1) { hour = "0" + hour; }
            if (minute.Length == 1) { minute = "0" + minute; }
            if (second.Length == 1) { second = "0" + second; }

            string randomTime = hour + ":" + minute + ":" + second;
            return randomTime;
        }

        private string event_RandomDataValueFromDatabase()
        {
            string randomDataValue;

            try {

                int randomRowNumber = event_GenerateRandomInteger(1, maxId);
                string query = "SELECT [" + columnName + "]" +
                    " FROM [" + tableName + "]" +
                    " WHERE [ID] = " + randomRowNumber;

                randomDataValue = database.event_RetrieveSpecificDataValue(query);
            }
            catch (Exception ex) {
                randomDataValue = "";
            }

            return randomDataValue;
        }

        //****************************************************************************************************
        //****************************************************************************************************

        private double event_GenerateRandomDouble(double startDecimal, double endDecimal)
        {
            double randomDecimal = random.NextDouble() *
                (endDecimal - startDecimal) +
                startDecimal;

            return randomDecimal;
        }

        private int event_GenerateRandomInteger(int startIndex, int endIndex)
        {
            int randomRow = random.Next(startIndex, endIndex);
            return randomRow;
        }
    }
}