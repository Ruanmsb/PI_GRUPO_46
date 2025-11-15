using ControlOS.Models;
using ControlOS.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ControlOS.Controllers
{
    public class Clientes : Controller
    {
        private readonly IClientesRepositorio _clientesRepositorio;
        public Clientes(IClientesRepositorio clientesRepositorio) 
        {
            _clientesRepositorio = clientesRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(ClientesModel cliente)
        {
            _clientesRepositorio.Adicionar(cliente);
            return RedirectToAction("Index");
        }
    }
}
