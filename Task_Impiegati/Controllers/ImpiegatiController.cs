using Microsoft.AspNetCore.Mvc;
using Task_Impiegati.Models;
using Task_Impiegati.Services;

namespace Task_Impiegati.Controllers
{
    public class ImpiegatiController : Controller
    {
        private readonly ImpiegatiService _service;
        private readonly RepartoService _repservice;

        public ImpiegatiController(ImpiegatiService service, RepartoService repservice)
        {
            _service = service;
            _repservice = repservice;
        }

        public IActionResult Lista()
        {
            List<Impiegati> elenco = _service.ElencoImpiegati();

            return View(elenco);
        }

        public IActionResult Inserimento()
        {
            return View();
        }


        [HttpPost]
        public RedirectResult Salvataggio(Impiegati objImpiegati)
        {
            if (_service.InserisciImpiegato(objImpiegati))
                return Redirect("/Impiegati/Lista");
            else
                return Redirect("/Impiegati/Errore");
        }
    }
}
