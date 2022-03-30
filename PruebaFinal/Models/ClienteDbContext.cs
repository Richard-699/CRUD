using Microsoft.EntityFrameworkCore;

namespace PruebaFinal.Models
{
    public class ClienteDbContext:DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Pais> Pais { get; set; }

        public ClienteDbContext(DbContextOptions<ClienteDbContext> options) : base(options)
        {
             
        }
    }
}
