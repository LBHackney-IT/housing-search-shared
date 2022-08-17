namespace Hackney.Shared.HousingSearch.Domain.Asset
{
    public class AssetLocation
    {
        public static AssetLocation Create(string floorNo)
        {
            return new AssetLocation(
                floorNo
            );
        }

        public AssetLocation() { }

        private AssetLocation(string floorNo)
        {
            FloorNo = floorNo;
        }
        public string FloorNo { get; set; }
    }
}
