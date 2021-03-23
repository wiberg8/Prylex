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
        public const string PasswordHash = "UFODLE68";
        public const string SaltKey = "86VNDOFU";
        public const string VIKey = "isdf345tHtHjHnYU";
        public const string Alphabet = "1QAZ2WSX3EDC4RFV5TGB6YHN7UJM8K9OLP";

        public const string InstallningarFileName = "Installningar.json";
        public static readonly Color standardForeColor = SystemColors.ControlText;
        public static readonly Color highlightColor = SystemColors.MenuHighlight;
        public static readonly Color firstGridColor = Color.White;
        public static readonly Color secondGridColor = Color.FromArgb(242, 242, 242);
    }
}
