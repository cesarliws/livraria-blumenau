using System.IO;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace LivrariaBlumenau.Models
{
    public class DbEntities : DbContext
    {
        public DbEntities(DbContextOptions<DbEntities> options) : base(options)
        {
        }

        public DbSet<Livro> Livros { get; set; }
    }

    class DBEntitiesContextFactory : IDesignTimeDbContextFactory<DbEntities>
    {
        public DbEntities CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var builder = new DbContextOptionsBuilder<DbEntities>();
            builder.UseSqlServer(connectionString);

            return new DbEntities(builder.Options);
        }
    }

}
