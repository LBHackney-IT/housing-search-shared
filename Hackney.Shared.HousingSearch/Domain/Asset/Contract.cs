using Hackney.Shared.HousingSearch.Domain.Contract;
using Hackney.Shared.HousingSearch.Domain.Enums;
using System;
using System.Collections.Generic;

namespace Hackney.Shared.HousingSearch.Domain.Asset
{
    public class Contract
    {
        public string Id { get; set; }
        public string TargetId { get; set; }
        public string TargetType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string EndReason { get; set; }
        public bool? IsApproved { get; set; }
        public ApprovalStatus ApprovalStatus { get; set; }
        public string ApprovalStatusReason { get; set; }
        public bool? IsActive { get; set; }
        public IEnumerable<Charges> Charges { get; set; }
        public IEnumerable<RelatedPeople> RelatedPeople { get; set; }
    }
}
