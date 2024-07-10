using Hackney.Shared.HousingSearch.Domain.Contract;
using Nest;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Contract
{
    public class QueryableRelatedPeople
    {
        [Text(Name = "id")] public string Id { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public string Name { get; set; }
    }
}