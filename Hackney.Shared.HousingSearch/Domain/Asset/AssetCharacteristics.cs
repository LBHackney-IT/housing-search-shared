namespace Hackney.Shared.HousingSearch.Domain.Asset
{
    public class AssetCharacteristics
    {
        public static AssetCharacteristics Create(int numberOfBedrooms, int numberOfLifts, int numberOfLivingRooms, string windowType, string yearConstructed, string assetPropertyFolderLink,
        string epcExpiryDate, string fireSafetyCertificateExpiryDate, string gasSafetyCertificateExpiryDate, string elecCertificateExpiryDate,
        bool optionToTax, bool hasStairs, int numberOfStairs, bool hasRampAccess, bool hasCommunalAreas, bool? hasPrivateBathroom,
        int numberOfBathrooms, string bathroomFloor, bool? hasPrivateKitchen, int numberOfKitchens, string kitchenfloor,
        string alertSystemExpiryDate, string epcScore, int numberOfFloors, string accessibilityComments, int numberOfBedSpaces, int numberOfCots,
        string sleepingArrangementNotes, int numberOfShowers, string kitchenNotes, bool? isStepFree)
        {
            return new AssetCharacteristics(
                numberOfBedrooms,
                numberOfLifts,
                numberOfLivingRooms,
                windowType,
                yearConstructed,
                assetPropertyFolderLink,
                epcExpiryDate,
                fireSafetyCertificateExpiryDate,
                gasSafetyCertificateExpiryDate,
                elecCertificateExpiryDate,
                optionToTax,
                hasStairs,
                numberOfStairs,
                hasRampAccess,
                hasCommunalAreas,
                hasPrivateBathroom,
                numberOfBathrooms,
                bathroomFloor,
                hasPrivateKitchen,
                numberOfKitchens,
                kitchenfloor,
                alertSystemExpiryDate,
                epcScore,
                numberOfFloors,
                accessibilityComments,
                numberOfBedSpaces,
                numberOfCots,
                sleepingArrangementNotes,
                numberOfShowers,
                kitchenNotes,
                isStepFree

            );
        }
        public AssetCharacteristics() { }
        private AssetCharacteristics(int numberOfBedrooms, int numberOfLifts, int numberOfLivingRooms, string windowType,
            string yearConstructed, string assetPropertyFolderLink, string epcExpiryDate, string fireSafetyCertificateExpiryDate,
            string gasSafetyCertificateExpiryDate, string elecCertificateExpiryDate, bool optionToTax, bool hasStairs, int numberOfStairs,
            bool hasRampAccess, bool hasCommunalAreas, bool? hasPrivateBathroom, int numberOfBathrooms, string bathroomFloor,
            bool? hasPrivateKitchen, int numberOfKitchens, string kitchenfloor, string alertSystemExpiryDate, string epcScore,
            int numberOfFloors, string accessibilityComments, int numberOfBedSpaces, int numberOfCots, string sleepingArrangementNotes,
            int numberOfShowers, string kitchenNotes, bool? isStepFree)
        {
            NumberOfBedrooms = numberOfBedrooms;
            NumberOfLifts = numberOfLifts;
            NumberOfLivingRooms = numberOfLivingRooms;
            WindowType = windowType;
            YearConstructed = yearConstructed;
            AssetPropertyFolderLink = assetPropertyFolderLink;
            EpcExpiryDate = epcExpiryDate;
            FireSafetyCertificateExpiryDate = fireSafetyCertificateExpiryDate;
            GasSafetyCertificateExpiryDate = gasSafetyCertificateExpiryDate;
            ElecCertificateExpiryDate = elecCertificateExpiryDate;
            OptionToTax = optionToTax;
            HasStairs = hasStairs;
            NumberOfStairs = numberOfStairs;
            HasRampAccess = hasRampAccess;
            HasCommunalAreas = hasCommunalAreas;
            HasPrivateBathroom = hasPrivateBathroom;
            NumberOfBathrooms = numberOfBathrooms;
            BathroomFloor = bathroomFloor;
            HasPrivateKitchen = hasPrivateKitchen;
            NumberOfKitchens = numberOfKitchens;
            Kitchenfloor = kitchenfloor;
            AlertSystemExpiryDate = alertSystemExpiryDate;
            EpcScore = epcScore;
            NumberOfFloors = numberOfFloors;
            AccessibilityComments = accessibilityComments;
            NumberOfBedSpaces = numberOfBedSpaces;
            NumberOfCots = numberOfCots;
            SleepingArrangementNotes = sleepingArrangementNotes;
            NumberOfShowers = numberOfShowers;
            KitchenNotes = kitchenNotes;
            IsStepFree = isStepFree;
        }

        public int NumberOfBedrooms { get; set; }
        public int NumberOfLifts { get; set; }
        public int NumberOfLivingRooms { get; set; }
        public string WindowType { get; set; }
        public string YearConstructed { get; set; }
        public string AssetPropertyFolderLink { get; set; }
        public string EpcExpiryDate { get; set; }
        public string FireSafetyCertificateExpiryDate { get; set; }
        public string GasSafetyCertificateExpiryDate { get; set; }
        public string ElecCertificateExpiryDate { get; set; }
        public bool OptionToTax { get; set; }
        public bool HasStairs { get; set; }
        public int NumberOfStairs { get; set; }
        public bool HasRampAccess { get; set; }
        public bool HasCommunalAreas { get; set; }
        public bool? HasPrivateBathroom { get; set; }
        public int NumberOfBathrooms { get; set; }
        public string BathroomFloor { get; set; }
        public bool? HasPrivateKitchen { get; set; }
        public int NumberOfKitchens { get; set; }
        public string Kitchenfloor { get; set; }
        public string AlertSystemExpiryDate { get; set; }
        public string EpcScore { get; set; }
        public int NumberOfFloors { get; set; }
        public string AccessibilityComments { get; set; }
        public int NumberOfBedSpaces { get; set; }
        public int NumberOfCots { get; set; }
        public string SleepingArrangementNotes { get; set; }
        public int NumberOfShowers { get; set; }
        public string KitchenNotes { get; set; }
        public bool? IsStepFree { get; set; }
    }
}
