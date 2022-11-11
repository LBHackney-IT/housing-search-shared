using Hackney.Shared.HousingSearch.Domain.Process;
using Hackney.Shared.Processes.Domain;
using Nest;
using System;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Processes
{
    public class QueryableRelatedEntity
    {
        public QueryableRelatedEntity() { }

        public QueryableRelatedEntity(string id, string targetType, string subType, string description)
        {
            Id = id;
            TargetType = targetType;
            SubType = subType;
            Description = description;
        }

        public static QueryableRelatedEntity Create(string id, string targetType, string subType, string description)
        {
            return new QueryableRelatedEntity(id, targetType, subType, description);
        }

        [Text(Name = "id")]
        public string Id { get; set; }

        [Text(Name = "targetType")]
        public string TargetType { get; set; }

        [Text(Name = "subType")]
        public string SubType { get; set; }

        [Keyword(Name = "description")]
        public string Description { get; set; }
    }
}