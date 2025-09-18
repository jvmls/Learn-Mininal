namespace Learn.Infraestrutura.DB;
using Learn.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

public class DbContexto : DbContext
{
    private readonly IConfiguration _configuration;
    public DbContexto(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public DbSet<Adm> Adms { get; set; } = default!;
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Adm>().HasData(
            new Adm
            {
                Id = 1,
                Email = "admin",
                Senha = "admin",
                Perfil = "Cleber"
            }
        );
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = _configuration.GetConnectionString("mysql")?.ToString();
        if (!optionsBuilder.IsConfigured)
        {   
            if (!string.IsNullOrEmpty(connectionString))
            {
                optionsBuilder.UseMySql(connectionString, 
                ServerVersion.AutoDetect(connectionString));
                return;
            }
        }
    }
}