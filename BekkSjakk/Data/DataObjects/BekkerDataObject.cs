using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BekkSjakk.Data.DataObjects
{
    public class BekkerDataObject
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public int Elo { get; set; }
    }
}