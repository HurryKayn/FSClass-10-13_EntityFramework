using Microsoft.AspNetCore.Mvc;

namespace Esercitazione202310_12DaTemplate.Controllers
{
    public class StudenteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
