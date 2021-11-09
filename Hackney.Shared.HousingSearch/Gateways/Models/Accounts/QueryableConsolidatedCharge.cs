using Nest;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Accounts
{
    public class QueryableConsolidatedCharge
    {
        [Text(Name = "type")]
        public string Type { get; set; }

        [Text(Name = "frequency")]
        public string Frequency { get; set; }

        [Text(Name = "amount")]
        public decimal Amount { get; set; }
    }
}
