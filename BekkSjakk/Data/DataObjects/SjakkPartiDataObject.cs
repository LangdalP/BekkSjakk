using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BekkSjakk.Models;

namespace BekkSjakk.Data.DataObjects
{
    public class SjakkPartiDataObject
    {
        public int Id { get; set; }
        public BekkerDataObject SpillerHvit { get; set; }
        public BekkerDataObject SpillerSvart { get; set; }
        public DateTimeOffset Dato { get; set; }
        public PartiResultat Resultat { get; set; }
        public string Pgn { get; set; }
    }
}