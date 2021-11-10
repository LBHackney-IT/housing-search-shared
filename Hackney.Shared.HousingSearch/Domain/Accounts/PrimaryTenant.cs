using System;
using System.ComponentModel.DataAnnotations;

namespace Hackney.Shared.HousingSearch.Domain.Accounts
{
    public class PrimaryTenants
    {
        public static PrimaryTenants Create(Guid id, string fullName)
        {
            return new PrimaryTenants(id, fullName);
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
