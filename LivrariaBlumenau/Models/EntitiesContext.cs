using System.IO;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace LivrariaBlumenau.Models
{
    public class EntitiesContext : DbContext
    {
        public EntitiesContext(DbContextOptions<EntitiesContext> options) : base(options)
        {
        }

        public DbSet<Livro> Livros { get; set; }
    }

    class DBEntitiesContextFactory : IDesignTimeDbContextFactory<EntitiesContext>
    {
        public EntitiesContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var builder = new DbContextOptionsBuilder<EntitiesContext>();
            builder.UseSqlServer(connectionString);

            return new EntitiesContext(builder.Options);
        }
    }

}
