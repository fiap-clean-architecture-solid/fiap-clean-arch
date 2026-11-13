using Microsoft.AspNetCore.Mvc;

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