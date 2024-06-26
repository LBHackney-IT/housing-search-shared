using System.Collections.Generic;
using System.Linq;
using Hackney.Shared.HousingSearch.Factories;
using Hackney.Shared.HousingSearch.Gateways.Models.Tenures;
using Hackney.Shared.Tenure.Domain;

namespace Hackney.Shared.HousingSearch.Domain.Tenure
{
    public class Tenure
    {
        public static Tenure Create(string id, string paymentReference, string startOfTenureDate, string endOfTenureDate,
            List<QueryableHouseholdMember> houseHoldMembers, QueryableTenuredAsset tenuredAsset, QueryableTenureType tenureType, QueryableTempAccommodationInfo TempAccommodationInfo)
        {
            return new Tenure(id, paymentReference, startOfTenureDate, endOfTenureDate, houseHoldMembers,
                tenuredAsset, tenureType, TempAccommodationInfo);
        }

        public Tenure()
        {

        }

        private Tenure(string id, string paymentReference, string startOfTenureDate, string endOfTenureDate,
            List<QueryableHouseholdMember> houseHoldMembers, QueryableTenuredAsset tenuredAsset, QueryableTenureType tenureType, QueryableTempAccommodationInfo queryableTempAccommodationInfo)
        {
            Id = id;
            PaymentReference = paymentReference;
            StartOfTenureDate = startOfTenureDate;
            EndOfTenureDate = endOfTenureDate;
            HouseholdMembers = houseHoldMembers != null && houseHoldMembers.Any() ? houseHoldMembers.Select(HouseholdMember.Create).ToList() : new List<HouseholdMember>();
            TenureType = TenureType.Create(tenureType);
            TenuredAsset = TenuredAsset.Create(tenuredAsset);
            TempAccommodationInfo = queryableTempAccommodationInfo?.ToDomain();
        }

        public string Id { get; set; }
        public string PaymentReference { get; set; }
        public List<HouseholdMember> HouseholdMembers { get; set; }
        public TenuredAsset TenuredAsset { get; set; }
        public string StartOfTenureDate { get; set; }
        public string EndOfTenureDate { get; set; }
        public TenureType TenureType { get; set; }
        public bool IsActive => TenureHelpers.IsTenureActive(EndOfTenureDate);
        public TempAccommodationInfo TempAccommodationInfo { get; set; }
    }
}
