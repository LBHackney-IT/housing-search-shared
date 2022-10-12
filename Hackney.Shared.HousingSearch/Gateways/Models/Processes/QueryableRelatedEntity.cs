using Hackney.Shared.HousingSearch.Domain.Process;
using Hackney.Shared.Processes.Domain;
using Nest;
using System;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Processes
{
    public class QueryableRelatedEntity
    {
        public QueryableRelatedEntity() { }

        public QueryableRelatedEntity(Guid id, string targetType, SubType subType, string description)
        {
            Id = id;
            TargetType = targetType;
            SubType = subType;
            Description = description;
        }

        public static QueryableRelatedEntity Create(Guid id, string targetType, SubType subType, string description)
        {
            return new QueryableRelatedEntity(id, targetType, subType, description);
        }

        [Text(Name = "id")]
        public Guid Id { get; set; }

        [Text(Name = "targetType")]
        public string TargetType { get; set; }

        [Text(Name = "subType")]
        public SubType? SubType { get; set; }

        [Text(Name = "description")]
        public string Description { get; set; }
    }
}