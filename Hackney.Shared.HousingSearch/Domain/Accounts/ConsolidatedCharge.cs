using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Hackney.Shared.HousingSearch.Gateways.Models.Accounts;

namespace Hackney.Shared.HousingSearch.Domain.Accounts
{
    public class ConsolidatedCharge
    {

        public static ConsolidatedCharge Create(string type, string frequency, decimal amount)
        {
            return new ConsolidatedCharge(type, frequency, amount);
        }

        private ConsolidatedCharge(string type, string frequency, decimal amount)
        {
            Type = type;
            Frequency = frequency;
            Amount = amount;
        }

        /// <example>
        ///     Rent
        /// </example>
        [NotNull]
        [Required]
        public string Type { get; }

        /// <example>
        ///     Weekly
        /// </example>
        [NotNull]
        [Required]
        public string Frequency { get; }

        /// <example>
        ///     101.20
        /// </example>
        [NotNull]
        [Required]
        public decimal Amount { get; }
    }
}
