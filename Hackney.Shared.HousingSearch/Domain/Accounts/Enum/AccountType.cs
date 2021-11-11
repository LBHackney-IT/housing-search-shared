using System.Text.Json.Serialization;

namespace Hackney.Shared.HousingSearch.Domain.Accounts.Enum
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AccountType
    {
        Master,
        Recharge,
        Sundry
    }
}
