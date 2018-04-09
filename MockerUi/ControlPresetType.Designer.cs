namespace MockerUi
{
    partial class ControlPresetType
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
            this.dropdownDataType = new MetroFramework.Controls.MetroComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // dropdownDataType
            // 
            this.dropdownDataType.DropDownHeight = 150;
            this.dropdownDataType.ForeColor = System.Drawing.Color.Black;
            this.dropdownDataType.FormattingEnabled = true;
            this.dropdownDataType.IntegralHeight = false;
            this.dropdownDataType.ItemHeight = 23;
            this.dropdownDataType.Location = new System.Drawing.Point(8, 29);
            this.dropdownDataType.Name = "dropdownDataType";
            this.dropdownDataType.Size = new System.Drawing.Size(236, 29);
            this.dropdownDataType.TabIndex = 30;
            this.dropdownDataType.UseSelectable = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 87);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(228, 108);
            this.materialLabel1.TabIndex = 33;
            this.materialLabel1.Text = "Custom data values that will be used to populate the specified column. Every data" +
    " value must be in a separate line.";
            // 
            // ControlPresetType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dropdownDataType);
            this.Name = "ControlPresetType";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(540, 200);
            this.Load += new System.EventHandler(this.action_FormLoad);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox dropdownDataType;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
