using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;
using BekkSjakk.Data.DataObjects;

namespace BekkSjakk.Models
{
    public class SjakkParti
    {
        public string SpillerHvit { get; }
        public string SpillerSvart { get; }
        public DateTimeOffset Dato { get; }
        public PartiResultat Resultat { get; }
        public string Pgn { get; }

        public SjakkParti(string hvit, string svart, DateTimeOffset dato, PartiResultat resultat, string pgn)
        {
            SpillerHvit = hvit;
            SpillerSvart = svart;
            Dato = dato;
            Resultat = resultat;
            Pgn = pgn;
        }

        public SjakkParti(SjakkPartiDataObject dataObject)
        {
            SpillerHvit = dataObject.SpillerHvit.Navn;
            SpillerSvart = dataObject.SpillerSvart.Navn;
            Dato = dataObject.Dato;
            Resultat = dataObject.Resultat;
            Pgn = dataObject.Pgn;
        }
    }
}