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
            List<ClientesModel> clientes =  _clientesRepositorio.BuscarTodos();
            return View(clientes);
        }
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Editar(ClientesModel cliente)
        {
            if (!ModelState.IsValid)
            {
                return View(cliente);
            }

            _clientesRepositorio.Atualizar(cliente);

            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            ClientesModel? cliente = _clientesRepositorio.ListarPorId(id);
            if(cliente == null) return NotFound();
            return View(cliente);
        }

        [HttpPost]
        public IActionResult Criar(ClientesModel cliente)
        {
            _clientesRepositorio.Adicionar(cliente);
            return RedirectToAction("Index");
        }
    }
}
