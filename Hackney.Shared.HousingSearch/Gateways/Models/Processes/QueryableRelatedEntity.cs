using Hackney.Shared.HousingSearch.Domain.Process;
using Hackney.Shared.Processes.Domain;
using Nest;
using System;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Processes
{
    public class QueryableRelatedEntity
    {
        public QueryableRelatedEntity() { }

        public static QueryableRelatedEntity Create(Guid id, TargetType targetType, SubType subType, string description)
        {
            return new QueryableRelatedEntity(id, targetType, subType, description);
        }

        public QueryableRelatedEntity(Guid id, TargetType targetType, SubType subType, string description)
        {
            Id = id;
            TargetType = targetType;
            SubType = subType;
            Description = description;
        }

        [Text(Name = "id")]
        public Guid Id { get; set; }

        [Text(Name = "targetType")]
        public TargetType TargetType { get; set; }

        [Text(Name = "subType")]
        public SubType SubType { get; set; }

        [Text(Name = "description")]
        public string Description { get; set; }
    }
}