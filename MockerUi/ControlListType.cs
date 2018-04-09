using System.Windows.Forms;

namespace MockerUi
{
    public partial class ControlListType : UserControl
    {
        public ControlListType()
        {
            InitializeComponent();
        }

        internal string event_RetrieveDataValuesArray()
        {
            string dataGlob = textboxCustomData.Text;
            dataGlob = dataGlob.Replace("\n", ";");
            return dataGlob;
        }

        internal void event_ResetFields()
        {
            textboxCustomData.ResetText();
        }
    }
}
