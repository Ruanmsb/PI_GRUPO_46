using Microsoft.AspNetCore.Mvc;

namespace ControlOS.Controllers
{
    public class ListaOrdemServico : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
