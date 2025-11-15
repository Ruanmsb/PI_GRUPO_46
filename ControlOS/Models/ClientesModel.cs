namespace ControlOS.Models
{
    public class ClientesModel
    {
        public int Id { get; set; }
        public string? NomeRazao { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string? CpfCnpj { get; set; }
        public string? Rua { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Cidade { get; set; }
        public string? Bairro { get; set; }
        public string? CEP { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
