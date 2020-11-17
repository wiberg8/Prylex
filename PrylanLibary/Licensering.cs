using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace PrylanLibary
{
    public static class Licensering
    {
		public static string GetComputerUUId()
		{
			var mos = new ManagementObjectSearcher("Select UUID From Win32_ComputerSystemProduct");
			ManagementObjectCollection mbsList = mos.Get();
			string id = null;
			foreach (ManagementBaseObject mo in mbsList)
			{
				id = mo["UUID"].ToString();
				break;
			}
			string aId = null;
			string[] splits = id.Split('-');
			foreach (string s in splits)
				aId += s;

			return UUIDEncrypt(aId, Config.Alphabet);
		}

		private static string UUIDEncrypt(string plainText, string alphabet)
		{
			//if (plainText.Contains('-'))
			//	plainText = string.Join("", plainText.Split('-'));
			//Console.WriteLine(plainText);
			String encryptedString = null;
			int shift = alphabet.Length / 2;

			int count = 1;
			foreach (char c in plainText)
			{
				int nextIndex = alphabet.IndexOf(c) + shift;
				if (nextIndex >= alphabet.Length)
					nextIndex = nextIndex - alphabet.Length;

				encryptedString += alphabet[nextIndex];
				shift = alphabet.IndexOf(alphabet[nextIndex]);

				if (count == 8 || count == 16 || count == 24)
					encryptedString += "-";
				count++;

			}

			return encryptedString;
		}

		private static string UUIDDecrypt(string encryptedText, string alphabet)
		{
			String plainString = null;
			int shift = alphabet.Length / 2;
			foreach (char c in encryptedText)
			{
				int nextIndex = alphabet.IndexOf(c) - shift;
				if (nextIndex < 0)
					nextIndex = alphabet.Length + nextIndex;
				plainString += alphabet[nextIndex];
				shift = alphabet.IndexOf(c);
			}
			return plainString;
		}

		public static string ExtractUUID(this string Licence)
		{
			string[] splits = Licence.Split('-');
			return splits[0] + splits[2] + splits[4] + splits[6];
		}

		public static DateTime ExtractDateTime(string Licence)
		{
			string[] splits = Licence.Split('-');
			return DateTime.Parse(splits[1] +"-"+ splits[3] + "-" + splits[5]);
		}

		public static bool LicenseValid()
        {
			return false;
        }

		public static bool LiceneCorrectFormat()
        {
			return false;
		}

		public static DateTime LicenseGetDate()
		{
			return new DateTime();
		}
	}
}
