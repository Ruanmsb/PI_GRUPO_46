using ControlOS.Data;
using ControlOS.Models;

namespace ControlOS.Repositorio
{
    public class ClientesRepositorio : IClientesRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ClientesRepositorio(BancoContext bancoContext) 
        {
            _bancoContext = bancoContext;
        }
        public ClientesModel Adicionar(ClientesModel clientes)
        {
            _bancoContext.Clientes.Add(clientes);
            _bancoContext.SaveChanges();
            return clientes;
        }
    }
}
