using System.Text.Json.Serialization;

namespace Hackney.Shared.HousingSearch.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ApprovalStatus
    {
        PendingApproval,
        Approved,
        PendingReapproval
    }
}