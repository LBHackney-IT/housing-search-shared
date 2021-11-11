using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Hackney.Shared.HousingSearch.Gateways.Models.Accounts;

namespace Hackney.Shared.HousingSearch.Domain.Accounts
{
    public class PrimaryTenants
    {
        public static IEnumerable<PrimaryTenants> Create(List<QueryablePrimaryTenant> primaryTenants)
        {
            if (primaryTenants != null)
                foreach (var primaryTenant in primaryTenants)
                {
                    yield return new PrimaryTenants(primaryTenant.Id, primaryTenant.FullNameName);
                }

            yield return null;
        }

        private PrimaryTenants(Guid id, string fullName)
        {
            Id = id;
            FullName = fullName;
        }

        /// <example>
        ///     793dd4ca-d7c4-4110-a8ff-c58eac4b90fa
        /// </example>
        [Required]
        public Guid Id { get; }
        /// <example>
        ///     Smith Johnson
        /// </example>
        [Required]
        public string FullName { get; }
    }
}
