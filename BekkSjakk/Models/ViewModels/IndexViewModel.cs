using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BekkSjakk.Models.ViewModels
{
    public class IndexViewModel
    {
        public List<Bekker> Bekkere { get; set; }
        public List<SjakkParti> Partier { get; set; }
    }
}