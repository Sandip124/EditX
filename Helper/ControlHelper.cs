using System;
using System.Linq;
using System.Windows.Forms;

namespace EditX.Helper
{
    public class ControlHelper
    {
        public static Panel findPanel(Form form, string key)
        {
            if (!(form.Controls.Find(key, true).FirstOrDefault() is Panel panel))
            {
                throw new Exception($"Panel with that key {key} is not found.");
            }
            return panel;
        }
    }
}
