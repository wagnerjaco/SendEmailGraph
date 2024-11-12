using Newtonsoft.Json;
using System.Net.Http.Headers;


namespace SendEmailGraph
{

    public class SendEmail
    {
        public static Profile profile;
        public async Task SendEmailGraphAsync(string token)
        {
            profile = NewConf.GetProfile();
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var emailContent = new
                {
                    message = new
                    {
                        subject = "Testando envio de e-mail via Graph API",
                        body = new
                        {
                            contentType = "HTML",
                            content = "<p>Olá, equipe!</p><p>Este é um e-mail de teste enviado pela API Microsoft Graph.</p>"
                        },
                        toRecipients = new[]
                        {
                            new { emailAddress = new { address =profile.torecipient} }
                        },
                        ccRecipients = new[]
                        {
                            new { emailAddress = new { address =profile.ccrecipient } }
                        }
                    },
                    saveToSentItems = "true"
                };

                var content = new StringContent(JsonConvert.SerializeObject(emailContent), System.Text.Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync($"{profile.graphApiUrl}/users/{profile.user}/sendMail", content);

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("E-mail enviado com sucesso!");
                }
                else
                {
                    Console.WriteLine($"Erro ao enviar e-mail: {response.StatusCode} - {await response.Content.ReadAsStringAsync()}");
                }
            }
        }
    }
}
