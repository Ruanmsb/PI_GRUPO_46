using ControlOS.Models;

namespace ControlOS.Repositorio
{
    public interface IClientesRepositorio
    {
        ClientesModel? ListarPorId(int id);
        List<ClientesModel> BuscarTodos();
        ClientesModel Adicionar(ClientesModel clientes);
        ClientesModel Atualizar (ClientesModel cliente);
    }
}
