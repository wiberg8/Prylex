using Newtonsoft.Json;
using PrylanLibary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static PrylanLibary.Global;

namespace PrylanLibary
{ 
    public static class StringExtensions
    {
		public static string RemoveWhiteSpaces(this string str)
		{
			return string.Join(string.Empty, str.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
		}
	}
}
