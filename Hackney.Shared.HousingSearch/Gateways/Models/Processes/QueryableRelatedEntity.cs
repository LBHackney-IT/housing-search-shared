using Hackney.Shared.HousingSearch.Domain.Process;
using Nest;
using System;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Processes
{
    public class QueryableRelatedEntity
    {
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