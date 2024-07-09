using System;
using Hackney.Shared.HousingSearch.Gateways.Models.Contract;
using Nest;
using System.Collections.Generic;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Assets
{
    public class QueryableAssetContract
    {
        public Domain.Contract.Contract Create()
        {
            return Domain.Contract.Contract.Create(Id, TargetId, TargetType, StartDate, ApprovalDate, IsApproved,
                Charges, RelatedPeople);
        }

        [Text(Name = "id")]
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
