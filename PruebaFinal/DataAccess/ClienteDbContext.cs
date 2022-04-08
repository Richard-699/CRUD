using Microsoft.EntityFrameworkCore;
using PruebaFinal.Models;

namespace PruebaFinal.DataAccess
{
    public class ClienteDbContext:DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Ciudades> Ciudades { get; set; }

        public ClienteDbContext(DbContextOptions<ClienteDbContext> options) : base(options)
        {
             
        }
    }
}
