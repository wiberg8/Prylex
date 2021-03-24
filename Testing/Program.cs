using PrylanLibary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing
{
    static class Program
    {
        public static Installningar AppSettings { get; set; }

        static Program()
        {
            Installningar.FileName = Config.InstallningarFileName;
            AppSettings = new Installningar();
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppSettings.Ladda();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NyArtikelDialog());
            AppSettings.Spara();
        }

    }
}
