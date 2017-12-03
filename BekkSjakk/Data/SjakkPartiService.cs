using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using BekkSjakk.Data.DataObjects;
using BekkSjakk.Models;
using Newtonsoft.Json;

namespace BekkSjakk.Data
{
    public class SjakkPartiService
    {
        private const string GamesEndpoint = "https://bekksjakkapi.azurewebsites.net/api/Partier";

        public SjakkPartiService() { }

        public async Task<List<SjakkParti>> HentAllePartiAsync()
        {
            HttpClient client = new HttpClient();
            var apiKey = ConfigurationManager.AppSettings["ApiKey"];
            var fullUrl = $"{GamesEndpoint}?code={apiKey}";
            using (HttpResponseMessage response = await client.GetAsync(fullUrl))
            {
                using (HttpContent content = response.Content)
                {
                    string result = await content.ReadAsStringAsync();
                    var partierDataObject = JsonConvert.DeserializeObject<List<SjakkPartiDataObject>>(result);
                    return partierDataObject.Select(p => new SjakkParti(p)).ToList();
                }
            }
        }

    }
}