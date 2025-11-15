using ControlOS.Data;
using ControlOS.Models;

namespace ControlOS.Repositorio
{
    public class UsuariosRepositorio : IUsuarioRepositorio
    {
        private readonly BancoContext _bancoContext;
        public UsuariosRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public List<UsuariosModel> BuscarTodos()
        {
            return _bancoContext.Usuarios.ToList();
        }

        public UsuariosModel Adicionar(UsuariosModel usuario)
        {
            _bancoContext.Usuarios.Add(usuario);
            _bancoContext.SaveChanges();
            return usuario;
        }
    }
}
