using Esercitazione202310_12DaTemplate.Models;
using Microsoft.AspNetCore.Mvc;

namespace Esercitazione202310_12DaTemplate.Controllers
{
    public class AutomobileController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("NuovaAuto");
            return View();
        }
        
        [HttpGet]
        public IActionResult NuovaAuto()
        {
            Auto_Marche auto_MArche = new Auto_Marche();
            auto_MArche.Auto = new Automobile();
            return View("AddAutomobile",auto_MArche);
        }

        [HttpPost]
        public IActionResult NuovaAuto(Auto_Marche auto_Marche)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("ConfermaInserimento");
            }
            
            return View("AddAutomobile" , auto_Marche);
        }

    }
}
