using Hackney.Shared.HousingSearch.Domain.Accounts;

namespace Hackney.Shared.HousingSearch.Gateways.Entities.Accounts
{
    public class ConsolidatedChargeDbEntity
    {
        public ConsolidatedCharge ToConsolidatedCharge()
        {
            return ConsolidatedCharge.Create(Type, Frequency, Amount);
        }

        public string Type { get; set; }

        public string Frequency { get; set; }

        public decimal Amount { get; set; }
    }
}
