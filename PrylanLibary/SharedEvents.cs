using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrylanLibary
{
    public static class SharedEvents
    {
        private static void mouseEnter(object sender, EventArgs e)
        {
            if (sender is Label label)
            {
                label.ForeColor = Config.HIGHLIGHT_COLOR;
            }
        }
        private static void mouseLeave(object sender, EventArgs e)
        {
            if(sender is Label label)
            {
                label.ForeColor = Config.STANDARD_FORE_COLOR;
            }
        }
        private static void doubleClick(object sender, EventArgs e)
        {
            if (sender is Label label)
            {
                Clipboard.SetText(label.Text);
            }  
        }
        public static void AttachToAllLabelsInForm(Form frm, System.ComponentModel.ComponentCollection compoments)
        {
            IEnumerable<Control> controls = frm.GetAllChildren();
            ToolTip toolTip = compoments.OfType<ToolTip>().FirstOrDefault();
            foreach (Control ctrl in controls)
            {
                if(ctrl is Label label)
                {
                    label.MouseDoubleClick += doubleClick;
                    label.MouseLeave += mouseLeave;
                    label.MouseEnter += mouseEnter;
                    toolTip?.SetToolTip(label, Locales.KopieraDubbelKlick);
                }
            }
        }
    }
}
