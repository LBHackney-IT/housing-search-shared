using Hackney.Shared.HousingSearch.Gateways.Models.Tenures;

namespace Hackney.Shared.HousingSearch.Domain.Tenure
{
    public class TempAccommodationInfo
    {
        public string BookingStatus { get; set; }
        public TemporaryAccommodationOfficer AssignedOfficer { get; set; }

        public static TempAccommodationInfo Create(QueryableTempAccommodationInfo TempAccommodationInfo)
        {
            return new TempAccommodationInfo(TempAccommodationInfo);
        }
        public TempAccommodationInfo()
        {

        }
        private TempAccommodationInfo(QueryableTempAccommodationInfo TempAccommodationInfo)
        {
            BookingStatus = TempAccommodationInfo?.BookingStatus;
            AssignedOfficer = TempAccommodationInfo?.AssignedOfficer;
        }
    }
}


