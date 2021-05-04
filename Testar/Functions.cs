using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testar
{
    class Functions
    {
        private static readonly Random random = new Random();
        private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private const string numbers = "123456789";
        public static string[] firstNames = File.ReadAllLines("FirstNames.txt");
        public static string[] lastNames = File.ReadAllLines("lastNames.txt");

        public static string GeneratePersNr()
        {
            return $"{GenerateRandomNumbers(6)}-{GenerateRandomNumbers(4)}";
        }

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

        public static string GetRandomFirstName()
        {
            return firstNames[random.Next(0, firstNames.Count() - 1)];
        }
        public static string GetRandomLastName()
        {
            return lastNames[random.Next(0, lastNames.Count() - 1)];
        }
    }
}
