using MediatR;

public record CriarAssinaturaCommand(string TipoAssinatura, Guid UsuarioId) : IRequest<Guid>;