using Microsoft.AspNetCore.Mvc;

namespace ControlOS.Controllers
{
    public class Usuarios : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
