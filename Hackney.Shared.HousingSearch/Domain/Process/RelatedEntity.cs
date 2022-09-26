using Hackney.Shared.Processes.Domain;
using System;

namespace Hackney.Shared.HousingSearch.Domain.Process
{
    public class RelatedEntity
    {
        public RelatedEntity() { }

        public static RelatedEntity Create(Guid id, TargetType targetType, SubType subType, string description)
        {
            return new RelatedEntity(id, targetType, subType, description);
        }

        public RelatedEntity(Guid id, TargetType targetType, SubType subType, string description)
        {
            Id = id;
            TargetType = targetType;
            SubType = subType;
            Description = description;
        }

        public Guid Id { get; set; }
        public TargetType TargetType { get; set; }

        public SubType SubType { get; set; }
        public string Description { get; set; }

    }
}
