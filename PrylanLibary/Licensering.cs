using Newtonsoft.Json;
using PrylanLibary.Models.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PrylanLibary
{
    public class Licensering
    {
        private HttpClient client = new HttpClient();
        public async Task<LicenseWrapper> LogInAsync(string kundNamn, string pinKod)
        {
            try
            {
                string formattedAdress = string.Format("https://localhost:44366/api/Licens/{0}/{1}", kundNamn, pinKod);
                var encodedWrapper = await (await client.GetAsync(formattedAdress)).Content.ReadAsStringAsync();
                LicenseWrapper licenseWrapper = JsonConvert.DeserializeObject<LicenseWrapper>(encodedWrapper);
                return licenseWrapper;
            }
            catch
            {
                return null;
            }
        }

        public async Task<IList<string>> GetDistinctKundNamnAsync()
        {
            try
            {
                string getAdress = string.Format("https://localhost:44366/api/Licens/");
                var encodedNames = await (await client.GetAsync(getAdress)).Content.ReadAsStringAsync();
                List<string> names = JsonConvert.DeserializeObject<List<string>>(encodedNames);
                if (names is null)
                    names =  new List<string>();
                return names;
            }
            catch
            {
                return new List<string>();
            }
        }
    }
}
