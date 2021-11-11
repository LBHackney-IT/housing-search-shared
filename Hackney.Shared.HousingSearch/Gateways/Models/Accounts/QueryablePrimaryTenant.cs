using System;
using Hackney.Shared.HousingSearch.Domain.Accounts;
using Nest;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Accounts
{
    public class QueryablePrimaryTenant
    {
        public PrimaryTenant ToPrimaryTenant(Guid id, string fullName)
        {
            return PrimaryTenant.Create(id, fullName);
        }

        [Text(Name = "id")]
        public Guid Id { get; set; }
        [Text(Name = "fullName")]
        public string FullName { get; set; }
    }
}
