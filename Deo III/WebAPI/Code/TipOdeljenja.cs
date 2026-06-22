using System.Text.Json.Serialization;

namespace WebAPI.Code;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TipOdeljenja
{
    Do5,
    Od6Do16,
    Odrasli
}
