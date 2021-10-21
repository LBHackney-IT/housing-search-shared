using Hackney.Shared.HousingSearch.Domain.Asset;
using Nest;
using Asset = Hackney.Shared.HousingSearch.Domain.Asset.Asset;
using TenureObject = Hackney.Shared.HousingSearch.Domain.Asset.Tenure;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Assets
{
    public class QueryableAsset
    {
        public Asset Create()
        {
            var assetAddress = AssetAddress == null
                ? new AssetAddress()
                : Domain.Asset.AssetAddress.Create(
                    AssetAddress.Uprn,
                    AssetAddress.AddressLine1,
                    AssetAddress.AddressLine2,
                    AssetAddress.AddressLine3,
                    AssetAddress.AddressLine4,
                    AssetAddress.PostCode,
                    AssetAddress.PostPreamble
                );

            var tenure = Tenure == null
                ? new TenureObject()
                : Domain.Asset.Tenure.Create(
                    Tenure.Id,
                    Tenure.PaymentReference,
                    Tenure.StartOfTenureDate,
                    Tenure.EndOfTenureDate,
                    Tenure.Type
                );

            return Asset.Create(
                Id,
                AssetId,
                AssetType,
                IsAssetCautionaryAlerted,
                assetAddress,
                tenure
            );
        }

        [Text(Name = "id")]
        public string Id { get; set; }

        [Text(Name = "assetId")]
        public string AssetId { get; set; }

        [Text(Name = "assetType")]
        public string AssetType { get; set; }

        [Text(Name = "isAssetCautionaryAlerted")]
        public bool IsAssetCautionaryAlerted { get; set; }

        public QueryableAssetAddress AssetAddress { get; set; }

        public QueryableAssetTenure Tenure { get; set; }
    }
}
