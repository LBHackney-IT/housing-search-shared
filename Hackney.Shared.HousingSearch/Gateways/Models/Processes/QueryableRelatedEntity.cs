using Hackney.Shared.HousingSearch.Domain.Process;
using Nest;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Processes
{
    public class QueryableRelatedEntity
    {
        [Text(Name = "id")]
        public string Id { get; set; }

        [Text(Name = "targetType")]
        public string TargetType { get; set; }

        [Text(Name = "subType")]
        public string SubType { get; set; }

        [Text(Name = "description")]
        public string Description { get; set; }
    }
}