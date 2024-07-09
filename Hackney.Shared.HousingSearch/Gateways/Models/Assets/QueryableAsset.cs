using System.Linq;
using Nest;
using Asset = Hackney.Shared.HousingSearch.Domain.Asset.Asset;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Assets
{
    public class QueryableAsset
    {
        public Asset Create()
        {
            var assetAddress = AssetAddress == null
                ? null
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
                AssetCharacteristics.AssetPropertyFolderLink,
                AssetCharacteristics.EpcExpiryDate,
                AssetCharacteristics.FireSafetyCertificateExpiryDate,
                AssetCharacteristics.GasSafetyCertificateExpiryDate,
                AssetCharacteristics.ElecCertificateExpiryDate,
                AssetCharacteristics.OptionToTax,
                AssetCharacteristics.HasStairs,
                AssetCharacteristics.NumberOfStairs,
                AssetCharacteristics.HasRampAccess,
                AssetCharacteristics.HasCommunalAreas,
                AssetCharacteristics.HasPrivateBathroom,
                AssetCharacteristics.NumberOfBathrooms,
                AssetCharacteristics.BathroomFloor,
                AssetCharacteristics.HasPrivateKitchen,
                AssetCharacteristics.NumberOfKitchens,
                AssetCharacteristics.Kitchenfloor,
                AssetCharacteristics.AlertSystemExpiryDate,
                AssetCharacteristics.EpcScore,
                AssetCharacteristics.NumberOfFloors,
                AssetCharacteristics.AccessibilityComments,
                AssetCharacteristics.NumberOfBedSpaces,
                AssetCharacteristics.NumberOfCots,
                AssetCharacteristics.SleepingArrangementNotes,
                AssetCharacteristics.NumberOfShowers,
                AssetCharacteristics.KitchenNotes,
                AssetCharacteristics.IsStepFree
                );

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
                ? null
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
                        AssetCharacteristics.AssetPropertyFolderLink,
                        AssetCharacteristics.EpcExpiryDate,
                        AssetCharacteristics.FireSafetyCertificateExpiryDate,
                        AssetCharacteristics.GasSafetyCertificateExpiryDate,
                        AssetCharacteristics.ElecCertificateExpiryDate,
                        AssetCharacteristics.OptionToTax,
                        AssetCharacteristics.HasStairs,
                        AssetCharacteristics.NumberOfStairs,
                        AssetCharacteristics.HasRampAccess,
                        AssetCharacteristics.HasCommunalAreas,
                        AssetCharacteristics.HasPrivateBathroom,
                        AssetCharacteristics.NumberOfBathrooms,
                        AssetCharacteristics.BathroomFloor,
                        AssetCharacteristics.HasPrivateKitchen,
                        AssetCharacteristics.NumberOfKitchens,
                        AssetCharacteristics.Kitchenfloor,
                        AssetCharacteristics.AlertSystemExpiryDate,
                        AssetCharacteristics.EpcScore,
                        AssetCharacteristics.NumberOfFloors,
                        AssetCharacteristics.AccessibilityComments,
                        AssetCharacteristics.NumberOfBedSpaces,
                        AssetCharacteristics.NumberOfCots,
                        AssetCharacteristics.SleepingArrangementNotes,
                        AssetCharacteristics.NumberOfShowers,
                        AssetCharacteristics.KitchenNotes,
                        AssetCharacteristics.IsStepFree);

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
                    AssetManagement.IsNoRepairsMaintenance,
                    AssetManagement.IsTemporaryAccomodation
                );

            var assetLocation = AssetLocation == null
                ? null
                : Domain.Asset.AssetLocation.Create(
                    AssetLocation.FloorNo
                );

            var contract = AssetContract == null
                ? null
                : Domain.Asset.Contract.Create(
                    AssetContract.Id,
                    AssetContract.TargetId,
                    AssetContract.TargetType,
                    AssetContract.StartDate,
                    AssetContract.ApprovalDate,
                    AssetContract.IsApproved,
                    AssetContract.Charges?.Select(p => p.Create()).ToList(),
                    AssetContract.RelatedPeople?.Select(p => p.Create()).ToList()
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
                assetManagement,
                assetLocation,
                IsActive,
                contract
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

        [Text(Name = "isActive")]
        public bool IsActive { get; set; }

        [Text(Name = "parentAssetIds")]
        public string ParentAssetIds { get; set; }

        [Text(Name = "assetStatus")]
        public string AssetStatus { get; set; }

        public QueryableAssetAddress AssetAddress { get; set; }

        public QueryableAssetTenure Tenure { get; set; }

        public QueryableAssetCharacteristics AssetCharacteristics { get; set; }

        public QueryableAssetManagement AssetManagement { get; set; }

        public QueryableAssetLocation AssetLocation { get; set; }
        public QueryableAssetContract AssetContract { get; set; }
    }
}
