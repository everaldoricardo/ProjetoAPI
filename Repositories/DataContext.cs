using Microsoft.EntityFrameworkCore;

namespace Catalogo.Repositories;

public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseInMemoryDatabase("CatalogoDb");
    }

    public DbSet<DbContext> Catalogo { get; set; }
}