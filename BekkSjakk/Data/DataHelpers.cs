using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using BekkSjakk.Data.DataObjects;
using BekkSjakk.Models;
using Newtonsoft.Json;

namespace BekkSjakk.Data
{
    public static class DataHelpers
    {
        public static async Task<List<T>> HentObjekter<T>(string url)
        {
            HttpClient client = new HttpClient();
            var apiKey = ConfigurationManager.AppSettings["ApiKey"];
            var fullUrl = $"{url}?code={apiKey}";
            using (HttpResponseMessage response = await client.GetAsync(fullUrl))
            {
                using (HttpContent content = response.Content)
                {
                    string result = await content.ReadAsStringAsync();
                    var dataObjectList = JsonConvert.DeserializeObject<List<T>>(result);
                    return dataObjectList;
                }
            }
        }
    }
}