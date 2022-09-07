using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hackney.Shared.HousingSearch.Domain.Process
{
    public class Process
    {
        public Guid Id { get; set; }
        public Guid TargetId { get; set; }
        public TargetType TargetType { get; set; }
        public List<RelatedEntity> RelatedEntities { get; set; }
        public ProcessName ProcessName { get; set; }
        public PatchAssignment PatchAssignment { get; set; }
        public ProcessState CurrentState { get; set; }
        public List<ProcessState> PreviousStates { get; set; }
        public int? VersionNumber { get; set; }
    }
}
