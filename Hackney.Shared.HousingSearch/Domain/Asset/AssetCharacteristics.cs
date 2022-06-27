namespace Hackney.Shared.HousingSearch.Domain.Asset
{
    public class AssetCharacteristics
    {
        public static AssetCharacteristics Create(int numberOfBedrooms, int numberOfLifts, int numberOfLivingRooms
        , string windowType, string yearConstructed, int numberOfBedSpaces, int numberOfCots, int numberOfFloors
        , bool hasPrivateBathroom, bool hasPrivateKitchen, bool isStepFree)
        {
            return new AssetCharacteristics(
                numberOfBedrooms,
                numberOfLifts,
                numberOfLivingRooms,
                windowType,
                yearConstructed,
                numberOfBedSpaces,
                numberOfCots,
                numberOfFloors,
                hasPrivateBathroom,
                hasPrivateKitchen,
                isStepFree
            );
        }
        public AssetCharacteristics() { }

        private AssetCharacteristics(int numberOfBedrooms, int numberOfLifts, int numberOfLivingRooms
            , string windowType, string yearConstructed, int numberOfBedSpaces, int numberOfCots, int numberOfFloors
        , bool hasPrivateBathroom, bool hasPrivateKitchen, bool isStepFree)
        {
            NumberOfBedrooms = numberOfBedrooms;
            NumberOfLifts = numberOfLifts;
            NumberOfLivingRooms = numberOfLivingRooms;
            WindowType = windowType;
            YearConstructed = yearConstructed;
            NumberOfBedSpaces = numberOfBedSpaces;
            NumberOfCots = numberOfCots;
            NumberOfFloors = numberOfFloors;
            HasPrivateBathroom = hasPrivateBathroom;
            HasPrivateKitchen = hasPrivateKitchen;
            IsStepFree = isStepFree;
        }
        public int NumberOfBedrooms { get; set; }
        public int NumberOfLifts { get; set; }
        public int NumberOfLivingRooms { get; set; }
        public string WindowType { get; set; }
        public string YearConstructed { get; set; }
        public int NumberOfBedSpaces { get; set; }
        public int NumberOfCots { get; set; }
        public int NumberOfFloors { get; set; }
        public bool HasPrivateBathroom { get; set; }
        public bool HasPrivateKitchen { get; set; }
        public bool IsStepFree { get; set; }
    }
}
