using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace PrylanLibary
{
    public static class Global
    {
        public const string INSTALLNINGAR_FILENAME = "Installningar.json";
        public const string PERSNR_REGEX = "^[0-9]{6}[-][0-9]{4}$";
        public static readonly Color STANDARD_FORE_COLOR;
        public static readonly Color HIGHLIGHT_COLOR;
        public static readonly Color FIRST_GRID_COLOR;
        public static readonly Color SECOND_GRID_COLOR;

        static Global()
        {
            STANDARD_FORE_COLOR = SystemColors.ControlText;
            HIGHLIGHT_COLOR = SystemColors.MenuHighlight;
            FIRST_GRID_COLOR = Color.White;
            SECOND_GRID_COLOR = Color.FromArgb(242, 242, 242);
        }
    }
}
