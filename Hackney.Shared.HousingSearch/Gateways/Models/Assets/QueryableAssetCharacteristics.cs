namespace Hackney.Shared.HousingSearch.Gateways.Models.Assets
{
    public class QueryableAssetCharacteristics
    {
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
