
using System.Text.Json.Serialization;

namespace Hackney.Shared.HousingSearch.Domain.Contract
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Frequency
    {
        Daily,
        Weekly,
        Monthly,
        Yearly
    }
}
