using System;
using Hackney.Shared.HousingSearch.Domain.Accounts;

namespace Hackney.Shared.HousingSearch.Gateways.Entities.Accounts
{
    public class PrimaryTenantsDbEntity
    {
        public PrimaryTenant ToPrimaryTenant(Guid id, string fullName)
        {
            return PrimaryTenant.Create(id, fullName);
        }

        public Guid Id { get; set; }

        public string FullName { get; set; }
    }
}
