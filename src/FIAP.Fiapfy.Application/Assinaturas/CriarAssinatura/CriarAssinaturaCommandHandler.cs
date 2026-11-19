using ErrorOr;
using FIAP.Fiapfy.Application.Common.Interfaces;
using FIAP.Fiapfy.Domain.Assinaturas;
using MediatR;

namespace FIAP.Fiapfy.Application.Assinaturas.CriarAssinatura;

public class CriarAssinaturaCommandHandler : IRequestHandler<CriarAssinaturaCommand, ErrorOr<Assinatura>>
{
    private readonly IAssinaturasRepository _assinaturaRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CriarAssinaturaCommandHandler(IAssinaturasRepository assinaturaRepository, IUnitOfWork unitOfWork)
    {
        _assinaturaRepository = assinaturaRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<Assinatura>> Handle(CriarAssinaturaCommand request, CancellationToken cancellationToken)
    {
        //Criando Assinatura
        var assinatura = new Assinatura
        {
            Id = Guid.NewGuid()
        };

        _assinaturaRepository.Inserir(assinatura);
        await _unitOfWork.CommitAsync();

        return assinatura;
    }
}