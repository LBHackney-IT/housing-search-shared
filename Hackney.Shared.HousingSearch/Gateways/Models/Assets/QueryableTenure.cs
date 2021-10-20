using Nest;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Assets
{
    public class QueryableTenure
    {
        public Domain.Asset.Tenure Create()
        {
            return Domain.Asset.Tenure.Create(
                Id,
                PaymentReference,
                StartOfTenureDate,
                EndOfTenureDate,
                Type
            );
        }

        [Text(Name = "id")]
        public string Id { get; set; }
        public string PaymentReference { get; set; }
        public string StartOfTenureDate { get; set; }
        public string EndOfTenureDate { get; set; }
        public string Type { get; set; }
    }
}
