using System;

namespace Hackney.Shared.HousingSearch.Domain.Asset
{
    public class AssetManagement
    {
        public static AssetManagement Create(string agent, string areaOfficeName, bool isCouncilProperty, string managingOrganisation,
            Guid managingOrganisationId, string owner, bool isTMOManaged, string propertyOccupiedStatus, bool isNoRepairsMaintenance,
            bool isTemporaryAccomodation, bool? isTemporaryAccommodationBlock, Guid? temporaryAccommodationParentAssetId, bool? isPartOfTemporaryAccommodationBlock)
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
                isNoRepairsMaintenance,
                isTemporaryAccomodation,
                isTemporaryAccommodationBlock,
                temporaryAccommodationParentAssetId,
                isPartOfTemporaryAccommodationBlock
            );
        }
        public AssetManagement() { }

        private AssetManagement(string agent, string areaOfficeName, bool isCouncilProperty, string managingOrganisation,
            Guid managingOrganisationId, string owner, bool isTMOManaged, string propertyOccupiedStatus, bool isNoRepairsMaintenance,
            bool isTemporaryAccomodation, bool? isTemporaryAccommodationBlock, Guid? temporaryAccommodationParentAssetId, bool? isPartOfTemporaryAccommodationBlock)
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
            IsTemporaryAccomodation = isTemporaryAccomodation;
            IsTemporaryAccommodationBlock = isTemporaryAccommodationBlock;
            TemporaryAccommodationParentAssetId = temporaryAccommodationParentAssetId;
            IsPartOfTemporaryAccommodationBlock = isPartOfTemporaryAccommodationBlock;
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
        public bool IsTemporaryAccomodation { get; set; }
        public bool? IsTemporaryAccommodationBlock { get; set; }
        public Guid? TemporaryAccommodationParentAssetId { get; set; }
        public bool? IsPartOfTemporaryAccommodationBlock { get; set; }
    }
}
