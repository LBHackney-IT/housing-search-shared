using Hackney.Shared.HousingSearch.Domain.Accounts;
using Nest;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Accounts
{
    public class QueryableConsolidatedCharge
    {
        public ConsolidatedCharge Create()
        {
            return ConsolidatedCharge.Create(Type,Frequency,Amount);
        }

        [Text(Name = "type")]
        public string Type { get; set; }

        [Text(Name = "frequency")]
        public string Frequency { get; set; }

        [Text(Name = "amount")]
        public decimal Amount { get; set; }
    }
}
