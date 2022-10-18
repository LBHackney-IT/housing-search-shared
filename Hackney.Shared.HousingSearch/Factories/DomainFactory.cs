using Hackney.Shared.HousingSearch.Gateways.Models.Processes;
using DomainProcess = Hackney.Shared.HousingSearch.Domain.Process.Process;
using System.Collections.Generic;
using Hackney.Shared.Processes.Domain;
using System.Linq;
using System;
using Hackney.Shared.HousingSearch.Domain.Staff;
using Hackney.Shared.HousingSearch.Gateways.Models.Staffs;

namespace Hackney.Shared.HousingSearch.Factories
{
    public static class DomainFactory
    {
        public static RelatedEntity ToDomain(this QueryableRelatedEntity entity)
        {
            return new RelatedEntity
            {
                Id = entity.Id,
                TargetType = (TargetType)Enum.Parse(typeof(TargetType), entity.TargetType),
                SubType = entity.SubType,
                Description = entity.Description
            };
        }

        public static List<RelatedEntity> ToDomain(this List<QueryableRelatedEntity> relatedEntities)
        {
            return relatedEntities.Select(x => x.ToDomain()).ToList();
        }

        public static PatchAssignment ToDomain(this QueryablePatchAssignment entity)
        {
            return new PatchAssignment
            {
                PatchId = Guid.Parse(entity.PatchId),
                PatchName = entity.PatchName,
                ResponsibleEntityId = Guid.Parse(entity.ResponsibleEntityId),
                ResponsibleName = entity.ResponsibleName
            };
        }

        public static DomainProcess ToDomain(this QueryableProcess entity)
        {
            return new DomainProcess(entity.Id,
                                     entity.TargetId,
                                     entity.TargetType,
                                     entity.RelatedEntities.ToDomain(),
                                     (ProcessName)Enum.Parse(typeof(ProcessName), entity.ProcessName),
                                     entity.PatchAssignment.ToDomain(),
                                     entity.State,
                                     DateTime.Parse(entity.ProcessStartedAt),
                                     DateTime.Parse(entity.StateStartedAt));
        }

        public static Staff ToDomain(this QueryableStaff entity)
        {
            return new Staff(entity.FirstName, entity.LastName, entity.EmailAddress, entity.PatchId, entity.AreaId);
        }
    }
}
