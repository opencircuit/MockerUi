using System;
using System.Data.SQLite;
using System.Data;
using System.Collections;
using System.Windows.Forms;

namespace MockerUi
{
    internal class DatabaseConnector
    {
        private SQLiteConnection connection;
        private string databasePath;

        internal DatabaseConnector(string databasePath)
        {
            this.databasePath = databasePath;
        }

        internal void event_OpenConnection()
        {
            string connectionString = "Data Source=" + databasePath + ";Version=3;";
            connection = new SQLiteConnection(connectionString);
            connection.Open();
        }

        internal ArrayList event_RetrieveTableList()
        {

            DataTable databaseSchema = connection.GetSchema("Tables");
            ArrayList tableList = new ArrayList();

            foreach (DataRow tableRow in databaseSchema.Rows) {

                string tableName = tableRow[2].ToString().ToUpper();

                if (tableName.Equals("SQLITE_SEQUENCE")) { continue; }
                else if (tableName.Equals("SQLITE_STAT1")) { continue; }
                else { tableList.Add(tableName); }
            }

            databaseSchema.Dispose();

            return tableList;
        }

        internal ArrayList event_RetrieveColumnList(string tableName)
        {
            ArrayList columnList = new ArrayList();

            try {

                string query = "SELECT * FROM [" + tableName + "]";
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM [" + tableName + "]", connection);
                SQLiteDataReader dataResults = command.ExecuteReader();

                for (int columnIndex = 0; columnIndex < dataResults.FieldCount; columnIndex++) {

                    string columnName = dataResults.GetName(columnIndex).ToUpper();
                    columnList.Add(columnName);
                }

                dataResults.Close();
                command.Dispose();
            }
            catch (Exception ex) {
                MessageBox.Show("ERROR: event_RetrieveColumnList" + "\n" + ex.Message);
            }

            return columnList;
        }

        internal int event_RetrieveMaxIdNumber(string tableName)
        {
            string query = "SELECT MAX(ID) FROM [" + tableName + "]";

            SQLiteCommand command = new SQLiteCommand();
            command.Connection = connection;
            command.CommandText = query;
            SQLiteDataReader dataReader = command.ExecuteReader();

            int maxIdNumber = 0;

            while (dataReader.Read()) {
                maxIdNumber = Int32.Parse(dataReader[0].ToString());
            }

            dataReader.Close();
            command.Dispose();

            return maxIdNumber;
        }

        internal string event_RetrieveSpecificDataValue(string query)
        {
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = connection;
            command.CommandText = query;
            SQLiteDataReader dataReader = command.ExecuteReader();

            string dataValue = "";

            while (dataReader.Read()) {
                dataValue = dataReader[0].ToString();
            }

            dataReader.Close();
            command.Dispose();

            return dataValue;
        }

        internal void event_CloseConnection()
        {
            connection.Close();
            connection.Dispose();
        }
    }
}