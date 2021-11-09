using System;
using Hackney.Shared.HousingSearch.Domain.Transactions;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Transactions
{
    public class QueryablePerson
    {
        public Person Create()
        {
            return new Person
            {
                Id = Id,
                FullName = FullName
            };
        }

        public Guid Id { get; set; }

        public string FullName { get; set; }
    }
}
