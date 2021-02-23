using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
            Installningar.FileName = "Installningar.json";
            BackupDatabase();
            DBHandler.SetConnection(Installningar.Hamta().Databas);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        public static void BackupDatabase()
        {
            var ins = Installningar.Hamta();
            if (ins.BackupOnStart && File.Exists(ins.Databas) && Directory.Exists(ins.DatabasBackup))
            {
                IO.Backup(ins.DatabasBackup, ins.Databas);
            }
        }

        public static void PreLoadSettings()
        {
            var ins = new Installningar();
            ins.ForetagsNamn = "KalleKula";
            ins.Beskrivningar = new List<string> {"Dell-3190", "Dell-3180", "HP-430"};
            ins.Os = new List<string> { "Windows 10", "Windows 7", "Windows XP" };
            ins.Tillhorigheter = new List<string> { "2015", "2016", "2017" };
            ins.Handelser = new List<string> { "Skickad på reperation", "Återlämnad reperation"};
            ins.Databas = @"E:\PrylanDb.db";
            Installningar.Spara(ins);
        }


    }
}
