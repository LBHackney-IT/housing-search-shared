namespace Hackney.Shared.HousingSearch.Domain.Asset
{
    public class AssetLocation
    {
        public static AssetLocation Create(int floorNo)
        {
            return new AssetLocation(
                floorNo
            );
        }

        public AssetLocation() { }

        private AssetLocation(int floorNo)
        {
            FloorNo = floorNo;
        }
        public int FloorNo { get; set; }
    }
}
