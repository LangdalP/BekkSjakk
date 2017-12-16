using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BekkSjakk.Data.DataObjects;

namespace BekkSjakk.Models
{
    public class Bekker
    {
        public string Navn { get; set; }
        public int Elo { get; set; }

        public Bekker() { }

        public Bekker(BekkerDataObject dataObject)
        {
            Navn = dataObject.Navn;
            Elo = dataObject.Elo;
        }
    }
}