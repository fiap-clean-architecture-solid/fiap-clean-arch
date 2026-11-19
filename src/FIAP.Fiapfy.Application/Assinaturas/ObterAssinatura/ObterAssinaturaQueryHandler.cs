using ErrorOr;
using FIAP.Fiapfy.Application.Common.Interfaces;
using FIAP.Fiapfy.Domain.Assinaturas;
using MediatR;

public class ObterAssinaturaQueryHandler : IRequestHandler<ObterAssinaturaQuery, ErrorOr<Assinatura>>
{
    private readonly IAssinaturasRepository _assinaturasRepository;

    public ObterAssinaturaQueryHandler(IAssinaturasRepository assinaturasRepository)
    {
        _assinaturasRepository = assinaturasRepository;
    }

    public async Task<ErrorOr<Assinatura>> Handle(ObterAssinaturaQuery query, CancellationToken cancellationToken)
    {
        var assinatura = await _assinaturasRepository.ObterPorIdAsync(query.Id);

        return assinatura is null
            ? Error.NotFound(description: "Assinatura não encontrada")
            : assinatura;
    }
}