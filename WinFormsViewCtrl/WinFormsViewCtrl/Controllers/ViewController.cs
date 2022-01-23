using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsViewCtrl.Controllers
{
    public class ViewController
    {
        private Dictionary<string, UserControl> Views = new Dictionary<string, UserControl>();
        private Panel viewPanel;

        public ViewController(Panel panel)
        {
            viewPanel = panel;
            viewPanel.BackColor = Color.AliceBlue;
        }

        public void RegisterView(string name, UserControl control)
        {
            if (!Views.ContainsKey(name))
            {
                Views.Add(name, control);
            }
        }

        public void ShowView(string name)
        {
            if (!Views.ContainsKey(name))
            {
                throw new Exception($"There is no register View {name}");
            }

            UserControl ctrl = Views[name];
            ctrl.Visible = true;
            ctrl.Dock = DockStyle.Fill;
            viewPanel.Controls.Clear();
            viewPanel.Controls.Add(ctrl);
        }
    }
}
