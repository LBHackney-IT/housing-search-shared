// TODO: Replace with classes from Hackney.Shared.Processes

using System.Text.Json.Serialization;

namespace Hackney.Shared.HousingSearch.Domain.Process
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ProcessName
    {
        soletojoint,
        changeofname
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TargetType
    {
        tenure,
        person,
        asset
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SubType
    {
        tenant,
        householdMember,
        newTenure
    }
}