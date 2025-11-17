using System.ComponentModel.DataAnnotations.Schema;

namespace ControlOS.Models
{
    public class OrdensServicoModel
    {
        public int Id { get; set; }

        public string? TipoServico { get; set; }  // Manutencao, Instalacao, Revisao
        public string? ExternoInterno { get; set; } // Externo ou Interno
        public string? StatusOS { get; set; } //Pendente, EmAndamento, Finalizado, Cancelado
        public string? DescricaoServico { get; set; }
        public DateTime DataOS { get; set; }
        public string? NomeCliente { get; set; }
        public string? RuaCliente { get; set; }
        public string? NumeroResidenciaCliente { get; set; }
        public string? NomeTecnico { get; set; }
    }
}
