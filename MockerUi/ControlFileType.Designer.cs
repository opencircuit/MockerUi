namespace MockerUi
{
    partial class ControlFileType
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textboxFilePath = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonSelectDataFile = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textboxFilePath
            // 
            this.textboxFilePath.Depth = 0;
            this.textboxFilePath.Hint = "Custom Values File Path";
            this.textboxFilePath.Location = new System.Drawing.Point(8, 8);
            this.textboxFilePath.MaxLength = 32767;
            this.textboxFilePath.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxFilePath.Name = "textboxFilePath";
            this.textboxFilePath.PasswordChar = '\0';
            this.textboxFilePath.SelectedText = "";
            this.textboxFilePath.SelectionLength = 0;
            this.textboxFilePath.SelectionStart = 0;
            this.textboxFilePath.Size = new System.Drawing.Size(524, 23);
            this.textboxFilePath.TabIndex = 24;
            this.textboxFilePath.TabStop = false;
            this.textboxFilePath.UseSystemPasswordChar = false;
            // 
            // buttonSelectDataFile
            // 
            this.buttonSelectDataFile.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSelectDataFile.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonSelectDataFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSelectDataFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonSelectDataFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectDataFile.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectDataFile.ForeColor = System.Drawing.Color.White;
            this.buttonSelectDataFile.Location = new System.Drawing.Point(388, 37);
            this.buttonSelectDataFile.Name = "buttonSelectDataFile";
            this.buttonSelectDataFile.Size = new System.Drawing.Size(144, 30);
            this.buttonSelectDataFile.TabIndex = 23;
            this.buttonSelectDataFile.Text = "SELECT FILE (.txt)";
            this.buttonSelectDataFile.UseVisualStyleBackColor = false;
            this.buttonSelectDataFile.Click += new System.EventHandler(this.action_SelectCustomDataFile);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 97);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(524, 98);
            this.materialLabel1.TabIndex = 29;
            this.materialLabel1.Text = "File with custom data values that will be used to populate the specified column. " +
    "Every data value must be in a separate line. Do not include semi-colons or comma" +
    "s.";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // ControlFileType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.textboxFilePath);
            this.Controls.Add(this.buttonSelectDataFile);
            this.Name = "ControlFileType";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(540, 200);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField textboxFilePath;
        private System.Windows.Forms.Button buttonSelectDataFile;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
