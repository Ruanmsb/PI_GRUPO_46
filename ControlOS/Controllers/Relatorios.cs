using Microsoft.AspNetCore.Mvc;

namespace ControlOS.Controllers
{
    public class Relatorios : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
