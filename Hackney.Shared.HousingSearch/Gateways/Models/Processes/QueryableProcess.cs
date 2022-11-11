using Hackney.Shared.Processes.Domain;
using Nest;
using System.Collections.Generic;
using System.Linq;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Processes
{
    public class QueryableProcess
    {
        public QueryableProcess(string id, string targetId, string targetType, List<QueryableRelatedEntity> relatedEntities, string processName, QueryablePatchAssignment patchAssignment, string state, string processStartedAt, string stateStartedAt)
        {
            Id = id;
            TargetId = targetId;
            TargetType = targetType;
            RelatedEntities = relatedEntities;
            ProcessName = processName;
            PatchAssignment = patchAssignment;
            State = state;
            ProcessStartedAt = processStartedAt;
            StateStartedAt = stateStartedAt;
        }

        public QueryableProcess()
        {
        }

        public static QueryableProcess Create(string id, string targetId, string targetType, List<QueryableRelatedEntity> relatedEntities, string processName, QueryablePatchAssignment patchAssignment, string state, string processStartedAt, string stateStartedAt)
        {
            return new QueryableProcess(id, targetId, targetType, relatedEntities, processName, patchAssignment, state, processStartedAt, stateStartedAt);
        }

        [Text(Name = "id")]
        public string Id { get; set; }

        [Text(Name = "targetId")]
        public string TargetId { get; set; }

        [Text(Name = "targetType")]
        public string TargetType { get; set; }

        [Keyword(Name = "processName")]
        public string ProcessName { get; set; }

        [Keyword(Name = "state")]
        public string State { get; set; }

        [Text(Name = "patchAssignment")]
        public QueryablePatchAssignment PatchAssignment { get; set; }

        [Text(Name = "processStartedAt")]
        public string ProcessStartedAt { get; set; }

        [Text(Name = "relatedEntities")]
        public List<QueryableRelatedEntity> RelatedEntities { get; set; }

        [Text(Name = "stateStartedAt")]
        public string StateStartedAt { get; set; }
    }
}
