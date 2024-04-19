using System.Collections.Generic;
using System.Linq;
using Hackney.Shared.HousingSearch.Gateways.Models.Tenures;
using Hackney.Shared.Tenure.Domain;

namespace Hackney.Shared.HousingSearch.Domain.Tenure
{
    public class TempAccommodationInfo
    {
        public string BookingStatus { get; set; }

        public static TempAccommodationInfo Create(QueryableTempAccommodationInfo TempAccommodationInfo)
        {
            return new TempAccommodationInfo(TempAccommodationInfo);
        }
        public TempAccommodationInfo()
        {

        }
        private TempAccommodationInfo(QueryableTempAccommodationInfo TempAccommodationInfo)
        {
            BookingStatus = TempAccommodationInfo.BookingStatus;
        }
    }
}


