using FIAP.Fiapfy.Domain.Assinaturas;

namespace FIAP.Fiapfy.Application.Common.Interfaces;

public interface IAssinaturasRepository
{
    Task InserirAsync(Assinatura assinatura);
    Task<Assinatura?> ObterPorIdAsync(Guid id); 
}