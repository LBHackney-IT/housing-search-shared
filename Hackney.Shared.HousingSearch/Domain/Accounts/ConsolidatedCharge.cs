using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Hackney.Shared.HousingSearch.Gateways.Models.Accounts;

namespace Hackney.Shared.HousingSearch.Domain.Accounts
{
    public class ConsolidatedCharge
    {

        public static IEnumerable<ConsolidatedCharge> Create(IEnumerable<QueryableConsolidatedCharge> consolidatedCharges)
        {
            if (consolidatedCharges != null)
                foreach (QueryableConsolidatedCharge consolidatedCharge in consolidatedCharges)
                {
                    yield return new ConsolidatedCharge(consolidatedCharge.Type, consolidatedCharge.Frequency,
                        consolidatedCharge.Amount);
                }

            yield return null;
        }

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
        public string Type { get; }

        /// <example>
        ///     Weekly
        /// </example>
        [NotNull]
        public string Frequency { get; }

        /// <example>
        ///     101.20
        /// </example>
        [NotNull]
        public decimal Amount { get; }
    }
}
