using FIAP.Fiapfy.Domain.Assinaturas;
using Microsoft.EntityFrameworkCore;

public class FiapfyDbContext : DbContext
{
    public FiapfyDbContext(DbContextOptions<FiapfyDbContext> options) : base(options)
    {
    }

    public DbSet<Assinatura> Assinaturas { get; set; }
}