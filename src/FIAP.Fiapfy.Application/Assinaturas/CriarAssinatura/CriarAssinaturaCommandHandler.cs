using MediatR;

public class CriarAssinaturaCommandHandler : IRequestHandler<CriarAssinaturaCommand, Guid>
{
    public Task<Guid> Handle(CriarAssinaturaCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(Guid.NewGuid());
    }
}