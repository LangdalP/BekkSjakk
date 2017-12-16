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
            var partiDataObjects = await DataHelpers.HentObjekter<SjakkPartiDataObject>(GamesEndpoint);
            return partiDataObjects.Select(p => new SjakkParti(p)).ToList();
        }

    }
}