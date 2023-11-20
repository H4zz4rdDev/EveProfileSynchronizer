using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using EveProfileSynchronizer.Core.Model;
using Newtonsoft.Json;

namespace EveProfileSynchronizer.Core
{
    internal class EsiDataProvider
    {
        public string GetCharacterNamesJson(int[] characterIds)
        {
            if (characterIds == null) throw new ArgumentNullException(nameof(characterIds));

            var responseMessage = DoEsiCall(characterIds);

            return responseMessage.Content.ReadAsStringAsync().Result;

            //File.WriteAllText(
            //    AppConfiguration.GetCacheFolderPath() + "\\eve_profiles.json",
            //    AppUtils.FormatJson(responseMessageString));
        }

        public string GetCharacterCorpAndAllianceName(int[] ids)
        {
            if (ids == null) throw new ArgumentNullException(nameof(ids));

            var responseMessage = DoEsiCall(ids);

            return responseMessage.Content.ReadAsStringAsync().Result;
        }

        public string GetCharacterDetailsJson(int characterId)
        {
            var client = new HttpClient();

            var httpRequestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://esi.evetech.net/latest/characters/{characterId}/?datasource=tranquility"),
            };

            var result = client.SendAsync(httpRequestMessage).Result.Content.ReadAsStringAsync().Result;

            return result;
        }

        private HttpResponseMessage DoEsiCall(object data)
        {
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
                Content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json")
            };

            return client.SendAsync(httpRequestMessage).Result;
        }
    }
}
