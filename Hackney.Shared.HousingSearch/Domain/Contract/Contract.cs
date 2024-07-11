using Hackney.Shared.HousingSearch.Gateways.Models.Contract;
using System;
using System.Collections.Generic;

namespace Hackney.Shared.HousingSearch.Domain.Contract
{
    public class Contract
    {
        public string Id { get; set; }
        public string TargetId { get; set; }
        public string TargetType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public bool? IsApproved { get; set; }
        public IEnumerable<QueryableCharges> Charges { get; set; }
        public IEnumerable<QueryableRelatedPeople> RelatedPeople { get; set; }
    }
}