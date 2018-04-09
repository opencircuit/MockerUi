using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace MockerUi
{
    public partial class FormConfiguration : MaterialForm
    {
        private Common common = new Common();
        private DatabaseConnector database;
        private ControlPresetType controlPresetType = new ControlPresetType();
        private ControlFileType controlFileType = new ControlFileType();
        private ControlListType controlListType = new ControlListType();

        private XmlWriter xml;
        private Microsoft.Office.Interop.Excel.Application excel;
        private Microsoft.Office.Interop.Excel.Workbook workbook;
        private Microsoft.Office.Interop.Excel.Worksheet sheet;
        private Dictionary<string, string> columnDictionary;
        private Dictionary<string, int> idCountDictionary;
        private ArrayList headerList = new ArrayList();
        private ArrayList objectList = new ArrayList();

        private string configurationDirectory;
        private string controlType;
        private string filePath;
        private string fileType;
        private string labelText;

        public FormConfiguration()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey900, Primary.Grey900,
                Primary.Grey900, Accent.Blue100,
                TextShade.WHITE
            );
        }

        private void action_FormLoad(object sender, EventArgs e)
        {
            event_InitializeConfigurationsDirectory();
            event_InitializeConfigurationsDropdown();
            event_InitializeResourceVerification();
            event_InitializeGridviewColumns();
            event_InitializeDropdownValues();
            event_InitializeDefaultValues();
            event_InitializeDatabaseMapping();

            panelControlBackground.Controls.Add(controlPresetType);
        }

        private void action_DefaultDataType(object sender, EventArgs e)
        {
            if (radioDefault.Checked) {
                panelControlBackground.Controls.Clear();
                panelControlBackground.Controls.Add(controlPresetType);
                controlType = radioDefault.Text;
            }
        }

        private void action_CustomFileDataType(object sender, EventArgs e)
        {
            if (radioCustomFile.Checked) {
                panelControlBackground.Controls.Clear();
                panelControlBackground.Controls.Add(controlFileType);
                controlType = radioCustomFile.Text;
            }
        }

        private void action_CustomValuesDataType(object sender, EventArgs e)
        {
            if (radioCustomValues.Checked) {
                panelControlBackground.Controls.Clear();
                panelControlBackground.Controls.Add(controlListType);
                controlType = radioCustomValues.Text;
            }
        }

        private void action_AddDataFieldToList(object sender, EventArgs e)
        {
            try {

                string columnName = textboxColumnName.Text;
                if (columnName.Length == 0) {
                    MessageBox.Show("Please provide a column name.");
                    return;
                }

                string[] row = event_RetrieveGridviewRowData(columnName);
                gridviewDataSetup.Rows.Add(row);
                event_ResetAllDataFields();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void action_RemoveSelectionFromList(object sender, EventArgs e)
        {
            try {

                gridviewDataSetup.Rows.Remove(gridviewDataSetup.SelectedRows[0]);
                gridviewDataSetup.ClearSelection();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void action_OutputFileTypeSelected(object sender, EventArgs e)
        {
            string outputFileType = dropdownOutputFileType.Text;
            event_SetLabelNameStatus(outputFileType);
        }

        private void action_SaveConfiguration(object sender, EventArgs e)
        {
            string fileName = textboxConfigurationFileName.Text;

            if (fileName.Length == 0) {
                MessageBox.Show("Please provide a configuration file name before saving.");
                return;
            }

            if (fileName.EndsWith(".xml")) { fileName = fileName.Replace(".xml", ""); }
            string currentDirectory = common.event_GetCurrentDirectory();
            string filePath = currentDirectory + "\\Configurations\\" + fileName + ".xml";
            event_GenerateXml(filePath);
            dropdownConfigurations.Items.Add(fileName);
        }

        private void action_LoadConfiguration(object sender, EventArgs e)
        {
            string fileName = dropdownConfigurations.Text;

            if (fileName.Length == 0) {
                MessageBox.Show("Please select a configuration file to load.");
                return;
            }

            if (!fileName.EndsWith(".xml")) { fileName = fileName + ".xml"; }
            string currentDirectory = common.event_GetCurrentDirectory();
            string filePath = currentDirectory + "\\Configurations\\" + fileName;
            gridviewDataSetup.Rows.Clear();

            XmlNodeList primaryNodes;
            primaryNodes = event_LoadPrimaryNodesList(filePath, "DataRow");
            event_LoadDataSetupFromConfiguration(primaryNodes);
        }

        private void action_DeleteConfiguration(object sender, EventArgs e)
        {
            string fileName = dropdownConfigurations.Text;

            if (fileName.Length == 0) {
                MessageBox.Show("Please select a configuration to delete.");
                return;
            }

            string title = "Confirm";
            string message = "Are you sure you want to delete the configuration '" + fileName + "'";
            DialogResult dialogResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes) {

                string currentDirectory = common.event_GetCurrentDirectory();
                string filePath = currentDirectory + "\\Configurations\\" + fileName + ".xml";
                int index = dropdownConfigurations.SelectedIndex;

                if (File.Exists(filePath)) {
                    File.Delete(filePath);
                    dropdownConfigurations.Items.RemoveAt(index);
                }
            }
        }

        private void action_GenerateDataFile(object sender, EventArgs e)
        {
            fileType = dropdownOutputFileType.Text;

            if (fileType.Length == 0) {
                MessageBox.Show("Please select an output file type.");
                return;
            }

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {

                labelText = textboxLabelName.Text;
                if (labelText.Length == 0) { labelText = "Data"; }
                int requestedRecordsCount = Int32.Parse(textboxNumberOfRows.Text);
                string folderPath = folderBrowserDialog.SelectedPath;
                filePath = folderPath + "\\RandomData." + fileType.ToLower();
                event_GenerateInitialFile();

                database.event_OpenConnection();
                event_InitializeObjectList();

                for (int rowIndex = 0; rowIndex < requestedRecordsCount; rowIndex++) {
                    event_GenerateRecordForFile(rowIndex);
                }

                database.event_CloseConnection();
                event_CloseFileProcesses();
            }
        }
    }
}