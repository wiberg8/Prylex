using Newtonsoft.Json;
using PrylanLibary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrylanLibary
{
    public static class ObjectExtensions
    {
        public static string ToJson(this object o)
        {
            string enkodad = JsonConvert.SerializeObject(o, Formatting.Indented);
            return enkodad;
        }
    }
}
