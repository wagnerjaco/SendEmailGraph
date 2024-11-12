using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendEmailGraph
{
    public class Profile
    {       
        public string clientId { get; set; }
        public string clientSecret { get; set; }
        public string tenantId { get; set; }
        public string graphApiUrl { get; set; }
        public string user { get; set; }
        public string torecipient { get; set; }
        public string ccrecipient { get; set; }

    }
}
