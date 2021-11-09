using System.Collections.Generic;
using Nest;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Accounts
{
    public class QueryableTenure
    {
        [Text(Name = "fullAddress")]
        public string FullAddress { get; set; }
        [Text(Name = "primaryTenants")]
        public List<QueryablePrimaryTenant> PrimaryTenants { get; set; }
    }
}
