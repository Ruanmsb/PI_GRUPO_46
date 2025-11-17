using ControlOS.Data;
using ControlOS.Models;

namespace ControlOS.Repositorio
{
    public class OrdensServicoRepositorio : IOrdensServicoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public OrdensServicoRepositorio(BancoContext bancoContext) 
        {
            _bancoContext = bancoContext;
        }
        public OrdensServicoModel Adicionar(OrdensServicoModel ordensServico)
        {
            _bancoContext.OrdensServico.Add(ordensServico);
            _bancoContext.SaveChanges();
            return ordensServico;
        }

        public OrdensServicoModel? ListarPorId(int id)
        {
            return _bancoContext.OrdensServico.FirstOrDefault(x => x.Id == id);
        }
        public List<OrdensServicoModel> BuscarTodos()
        {
            return _bancoContext.OrdensServico.ToList();
        }

        public OrdensServicoModel Atualizar(OrdensServicoModel os)
        {
            OrdensServicoModel? contatoDB = ListarPorId(os.Id);

            if(os == null) throw new System.Exception("Erro na atualização");

            contatoDB.TipoServico = os.TipoServico;
            contatoDB.ExternoInterno = os.ExternoInterno;
            contatoDB.StatusOS = os.StatusOS;
            contatoDB.DescricaoServico = os.DescricaoServico;
            contatoDB.DataOS = os.DataOS;
            contatoDB.NomeCliente = os.NomeCliente;
            contatoDB.NomeTecnico = os.NomeTecnico;

            _bancoContext.OrdensServico.Update(contatoDB);
            _bancoContext.SaveChanges();

            return contatoDB;
        }
    }
}
