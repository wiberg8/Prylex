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
        private const string passwordHash = "UFODLE68";
        private const string saltKey = "86VNDOFU";
        private const string vIKey = "isdf345tHtHjHnYU";
        private const string alphabet = "1QAZ2WSX3EDC4RFV5TGB6YHN7UJM8K9OLP";
        private const string installningarFileName = "Installningar.json";
        private static readonly Color standardForeColor = SystemColors.ControlText;
        private static readonly Color highlightColor = SystemColors.MenuHighlight;
        private static readonly Color firstGridColor = Color.White;
        private static readonly Color secondGridColor = Color.FromArgb(242, 242, 242);

        public static string PasswordHash => passwordHash;
        public static string SaltKey => saltKey;
        public static string VIKey => vIKey;
        public static string Alphabet => alphabet;
        public static string InstallningarFileName => installningarFileName;
        public static Color StandardForeColor => standardForeColor;
        public static Color HighlightColor => highlightColor;
        public static Color FirstGridColor => firstGridColor;
        public static Color SecondGridColor => secondGridColor;
    }
}
