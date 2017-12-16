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
    public class BekkerService
    {
        private const string PlayersEndpoint = "https://bekksjakkapi.azurewebsites.net/api/Bekkere";

        public BekkerService() { }

        public async Task<List<Bekker>> HentAlleBekkereAsync()
        {
            var bekkerDataObjects = await DataHelpers.HentObjekter<BekkerDataObject>(PlayersEndpoint);
            return bekkerDataObjects.Select(x => new Bekker(x)).ToList();
        }
    }
}