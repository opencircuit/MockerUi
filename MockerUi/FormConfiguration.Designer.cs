namespace MockerUi
{
    partial class FormConfiguration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguration));
            this.panelBackground = new System.Windows.Forms.Panel();
            this.buttonDeleteConfiguration = new System.Windows.Forms.Button();
            this.dropdownConfigurations = new MetroFramework.Controls.MetroComboBox();
            this.textboxConfigurationFileName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonLoadConfiguration = new System.Windows.Forms.Button();
            this.buttonSaveConfiguration = new System.Windows.Forms.Button();
            this.panelControlBackground = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.textboxLabelName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dropdownOutputFileType = new MetroFramework.Controls.MetroComboBox();
            this.textboxNumberOfRows = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupboxDataTypes = new System.Windows.Forms.GroupBox();
            this.radioCustomValues = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioCustomFile = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioDefault = new MaterialSkin.Controls.MaterialRadioButton();
            this.textboxColumnName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonGenerateDataFile = new System.Windows.Forms.Button();
            this.buttonRemoveFieldFromList = new System.Windows.Forms.Button();
            this.buttonAddFieldToList = new System.Windows.Forms.Button();
            this.panelGridviewBackground = new System.Windows.Forms.Panel();
            this.gridviewDataSetup = new MetroFramework.Controls.MetroGrid();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panelBackground.SuspendLayout();
            this.groupboxDataTypes.SuspendLayout();
            this.panelGridviewBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDataSetup)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBackground.Controls.Add(this.buttonDeleteConfiguration);
            this.panelBackground.Controls.Add(this.dropdownConfigurations);
            this.panelBackground.Controls.Add(this.textboxConfigurationFileName);
            this.panelBackground.Controls.Add(this.buttonLoadConfiguration);
            this.panelBackground.Controls.Add(this.buttonSaveConfiguration);
            this.panelBackground.Controls.Add(this.panelControlBackground);
            this.panelBackground.Controls.Add(this.materialLabel1);
            this.panelBackground.Controls.Add(this.textboxLabelName);
            this.panelBackground.Controls.Add(this.dropdownOutputFileType);
            this.panelBackground.Controls.Add(this.textboxNumberOfRows);
            this.panelBackground.Controls.Add(this.groupboxDataTypes);
            this.panelBackground.Controls.Add(this.textboxColumnName);
            this.panelBackground.Controls.Add(this.buttonGenerateDataFile);
            this.panelBackground.Controls.Add(this.buttonRemoveFieldFromList);
            this.panelBackground.Controls.Add(this.buttonAddFieldToList);
            this.panelBackground.Controls.Add(this.panelGridviewBackground);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 60);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Padding = new System.Windows.Forms.Padding(20);
            this.panelBackground.Size = new System.Drawing.Size(1140, 560);
            this.panelBackground.TabIndex = 0;
            // 
            // buttonDeleteConfiguration
            // 
            this.buttonDeleteConfiguration.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDeleteConfiguration.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonDeleteConfiguration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonDeleteConfiguration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonDeleteConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteConfiguration.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteConfiguration.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteConfiguration.Location = new System.Drawing.Point(23, 505);
            this.buttonDeleteConfiguration.Name = "buttonDeleteConfiguration";
            this.buttonDeleteConfiguration.Size = new System.Drawing.Size(236, 30);
            this.buttonDeleteConfiguration.TabIndex = 35;
            this.buttonDeleteConfiguration.Text = "DELETE SELECTED CONFIGURATION";
            this.buttonDeleteConfiguration.UseVisualStyleBackColor = false;
            this.buttonDeleteConfiguration.Click += new System.EventHandler(this.action_DeleteConfiguration);
            // 
            // dropdownConfigurations
            // 
            this.dropdownConfigurations.DropDownHeight = 150;
            this.dropdownConfigurations.ForeColor = System.Drawing.Color.Black;
            this.dropdownConfigurations.FormattingEnabled = true;
            this.dropdownConfigurations.IntegralHeight = false;
            this.dropdownConfigurations.ItemHeight = 23;
            this.dropdownConfigurations.Location = new System.Drawing.Point(23, 434);
            this.dropdownConfigurations.Name = "dropdownConfigurations";
            this.dropdownConfigurations.Size = new System.Drawing.Size(236, 29);
            this.dropdownConfigurations.TabIndex = 34;
            this.dropdownConfigurations.UseSelectable = true;
            // 
            // textboxConfigurationFileName
            // 
            this.textboxConfigurationFileName.Depth = 0;
            this.textboxConfigurationFileName.Hint = "Configuration File Name";
            this.textboxConfigurationFileName.Location = new System.Drawing.Point(23, 349);
            this.textboxConfigurationFileName.MaxLength = 32767;
            this.textboxConfigurationFileName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxConfigurationFileName.Name = "textboxConfigurationFileName";
            this.textboxConfigurationFileName.PasswordChar = '\0';
            this.textboxConfigurationFileName.SelectedText = "";
            this.textboxConfigurationFileName.SelectionLength = 0;
            this.textboxConfigurationFileName.SelectionStart = 0;
            this.textboxConfigurationFileName.Size = new System.Drawing.Size(236, 23);
            this.textboxConfigurationFileName.TabIndex = 33;
            this.textboxConfigurationFileName.TabStop = false;
            this.textboxConfigurationFileName.UseSystemPasswordChar = false;
            // 
            // buttonLoadConfiguration
            // 
            this.buttonLoadConfiguration.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonLoadConfiguration.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonLoadConfiguration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonLoadConfiguration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonLoadConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadConfiguration.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadConfiguration.ForeColor = System.Drawing.Color.White;
            this.buttonLoadConfiguration.Location = new System.Drawing.Point(23, 469);
            this.buttonLoadConfiguration.Name = "buttonLoadConfiguration";
            this.buttonLoadConfiguration.Size = new System.Drawing.Size(236, 30);
            this.buttonLoadConfiguration.TabIndex = 32;
            this.buttonLoadConfiguration.Text = "LOAD CONFIGURATION";
            this.buttonLoadConfiguration.UseVisualStyleBackColor = false;
            this.buttonLoadConfiguration.Click += new System.EventHandler(this.action_LoadConfiguration);
            // 
            // buttonSaveConfiguration
            // 
            this.buttonSaveConfiguration.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSaveConfiguration.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonSaveConfiguration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSaveConfiguration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonSaveConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveConfiguration.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveConfiguration.ForeColor = System.Drawing.Color.White;
            this.buttonSaveConfiguration.Location = new System.Drawing.Point(23, 378);
            this.buttonSaveConfiguration.Name = "buttonSaveConfiguration";
            this.buttonSaveConfiguration.Size = new System.Drawing.Size(236, 30);
            this.buttonSaveConfiguration.TabIndex = 31;
            this.buttonSaveConfiguration.Text = "SAVE CONFIGURATION";
            this.buttonSaveConfiguration.UseVisualStyleBackColor = false;
            this.buttonSaveConfiguration.Click += new System.EventHandler(this.action_SaveConfiguration);
            // 
            // panelControlBackground
            // 
            this.panelControlBackground.Location = new System.Drawing.Point(280, 15);
            this.panelControlBackground.Name = "panelControlBackground";
            this.panelControlBackground.Size = new System.Drawing.Size(545, 200);
            this.panelControlBackground.TabIndex = 30;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(879, 23);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(125, 19);
            this.materialLabel1.TabIndex = 27;
            this.materialLabel1.Text = "Number of Rows:";
            // 
            // textboxLabelName
            // 
            this.textboxLabelName.Depth = 0;
            this.textboxLabelName.Hint = "";
            this.textboxLabelName.Location = new System.Drawing.Point(879, 107);
            this.textboxLabelName.MaxLength = 32767;
            this.textboxLabelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxLabelName.Name = "textboxLabelName";
            this.textboxLabelName.PasswordChar = '\0';
            this.textboxLabelName.SelectedText = "";
            this.textboxLabelName.SelectionLength = 0;
            this.textboxLabelName.SelectionStart = 0;
            this.textboxLabelName.Size = new System.Drawing.Size(236, 23);
            this.textboxLabelName.TabIndex = 26;
            this.textboxLabelName.TabStop = false;
            this.textboxLabelName.UseSystemPasswordChar = false;
            // 
            // dropdownOutputFileType
            // 
            this.dropdownOutputFileType.DropDownHeight = 150;
            this.dropdownOutputFileType.ForeColor = System.Drawing.Color.Black;
            this.dropdownOutputFileType.FormattingEnabled = true;
            this.dropdownOutputFileType.IntegralHeight = false;
            this.dropdownOutputFileType.ItemHeight = 23;
            this.dropdownOutputFileType.Location = new System.Drawing.Point(879, 62);
            this.dropdownOutputFileType.Name = "dropdownOutputFileType";
            this.dropdownOutputFileType.Size = new System.Drawing.Size(236, 29);
            this.dropdownOutputFileType.TabIndex = 24;
            this.dropdownOutputFileType.UseSelectable = true;
            this.dropdownOutputFileType.SelectedIndexChanged += new System.EventHandler(this.action_OutputFileTypeSelected);
            // 
            // textboxNumberOfRows
            // 
            this.textboxNumberOfRows.Depth = 0;
            this.textboxNumberOfRows.Hint = "";
            this.textboxNumberOfRows.Location = new System.Drawing.Point(1010, 23);
            this.textboxNumberOfRows.MaxLength = 32767;
            this.textboxNumberOfRows.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxNumberOfRows.Name = "textboxNumberOfRows";
            this.textboxNumberOfRows.PasswordChar = '\0';
            this.textboxNumberOfRows.SelectedText = "";
            this.textboxNumberOfRows.SelectionLength = 0;
            this.textboxNumberOfRows.SelectionStart = 0;
            this.textboxNumberOfRows.Size = new System.Drawing.Size(105, 23);
            this.textboxNumberOfRows.TabIndex = 23;
            this.textboxNumberOfRows.TabStop = false;
            this.textboxNumberOfRows.Text = "1000";
            this.textboxNumberOfRows.UseSystemPasswordChar = false;
            // 
            // groupboxDataTypes
            // 
            this.groupboxDataTypes.Controls.Add(this.radioCustomValues);
            this.groupboxDataTypes.Controls.Add(this.radioCustomFile);
            this.groupboxDataTypes.Controls.Add(this.radioDefault);
            this.groupboxDataTypes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxDataTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.groupboxDataTypes.Location = new System.Drawing.Point(23, 58);
            this.groupboxDataTypes.Name = "groupboxDataTypes";
            this.groupboxDataTypes.Size = new System.Drawing.Size(236, 160);
            this.groupboxDataTypes.TabIndex = 12;
            this.groupboxDataTypes.TabStop = false;
            this.groupboxDataTypes.Text = " Data Type Selection ";
            // 
            // radioCustomValues
            // 
            this.radioCustomValues.AutoSize = true;
            this.radioCustomValues.Depth = 0;
            this.radioCustomValues.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioCustomValues.Location = new System.Drawing.Point(24, 110);
            this.radioCustomValues.Margin = new System.Windows.Forms.Padding(0);
            this.radioCustomValues.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioCustomValues.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioCustomValues.Name = "radioCustomValues";
            this.radioCustomValues.Ripple = true;
            this.radioCustomValues.Size = new System.Drawing.Size(154, 30);
            this.radioCustomValues.TabIndex = 21;
            this.radioCustomValues.Text = "Custom Data Values";
            this.radioCustomValues.UseVisualStyleBackColor = true;
            this.radioCustomValues.CheckedChanged += new System.EventHandler(this.action_CustomValuesDataType);
            // 
            // radioCustomFile
            // 
            this.radioCustomFile.AutoSize = true;
            this.radioCustomFile.Depth = 0;
            this.radioCustomFile.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioCustomFile.Location = new System.Drawing.Point(24, 70);
            this.radioCustomFile.Margin = new System.Windows.Forms.Padding(0);
            this.radioCustomFile.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioCustomFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioCustomFile.Name = "radioCustomFile";
            this.radioCustomFile.Ripple = true;
            this.radioCustomFile.Size = new System.Drawing.Size(134, 30);
            this.radioCustomFile.TabIndex = 20;
            this.radioCustomFile.Text = "Custom Data File";
            this.radioCustomFile.UseVisualStyleBackColor = true;
            this.radioCustomFile.CheckedChanged += new System.EventHandler(this.action_CustomFileDataType);
            // 
            // radioDefault
            // 
            this.radioDefault.AutoSize = true;
            this.radioDefault.Checked = true;
            this.radioDefault.Depth = 0;
            this.radioDefault.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioDefault.Location = new System.Drawing.Point(24, 30);
            this.radioDefault.Margin = new System.Windows.Forms.Padding(0);
            this.radioDefault.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioDefault.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioDefault.Name = "radioDefault";
            this.radioDefault.Ripple = true;
            this.radioDefault.Size = new System.Drawing.Size(141, 30);
            this.radioDefault.TabIndex = 19;
            this.radioDefault.TabStop = true;
            this.radioDefault.Text = "Preset Data Types";
            this.radioDefault.UseVisualStyleBackColor = true;
            this.radioDefault.CheckedChanged += new System.EventHandler(this.action_DefaultDataType);
            // 
            // textboxColumnName
            // 
            this.textboxColumnName.Depth = 0;
            this.textboxColumnName.Hint = "Column Name";
            this.textboxColumnName.Location = new System.Drawing.Point(23, 23);
            this.textboxColumnName.MaxLength = 32767;
            this.textboxColumnName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxColumnName.Name = "textboxColumnName";
            this.textboxColumnName.PasswordChar = '\0';
            this.textboxColumnName.SelectedText = "";
            this.textboxColumnName.SelectionLength = 0;
            this.textboxColumnName.SelectionStart = 0;
            this.textboxColumnName.Size = new System.Drawing.Size(236, 23);
            this.textboxColumnName.TabIndex = 20;
            this.textboxColumnName.TabStop = false;
            this.textboxColumnName.UseSystemPasswordChar = false;
            // 
            // buttonGenerateDataFile
            // 
            this.buttonGenerateDataFile.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonGenerateDataFile.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonGenerateDataFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonGenerateDataFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonGenerateDataFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerateDataFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateDataFile.ForeColor = System.Drawing.Color.White;
            this.buttonGenerateDataFile.Location = new System.Drawing.Point(879, 156);
            this.buttonGenerateDataFile.Name = "buttonGenerateDataFile";
            this.buttonGenerateDataFile.Size = new System.Drawing.Size(236, 59);
            this.buttonGenerateDataFile.TabIndex = 16;
            this.buttonGenerateDataFile.Text = "GENERATE DATA FILE";
            this.buttonGenerateDataFile.UseVisualStyleBackColor = false;
            this.buttonGenerateDataFile.Click += new System.EventHandler(this.action_GenerateDataFile);
            // 
            // buttonRemoveFieldFromList
            // 
            this.buttonRemoveFieldFromList.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonRemoveFieldFromList.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonRemoveFieldFromList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonRemoveFieldFromList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonRemoveFieldFromList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveFieldFromList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveFieldFromList.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveFieldFromList.Location = new System.Drawing.Point(23, 273);
            this.buttonRemoveFieldFromList.Name = "buttonRemoveFieldFromList";
            this.buttonRemoveFieldFromList.Size = new System.Drawing.Size(236, 30);
            this.buttonRemoveFieldFromList.TabIndex = 15;
            this.buttonRemoveFieldFromList.Text = "REMOVE SELECTION FROM LIST";
            this.buttonRemoveFieldFromList.UseVisualStyleBackColor = false;
            this.buttonRemoveFieldFromList.Click += new System.EventHandler(this.action_RemoveSelectionFromList);
            // 
            // buttonAddFieldToList
            // 
            this.buttonAddFieldToList.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAddFieldToList.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonAddFieldToList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAddFieldToList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonAddFieldToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddFieldToList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddFieldToList.ForeColor = System.Drawing.Color.White;
            this.buttonAddFieldToList.Location = new System.Drawing.Point(23, 237);
            this.buttonAddFieldToList.Name = "buttonAddFieldToList";
            this.buttonAddFieldToList.Size = new System.Drawing.Size(236, 30);
            this.buttonAddFieldToList.TabIndex = 13;
            this.buttonAddFieldToList.Text = "ADD DATA FIELD TO LIST";
            this.buttonAddFieldToList.UseVisualStyleBackColor = false;
            this.buttonAddFieldToList.Click += new System.EventHandler(this.action_AddDataFieldToList);
            // 
            // panelGridviewBackground
            // 
            this.panelGridviewBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGridviewBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelGridviewBackground.Controls.Add(this.gridviewDataSetup);
            this.panelGridviewBackground.Location = new System.Drawing.Point(285, 237);
            this.panelGridviewBackground.Name = "panelGridviewBackground";
            this.panelGridviewBackground.Padding = new System.Windows.Forms.Padding(2);
            this.panelGridviewBackground.Size = new System.Drawing.Size(830, 298);
            this.panelGridviewBackground.TabIndex = 0;
            // 
            // gridviewDataSetup
            // 
            this.gridviewDataSetup.AllowUserToAddRows = false;
            this.gridviewDataSetup.AllowUserToDeleteRows = false;
            this.gridviewDataSetup.AllowUserToResizeRows = false;
            this.gridviewDataSetup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewDataSetup.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridviewDataSetup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridviewDataSetup.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridviewDataSetup.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewDataSetup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridviewDataSetup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridviewDataSetup.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridviewDataSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridviewDataSetup.EnableHeadersVisualStyles = false;
            this.gridviewDataSetup.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridviewDataSetup.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridviewDataSetup.Location = new System.Drawing.Point(2, 2);
            this.gridviewDataSetup.MultiSelect = false;
            this.gridviewDataSetup.Name = "gridviewDataSetup";
            this.gridviewDataSetup.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewDataSetup.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridviewDataSetup.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridviewDataSetup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridviewDataSetup.Size = new System.Drawing.Size(826, 294);
            this.gridviewDataSetup.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // FormConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 620);
            this.Controls.Add(this.panelBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormConfiguration";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mocker";
            this.Load += new System.EventHandler(this.action_FormLoad);
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.groupboxDataTypes.ResumeLayout(false);
            this.groupboxDataTypes.PerformLayout();
            this.panelGridviewBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDataSetup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Panel panelGridviewBackground;
        private System.Windows.Forms.Button buttonAddFieldToList;
        private System.Windows.Forms.Button buttonRemoveFieldFromList;
        private System.Windows.Forms.Button buttonGenerateDataFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private MetroFramework.Controls.MetroGrid gridviewDataSetup;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxColumnName;
        private System.Windows.Forms.GroupBox groupboxDataTypes;
        private MaterialSkin.Controls.MaterialRadioButton radioCustomValues;
        private MaterialSkin.Controls.MaterialRadioButton radioCustomFile;
        private MaterialSkin.Controls.MaterialRadioButton radioDefault;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MetroFramework.Controls.MetroComboBox dropdownOutputFileType;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxNumberOfRows;
        private System.Windows.Forms.Panel panelControlBackground;
        private System.Windows.Forms.Button buttonLoadConfiguration;
        private System.Windows.Forms.Button buttonSaveConfiguration;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxConfigurationFileName;
        private MetroFramework.Controls.MetroComboBox dropdownConfigurations;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button buttonDeleteConfiguration;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxLabelName;
    }
}

