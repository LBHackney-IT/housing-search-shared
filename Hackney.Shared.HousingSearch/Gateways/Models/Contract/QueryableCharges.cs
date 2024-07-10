using Nest;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Contract
{
    public class QueryableCharges
    {
        [Text(Name = "id")] public string Id { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public string Frequency { get; set; }
        public decimal? Amount { get; set; }
    }
}