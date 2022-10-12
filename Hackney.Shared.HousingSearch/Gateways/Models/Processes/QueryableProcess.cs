using Hackney.Shared.Processes.Domain;
using Nest;
using System.Collections.Generic;
using System.Linq;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Processes
{
    public class QueryableProcess
    {
        public QueryableProcess(string id, string targetId, string targetType, List<QueryableRelatedEntity> relatedEntities, string processName, QueryablePatchAssignment patchAssignment, string state)
        {
            Id = id;
            TargetId = targetId;
            TargetType = targetType;
            RelatedEntities = relatedEntities;
            ProcessName = processName;
            PatchAssignment = patchAssignment;
            State = state;
        }

        public static QueryableProcess Create(string id, string targetId, string targetType, List<QueryableRelatedEntity> relatedEntities, string processName, QueryablePatchAssignment patchAssignment, string state)
        {
            return new QueryableProcess(id, targetId, targetType, relatedEntities, processName, patchAssignment, state);
        }

        [Text(Name = "id")]
        public string Id { get; set; }

        [Text(Name = "targetId")]
        public string TargetId { get; set; }

        [Text(Name = "targetType")]
        public string TargetType { get; set; }

        [Text(Name = "processName")]
        public string ProcessName { get; set; }

        [Text(Name = "state")]
        public string State { get; set; }

        [Text(Name = "patchAssignment")]
        public QueryablePatchAssignment PatchAssignment { get; set; }

        [Text(Name = "createdAt")]
        public string CreatedAt { get; set; }

        [Text(Name = "relatedEntities")]
        public List<QueryableRelatedEntity> RelatedEntities { get; set; }
    }
}
