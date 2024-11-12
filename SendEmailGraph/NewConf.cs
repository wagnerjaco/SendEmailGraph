using System;
using prmToolkit.Configuration;

namespace SendEmailGraph
{
    public static class NewConf
    {
        public static Profile GetProfile()
        {
            Profile profile = new Profile();           
            profile.clientId = Configuration.GetKeyAppSettings("clientId");
            profile.clientSecret = Configuration.GetKeyAppSettings("clientSecret");
            profile.tenantId = Configuration.GetKeyAppSettings("tenantId");
            profile.graphApiUrl = Configuration.GetKeyAppSettings("graphApiUrl");
            profile.user = Configuration.GetKeyAppSettings("user");
            profile.torecipient = Configuration.GetKeyAppSettings("torecipient");
            profile.ccrecipient = Configuration.GetKeyAppSettings("ccrecipient");
            return profile;
        }

    }
}
