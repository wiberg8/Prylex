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
        public async Task<LicenseWrapper> AuenticateLicenseAsync(Guid guid)
        {
            try
            {
                string formattedAdress = string.Format("https://localhost:5000/authenticate/Licens/{0}", guid.ToString());
                var encodedWrapper = await (await client.GetAsync(formattedAdress)).Content.ReadAsStringAsync();
                LicenseWrapper licenseWrapper = JsonConvert.DeserializeObject<LicenseWrapper>(encodedWrapper);
                return licenseWrapper;
            }
            catch
            {
                return null;
            }
        }
    }
}
