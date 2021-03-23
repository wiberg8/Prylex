using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public static class Functions
    {
        private static Random random = new Random();
        public static string RandomGeneratedString(int length, bool numbersOnly = false)
        {
            string chars;
            if (numbersOnly)
                chars = "123456789";
            else
                chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
