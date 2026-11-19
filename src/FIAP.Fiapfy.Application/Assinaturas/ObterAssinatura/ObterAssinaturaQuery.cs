using ErrorOr;
using FIAP.Fiapfy.Domain.Assinaturas;
using MediatR;

public record ObterAssinaturaQuery(Guid Id) : IRequest<ErrorOr<Assinatura>>;