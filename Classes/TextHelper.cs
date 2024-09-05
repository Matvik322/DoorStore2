using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoorStoreV2.Classes
{
    public class TextHelper
    {
        private Dictionary<Control, string> initialTexts;

        public TextHelper()
        {
            initialTexts = new Dictionary<Control, string>();
        }

        public void ClearText(Control control)
        {
            SaveInitialText(control);
            control.Text = string.Empty;
        }

        public void RestoreText(Control control)
        {
            if (initialTexts.ContainsKey(control))
            {
                control.Text = initialTexts[control];
            }
        }

        private void SaveInitialText(Control control)
        {
            if (!initialTexts.ContainsKey(control))
            {
                initialTexts[control] = control.Text;
            }
        }
    }
}
