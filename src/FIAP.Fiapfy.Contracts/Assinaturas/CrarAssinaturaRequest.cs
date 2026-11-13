namespace FIAP.Fiapfy.Contracts.Assinaturas;

public record CriarAssinaturaRequest(TipoAssinaturaEnum TipoAssinatura, Guid UsuarioId);
