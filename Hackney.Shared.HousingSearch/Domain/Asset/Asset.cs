namespace Hackney.Shared.HousingSearch.Domain.Asset
{
    public class Asset
    {
        public static Asset CreateAll(string id, string assetId, string assetType, bool isAssetCautionaryAlerted,
            AssetAddress assetAddress, Tenure tenure, string rootAsset, string parentAssetIds, string patchId, string areaId,
            AssetCharacteristics assetCharacteristics, AssetManagement assetManagement, AssetLocation assetLocation, bool isActive, Contract contract)
        {
            return new Asset(id, assetId, assetType, isAssetCautionaryAlerted, assetAddress, tenure, rootAsset, patchId,
                      areaId, parentAssetIds, assetCharacteristics, assetManagement, assetLocation, isActive, contract);
        }

        public static Asset Create(string id, string assetId, string assetType, bool isAssetCautionaryAlerted,
                                   AssetAddress assetAddress, Tenure tenure, string patchId, string areaId,
                                   AssetCharacteristics assetCharacteristics, string assetStatus)
        {
            return new Asset(id, assetId, assetType, isAssetCautionaryAlerted, patchId, areaId, assetAddress, tenure, assetCharacteristics, assetStatus);
        }

        public Asset()
        {

        }

        private Asset(string id, string assetId, string assetType, bool isAssetCautionaryAlerted, string patchId, string areaId,
                      AssetAddress assetAddress, Tenure tenure, AssetCharacteristics assetCharacteristics, string assetStatus)
        {
            Id = id;
            AssetId = assetId;
            AssetType = assetType;
            IsAssetCautionaryAlerted = isAssetCautionaryAlerted;
            AssetAddress = assetAddress;
            Tenure = tenure;
            PatchId = patchId;
            AreaId = areaId;
            AssetCharacteristics = assetCharacteristics;
            AssetStatus = assetStatus;
        }

        private Asset(string id, string assetId, string assetType,
            bool isAssetCautionaryAlerted, AssetAddress assetAddress, Tenure tenure, string rootAsset, string parentAssetIds, string patchId, string areaId,
             AssetCharacteristics assetCharacteristics, AssetManagement assetManagement, AssetLocation assetLocation, bool isActive, Contract contract)
        {
            Id = id;
            AssetId = assetId;
            AssetType = assetType;
            IsAssetCautionaryAlerted = isAssetCautionaryAlerted;
            AssetAddress = assetAddress;
            Tenure = tenure;
            RootAsset = rootAsset;
            IsActive = isActive;
            ParentAssetIds = parentAssetIds;
            PatchId = patchId;
            AreaId = areaId;
            AssetCharacteristics = assetCharacteristics;
            AssetManagement = assetManagement;
            AssetLocation = assetLocation;
            AssetContract = contract;
        }

        public string Id { get; set; }

        public string AssetId { get; set; }

        public string AssetType { get; set; }

        public bool IsAssetCautionaryAlerted { get; set; }

        public AssetAddress AssetAddress { get; set; }

        public Tenure Tenure { get; set; }

        public string RootAsset { get; set; }

        public bool IsActive { get; set; }
        public string ParentAssetIds { get; set; }

        public string PatchId { get; set; }
        public string AreaId { get; set; }

        public AssetCharacteristics AssetCharacteristics { get; set; }

        public AssetManagement AssetManagement { get; set; }

        public string AssetStatus { get; set; }

        public AssetLocation AssetLocation { get; set; }
        public Contract AssetContract { get; set; }
    }
}
