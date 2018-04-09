using System;
using System.Windows.Forms;
using System.Collections;

namespace MockerUi
{
    public partial class ControlPresetType : UserControl
    {
        private Common common = new Common();

        public ControlPresetType()
        {
            InitializeComponent();
        }

        private void action_FormLoad(object sender, EventArgs e)
        {
            string file = "DataTypes.txt";
            string directory = common.event_GetCurrentDirectory();
            ArrayList dataTypes = common.event_RetrieveFileContents(directory + "\\" + file);
            dropdownDataType.DataSource = dataTypes;
        }

        internal string event_RetrievePresetDataSelection()
        {
            return dropdownDataType.Text;
        }

        internal void event_ResetFields()
        {
            dropdownDataType.SelectedIndex = 0;
        }
    }
}
