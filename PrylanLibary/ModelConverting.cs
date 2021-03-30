using Newtonsoft.Json;
using PrylanLibary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrylanLibary
{
    public static class ModelConverting
    {
        public static string ToJson(this List<Person> personer)
        {
            string personerEnkodad = JsonConvert.SerializeObject(personer, Formatting.Indented);
            return personerEnkodad;
        }

        public static string ToJson(this List<Artikel> artiklar)
        {
            string artiklarEnkodad = JsonConvert.SerializeObject(artiklar, Formatting.Indented);
            return artiklarEnkodad;
        }
    }
}
