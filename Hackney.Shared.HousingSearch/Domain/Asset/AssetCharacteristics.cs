namespace Hackney.Shared.HousingSearch.Domain.Asset
{
    public class AssetCharacteristics
    {
        public static AssetCharacteristics Create(int numberOfBedrooms, int numberOfLifts, int numberOfLivingRooms
        , string windowType, string yearConstructed)
        {
            return new AssetCharacteristics(
                numberOfBedrooms,
                numberOfLifts,
                numberOfLivingRooms,
                windowType,
                yearConstructed

            );
        }
        public AssetCharacteristics() { }

        private AssetCharacteristics(int numberOfBedrooms, int numberOfLifts, int numberOfLivingRooms
            , string windowType, string yearConstructed)
        {
            NumberOfBedrooms = numberOfBedrooms;
            NumberOfLifts = numberOfLifts;
            NumberOfLivingRooms = numberOfLivingRooms;
            WindowType = windowType;
            YearConstructed = yearConstructed;
        }
        public int NumberOfBedrooms { get; set; }
        public int NumberOfLifts { get; set; }
        public int NumberOfLivingRooms { get; set; }
        public string WindowType { get; set; }
        public string YearConstructed { get; set; }
    }
}
