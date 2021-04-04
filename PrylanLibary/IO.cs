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
                    File.Copy(backupFile, directory + $"\\{Path.GetFileNameWithoutExtension(backupFile)}" + currentDate + Path.GetExtension(backupFile));
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
