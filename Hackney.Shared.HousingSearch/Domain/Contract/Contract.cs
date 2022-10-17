using Hackney.Shared.HousingSearch.Domain.Contract;
using Hackney.Shared.HousingSearch.Gateways.Models.Contract;
using System;
using System.Collections.Generic;

namespace Hackney.Shared.HousingSearch.Domain.Contract
{
    public class Contract
    {
        public static Contract Create(string id, IEnumerable<QueryableCharges> charges)
        {
            return new Contract(
                id,
                charges
            );
        }
        public Contract() { }

        private Contract(string id, IEnumerable<QueryableCharges> charges)
        {
            Id = id;
            Charges = charges;
        }

        public string Id { get; set; }
        public IEnumerable<QueryableCharges> Charges { get; set; }
    }
}
