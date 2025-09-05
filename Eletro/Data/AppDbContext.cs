using Eletro.Models;
using Microsoft.EntityFrameworkCore;

namespace Eletro.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Eletrodomestico> Eletrodomesticos { get; set; }
    }
}
