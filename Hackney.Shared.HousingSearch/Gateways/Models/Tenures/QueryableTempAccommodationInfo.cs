using Hackney.Shared.HousingSearch.Domain.Tenure;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Tenures
{
    public class QueryableTempAccommodationInfo
    {
        public string BookingStatus { get; set; }
        public TempAccommodationOfficer AssignedOfficer { get; set; }
    }
}
