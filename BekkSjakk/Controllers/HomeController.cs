using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using BekkSjakk.Data;
using BekkSjakk.Models.ViewModels;

namespace BekkSjakk.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            // TODO 1: Liste opp antal parti spelt
            var partier = await new SjakkPartiService().HentAllePartiAsync();
            var bekkere = await new BekkerService().HentAlleBekkereAsync();
            var vm = new IndexViewModel
            {
                Bekkere = bekkere.OrderByDescending(b => b.Elo).ToList(),
                Partier = partier.OrderByDescending(p => p.Dato).ToList()
            };
            return View(vm);
        }
    }
}