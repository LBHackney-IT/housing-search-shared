using System.Collections.Generic;

namespace Hackney.Shared.HousingSearch.Domain.Process
{
    public class Process
    {
        public string Id { get; set; }
        public string ProcessName { get; set; }
        public string State { get; set; }
        public PatchAssignment PatchAssignment { get; set; }
        public string CreatedAt { get; set; }
        public List<RelatedEntity> RelatedEntities { get; set; }
    }
}