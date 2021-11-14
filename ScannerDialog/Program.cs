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
            //TODO Om databas ej kan öppnas så måste en dialog där man kan välja db fixas
            if (DBAccess.Open(AppSettings.Databas))
            {
                Application.Run(new MainForm());
                DBAccess.Close();
            }
            AppSettings.Spara();
            Logger.WriteToFile();
        }

        private static bool IsApplicationRunning()
        {
            Process curr = Process.GetCurrentProcess();
            Process[] procs = Process.GetProcessesByName(curr.ProcessName);
            foreach (Process p in procs)
            {
                if ((p.Id != curr.Id) && (p.MainModule.FileName == curr.MainModule.FileName))
                {
                    return p is null;
                }
            }
            return false;
        }

        private static void BackupDatabase()
        {
            if (AppSettings.BackupOnStart && File.Exists(Global.DATABASE_FILE) && Directory.Exists(AppSettings.DatabasBackup))
            {
                IO.Backup(AppSettings.DatabasBackup, Global.DATABASE_FILE);
            }
        }

    }
}
