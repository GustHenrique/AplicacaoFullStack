using AplicacaoFullStack.Models;
using Microsoft.EntityFrameworkCore;

namespace AplicacaoFullStack.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
