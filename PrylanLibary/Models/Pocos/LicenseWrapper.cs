using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrylanLibary.Models.Pocos
{
    public class LicenseWrapper
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("hasExpired")]
        public bool HasExpired { get; set; }

        [JsonProperty("expireDate")]
        public DateTime ExpireDate { get; set; }
    }
}
