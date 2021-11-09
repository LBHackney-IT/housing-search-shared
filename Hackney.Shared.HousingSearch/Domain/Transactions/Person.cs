using System;

namespace Hackney.Shared.HousingSearch.Domain.Transactions
{
    public class Person
    {
        public static Person Create(Guid id, string fullName)
            => new Person(id, fullName);

        public Person(Guid id, string fullName)
        {
            Id = id;
            FullName = fullName;
        }

        public Guid Id { get; }

        public string FullName { get; }
    }
}
