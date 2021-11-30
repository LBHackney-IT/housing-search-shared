using System;

namespace Hackney.Shared.HousingSearch.Domain.Transactions
{
    public class Sender
    {
        public Sender()
        {
        }

        public static Sender Create(Guid id, string fullName)
            => new Sender(id, fullName);

        private Sender(Guid id, string fullName)
        {
            Id = id;
            FullName = fullName;
        }

        public Guid Id { get; set; }

        public string FullName { get; set; }
    }
}
