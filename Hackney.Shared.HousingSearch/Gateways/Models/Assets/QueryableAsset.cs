using System.Collections.Generic;
using Hackney.Shared.HousingSearch.Domain.Asset;
using Nest;
using Asset = Hackney.Shared.HousingSearch.Domain.Asset.Asset;

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
                ? null
                : Domain.Asset.Tenure.Create(
                    Tenure.Id,
                    Tenure.PaymentReference,
                    Tenure.StartOfTenureDate,
                    Tenure.EndOfTenureDate,
                    Tenure.Type
                );
            var assetCharacteristics = AssetCharacteristics == null
            ? null
            : Domain.Asset.AssetCharacteristics.Create(
                AssetCharacteristics.NumberOfBedrooms,
                AssetCharacteristics.NumberOfLifts,
                AssetCharacteristics.NumberOfLivingRooms,
                AssetCharacteristics.WindowType,
                AssetCharacteristics.YearConstructed,
                AssetCharacteristics.NumberOfBedSpaces,
                AssetCharacteristics.NumberOfCots,
                AssetCharacteristics.GroundFloor,
                AssetCharacteristics.PrivateBathroom,
                AssetCharacteristics.PrivateKitchen,
                AssetCharacteristics.StepFree);

            return Asset.Create(
                Id,
                AssetId,
                AssetType,
                IsAssetCautionaryAlerted,
                assetAddress,
                tenure,
                assetCharacteristics,
                AssetStatus
            );
        }

        public Asset CreateAll()
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
                ? null
                : Domain.Asset.Tenure.Create(
                    Tenure.Id,
                    Tenure.PaymentReference,
                    Tenure.StartOfTenureDate,
                    Tenure.EndOfTenureDate,
                    Tenure.Type
                );

            var assetCharacteristics = AssetCharacteristics == null
                ? null
                : Domain.Asset.AssetCharacteristics.Create(
                    AssetCharacteristics.NumberOfBedrooms,
                    AssetCharacteristics.NumberOfLifts,
                    AssetCharacteristics.NumberOfLivingRooms,
                    AssetCharacteristics.WindowType,
                    AssetCharacteristics.YearConstructed,
                    AssetCharacteristics.NumberOfBedSpaces,
                    AssetCharacteristics.NumberOfCots,
                    AssetCharacteristics.GroundFloor,
                    AssetCharacteristics.PrivateBathroom,
                    AssetCharacteristics.PrivateKitchen,
                    AssetCharacteristics.StepFree);

            var assetManagement = AssetManagement == null
                ? null
                : Domain.Asset.AssetManagement.Create(
                    AssetManagement.Agent,
                    AssetManagement.AreaOfficeName,
                    AssetManagement.IsCouncilProperty,
                    AssetManagement.ManagingOrganisation,
                    AssetManagement.ManagingOrganisationId,
                    AssetManagement.Owner,
                    AssetManagement.IsTMOManaged,
                    AssetManagement.PropertyOccupiedStatus,
                    AssetManagement.IsNoRepairsMaintenance
                );

            return Asset.CreateAll(
                Id,
                AssetId,
                AssetType,
                IsAssetCautionaryAlerted,
                assetAddress,
                tenure,
                RootAsset,
                ParentAssetIds,
                assetCharacteristics,
                assetManagement
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

        [Text(Name = "rootAsset")]
        public string RootAsset { get; set; }

        [Text(Name = "parentAssetIds")]
        public string ParentAssetIds { get; set; }

        [Text(Name = "assetStatus")]
        public string AssetStatus { get; set; }

        [Text(Name = "isTemporaryAccomodation")]
        public bool IsTemporaryAccomodation { get; set; }

        public QueryableAssetAddress AssetAddress { get; set; }

        public QueryableAssetTenure Tenure { get; set; }

        public QueryableAssetCharacteristics AssetCharacteristics { get; set; }

        public QueryableAssetManagement AssetManagement { get; set; }
    }
}
