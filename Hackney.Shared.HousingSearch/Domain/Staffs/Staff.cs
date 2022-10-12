using System;
using System.Collections.Generic;
using System.Text;

namespace Hackney.Shared.HousingSearch.Domain.Staff
{
    public class Staff
    {
        public Staff() { }
        public static Staff Create(string firstName, string lastName,
           string emailAddress, Guid? patchId, Guid? areaId)
        {
            return new Staff(firstName, lastName, emailAddress, patchId, areaId);
        }

        private Staff(string firstName, string lastName, string emailAddress, Guid? patchId, Guid? areaId)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            PatchId = patchId;
            AreaId = areaId;
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public Guid? PatchId { get; set; }

        public Guid? AreaId { get; set; }
    }
}
