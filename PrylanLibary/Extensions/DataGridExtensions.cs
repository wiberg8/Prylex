using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrylanLibary
{
    public static class DataGridLibary
    {

        public static void SetColorVariationToRows(this DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (i % 2 == 0)
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = Global.FIRST_GRID_COLOR;
                else
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = Global.SECOND_GRID_COLOR;
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
