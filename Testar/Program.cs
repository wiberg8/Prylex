using System;
using System.Collections.Generic;
using System.Linq;
using static Testar.Functions;

namespace Testar
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Parse();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.GetType());
            }  
            finally
            {
                
            }
            //int x = int.Parse(Console.ReadLine());
            //var lines = new List<string>();
            //for (int i = 1; i <= x; i++)
            //{
            //    lines.Add($"{GeneratePersNr()};{GetRandomLastName()};{GetRandomFirstName()}");
            //}
            //System.IO.File.WriteAllLines("exports.txt", lines);
            //Console.ReadLine();
        }
        static void Parse()
        {
            try
            {
                int.Parse("123h4");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    
}
