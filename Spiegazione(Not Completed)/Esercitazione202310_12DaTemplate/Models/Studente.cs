using Microsoft.AspNetCore.Mvc;

namespace Esercitazione202310_12DaTemplate.Models
{
    public class Studente : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
