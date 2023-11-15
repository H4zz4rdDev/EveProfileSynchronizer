using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EveProfileSynchronizer.Core
{
    internal class EsiDataProvider
    {
        public HttpResponseMessage GetCharacterNames(int[] characterIds)
        {
            if (characterIds == null) throw new ArgumentNullException(nameof(characterIds));

            var client = new HttpClient();
            var httpRequestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://esi.evetech.net/latest/universe/names/?datasource=tranquility"),
                Headers =
                {
                    { HttpRequestHeader.Accept.ToString(), "application/json" },
                    { "Cache-Control", "no-cache" }
                },
                Content = new StringContent(JsonConvert.SerializeObject(characterIds), Encoding.UTF8, "application/json")
            };

            return client.SendAsync(httpRequestMessage).Result;
        }
    }
}
