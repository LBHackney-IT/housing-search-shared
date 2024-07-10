namespace Hackney.Shared.HousingSearch.Domain.Contract
{
    public class Charges
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public string Frequency { get; set; }
        public decimal? Amount { get; set; }
    }
}