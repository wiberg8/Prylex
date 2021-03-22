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
            Installningar.FileName = Config.InstallningarFileName;
            BackupDatabase();
            DataAccess.CurrentFile = Installningar.Hamta().Databas;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        private static Process PriorProcess()
        {
            Process curr = Process.GetCurrentProcess();
            Process[] procs = Process.GetProcessesByName(curr.ProcessName);
            foreach (Process p in procs)
            {
                if ((p.Id != curr.Id) &&
                    (p.MainModule.FileName == curr.MainModule.FileName))
                    return p;
            }
            return null;
        }

        public static void BackupDatabase()
        {
            var ins = Installningar.Hamta();
            if (ins.BackupOnStart && File.Exists(ins.Databas) && Directory.Exists(ins.DatabasBackup))
            {
                IO.Backup(ins.DatabasBackup, ins.Databas);
            }
        }

    }
}
