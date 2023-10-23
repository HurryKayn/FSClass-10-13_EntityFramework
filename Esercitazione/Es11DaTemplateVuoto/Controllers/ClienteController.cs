using Es11DaTemplateVuoto.Models;
using Microsoft.AspNetCore.Mvc;

namespace Es11DaTemplateVuoto.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("NuovoCliente");
            return View();
        }
        [HttpGet]
        public IActionResult NuovoCliente() 
        {
            return View("AddCliente");
        }
        [HttpPost]
        public IActionResult NuovoCliente(Cliente cliente)
        {
            if (cliente.Zona == 0) 
            {
                ModelState.AddModelError("Zona", "Selezionare la zona");
            }

            if (ModelState.IsValid)
            {
                return RedirectToAction("ConfermaInserimento");
            }
            return View("AddCliente");
        }
    }
}
