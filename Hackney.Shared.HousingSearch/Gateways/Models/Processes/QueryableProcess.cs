using Hackney.Shared.Processes.Domain;
using Nest;
using System.Collections.Generic;
using System.Linq;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Processes
{
    public class QueryableProcess
    {
        public QueryableProcess() { }
        public static QueryableProcess Create(string id, string targetId, TargetType targetType, List<QueryableRelatedEntity> relatedEntities, ProcessName processName, QueryablePatchAssignment patchAssignment, string state)
        {
            return new QueryableProcess(id, targetId, targetType, relatedEntities, processName, patchAssignment, state);
        }

        private QueryableProcess(string id, string targetId, TargetType targetType, List<QueryableRelatedEntity> relatedEntities, ProcessName processName, QueryablePatchAssignment patchAssignment, string state)
        {
            Id = id;
            TargetId = targetId;
            TargetType = targetType;
            RelatedEntities = relatedEntities;
            ProcessName = processName;
            PatchAssignment = patchAssignment;
            State = state;
        }
        public QueryableProcess Create()
        {
            var patchAssignment = PatchAssignment == null
                ? new QueryablePatchAssignment() :
                  QueryablePatchAssignment.Create(
                    PatchAssignment.PatchId,
                    PatchAssignment.PatchName,
                    PatchAssignment.ResponsibleEntityId,
                    PatchAssignment.ResponsibleName);

            var relatedEntities = RelatedEntities == null
                ? new List<QueryableRelatedEntity>() :
                RelatedEntities.Select(x => QueryableRelatedEntity.Create(
                                                       x.Id,
                                                       x.TargetType,
                                                       x.SubType,
                                                       x?.Description)).ToList();



            return Create(Id, TargetId, TargetType, relatedEntities, ProcessName, patchAssignment, State);
        }

        [Text(Name = "id")]
        public string Id { get; set; }

        [Text(Name = "targetId")]
        public string TargetId { get; set; }

        [Text(Name = "targetType")]
        public TargetType TargetType { get; set; }

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
