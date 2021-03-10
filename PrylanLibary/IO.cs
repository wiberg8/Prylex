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
        //public static Encoding GetEncoding(string filename)
        //{
        //    // Read the BOM
        //    var bom = new byte[4];
        //    using (var file = new FileStream(filename, FileMode.Open, FileAccess.Read))
        //    {
        //        file.Read(bom, 0, 4);
        //    }

        //    // Analyze the BOM
        //    if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) return Encoding.UTF7;
        //    if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) return Encoding.UTF8;
        //    if (bom[0] == 0xff && bom[1] == 0xfe && bom[2] == 0 && bom[3] == 0) return Encoding.UTF32; //UTF-32LE
        //    if (bom[0] == 0xff && bom[1] == 0xfe) return Encoding.Unicode; //UTF-16LE
        //    if (bom[0] == 0xfe && bom[1] == 0xff) return Encoding.BigEndianUnicode; //UTF-16BE
        //    if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff) return new UTF32Encoding(true, true);  //UTF-32BE

        //    // We actually have no idea what the encoding is if we reach this point, so
        //    // you may wish to return null instead of defaulting to ASCII
        //    return Encoding.ASCII;
        //}
        public static Encoding GetEncoding(String fileName)
        {
            
            // open the file with the stream-reader:
            using (StreamReader reader = new StreamReader(fileName, true))
            {
                // read the contents of the file into a string
                String contents = reader.ReadToEnd();

                // return the encoding.
                return reader.CurrentEncoding;
            }
        }
    }
}
