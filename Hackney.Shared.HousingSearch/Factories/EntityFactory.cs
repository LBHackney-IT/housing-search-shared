using Hackney.Shared.HousingSearch.Gateways.Models.Processes;
using DomainProcess = Hackney.Shared.HousingSearch.Domain.Process.Process;
using System.Collections.Generic;
using Hackney.Shared.Processes.Domain;
using System.Linq;
using System;

namespace Hackney.Shared.HousingSearch.Factories
{
    public static class EntityFactory
    {
        public static QueryableRelatedEntity ToDatabase(this RelatedEntity domain)
        {
            return new QueryableRelatedEntity
            {
                Id = domain.Id,
                TargetType = domain.TargetType.ToString(),
                SubType = domain.SubType,
                Description = domain.Description
            };
        }

        public static List<QueryableRelatedEntity> ToDatabase(this List<RelatedEntity> relatedEntities)
        {
            return relatedEntities.Select(x => x.ToDatabase()).ToList();
        }

        public static QueryablePatchAssignment ToDatabase(this PatchAssignment domain)
        {
            return new QueryablePatchAssignment
            {
                PatchId = domain.PatchId.ToString(),
                PatchName = domain.PatchName,
                ResponsibleEntityId = domain.ResponsibleEntityId.ToString(),
                ResponsibleName = domain.ResponsibleName
            };
        }

        public static QueryableProcess ToDatabase(this DomainProcess entity)
        {
            return new QueryableProcess(entity.Id, entity.TargetId, entity.TargetType, entity.RelatedEntities.ToDatabase(), entity.ProcessName, entity.PatchAssignment.ToDatabase(), entity.State);
        }
    }
}
