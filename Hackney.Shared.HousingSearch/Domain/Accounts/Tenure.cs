using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Hackney.Shared.HousingSearch.Gateways.Models.Accounts;
using Hackney.Shared.Tenure.Domain;

namespace Hackney.Shared.HousingSearch.Domain.Accounts
{
    public class Tenure
    {

        public static Tenure Create(string tenureId, TenureType tenureType, string fullAddress, List<PrimaryTenant> primaryTenants)
        {
            return new Tenure(tenureId, tenureType, fullAddress, primaryTenants);
        }

        private Tenure(string tenureId, TenureType tenureType, string fullAddress, List<PrimaryTenant> primaryTenants)
        {
            TenureId = tenureId;
            TenureType = tenureType;
            FullAddress = fullAddress;
            PrimaryTenants = primaryTenants;
        }

        /// <example>
        ///     31245
        /// </example>
        [NotNull]
        public string TenureId { get; }

        /// <example>
        ///     Introductory
        /// </example>
        [NotNull]
        public TenureType TenureType { get; }

        /// <example>
        ///     285 Avenue, 315 Amsterdam
        /// </example>
        [NotNull]
        public string FullAddress { get; }

        public List<PrimaryTenant> PrimaryTenants { get; }
    }


}
