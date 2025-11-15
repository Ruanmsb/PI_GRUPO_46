using ControlOS.Models;

namespace ControlOS.Repositorio
{
    public interface IUsuarioRepositorio
    {
        List<UsuariosModel> BuscarTodos();
        UsuariosModel Adicionar(UsuariosModel usuario);
    }
}
