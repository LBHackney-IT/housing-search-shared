using System;
using System.Collections.Generic;
using System.Text;

namespace Hackney.Shared.HousingSearch.Domain.Staff
{
    public class Staff
    {
        public Staff() { }
        public static Staff Create(string firstName, string lastName,
           string emailAddress, Guid? patchId)
        {
            return new Staff(firstName, lastName, emailAddress, patchId);
        }

        private Staff(string firstName, string lastName, string emailAddress, Guid? patchId)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            PatchId = patchId;
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public Guid? PatchId { get; set; }
    }
}
