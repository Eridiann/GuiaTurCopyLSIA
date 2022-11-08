using Microsoft.AspNetCore.Mvc;

namespace GuiaTuristicaLSIA.API.Controllers
{
    public class GuiaTuristicaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
