using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hackney.Shared.HousingSearch.Domain.Process
{
    public class Process
    {
        public Process() { }

        public static Process Create(Guid id, Guid targetId, TargetType targetType, List<RelatedEntity> relatedEntities, ProcessName processName, PatchAssignment patchAssignment, string state)
        {
            return new Process(id, targetId, targetType, relatedEntities, processName, patchAssignment, state);
        }
        private Process(Guid id, Guid targetId, TargetType targetType, List<RelatedEntity> relatedEntities, ProcessName processName, PatchAssignment patchAssignment, string state)
        {
            Id = id;
            TargetId = targetId;
            TargetType = targetType;
            RelatedEntities = relatedEntities;
            ProcessName = processName;
            PatchAssignment = patchAssignment;
            State = state;
        }

        public Guid Id { get; set; }
        public Guid TargetId { get; set; }
        public TargetType TargetType { get; set; }
        public List<RelatedEntity> RelatedEntities { get; set; }
        public ProcessName ProcessName { get; set; }
        public PatchAssignment PatchAssignment { get; set; }
        public string State { get; set; }
    }
}
