using System.Text.Json.Serialization;

namespace Hackney.Shared.HousingSearch.Domain.Accounts.Enum
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RentGroupType
    {
        Tenant,
        LeaseHolders,
        GenFundRents,
        Garages,
        HaLeases,
        HraRents,
        MajorWorks,
        TempAcc,
        TempAccHRA,
        Travelers
    }
}
