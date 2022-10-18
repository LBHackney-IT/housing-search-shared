namespace Hackney.Shared.HousingSearch.Domain.Asset
{
    public class Asset
    {
        public static Asset CreateAll(string id, string assetId, string assetType,
            bool isAssetCautionaryAlerted, AssetAddress assetAddress, Tenure tenure, string rootAsset, string parentAssetIds,
            AssetCharacteristics assetCharacteristics, AssetManagement assetManagement, AssetLocation assetLocation, bool isActive, Contract contract)
        {
            return new Asset(id, assetId, assetType, isAssetCautionaryAlerted, assetAddress, tenure, rootAsset,
                parentAssetIds, assetCharacteristics, assetManagement, assetLocation, isActive, contract);
        }

        public static Asset Create(string id, string assetId, string assetType,
            bool isAssetCautionaryAlerted, AssetAddress assetAddress, Tenure tenure,
            AssetCharacteristics assetCharacteristics, string AssetStatus)
        {
            return new Asset(id, assetId, assetType, isAssetCautionaryAlerted, assetAddress, tenure, assetCharacteristics, AssetStatus);
        }

        public Asset()
        {

        }
        private Asset(string id, string assetId, string assetType,
            bool isAssetCautionaryAlerted, AssetAddress assetAddress, Tenure tenure, AssetCharacteristics assetCharacteristics, string assetStatus)
        {
            Id = id;
            AssetId = assetId;
            AssetType = assetType;
            IsAssetCautionaryAlerted = isAssetCautionaryAlerted;
            AssetAddress = assetAddress;
            Tenure = tenure;
            AssetCharacteristics = assetCharacteristics;
            AssetStatus = assetStatus;
        }
        private Asset(string id, string assetId, string assetType,
            bool isAssetCautionaryAlerted, AssetAddress assetAddress, Tenure tenure, string rootAsset, string parentAssetIds,
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
            AssetCharacteristics = assetCharacteristics;
            AssetManagement = assetManagement;
            AssetLocation = assetLocation;
            Contract = contract;
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

        public AssetCharacteristics AssetCharacteristics { get; set; }

        public AssetManagement AssetManagement { get; set; }

        public string AssetStatus { get; set; }

        public AssetLocation AssetLocation { get; set; }
        public Contract Contract { get; set; }
    }
}
