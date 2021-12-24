using System.Collections.Generic;
using System.Linq;

namespace Hackney.Shared.HousingSearch.Gateways.Entities.Accounts
{
    public class TenureDbEntity
    {
        public Domain.Accounts.Tenure ToTenure()
        {
            return Domain.Accounts.Tenure.Create(TenureId,
                TenureType.ToTenureType(),
                FullAddress,
                PrimaryTenants?.Select(p => p.ToPrimaryTenant(p.Id, p.FullName)).ToList());
        }

        public string TenureId { get; set; }

        public TenureTypeDbEntity TenureType { get; set; }

        public string FullAddress { get; set; }

        public List<PrimaryTenantsDbEntity> PrimaryTenants { get; set; }
    }
}
