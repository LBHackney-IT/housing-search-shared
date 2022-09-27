using Hackney.Shared.HousingSearch.Domain.Process;
using Hackney.Shared.Processes.Domain;
using Nest;
using System.Collections.Generic;
using System.Linq;
using RelatedEntity = Hackney.Shared.HousingSearch.Domain.Process.RelatedEntity;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Processes
{
    public class QueryableProcess
    {
        public Process Create()
        {
            var patchAssignment = PatchAssignment == null
                ? new PatchAssignment() :
                Domain.Process.PatchAssignment.Create(
                    PatchAssignment.PatchId,
                    PatchAssignment.PatchName,
                    PatchAssignment.ResponsibleEntityId,
                    PatchAssignment.ResponsibleName);

            var relatedEntities = RelatedEntities == null
                ? new List<RelatedEntity>() :
                RelatedEntities.Select(x => RelatedEntity.Create(
                                                       x.Id,
                                                       x.TargetType,
                                                       x.SubType,
                                                       x?.Description)).ToList();



            return Process.Create(Id, TargetId, TargetType, relatedEntities, ProcessName, patchAssignment, State);
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
