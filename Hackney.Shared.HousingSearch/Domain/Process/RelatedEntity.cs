using Hackney.Shared.Processes.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hackney.Shared.HousingSearch.Domain.Process
{
    public class RelatedEntity
    {
        public RelatedEntity() { }

        public static RelatedEntity Create(Guid id, string targetType, SubType subType, string description)
        {
            return new RelatedEntity(id, targetType, subType, description);
        }

        public RelatedEntity(Guid id, string targetType, SubType subType, string description)
        {
            Id = id;
            TargetType = targetType;
            SubType = subType;
            Description = description;
        }

        public Guid Id { get; set; }
        public string TargetType { get; set; }

        public SubType SubType { get; set; }
        public string Description { get; set; }
    }
}
