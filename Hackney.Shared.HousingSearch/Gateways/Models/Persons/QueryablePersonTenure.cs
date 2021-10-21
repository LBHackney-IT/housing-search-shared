using Nest;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Persons
{
    public class QueryablePersonTenure
    {
        [Text(Name = "id")]
        public string Id { get; set; }

        [Text(Name = "type")]
        public string Type { get; set; }

        [Text(Name = "startDate")]
        public string StartDate { get; set; }

        [Text(Name = "endDate")]
        public string EndDate { get; set; }

        [Text(Name = "assetFullAddress")]
        public string AssetFullAddress { get; set; }

        [Text(Name = "postCode")]
        public string PostCode { get; set; }

        [Text(Name = "paymentReference")]
        public string PaymentReference { get; set; }
    }
}
