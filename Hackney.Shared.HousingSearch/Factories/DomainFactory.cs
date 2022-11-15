using Hackney.Shared.HousingSearch.Gateways.Models.Processes;
using DomainProcess = Hackney.Shared.HousingSearch.Domain.Process.Process;
using System.Collections.Generic;
using System.Linq;
using System;
using Hackney.Shared.HousingSearch.Domain.Staff;
using Hackney.Shared.HousingSearch.Gateways.Models.Staffs;
using RelatedEntity = Hackney.Shared.HousingSearch.Domain.Process.RelatedEntity;
using PatchAssignment = Hackney.Shared.HousingSearch.Domain.Process.PatchAssignment;

namespace Hackney.Shared.HousingSearch.Factories
{
    public static class DomainFactory
    {
        public static RelatedEntity ToDomain(this QueryableRelatedEntity entity)
        {
            return new RelatedEntity
            {
                Id = entity.Id,
                TargetType = entity.TargetType,
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
                PatchId = entity.PatchId,
                PatchName = entity.PatchName,
                ResponsibleEntityId = entity.ResponsibleEntityId,
                ResponsibleName = entity.ResponsibleName
            };
        }

        public static DomainProcess ToDomain(this QueryableProcess entity)
        {
            return new DomainProcess
            {
                Id = entity.Id,
                TargetId = entity.TargetId,
                TargetType = entity.TargetType,
                ProcessName = entity.ProcessName,
                PatchAssignment = entity.PatchAssignment?.ToDomain(),
                RelatedEntities = entity.RelatedEntities.ToDomain(),
                State = entity.State,
                ProcessStartedAt = (entity.ProcessStartedAt is null ? (DateTime?)null : DateTime.Parse(entity.ProcessStartedAt)),
                StateStartedAt = (entity.StateStartedAt is null ? (DateTime?)null : DateTime.Parse(entity.StateStartedAt))
            };
        }

        public static StaffPatch ToDomain(this QueryableStaffPatch entity)
        {
            return new StaffPatch
            {
                Id = Guid.Parse(entity.Id),
                Name = entity.Name,
                AreaId = Guid.Parse(entity.AreaId),
                AreaName = entity.AreaName
            };
        }

        public static List<StaffPatch> ToDomain(this List<QueryableStaffPatch> patches)
        {
            return patches.Select(x => x.ToDomain()).ToList();
        }

        public static Staff ToDomain(this QueryableStaff entity)
        {
            return new Staff(entity.FirstName, entity.LastName, entity.EmailAddress, entity.Patches.ToDomain());
        }
    }
}
