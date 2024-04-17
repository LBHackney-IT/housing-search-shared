using System.Collections.Generic;
using System.Linq;
using Hackney.Shared.HousingSearch.Gateways.Models.Tenures;
using Hackney.Shared.Tenure.Domain;

namespace Hackney.Shared.HousingSearch.Domain.Tenure
{
    public class TemporaryAccommodationInfo
    {
        public string BookingStatus { get; set; }

        public static TemporaryAccommodationInfo Create(QueryableTemporaryAccommodationInfo temporaryAccommodationInfo)
        {
            return new TemporaryAccommodationInfo(temporaryAccommodationInfo);
        }
        public TemporaryAccommodationInfo()
        {

        }
        private TemporaryAccommodationInfo(QueryableTemporaryAccommodationInfo temporaryAccommodationInfo)
        {
            BookingStatus = temporaryAccommodationInfo.BookingStatus;
        }
    }
}


