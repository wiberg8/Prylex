using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrylanLibary;
using ScannerDialog.Forms;

namespace ScannerDialog
{
    static class Program
    {
        public static Installningar AppSettings { get; set; } = new Installningar();
        public static DataAccess DBAccess { get; private set; } = new DataAccess();
        public static bool ExitApplication { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (IsApplicationRunning())
            {
                MessageBox.Show(Locales.AlreadyRunning);
                return;
            }

            ApplicationStart();
        }

        private static void ApplicationStart()
        {
            AppSettings.Ladda();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BackupDatabase();
            bool dbOpen = DBAccess.Open(AppSettings.Databas);
            while (!dbOpen)
            {
                Application.Run(new BytDatabasForm());
                if (ExitApplication)
                {
                    AppSettings.Spara();
                    return;
                }
                dbOpen = DBAccess.Open(AppSettings.Databas);
            }
            Application.Run(new MainForm());
            DBAccess.Close();
            AppSettings.Spara();
            Logger.WriteToFile();
        }

        private static bool IsApplicationRunning()
        {
            Process curr = Process.GetCurrentProcess();
            return Process.GetProcessesByName(curr.ProcessName)
                        .Where(p => p.Id != curr.Id && p.MainModule.FileName == curr.MainModule.FileName)
                        .FirstOrDefault() != null;
        }

        private static void BackupDatabase()
        {
            try
            {
                if (AppSettings.BackupOnStart && File.Exists(AppSettings.Databas) && Directory.Exists(AppSettings.DatabasBackup))
                {
                    IO.Backup(AppSettings.DatabasBackup, AppSettings.Databas);
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
            }
        }

    }
}
