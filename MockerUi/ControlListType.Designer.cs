namespace MockerUi
{
    partial class ControlListType
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
            this.textboxCustomData = new System.Windows.Forms.TextBox();
            this.labelDescription = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // textboxCustomData
            // 
            this.textboxCustomData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxCustomData.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxCustomData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.textboxCustomData.Location = new System.Drawing.Point(8, 8);
            this.textboxCustomData.Multiline = true;
            this.textboxCustomData.Name = "textboxCustomData";
            this.textboxCustomData.Size = new System.Drawing.Size(297, 184);
            this.textboxCustomData.TabIndex = 5;
            // 
            // labelDescription
            // 
            this.labelDescription.Depth = 0;
            this.labelDescription.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDescription.Location = new System.Drawing.Point(337, 8);
            this.labelDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(195, 184);
            this.labelDescription.TabIndex = 28;
            this.labelDescription.Text = "Type in custom data values that will be used to populate the specified column. Ev" +
    "ery data value must be in a separate line. Do not include semi-colons or commas." +
    "";
            // 
            // ControlListType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textboxCustomData);
            this.Name = "ControlListType";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(540, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxCustomData;
        private MaterialSkin.Controls.MaterialLabel labelDescription;
    }
}
