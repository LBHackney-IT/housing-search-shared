﻿using Nest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Staffs
{
    public class QueryableStaff
    {
        [Text(Name = "firstName")]
        public string FirstName { get; set; }

        [Text(Name = "lastName")]
        public string LastName { get; set; }

        [Text(Name = "emailAddress")]
        public string EmailAddress { get; set; }

        [Text(Name = "patchId")]
        public Guid? PatchId { get; set; }
    }
}
