using System;
using System.Windows.Forms;

namespace MockerUi
{
    public partial class ControlFileType : UserControl
    {
        public ControlFileType()
        {
            InitializeComponent();
        }

        private void action_SelectCustomDataFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                textboxFilePath.Text = openFileDialog.FileName;
            }
        }

        internal string event_RetrieveFilePath()
        {
            return textboxFilePath.Text;
        }

        internal void event_ResetFields()
        {
            textboxFilePath.ResetText();
        }
    }
}
