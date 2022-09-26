using Nest;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Processes
{
    public class QueryablePatchAssignment
    {
        public QueryablePatchAssignment() { }
        public static QueryablePatchAssignment Create(string patchId, string patchName, string responsibleEntityId, string responsibleName)
        {
            return new QueryablePatchAssignment(patchId, patchName, responsibleEntityId, responsibleName);
        }

        private QueryablePatchAssignment(string patchId, string patchName, string responsibileEntityId, string responsibileName)
        {
            PatchId = patchId;
            PatchName = patchName;
            ResponsibleEntityId = responsibileEntityId;
            ResponsibleName = responsibileName;
        }

        [Text(Name = "patchId")]
        public string PatchId { get; set; }

        [Text(Name = "patchName")]
        public string PatchName { get; set; }

        [Text(Name = "responsibleEntityId")]
        public string ResponsibleEntityId { get; set; }

        [Text(Name = "responsibleName")]
        public string ResponsibleName { get; set; }
    }
}