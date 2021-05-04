using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrylanLibary
{
    public static class FormExtensions
    {
        public static IEnumerable<Control> GetAllChildren(this Control root)
        {
            Stack<Control> stack = new Stack<Control>();
            stack.Push(root);

            while (stack.Any())
            {
                Control next = stack.Pop();
                foreach (Control child in next.Controls)
                {
                    stack.Push(child);
                }
                yield return next;
            }
        }
    }
}
