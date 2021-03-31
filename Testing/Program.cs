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
        public static DataAccess dataAccess { get; set; }

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
            dataAccess = new DataAccess() { CurrentFile = AppSettings.Databas };
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NyArtikelDialog());
            AppSettings.Spara();
        }

    }
}
