using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
        public static DataAccess DBAccess { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (PriorProcess() is null)
            {
                ApplicationStart();
            }
            else
            {
                MessageBox.Show("Applikationen kör redan");
            }
        }

        private static void ApplicationStart()
        {
            AppSettings.FileName = Config.InstallningarFileName;
            AppSettings.Ladda();
            BackupDatabase();
            DBAccess = new DataAccess() { CurrentFile = AppSettings.Databas };
            DBAccess.TryOpen();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
            DBAccess.Close();
            AppSettings.Spara();
        }

        private static Process PriorProcess()
        {
            Process curr = Process.GetCurrentProcess();
            Process[] procs = Process.GetProcessesByName(curr.ProcessName);
            foreach (Process p in procs)
            {
                if ((p.Id != curr.Id) && (p.MainModule.FileName == curr.MainModule.FileName))
                {
                    return p;
                }
            }
            return null;
        }

        public static void BackupDatabase()
        {
            if (AppSettings.BackupOnStart && File.Exists(AppSettings.Databas) && Directory.Exists(AppSettings.DatabasBackup))
            {
                IO.Backup(AppSettings.DatabasBackup, AppSettings.Databas);
            }
        }

    }
}
