using ErrorOr;
using MediatR;

namespace FIAP.Fiapfy.Application.Assinaturas.CriarAssinatura;

public record CriarAssinaturaCommand(string TipoAssinatura, Guid UsuarioId) : IRequest<ErrorOr<Guid>>;