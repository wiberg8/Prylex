using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrylanLibary
{
    public class IO
    {
        public static void Backup(string directory, string BackupFile)
        {
            string CurrentDate;
            try
            {
                if (File.Exists(BackupFile))
                {
                    CurrentDate = DateTime.Now.ToString("yyyyMMdd_hhmmss");
                    File.Copy(BackupFile, directory + @"\Backup " + CurrentDate + Path.GetExtension(BackupFile));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Backup method error\n" + e.Message.ToString());
            }
        }
        public static void OpenDirectory(string DPath)
        {
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = DPath,
                    UseShellExecute = true,
                    Verb = "open"
                });
            }
            catch (Exception e)
            {
                Console.WriteLine("OpenDirectory method error\n" + e.Message.ToString());
            }
        }
    }
}
