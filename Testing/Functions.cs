using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Functions
    {
        private static readonly Random random = new Random();
        private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private const string numbers = "123456789";

        public static string GenerateRandom(int length)
        {
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string GenerateRandomNumbers(int length)
        {
            return new string(Enumerable.Repeat(numbers, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
