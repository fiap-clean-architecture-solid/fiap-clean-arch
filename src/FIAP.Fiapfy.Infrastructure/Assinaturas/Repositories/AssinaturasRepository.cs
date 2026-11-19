using FIAP.Fiapfy.Application.Common.Interfaces;
using FIAP.Fiapfy.Domain.Assinaturas;

public class AssinaturaRepository : IAssinaturasRepository
{
    public readonly static List<Assinatura> _assinaturas = [];


    public Task<Assinatura?> ObterPorIdAsync(Guid id)
    {
        var assinatura = _assinaturas.FirstOrDefault(a => a.Id == id);

        return Task.FromResult(assinatura);
    }

    public Task InserirAsync(Assinatura assinatura)
    {
        _assinaturas.Add(assinatura);

        return Task.CompletedTask;
    }
}