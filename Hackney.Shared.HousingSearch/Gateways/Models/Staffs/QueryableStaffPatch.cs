using System;

namespace Hackney.Shared.HousingSearch.Domain.Staff
{
    public class QueryableStaffPatch
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string AreaId { get; set; }
        public string AreaName { get; set; }
    }
}