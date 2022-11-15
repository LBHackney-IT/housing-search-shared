using System;

namespace Hackney.Shared.HousingSearch.Domain.Staff
{
    public class StaffPatch
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid AreaId { get; set; }
        public string AreaName { get; set; }
    }
}