using ErrorOr;
using FIAP.Fiapfy.Domain.Assinaturas;
using MediatR;

namespace FIAP.Fiapfy.Application.Assinaturas.CriarAssinatura;

public record CriarAssinaturaCommand(string TipoAssinatura, Guid UsuarioId) : IRequest<ErrorOr<Assinatura>>;