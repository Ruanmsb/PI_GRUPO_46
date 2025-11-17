using ControlOS.Data;
using ControlOS.Models;

namespace ControlOS.Repositorio
{
    public class ClientesRepositorio : IClientesRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ClientesRepositorio(BancoContext bancoContext) 
        {
            this._bancoContext = bancoContext;
        }
        public ClientesModel? ListarPorId(int id)
        {
            return _bancoContext.Clientes.FirstOrDefault(x => x.Id == id);
        }
        public List<ClientesModel> BuscarTodos()
        {
            return _bancoContext.Clientes.ToList();
        }
        public ClientesModel Adicionar(ClientesModel clientes)
        {
            _bancoContext.Clientes.Add(clientes);
            _bancoContext.SaveChanges();
            return clientes;
        }

        public ClientesModel Atualizar(ClientesModel cliente)
        {
            ClientesModel? contatoDB = ListarPorId(cliente.Id);

            if (cliente == null) throw new System.Exception("Erro na atualização do Cliente");

            contatoDB.NomeRazao = cliente.NomeRazao;
            contatoDB.Email = cliente.Email;
            contatoDB.Telefone = cliente.Telefone;
            contatoDB.CpfCnpj = cliente.CpfCnpj;
            contatoDB.Rua = cliente.Rua;
            contatoDB.Numero = cliente.Numero;
            contatoDB.Complemento = cliente.Complemento;
            contatoDB.Cidade = cliente.Cidade;
            contatoDB.Bairro = cliente.Bairro;
            contatoDB.CEP = cliente.CEP;

            _bancoContext.Clientes.Update(contatoDB);
            _bancoContext.SaveChanges();

            return contatoDB;
        }
    }
}
