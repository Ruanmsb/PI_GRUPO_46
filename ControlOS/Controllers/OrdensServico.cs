using AspNetCoreGeneratedDocument;
using ControlOS.Models;
using ControlOS.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ControlOS.Controllers
{
    public class OrdensServico : Controller
    {
        private readonly IOrdensServicoRepositorio _ordensServicoRepositorio;
        private readonly IClientesRepositorio _clientesRepositorio;
        private readonly IUsuarioRepositorio _usuariosRepositorio;
        public OrdensServico(IOrdensServicoRepositorio ordensServico, IClientesRepositorio clientesRepositorio, IUsuarioRepositorio usuariosRepositorio) 
        {
            _ordensServicoRepositorio = ordensServico;
            _clientesRepositorio = clientesRepositorio;
            _usuariosRepositorio = usuariosRepositorio;
        }
        public IActionResult Index()
        {
            List<OrdensServicoModel> ordensServico = _ordensServicoRepositorio.BuscarTodos();
            return View(ordensServico);

        }
        public IActionResult Criar()
        {
            ViewBag.Clientes = _clientesRepositorio.BuscarTodos(); // lista de clientes
            ViewBag.Usuarios = _usuariosRepositorio.BuscarTodos(); // lista de técnicos
            return View();
        }

        [HttpPost]
        public IActionResult Criar(OrdensServicoModel ordensServico)
        {
            _ordensServicoRepositorio.Adicionar(ordensServico);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Editar(OrdensServicoModel os)
        {
            if (!ModelState.IsValid)
            {
                return View(os);
            }

            _ordensServicoRepositorio.Atualizar(os);

            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            ViewBag.Clientes = _clientesRepositorio.BuscarTodos(); // lista de clientes
            ViewBag.Usuarios = _usuariosRepositorio.BuscarTodos(); // lista de técnicos
            OrdensServicoModel? os = _ordensServicoRepositorio.ListarPorId(id);
            if (os == null) return NotFound();
            return View(os);
        }

    }
}
