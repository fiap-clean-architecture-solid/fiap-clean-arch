using System.Text.Json.Serialization;

namespace FIAP.Fiapfy.Contracts.Assinaturas;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TipoAssinaturaEnum
{
    Gratuita, 
    Basica,
    Pro
}