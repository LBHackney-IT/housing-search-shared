using Hackney.Shared.HousingSearch.Domain.Contract;
using System;
using System.Collections.Generic;

namespace Hackney.Shared.HousingSearch.Domain.Asset
{
    public class Contract
    {
        public static Contract Create(string id, string targetId, string targetType, DateTime? startDate, DateTime? approvalDate,
            bool? isApproved, IEnumerable<Charges> charges, IEnumerable<RelatedPeople> relatedPeople)
        {
            return new Contract(
                id,
                targetId,
                targetType,
                startDate,
                approvalDate,
                isApproved,
                charges,
                relatedPeople
            );
        }
        public Contract() { }

        private Contract(string id, string targetId, string targetType, DateTime? startDate, DateTime? approvalDate,
            bool? isApproved, IEnumerable<Charges> charges, IEnumerable<RelatedPeople> relatedPeople)
        {
            Id = id;
            TargetId = targetId;
            TargetType = targetType;
            StartDate = startDate;
            ApprovalDate = approvalDate;
            IsApproved = isApproved;
            Charges = charges;
            RelatedPeople = relatedPeople;
        }

        public string Id { get; set; }
        public string TargetId { get; set; }
        public string TargetType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public bool? IsApproved { get; set; }
        public IEnumerable<Charges> Charges { get; set; }
        public IEnumerable<RelatedPeople> RelatedPeople { get; set; }
    }
}
