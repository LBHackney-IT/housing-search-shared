// TODO: Replace with class from Hackney.Shared.Processes

namespace Hackney.Shared.HousingSearch.Domain.Process
{
    public class PatchAssignment
    {
        public PatchAssignment() { }
        public static PatchAssignment Create(string patchId, string patchName, string responsibleEntityId, string responsibleName)
        {
            return new PatchAssignment(patchId, patchName, responsibleEntityId, responsibleName);
        }

        private PatchAssignment(string patchId, string patchName, string responsibileEntityId, string responsibileName)
        {
            PatchId = patchId;
            PatchName = patchName;
            ResponsibleEntityId = responsibileEntityId;
            ResponsibleName = responsibileName;
        }
        public string PatchId { get; set; }
        public string PatchName { get; set; }
        public string ResponsibleEntityId { get; set; }
        public string ResponsibleName { get; set; }
    }
}