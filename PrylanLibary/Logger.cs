using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrylanLibary
{
    public static class Logger
    {
        private static readonly StringBuilder logBuilder = new StringBuilder();
        private static readonly string logFileName = "exceptions.txt";
        public static void Log(Exception x)
        {
            logBuilder.Append($"------{x.GetType()}\n");
            logBuilder.Append(x);
            logBuilder.Append($"\n------{x.GetType()}\n");
        }
        public static void Log(string x)
        {
            logBuilder.Append($"{x}\n");
        }

        public static void WriteToFile()
        {
            File.WriteAllText(logFileName, logBuilder.ToString());
        }
    }
}
