using Nest;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Assets
{
    public class QueryableAssetLocation
    {
        [Text(Name = "floorNo")]
        public int FloorNo { get; set; }
    }
}
