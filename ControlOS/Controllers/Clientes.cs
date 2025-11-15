using Microsoft.AspNetCore.Mvc;

namespace ControlOS.Controllers
{
    public class Clientes : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
