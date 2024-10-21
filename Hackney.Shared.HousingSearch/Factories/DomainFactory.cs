using Hackney.Shared.HousingSearch.Gateways.Models.Processes;
using DomainProcess = Hackney.Shared.HousingSearch.Domain.Process.Process;
using System.Collections.Generic;
using System.Linq;
using System;
using Hackney.Shared.HousingSearch.Domain.Contract;
using RelatedEntity = Hackney.Shared.HousingSearch.Domain.Process.RelatedEntity;
using PatchAssignment = Hackney.Shared.HousingSearch.Domain.Process.PatchAssignment;
using Hackney.Shared.HousingSearch.Domain.Tenure;
using Hackney.Shared.HousingSearch.Gateways.Models.Assets;
using Hackney.Shared.HousingSearch.Gateways.Models.Contract;
using Hackney.Shared.HousingSearch.Gateways.Models.Tenures;

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
                ProcessStartedAt = (entity.ProcessStartedAt is null
                    ? (DateTime?)null
                    : DateTime.Parse(entity.ProcessStartedAt)),
                StateStartedAt = (entity.StateStartedAt is null
                    ? (DateTime?)null
                    : DateTime.Parse(entity.StateStartedAt))
            };
        }

        public static TempAccommodationInfo ToDomain(this QueryableTempAccommodationInfo entity)
        {
            return new TempAccommodationInfo
            {
                AssignedOfficer = entity.AssignedOfficer?.ToDomain(),
                BookingStatus = entity.BookingStatus
            };
        }

        public static TempAccommodationOfficer ToDomain(this QueryableTempAccommodationOfficer entity)
        {
            return new TempAccommodationOfficer
            {
                Id = entity.Id,
                Email = entity.Email,
                FirstName = entity.FirstName,
                LastName = entity.LastName
            };
        }

        public static Domain.Asset.Contract ToDomain(this QueryableAssetContract entity)
        {
            return new Domain.Asset.Contract
            {
                Id = entity.Id,
                TargetId = entity.TargetId,
                TargetType = entity.TargetType,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
                EndReason= entity.EndReason,
                ApprovalDate = entity.ApprovalDate,
                IsApproved = entity.IsApproved,
                ApprovalStatus = entity.ApprovalStatus,
                ApprovalStatusReason = entity.ApprovalStatusReason,
                IsActive = entity.IsActive,
                Charges = entity.Charges?.ToDomain(),
                RelatedPeople = entity.RelatedPeople?.ToDomain(),
            };
        }

        public static Charges ToDomain(this QueryableCharges entity)
        {
            return new Charges
            {
                Id = entity.Id,
                Type = entity.Type,
                SubType = entity.SubType,
                Frequency = entity.Frequency,
                Amount = entity.Amount
            };
        }

        public static IEnumerable<Charges> ToDomain(this IEnumerable<QueryableCharges> charges)
        {
            return charges.Select(x => x.ToDomain());
        }

        public static RelatedPeople ToDomain(this QueryableRelatedPeople entity)
        {
            return new RelatedPeople
            {
                Id = entity.Id,
                Type = entity.Type,
                SubType = entity.SubType,
                Name = entity.Name
            };
        }

        public static IEnumerable<RelatedPeople> ToDomain(this IEnumerable<QueryableRelatedPeople> relatedPeople)
        {
            return relatedPeople.Select(x => x.ToDomain());
        }
    }
}