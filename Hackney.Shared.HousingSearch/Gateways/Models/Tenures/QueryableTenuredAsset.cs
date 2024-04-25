namespace Hackney.Shared.HousingSearch.Gateways.Models.Tenures
{
    public class QueryableTenuredAsset
    {
        public string FullAddress { get; set; }
        public string Uprn { get; set; }
        public string Id { get; set; }
        public string Type { get; set; }
        public bool? IsTemporaryAccommodation { get; set; }
    }
}
