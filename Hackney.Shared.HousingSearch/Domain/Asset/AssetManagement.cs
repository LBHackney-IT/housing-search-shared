using System;

namespace Hackney.Shared.HousingSearch.Domain.Asset
{
    public class AssetManagement
    {
        public static AssetManagement Create(string agent, string areaOfficeName, bool isCouncilProperty, string managingOrganisation,
            Guid managingOrganisationId, string owner, bool isTMOManaged, string propertyOccupiedStatus, bool isNoRepairsMaintenance)
        {
            return new AssetManagement(
                agent,
                areaOfficeName,
                isCouncilProperty,
                managingOrganisation,
                managingOrganisationId,
                owner,
                isTMOManaged,
                propertyOccupiedStatus,
                isNoRepairsMaintenance
            );
        }
        public AssetManagement() { }

        private AssetManagement(string agent, string areaOfficeName, bool isCouncilProperty, string managingOrganisation,
            Guid managingOrganisationId, string owner, bool isTMOManaged, string propertyOccupiedStatus, bool isNoRepairsMaintenance)
        {
            Agent = agent;
            AreaOfficeName = areaOfficeName;
            IsCouncilProperty = isCouncilProperty;
            ManagingOrganisation = managingOrganisation;
            ManagingOrganisationId = managingOrganisationId;
            Owner = owner;
            IsTMOManaged = isTMOManaged;
            PropertyOccupiedStatus = propertyOccupiedStatus;
            IsNoRepairsMaintenance = isNoRepairsMaintenance;
        }

        public string Agent { get; set; }
        public string AreaOfficeName { get; set; }
        public bool IsCouncilProperty { get; set; }
        public string ManagingOrganisation { get; set; }
        public Guid ManagingOrganisationId { get; set; }
        public string Owner { get; set; }
        public bool IsTMOManaged { get; set; }
        public string PropertyOccupiedStatus { get; set; }
        public bool IsNoRepairsMaintenance { get; set; }
    }
}
