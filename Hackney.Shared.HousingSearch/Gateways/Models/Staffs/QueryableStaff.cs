using Hackney.Shared.HousingSearch.Domain.Staff;
using Nest;
using System;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Staffs
{
    public class QueryableStaff
    {
        public QueryableStaff(string firstName, string lastName, string emailAddress, Guid? patchId, Guid? areaId)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            PatchId = patchId;
            AreaId = areaId;
        }
        public static QueryableStaff Create(string firstName, string lastName, string emailAddress, Guid? patchId, Guid? areaId)
        {
            return new QueryableStaff(firstName, lastName, emailAddress, patchId, areaId);
        }

        [Text(Name = "firstName")]
        public string FirstName { get; set; }

        [Text(Name = "lastName")]
        public string LastName { get; set; }

        [Text(Name = "email")]
        public string EmailAddress { get; set; }

        [Text(Name = "patchId")]
        public Guid? PatchId { get; set; }

        [Text(Name = "areaId")]
        public Guid? AreaId { get; set; }

    }
}
