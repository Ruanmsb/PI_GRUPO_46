using ControlOS.Data;
using ControlOS.Models;
using ControlOS.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ControlOS.Controllers
{
    public class Usuarios : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public Usuarios(IUsuarioRepositorio usuarioRepositorio) 
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public IActionResult Index()
        {
            List<UsuariosModel> usuarios =  _usuarioRepositorio.BuscarTodos();
            return View(usuarios);
        }
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(UsuariosModel usuarios)
        {
            _usuarioRepositorio.Adicionar(usuarios);
            return RedirectToAction("Index");
        }
    }
}
