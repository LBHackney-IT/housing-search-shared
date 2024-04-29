using Hackney.Shared.HousingSearch.Gateways.Models.Tenures;

namespace Hackney.Shared.HousingSearch.Domain.Tenure
{
    public class TempAccommodationOfficer
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }


        public static TempAccommodationOfficer Create(QueryableTempAccommodationOfficer TempAccommodationOfficer)
        {
            return new TempAccommodationOfficer(TempAccommodationOfficer);
        }
        public TempAccommodationOfficer()
        {

        }
        private TempAccommodationOfficer(QueryableTempAccommodationOfficer TAOfficer)
        {
            Id = TAOfficer?.Id;
            FirstName = TAOfficer?.FirstName;
            LastName = TAOfficer?.LastName;
            Email = TAOfficer?.Email;
        }
    }
}


