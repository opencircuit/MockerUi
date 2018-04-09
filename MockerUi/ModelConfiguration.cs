using MaterialSkin.Controls;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System;
using System.IO;

namespace MockerUi
{
    internal class ModelConfiguration
    {
    }

    public partial class FormConfiguration : MaterialForm
    {
        private void event_InitializeConfigurationsDirectory()
        {
            string currentDirectory = common.event_GetCurrentDirectory();
            configurationDirectory = currentDirectory + "\\Configurations";
            common.event_CreateDirectory(configurationDirectory);
        }

        private void event_InitializeConfigurationsDropdown()
        {
            ArrayList configurationsList;
            configurationsList = common.event_GetDirectoryFileList(configurationDirectory);

            foreach (string configuration in configurationsList) {
                dropdownConfigurations.Items.Add(configuration);
            }
        }

        private void event_InitializeResourceVerification()
        {
            string project = "MockerUi";
            string dataTypesFile = "DataTypes.txt";
            string mockDataDB = "MockerData.db";
            string sqlite3Executable = "sqlite3.exe";
            string sqlite3Dll = "sqlite3.dll";
            string sqlite3Definition = "sqlite3.def";

            common.event_ExtractEmbeddedResource(project, dataTypesFile);
            common.event_ExtractEmbeddedResource(project, mockDataDB);
            common.event_ExtractEmbeddedResource(project, sqlite3Executable);
            common.event_ExtractEmbeddedResource(project, sqlite3Dll);
            common.event_ExtractEmbeddedResource(project, sqlite3Definition);
        }

        private void event_InitializeGridviewColumns()
        {
            gridviewDataSetup.Columns.Add("ColumnName", "Column Name");
            gridviewDataSetup.Columns.Add("DataType", "Data Type");
            gridviewDataSetup.Columns.Add("DataValue", "Data Value");
        }

        private void event_InitializeDropdownValues()
        {
            dropdownOutputFileType.Items.Add("CSV");
            dropdownOutputFileType.Items.Add("XML");
            dropdownOutputFileType.Items.Add("XLSX");
        }

        private void event_InitializeDefaultValues()
        {
            textboxNumberOfRows.Text = "1000";
            dropdownOutputFileType.SelectedIndex = 0;
        }

