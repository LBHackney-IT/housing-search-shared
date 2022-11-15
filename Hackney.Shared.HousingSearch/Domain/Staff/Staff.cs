using System;
using System.Collections.Generic;

namespace Hackney.Shared.HousingSearch.Domain.Staff
{
    public class Staff
    {
        public Staff() { }

        public Staff(string firstName, string lastName, string emailAddress, List<StaffPatch> patches)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Patches = patches;
        }
        public static Staff Create(string firstName, string lastName, string emailAddress, List<StaffPatch> patches)
        {
            return new Staff(firstName, lastName, emailAddress, patches);
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public List<StaffPatch> Patches { get; set; }
    }
}
