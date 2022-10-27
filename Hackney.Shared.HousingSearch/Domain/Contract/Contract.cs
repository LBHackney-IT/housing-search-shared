using Hackney.Shared.HousingSearch.Domain.Contract;
using Hackney.Shared.HousingSearch.Gateways.Models.Contract;
using System;
using System.Collections.Generic;

namespace Hackney.Shared.HousingSearch.Domain.Contract
{
    public class Contract
    {
        public static Contract Create(string id, string targetId, string targetType, IEnumerable<QueryableCharges> charges)
        {
            return new Contract(
                id,
                targetId,
                targetType,
                charges
            );
        }
        public Contract() { }

        private Contract(string id, string targetId, string targetType, IEnumerable<QueryableCharges> charges)
        {
            Id = id;
            TargetId = targetId;
            TargetType = targetType;
            Charges = charges;
        }

        public string Id { get; set; }
        public string TargetId { get; set; }
        public string TargetType { get; set; }
        public IEnumerable<QueryableCharges> Charges { get; set; }
    }
}
