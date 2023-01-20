using Microsoft.EntityFrameworkCore;

namespace ApiNet6EFCore.Controllers
{
    public class CepDbContext : DbContext
    {
        public DbSet<Cep> Ceps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "Cep");
        }
    }
}