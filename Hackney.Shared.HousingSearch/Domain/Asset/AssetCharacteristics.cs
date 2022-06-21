namespace Hackney.Shared.HousingSearch.Domain.Asset
{
    public class AssetCharacteristics
    {
        public static AssetCharacteristics Create(int numberOfBedrooms, int numberOfLifts, int numberOfLivingRooms
        , string windowType, string yearConstructed, int numberOfBedSpaces, int numberOfCots, bool groundFloor
        , bool privateBathroom, bool privateKitchen, bool stepFree)
        {
            return new AssetCharacteristics(
                numberOfBedrooms,
                numberOfLifts,
                numberOfLivingRooms,
                windowType,
                yearConstructed,
                numberOfBedSpaces,
                numberOfCots,
                groundFloor,
                privateBathroom,
                privateKitchen,
                stepFree
            );
        }
        public AssetCharacteristics() { }

        private AssetCharacteristics(int numberOfBedrooms, int numberOfLifts, int numberOfLivingRooms
            , string windowType, string yearConstructed, int numberOfBedSpaces, int numberOfCots, bool groundFloor
        , bool privateBathroom, bool privateKitchen, bool stepFree)
        {
            NumberOfBedrooms = numberOfBedrooms;
            NumberOfLifts = numberOfLifts;
            NumberOfLivingRooms = numberOfLivingRooms;
            WindowType = windowType;
            YearConstructed = yearConstructed;
            NumberOfBedSpaces = numberOfBedSpaces;
            NumberOfCots = numberOfCots;
            GroundFloor = groundFloor;
            PrivateBathroom = privateBathroom;
            PrivateKitchen = privateKitchen;
            StepFree = stepFree;
        }
        public int NumberOfBedrooms { get; set; }
        public int NumberOfLifts { get; set; }
        public int NumberOfLivingRooms { get; set; }
        public string WindowType { get; set; }
        public string YearConstructed { get; set; }
        public int NumberOfBedSpaces { get; set; }
        public int NumberOfCots { get; set; }
        public bool GroundFloor { get; set; }
        public bool PrivateBathroom { get; set; }
        public bool PrivateKitchen { get; set; }
        public bool StepFree { get; set; }
    }
}
