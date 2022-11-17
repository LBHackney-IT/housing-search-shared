using System;
using System.Collections.Generic;
using System.Text;

namespace Hackney.Shared.HousingSearch.Domain.Contract
{
    public class Charges
    {
        public Charges() { }

        public static Charges Create(string id, string type, string subType, string frequency, decimal? amount)
        {
            return new Charges(id, type, subType, frequency, amount);
        }

        private Charges(string id, string type, string subType, string frequency, decimal? amount)
        {
            Id = id;
            Type = type;
            SubType = subType;
            Frequency = frequency;
            Amount = amount;
        }

        public string Id { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public string Frequency { get; set; }
        public decimal? Amount { get; set; }
    }
}
