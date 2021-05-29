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
                MessageBox.Show(Locales.AlreadyRunning);
            }
        }

        private static void ApplicationStart()
        {
            Installningar.FileName = Config.INSTALLNINGAR_FILENAME;
            AppSettings.Ladda();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LicensDialog dialog = new LicensDialog();
            dialog.ShowDialog();
            if (dialog.SuccesfulAuthentication)
            {
                AppSettings.LastLicense = dialog.SuccesfulLicense;
                BackupDatabase();
                DBAccess = new DataAccess() { CurrentFile = AppSettings.Databas };
                DBAccess.TryOpen();
                Application.Run(new MainForm());
                DBAccess.Close();
            }
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

        private static void BackupDatabase()
        {
            if (AppSettings.BackupOnStart && File.Exists(AppSettings.Databas) && Directory.Exists(AppSettings.DatabasBackup))
            {
                IO.Backup(AppSettings.DatabasBackup, AppSettings.Databas);
            }
        }

    }
}
