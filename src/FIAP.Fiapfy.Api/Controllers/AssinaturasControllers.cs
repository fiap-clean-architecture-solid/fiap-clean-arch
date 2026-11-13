using Microsoft.AspNetCore.Mvc;
using FIAP.Fiapfy.Contracts.Assinaturas;

namespace FIAP.Fiapfy.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AssinaturasController : ControllerBase
{
    [HttpPost]
    public IActionResult CriarAssinatura(CriarAssinaturaRequest request)
    {
        //RECEBER, TRADUZIR, DELEGAR, DEVOLVER

        
        return Ok(request);
    }

}