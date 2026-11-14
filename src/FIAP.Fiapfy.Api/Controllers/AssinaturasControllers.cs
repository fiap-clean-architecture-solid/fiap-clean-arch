using Microsoft.AspNetCore.Mvc;
using FIAP.Fiapfy.Contracts.Assinaturas;

namespace FIAP.Fiapfy.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AssinaturasController : ControllerBase
{
    private readonly IAssinaturaService _assinaturaService;

    public AssinaturasController(IAssinaturaService assinaturaService)
    {
        _assinaturaService = assinaturaService;
    }

    [HttpPost]
    public IActionResult CriarAssinatura(CriarAssinaturaRequest request)
    {
        var assinaturaId = _assinaturaService.CriarAssinatura(request.TipoAssinatura.ToString(),
                                                              request.UsuarioId);

        var retorno = new AssinaturaResponse(assinaturaId, request.TipoAssinatura);

        
        return Ok(retorno);
    }

}