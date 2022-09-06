using Hackney.Shared.HousingSearch.Domain.Process;
using Nest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Processes
{
    public class QueryableProcess
    {

        [Text(Name = "id")]
        public string Id { get; set; }

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
