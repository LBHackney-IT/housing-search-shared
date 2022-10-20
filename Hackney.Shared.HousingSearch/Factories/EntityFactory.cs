using Hackney.Shared.HousingSearch.Gateways.Models.Processes;
using DomainProcess = Hackney.Shared.HousingSearch.Domain.Process.Process;
using System.Collections.Generic;
using System.Linq;
using System;
using Hackney.Shared.HousingSearch.Gateways.Models.Staffs;
using Hackney.Shared.HousingSearch.Domain.Staff;
using Hackney.Shared.HousingSearch.Domain.Process;
using Hackney.Shared.Processes.Domain;
using HousingSearchRelatedEntity = Hackney.Shared.HousingSearch.Domain.Process.RelatedEntity;
using Process = Hackney.Shared.Processes.Domain.Process;
using RelatedEntity = Hackney.Shared.Processes.Domain.RelatedEntity;

namespace Hackney.Shared.HousingSearch.Factories
{
    public static class EntityFactory
    {
        public static QueryableRelatedEntity ToDatabase(this HousingSearchRelatedEntity domain)
        {
            return new QueryableRelatedEntity
            {
                Id = domain.Id,
                TargetType = domain.TargetType.ToString(),
                SubType = domain.SubType,
                Description = domain.Description
            };
        }

        public static List<QueryableRelatedEntity> ToDatabase(this List<HousingSearchRelatedEntity> relatedEntities)
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
            return new QueryableProcess
            {
                Id = entity.Id,
                TargetId = entity.TargetId,
                TargetType = entity.TargetType,
                RelatedEntities = entity.RelatedEntities.ToDatabase(),
                ProcessName = entity.ProcessName.ToString(),
                PatchAssignment = entity.PatchAssignment.ToDatabase(),
                State = entity.State,
                ProcessStartedAt = entity.ProcessStartedAt?.ToString(),
                StateStartedAt = entity.StateStartedAt?.ToString()
            };
        }

        public static QueryableStaff ToDatabase(this Staff entity)
        {
            return new QueryableStaff(entity.FirstName, entity.LastName, entity.EmailAddress, entity.PatchId, entity.AreaId);
        }

        public static QueryableRelatedEntity ToElasticSearch(this RelatedEntity entity)
        {
            return new QueryableRelatedEntity()
            {
                Description = entity.Description,
                Id = entity.Id,
                SubType = entity.SubType?.ToString(),
                TargetType = entity.TargetType.ToString()
            };
        }

        public static List<QueryableRelatedEntity> ToElasticSearch(this List<RelatedEntity> relatedEntities)
        {
            return relatedEntities.Select(x => x.ToElasticSearch()).ToList();
        }

        public static QueryableProcess ToElasticSearch(this Process entity)
        {
            return new QueryableProcess
            {
                Id = entity.Id.ToString(),
                TargetId = entity.TargetId.ToString(),
                TargetType = entity.TargetType.ToString(),
                RelatedEntities = entity.RelatedEntities.ToElasticSearch(),
                ProcessName = entity.ProcessName.ToString(),
                PatchAssignment = entity.PatchAssignment.ToDatabase(),
                State = entity.CurrentState.State,
                ProcessStartedAt = GetCreatedAt(entity),
                StateStartedAt = entity.CurrentState.CreatedAt.ToString()
            };
        }

        private static string GetCreatedAt(Process process)
        {
            if (process.PreviousStates is null || process.PreviousStates.Count == 0)
                return process.CurrentState?.CreatedAt.ToString();

            return process.PreviousStates.Min(x => x.CreatedAt).ToString();
        }
    }
}
