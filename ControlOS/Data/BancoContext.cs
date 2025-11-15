using ControlOS.Models;
using Microsoft.EntityFrameworkCore;

namespace ControlOS.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
