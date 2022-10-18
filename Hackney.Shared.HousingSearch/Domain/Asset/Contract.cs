using Hackney.Shared.HousingSearch.Domain.Contract;
using System;
using System.Collections.Generic;

namespace Hackney.Shared.HousingSearch.Domain.Asset
{
    public class Contract
    {
        public static Contract Create(string id, IEnumerable<Charges> charges)
        {
            return new Contract(
                id,
                charges
            );
        }
        public Contract() { }

        private Contract(string id, IEnumerable<Charges> charges)
        {
            Id = id;
            Charges = charges;
        }

        public string Id { get; set; }
        public IEnumerable<Charges> Charges { get; set; }
    }
}
