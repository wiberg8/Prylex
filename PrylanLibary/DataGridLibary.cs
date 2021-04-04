using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrylanLibary
{
    public class DataGridLibary
    {
        public static void SetColorVariationToRows(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (i % 2 == 0)
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = Config.FirstGridColor;
                else
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = Config.SecondGridColor;
            }
        }

        public static void SetColorVariationToRows(DataGridView dataGridView, Color first, Color second)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (i % 2 == 0)
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = first;
                else
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = second;
            }
        }
    }
}
