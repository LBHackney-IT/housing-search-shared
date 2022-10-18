using Hackney.Shared.HousingSearch.Domain.Contract;
using Nest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Contract
{
    public class QueryableCharges
    {
        public Charges Create()
        {
            return Charges.Create(
                Id,
                Type,
                SubType,
                Frequency,
                Amount
            );
        }
        [Text(Name = "id")]
        public string Id { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public Frequency Frequency { get; set; }
        public decimal? Amount { get; set; }
    }
}
