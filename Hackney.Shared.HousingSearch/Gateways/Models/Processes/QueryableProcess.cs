using Hackney.Shared.Processes.Domain;
using Nest;
using System.Collections.Generic;
using System.Linq;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Processes
{
    public class QueryableProcess
    {
        public QueryableProcess(string id,
                                string targetId,
                                string targetType,
                                ProcessName processName,
                                string state,
                                QueryablePatchAssignment patchAssignment,
                                string createdAt,
                                List<QueryableRelatedEntity> relatedEntities)
        {
            Id = id;
            TargetId = targetId;
            TargetType = targetType;
            ProcessName = processName;
            State = state;
            PatchAssignment = patchAssignment;
            CreatedAt = createdAt;
            RelatedEntities = relatedEntities;
        }

        public QueryableProcess Create(string id,
                                string targetId,
                                string targetType,
                                ProcessName processName,
                                string state,
                                QueryablePatchAssignment patchAssignment,
                                string createdAt,
                                List<QueryableRelatedEntity> relatedEntities)
        {
            return new QueryableProcess(id, targetId, targetType, processName, state, patchAssignment, createdAt, relatedEntities);
        }

        [Text(Name = "id")]
        public string Id { get; set; }

        [Text(Name = "targetId")]
        public string TargetId { get; set; }

        [Text(Name = "targetType")]
        public string TargetType { get; set; }

        [Text(Name = "processName")]
        public ProcessName ProcessName { get; set; }

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
