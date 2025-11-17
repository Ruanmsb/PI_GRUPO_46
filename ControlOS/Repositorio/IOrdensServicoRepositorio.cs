using ControlOS.Models;

namespace ControlOS.Repositorio
{
    public interface IOrdensServicoRepositorio
    {
        OrdensServicoModel Adicionar(OrdensServicoModel ordensServico);
        List<OrdensServicoModel> BuscarTodos();
        OrdensServicoModel? ListarPorId(int id);
        OrdensServicoModel Atualizar(OrdensServicoModel os);
    }
}
