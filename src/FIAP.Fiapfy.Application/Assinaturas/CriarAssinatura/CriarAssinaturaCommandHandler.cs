using ErrorOr;
using MediatR;

namespace FIAP.Fiapfy.Application.Assinaturas.CriarAssinatura;

public class CriarAssinaturaCommandHandler : IRequestHandler<CriarAssinaturaCommand, ErrorOr<Guid>>
{
    public async Task<ErrorOr<Guid>> Handle(CriarAssinaturaCommand request, CancellationToken cancellationToken)
    {
        return Guid.NewGuid();
    }
}