using System.Diagnostics.CodeAnalysis;

namespace Hackney.Shared.HousingSearch.Domain.Accounts
{
    public class ConsolidatedCharge
    {
        public ConsolidatedCharge()
        {
            
        }

        public static ConsolidatedCharge Create(string type, string frequency, decimal amount)
        {
            return new ConsolidatedCharge(type, frequency, amount);
        }

        private ConsolidatedCharge(string type,string frequency,decimal amount)
        {
            Type = type;
            Frequency = frequency;
            Amount = amount;
        }

        /// <example>
        ///     Rent
        /// </example>
        [NotNull]
        public string Type { get; set; }

        /// <example>
        ///     Weekly
        /// </example>
        [NotNull]
        public string Frequency { get; set; }

        /// <example>
        ///     101.20
        /// </example>
        [NotNull]
        public decimal Amount { get; set; }
    }
}
