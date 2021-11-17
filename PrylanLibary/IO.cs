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
        public static void Backup(string directory, string backupFile)
        {
            string currentDate;
            try
            {
                if (File.Exists(backupFile))
                {
                    currentDate = DateTime.Now.ToString(" [yyyy-MM-dd HH.mm.ss]");
                    File.Copy(backupFile, $"{directory}\\{Path.GetFileNameWithoutExtension(backupFile)}{currentDate}{Path.GetExtension(backupFile)}");
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
            }
        }
        public static void OpenDirectory(string dir)
        {
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = dir,
                    UseShellExecute = true,
                    Verb = "open"
                });
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
            }
        }

        public static Encoding GetEncoding(string fileName)
        {
            Encoding encoding;
            // open the file with the stream-reader:
            using (StreamReader reader = new StreamReader(fileName, true))
            {
                // read the contents of the file into a string
                string contents = reader.ReadToEnd();

                // return the encoding.
                encoding = reader.CurrentEncoding;
            }
            return encoding;
        }
    }
}
