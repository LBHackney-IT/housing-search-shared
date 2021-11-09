using System;
using Nest;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Accounts
{
    public class QueryablePrimaryTenant
    {
        [Text(Name = "id")]
        public Guid Id { get; set; }
        [Text(Name = "fullName")]
        public string FullNameName { get; set; }
    }
}
