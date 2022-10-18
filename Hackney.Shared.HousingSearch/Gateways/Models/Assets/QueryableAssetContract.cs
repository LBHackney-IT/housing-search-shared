using Hackney.Shared.HousingSearch.Gateways.Models.Contract;
using Nest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Assets
{
    public class QueryableAssetContract
    {
        public Domain.Contract.Contract Create()
        {
            return Domain.Contract.Contract.Create(Id, Charges);
        }

        [Text(Name = "id")]
        public string Id { get; set; }
        public IEnumerable<QueryableCharges> Charges { get; set; }
    }
}
