using System.Net.Http.Headers;
using Microsoft.Identity.Client;
using Newtonsoft.Json;
using SendEmailGraph;

namespace SendEmailGraphGraph
{
    public class Program
    {
        //private static readonly string clientId = "4d592024-82e1-4eeb-b067-753fbcda8577";
        //private static readonly string clientSecret = "pnC8Q~sAOx4D7O3fOm-aln6UO0dAXndc9gx6QdAz";
        //private static readonly string tenantId = "3215374b-193f-44ca-aa45-6b25df64043e";
        //private static readonly string graphApiUrl = "https://graph.microsoft.com/v1.0";
        //private static readonly string user = "wagner.jaco@toolsort.com.br";
        //private SmtpEmail smtpEmail;
        public static Profile profile;
        public static SendEmail _SendEmail;
        static async Task Main(string[] args)
        {
            profile = NewConf.GetProfile();
            _SendEmail = new SendEmail();
            string token = await GetAccessTokenAsync();
            if (!string.IsNullOrEmpty(token))
            {
               await _SendEmail.SendEmailGraphAsync(token);
            }
        }

        private static async Task<string> GetAccessTokenAsync()
        {
            var app = ConfidentialClientApplicationBuilder.Create(profile.clientId)
                .WithClientSecret(profile.clientSecret)
                .WithAuthority(new Uri($"https://login.microsoftonline.com/{profile.tenantId}"))
                .Build();

            string[] scopes = { "https://graph.microsoft.com/.default" };

            try
            {
                var result = await app.AcquireTokenForClient(scopes).ExecuteAsync();
                return result.AccessToken;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter token: {ex.Message}");
                return null;
            }
        }

    }
}
