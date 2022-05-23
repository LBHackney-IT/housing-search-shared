namespace Hackney.Shared.HousingSearch.Domain.Asset
{
    public class Asset
    {
        public static Asset CreateAll(string id, string assetId, string assetType,
            bool isAssetCautionaryAlerted, AssetAddress assetAddress, Tenure tenure, string rootAsset, string parentAssetIds, 
            AssetCharacteristics assetCharacteristics, AssetManagement assetManagement)
        {
            return new Asset(id, assetId, assetType, isAssetCautionaryAlerted, assetAddress, tenure, rootAsset, 
                parentAssetIds,  assetCharacteristics, assetManagement);
        }

        public static Asset Create(string id, string assetId, string assetType,
            bool isAssetCautionaryAlerted, AssetAddress assetAddress, Tenure tenure,
            AssetCharacteristics assetCharacteristics, string AssetStatus, int numberOfBedSpaces, int numberOfCots,
            bool groundFloor, bool privateBathroom, bool privateKitchen, bool stepFree)
        {
            return new Asset(id, assetId, assetType, isAssetCautionaryAlerted, assetAddress, tenure, assetCharacteristics, AssetStatus, 
                numberOfBedSpaces, numberOfCots, groundFloor, privateBathroom, privateKitchen, stepFree);
        }

        public Asset()
        {

        }
        private Asset(string id, string assetId, string assetType,
            bool isAssetCautionaryAlerted, AssetAddress assetAddress, Tenure tenure, AssetCharacteristics assetCharacteristics, string assetStatus, 
            int numberOfBedSpaces, int numberOfCots, bool groundFloor, bool privateBathroom, bool privateKitchen, bool stepFree)
        {
            Id = id;
            AssetId = assetId;
            AssetType = assetType;
            IsAssetCautionaryAlerted = isAssetCautionaryAlerted;
            AssetAddress = assetAddress;
            Tenure = tenure;
            AssetCharacteristics = assetCharacteristics;
            AssetStatus = assetStatus;
            NumberOfBedSpaces = numberOfBedSpaces;
            NumberOfCots = numberOfCots;
            GroundFloor = groundFloor;
            PrivateBathroom = privateBathroom;
            PrivateKitchen = privateKitchen;
            StepFree = stepFree;
        }
        private Asset(string id, string assetId, string assetType,
            bool isAssetCautionaryAlerted, AssetAddress assetAddress, Tenure tenure, string rootAsset, string parentAssetIds,
             AssetCharacteristics assetCharacteristics, AssetManagement assetManagement)
        {
            Id = id;
            AssetId = assetId;
            AssetType = assetType;
            IsAssetCautionaryAlerted = isAssetCautionaryAlerted;
            AssetAddress = assetAddress;
            Tenure = tenure;
            RootAsset = rootAsset;
            ParentAssetIds = parentAssetIds;
            AssetCharacteristics = assetCharacteristics;
            AssetManagement = assetManagement;       
        }

        public string Id { get; set; }

        public string AssetId { get; set; }

        public string AssetType { get; set; }

        public bool IsAssetCautionaryAlerted { get; set; }

        public AssetAddress AssetAddress { get; set; }

        public Tenure Tenure { get; set; }

        public string RootAsset { get; set; }
        public string ParentAssetIds { get; set; }

        public AssetCharacteristics AssetCharacteristics { get; set; }

        public AssetManagement AssetManagement { get; set; }

        public string AssetStatus { get; set; }

        public int NumberOfBedSpaces { get; set; }

        public int NumberOfCots { get; set; }

        public bool GroundFloor { get; set; }

        public bool PrivateBathroom { get; set; }

        public bool PrivateKitchen { get; set; }

        public bool StepFree { get; set; }
    }
}
