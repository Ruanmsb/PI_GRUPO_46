using ControlOS.Models;
using Microsoft.EntityFrameworkCore;

namespace ControlOS.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) { }
        public DbSet<UsuariosModel> Usuarios { get; set; }
        public DbSet<ClientesModel> Clientes{ get; set; }
        public DbSet<OrdensServicoModel> OrdensServico { get; set; }

    }
}