        private void event_InitializeDatabaseMapping()
        {
            try {

                string currentDirectory = common.event_GetCurrentDirectory();
                string databasePath = currentDirectory + "\\MockerData.db";
                database = new DatabaseConnector(databasePath);
                database.event_OpenConnection();

                ArrayList tableList = database.event_RetrieveTableList();
                columnDictionary = new Dictionary<string, string>();
                idCountDictionary = new Dictionary<string, int>();

                foreach (string tableName in tableList) {

                    ArrayList columnList;
                    columnList = database.event_RetrieveColumnList(tableName);
                    event_InitializeColumnDictionary(tableName, columnList);

                    int maxId = database.event_RetrieveMaxIdNumber(tableName);
                    idCountDictionary.Add(tableName, maxId);
                }

                database.event_CloseConnection();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void event_InitializeColumnDictionary(string tableName, ArrayList columnList) {

            foreach (string columnName in columnList) {

                if (columnName.Equals("ID")) { continue; }
                columnDictionary.Add(columnName, tableName);
            }
        }

        private string[] event_RetrieveGridviewRowData(string columnName)
        {
            var checkedRadio = groupboxDataTypes.
                Controls.OfType<RadioButton>().
                FirstOrDefault(radio => radio.Checked);

            string dataType = checkedRadio.Text;
            string dataValue = event_RetrieveDataValue(dataType);

            string[] row = new string[] { columnName, dataType, dataValue };
            return row;
        }

        private string event_RetrieveDataValue(string dataType)
        {
            string dataValue;

            if (dataType.Equals("Custom Data File")) {
                dataValue = controlFileType.event_RetrieveFilePath();
                controlFileType.event_ResetFields();
            }
            else if (dataType.Equals("Custom Data Values")) {
                dataValue = controlListType.event_RetrieveDataValuesArray();
                controlListType.event_ResetFields();
            }
            else {
                dataValue = controlPresetType.event_RetrievePresetDataSelection();
                controlPresetType.event_ResetFields();
            }

            return dataValue;
        }

        private void event_SetLabelNameStatus(string outputFileType)
        {
            bool isInteractive;
            string lableText;

            switch (outputFileType) {

                case "XML":
                    isInteractive = true;
                    lableText = "Primary Node Name";
                    break;

                case "XLSX":
                    isInteractive = true;
                    lableText = "Sheet Name";
                    break;

                default:
                    isInteractive = false;
                    lableText = string.Empty;
                    break;
            }

            textboxLabelName.Visible = isInteractive;
            textboxLabelName.Enabled = isInteractive;
            textboxLabelName.Hint = lableText;
        }

        private void event_ResetAllDataFields()
        {
            radioDefault.Checked = true;
            textboxColumnName.ResetText();
            textboxLabelName.Visible = false;
            textboxLabelName.Enabled = false;
            textboxLabelName.Hint = string.Empty;
        }

        private void event_GenerateXml(string filePath)
        {
            try {

                XmlWriterSettings xmlSettings = new XmlWriterSettings();
                xmlSettings.Encoding = Encoding.UTF8;
                xmlSettings.Indent = true;

                xml = XmlWriter.Create(filePath, xmlSettings);
                xml.WriteStartDocument();
                xml.WriteStartElement("Configuration");

                foreach (DataGridViewRow row in gridviewDataSetup.Rows) {

                    xml.WriteStartElement("DataRow");

                    var columnName = row.Cells["ColumnName"].Value;
                    event_CreateXmlNode(xml, "ColumnName", columnName.ToString());

                    var dataType = row.Cells["DataType"].Value;
                    event_CreateXmlNode(xml, "DataType", dataType.ToString());

                    var dataValue = row.Cells["DataValue"].Value;
                    event_CreateXmlNode(xml, "DataValue", dataValue.ToString());

                    xml.WriteEndElement();
                }

                xml.WriteEndElement();
                xml.WriteEndDocument();
                xml.Close();
                xml = null;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void event_CreateXmlNode(XmlWriter xml, string nodeName, string nodeValue)
        {
            try {

                xml.WriteStartElement(nodeName);
                xml.WriteString(nodeValue);
                xml.WriteEndElement();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private XmlNodeList event_LoadPrimaryNodesList(string filePath, string nodeName)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(filePath);
            XmlElement root = xmlDocument.DocumentElement;
            XmlNodeList primaryNodes = root.GetElementsByTagName(nodeName);

            return primaryNodes;
        }

        private void event_LoadDataSetupFromConfiguration(XmlNodeList primaryNodes)
        {
            foreach (XmlNode primaryNode in primaryNodes) {

                XmlNodeList stepNodes = primaryNode.ChildNodes;
                event_LoadSubNodeValues(stepNodes);
            }
        }

        private void event_LoadSubNodeValues(XmlNodeList stepNodes)
        {
            string[] row = new string[] {
                    stepNodes[0].InnerText,
                    stepNodes[1].InnerText,
                    stepNodes[2].InnerText};

            gridviewDataSetup.Rows.Add(row);
        }


        private void event_GenerateInitialFile()
        {
            event_RetrieveHeaders();

            switch (fileType) {

                case "CSV":
                    common.event_CreateCsvFile(filePath, headerList);
                    break;

                case "XML":
                    XmlWriterSettings xmlSettings = new XmlWriterSettings();
                    xmlSettings.Encoding = Encoding.UTF8;
                    xmlSettings.Indent = true;
                    xml = XmlWriter.Create(filePath, xmlSettings);
                    xml.WriteStartDocument();
                    xml.WriteStartElement("Random");
                    break;

                case "XLSX":
                    string project = "MockerUi";
                    string excelFile = "RandomData.xlsx";
                    common.event_ExtractEmbeddedResource(project, excelFile, filePath);
                    excel = new Microsoft.Office.Interop.Excel.Application();
                    excel.DisplayAlerts = false;
                    workbook = excel.Workbooks.Open(filePath);
                    sheet = workbook.Worksheets[1];
                    event_AddExcelHeaders();
                    break;

                default:
                    break;
            }
        }

        private void event_RetrieveHeaders()
        {
            headerList.Clear();

            foreach (DataGridViewRow row in gridviewDataSetup.Rows) {
                headerList.Add(row.Cells["ColumnName"].Value.ToString());
            }
        }

        private void event_AddExcelHeaders()
        {
            for (int headerIndex = 1; headerIndex <= headerList.Count; headerIndex++) {
                sheet.Cells[1, headerIndex] = (string)headerList[headerIndex - 1];
            }
        }

        private void event_InitializeObjectList()
        {
            objectList.Clear();

            foreach (DataGridViewRow row in gridviewDataSetup.Rows) {

                string dataType = row.Cells["DataType"].Value.ToString();

                switch (dataType) {

                    case "Custom Data File":
                        event_GenerateFileTypeObject(row);
                        break;

                    case "Custom Data Values":
                        event_GenerateListTypeObject(row);
                        break;

                    default:
                        event_GeneratePresetDataTypeObject(row);
                        break;
                }
            }
        }

        private void event_GenerateFileTypeObject(DataGridViewRow row)
        {
            string filePath = event_RetrieveColumnDataValue(row);
            ModelFileType modelFileType = new ModelFileType(filePath);
            objectList.Add(modelFileType);
        }

        private void event_GenerateListTypeObject(DataGridViewRow row)
        {
            string listContents = event_RetrieveColumnDataValue(row);
            ModelListType modelListType = new ModelListType(listContents);
            objectList.Add(modelListType);
        }

        private void event_GeneratePresetDataTypeObject(DataGridViewRow row)
        {
            string columnName = event_RetrieveColumnDataValue(row);
            columnName = columnName.Replace(" ", "").ToUpper();

            string tableName = event_RetrieveTableName(columnName);
            int maxId = event_RetrieveMaxIdCount(tableName);

            ModelPresetType modelPresetType = new ModelPresetType(
                database,
                tableName,
                columnName,
                maxId);

            objectList.Add(modelPresetType);
        }

        private string event_RetrieveColumnDataValue(DataGridViewRow row)
        {
            string columnDataValue;

            try { columnDataValue = row.Cells["DataValue"].Value.ToString(); }
            catch (Exception ex) { columnDataValue = ""; }

            return columnDataValue;
        }

        private string event_RetrieveTableName(string columnName)
        {
            string tableName;

            if (!columnDictionary.ContainsKey(columnName)) { tableName = ""; }
            else { tableName = columnDictionary[columnName.ToUpper()]; }

            return tableName;
        }

        private int event_RetrieveMaxIdCount(string tableName)
        {
            int maxId;

            if (tableName.Length == 0) { maxId = 0; }
            else { maxId = idCountDictionary[tableName]; }

            return maxId;
        }

        private void event_GenerateRecordForFile(int rowIndex)
        {
            if (fileType.Equals("XML")) { xml.WriteStartElement(labelText); }

            foreach (DataGridViewRow gridRow in gridviewDataSetup.Rows) {

                string dataType = gridRow.Cells["DataType"].Value.ToString();
                int columnIndex = gridRow.Index;

                string randomData;

                switch (dataType) {

                    case "Custom Data File":
                        ModelFileType modelFileType = (ModelFileType)objectList[columnIndex];
                        randomData = modelFileType.event_RetrieveRandomDataValue();
                        break;

                    case "Custom Data Values":
                        ModelListType modelListType = (ModelListType)objectList[columnIndex];
                        randomData = modelListType.event_RetrieveRandomDataValue();
                        break;

                    default:
                        ModelPresetType modelPresetType = (ModelPresetType)objectList[columnIndex];
                        randomData = modelPresetType.event_RetrieveRandomDataValue();
                        break;
                }

                event_AppendToCurrentRecord(randomData, rowIndex, columnIndex);
            }

            event_FinalizeNewRecord();
        }

        private void event_AppendToCurrentRecord(string randomData, int rowIndex, int columnIndex)
        {
            int gridRowsCount = gridviewDataSetup.Rows.Count - 1;

            switch (fileType) {

                case "CSV":
                    if (columnIndex < gridRowsCount) { randomData = randomData + ","; }
                    File.AppendAllText(filePath, randomData);
                    break;

                case "XML":
                    string nodeName = (string)headerList[columnIndex];
                    xml.WriteStartElement(nodeName);
                    xml.WriteString(randomData);
                    xml.WriteEndElement();
                    break;

                case "XLSX":
                    rowIndex = rowIndex + 2;
                    columnIndex = columnIndex + 1;
                    sheet.Cells[rowIndex, columnIndex] = randomData;
                    break;

                default:
                    break;
            }
        }

        private void event_FinalizeNewRecord()
        {
            switch (fileType) {

                case "CSV":
                    File.AppendAllText(filePath, Environment.NewLine);
                    break;

                case "XML":
                    xml.WriteEndElement();
                    break;

                default:
                    break;
            }
        }

        private void event_CloseFileProcesses()
        {
            int gridRowsCount = gridviewDataSetup.Rows.Count - 1;

            switch (fileType) {

                case "XML":
                    xml.WriteEndElement();
                    xml.WriteEndDocument();
                    xml.Close();
                    xml = null;
                    break;

                case "XLSX":
                    sheet.Name = labelText;
                    workbook.SaveAs(filePath);
                    workbook.Close();
                    excel.Quit();
                    break;

                default:
                    break;
            }
        }
    }
}