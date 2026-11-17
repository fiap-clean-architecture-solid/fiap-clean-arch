using Microsoft.AspNetCore.Mvc;
using FIAP.Fiapfy.Contracts.Assinaturas;
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

        var assinaturaId = await _mediator.Send(command);

        var retorno = new AssinaturaResponse(assinaturaId, request.TipoAssinatura);

        return Ok(retorno);
    }

}