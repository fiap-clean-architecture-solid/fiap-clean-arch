public interface IAssinaturaService
{
    Guid CriarAssinatura(string tipoAssinatura, Guid usuarioId);
}