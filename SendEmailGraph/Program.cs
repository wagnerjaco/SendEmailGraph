using System.Net.Http.Headers;
using Microsoft.Identity.Client;
using Newtonsoft.Json;
using SendEmailGraph;

namespace SendEmailGraphGraph
{
    public class Program
    {

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
