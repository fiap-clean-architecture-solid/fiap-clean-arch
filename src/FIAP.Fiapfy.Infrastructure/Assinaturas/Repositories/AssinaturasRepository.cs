using FIAP.Fiapfy.Application.Common.Interfaces;
using FIAP.Fiapfy.Domain.Assinaturas;

public class AssinaturaRepository : IAssinaturasRepository
{
    public readonly FiapfyDbContext _context;

    public AssinaturaRepository(FiapfyDbContext context)
    {
        _context = context;
    }

    public async Task<Assinatura?> ObterPorIdAsync(Guid id)
    {
        return await _context.Assinaturas.FindAsync(id);
    }

    public async Task InserirAsync(Assinatura assinatura)
    {
        await _context.Assinaturas.AddAsync(assinatura);

        await _context.SaveChangesAsync();
    }
}