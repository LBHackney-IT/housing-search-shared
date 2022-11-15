using Hackney.Shared.HousingSearch.Domain.Staff;
using Nest;
using System;
using System.Collections.Generic;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Staffs
{
    public class QueryableStaff
    {
        public QueryableStaff(string firstName, string lastName, string emailAddress, List<QueryableStaffPatch> patches)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Patches = patches;
        }

        public static QueryableStaff Create(string firstName, string lastName, string emailAddress, List<QueryableStaffPatch> patches)
        {
            return new QueryableStaff(firstName, lastName, emailAddress, patches);
        }

        [Text(Name = "firstName")]
        public string FirstName { get; set; }

        [Text(Name = "lastName")]
        public string LastName { get; set; }

        [Text(Name = "email")]
        public string EmailAddress { get; set; }

        [Text(Name = "relatedEntities")]
        public List<QueryableStaffPatch> Patches { get; set; }
    }
}
