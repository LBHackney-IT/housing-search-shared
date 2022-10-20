using System;
using System.Collections.Generic;
using System.Text;

namespace Hackney.Shared.HousingSearch.Domain.Process
{
    public class PatchAssignment
    {
        public string PatchId { get; set; }
        public string PatchName { get; set; }
        public string ResponsibleEntityId { get; set; }
        public string ResponsibleName { get; set; }
    }
}
