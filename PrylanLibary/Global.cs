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
        public const string PASSWORD_HASH = "UFODLE68";
        public const string SALT_KEY = "86VNDOFU";
        public const string VI_KEY = "isdf345tHtHjHnYU";
        public const string ALPHABET = "1QAZ2WSX3EDC4RFV5TGB6YHN7UJM8K9OLP";
        public const string INSTALLNINGAR_FILENAME = "Installningar.json";
        public const string TABLE_QUERIES_FILENAME = "tables.sql3";
        public const string PERSNR_REGEX = "^[0-9]{6}[-][0-9]{4}$";
        public static readonly Color STANDARD_FORE_COLOR;
        public static readonly Color HIGHLIGHT_COLOR;
        public static readonly Color FIRST_GRID_COLOR;
        public static readonly Color SECOND_GRID_COLOR;
        public static readonly string EXCEC_DRIVE;
        public static readonly string DATABASE_FILE;
        public static readonly string DATABASE_FOLDER;

        static Global()
        {
            STANDARD_FORE_COLOR = SystemColors.ControlText;
            HIGHLIGHT_COLOR = SystemColors.MenuHighlight;
            FIRST_GRID_COLOR = Color.White;
            SECOND_GRID_COLOR = Color.FromArgb(242, 242, 242);
            EXCEC_DRIVE = Path.GetPathRoot(System.Reflection.Assembly.GetEntryAssembly().Location);
            DATABASE_FOLDER = Path.Combine(EXCEC_DRIVE, "DB");
            DATABASE_FILE = Path.Combine(DATABASE_FOLDER, "prylexDB.db");
        }
    }
}
