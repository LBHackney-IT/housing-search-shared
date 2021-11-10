using System;
using Hackney.Shared.HousingSearch.Domain.Transactions;
using Nest;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Transactions
{
    public class QueryablePerson
    {
        public Person ToPerson()
        {
            return Person.Create(Id, FullName);
        }

        [Text(Name = "id")]
        public Guid Id { get; set; }

        [Text(Name = "fullName")]
        public string FullName { get; set; }
    }
}
