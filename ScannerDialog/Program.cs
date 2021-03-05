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

namespace ScannerDialog
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (PriorProcess() is null)
            {
                Installningar.FileName = "Installningar.json";
                BackupDatabase();
                DBHandler.SetConnection(Installningar.Hamta().Databas);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMain());
            }
            else
            {
                MessageBox.Show("Applikationen kör redan");
            }
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
