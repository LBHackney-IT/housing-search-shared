namespace Hackney.Shared.HousingSearch.Gateways.Models.Processes
{
    public class QueryablePatchAssignment
    {
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