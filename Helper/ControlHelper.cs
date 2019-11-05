using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditX.Helper
{
    public class ControlHelper
    {
        public static Panel findPanel(Form form, string key)
        {
            var panel = form.Controls.Find(key, true).FirstOrDefault() as Panel;
            try
            {
                if (panel == null)
                {
                    throw new Exception($"Panel with that key {key} is not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return panel;
        }
    }
}
