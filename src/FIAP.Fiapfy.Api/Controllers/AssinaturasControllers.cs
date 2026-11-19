using Microsoft.AspNetCore.Mvc;
using FIAP.Fiapfy.Contracts.Assinaturas;
using FIAP.Fiapfy.Application.Assinaturas.CriarAssinatura;
using MediatR;

namespace FIAP.Fiapfy.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AssinaturasController : ControllerBase
{
    private readonly ISender _mediator;

    public AssinaturasController(ISender mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CriarAssinatura(CriarAssinaturaRequest request)
    {
        var command = new CriarAssinaturaCommand(request.TipoAssinatura.ToString(), request.UsuarioId);

        var criarAssinaturaResultado = await _mediator.Send(command);

        return criarAssinaturaResultado.MatchFirst(
            assinatura => Ok(new AssinaturaResponse(assinatura.Id, request.TipoAssinatura)),
            error => Problem()
        );
    }

}