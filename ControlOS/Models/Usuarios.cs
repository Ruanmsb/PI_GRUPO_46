namespace ControlOS.Models
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public string? Telefone { get; set; }
        public string? Cargo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
