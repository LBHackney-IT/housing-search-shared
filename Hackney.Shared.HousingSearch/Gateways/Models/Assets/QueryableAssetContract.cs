using System;
using Hackney.Shared.HousingSearch.Gateways.Models.Contract;
using Nest;
using System.Collections.Generic;
using Hackney.Shared.HousingSearch.Domain.Contract;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Assets
{
    public class QueryableAssetContract
    {
        [Text(Name = "id")]
        public string Id { get; set; }
        public string TargetId { get; set; }
        public TargetType TargetType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public bool? IsApproved { get; set; }
        public IEnumerable<QueryableCharges> Charges { get; set; }
        public IEnumerable<QueryableRelatedPeople> RelatedPeople { get; set; }
    }
}
