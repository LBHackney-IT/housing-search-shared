﻿using Hackney.Shared.HousingSearch.Domain.Staff;
using Nest;
using System;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Staffs
{
    public class QueryableStaff
    {
        public Staff Create()
        {
            return Staff.Create(FirstName, LastName, EmailAddress, PatchId, AreaId);
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
