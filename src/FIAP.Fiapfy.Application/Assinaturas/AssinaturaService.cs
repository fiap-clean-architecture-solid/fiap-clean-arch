public class AssinaturaService : IAssinaturaService
{
    public Guid CriarAssinatura(string tipoAssinatura, Guid usuarioId)
    {
        return Guid.NewGuid(); 
    }
}