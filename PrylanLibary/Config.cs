using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PrylanLibary
{
    public static class Config
    {
        public const string PASSWORD_HASH = "UFODLE68";
        public const string SALT_KEY = "86VNDOFU";
        public const string VI_KEY = "isdf345tHtHjHnYU";
        public const string ALPHABET = "1QAZ2WSX3EDC4RFV5TGB6YHN7UJM8K9OLP";
        public const string INSTALLNINGAR_FILENAME = "Installningar.json";
        public const string TABLE_QUERIES_FILENAME = "tables.sql3";
        public const string PERSNR_REGEX = "^[0-9]{6}[-][0-9]{4}$";
        public static readonly Color STANDARD_FORE_COLOR = SystemColors.ControlText;
        public static readonly Color HIGHLIGHT_COLOR = SystemColors.MenuHighlight;
        public static readonly Color FIRST_GRID_COLOR = Color.White;
        public static readonly Color SECOND_GRID_COLOR = Color.FromArgb(242, 242, 242);
    }
}
