using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Hackney.Shared.HousingSearch.Domain.Accounts;
using Nest;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Accounts
{
    public class QueryableTenure
    {
        public Domain.Accounts.Tenure Create()
        {
            var primaryTenants = PrimaryTenants == null
                ? new List<PrimaryTenants>()
                : PrimaryTenants.Select(p => Domain.Accounts.PrimaryTenants.Create(p.Id, p.FullNameName)).ToList();

            return Domain.Accounts.Tenure.Create(TenureId, TenureType, FullAddress,primaryTenants);
        }

        [Text(Name = "tenureId")]
        public string TenureId { get; set; }

        [Text(Name = "tenureId")]
        public TenureType TenureType { get; set; }

        /// <example>
        ///     285 Avenue, 315 Amsterdam
        /// </example>
        [NotNull]
        public string FullAddress { get; set; }

        public List<QueryablePrimaryTenant> PrimaryTenants { get; set; }
    }
}
