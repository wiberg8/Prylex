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
        private static readonly USBAuthentication usbAuthentication = new USBAuthentication();
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

            (bool, string) x = usbAuthentication.AuthenticateUSB();
            bool usbConnected = x.Item1;
            string message = x.Item2;
            if (usbConnected)
            {
                SetupFolderDBFile();
                ApplicationStart();
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private static void ApplicationStart()
        {
            AppSettings.Ladda();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LicensDialog dialog = new LicensDialog();
            dialog.ShowDialog();
            if (dialog.SuccesfulAuthentication)
            {
                AppSettings.LastLicense = dialog.SuccesfulLicense;
                BackupDatabase();
                if (DBAccess.Open(Global.DATABASE_FILE))
                {
                    Application.Run(new MainForm());
                    DBAccess.Close();
                }
            }
            AppSettings.Spara();
            Logger.WriteToFile();
        }


        static void SetupFolderDBFile()
        {
            DirectoryInfo dbFolder = Directory.CreateDirectory(Global.DATABASE_FOLDER);
            FileInfo dbFile = new FileInfo(Global.DATABASE_FILE);
            if (dbFolder.Exists && !dbFile.Exists)
            {
               // new DataAccess().CreateFile(Global.DATABASE_FILE);
            }
        }
        //private static void CreateNeededFoldersIfNotExist()
        //{
        //    if (Global.)
        //    {

        //    }
        //}

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
