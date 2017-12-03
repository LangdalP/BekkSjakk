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
            var partier = await new SjakkPartiService().HentAllePartiAsync();
            var vm = new SjakkPartierViewModel {Partier = partier};
            return View(vm);
        }
    }
}