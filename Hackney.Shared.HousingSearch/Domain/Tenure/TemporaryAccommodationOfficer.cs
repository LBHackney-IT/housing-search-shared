using Hackney.Shared.HousingSearch.Gateways.Models.Tenures;

namespace Hackney.Shared.HousingSearch.Domain.Tenure
{
    public class TemporaryAccommodationOfficer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public static TemporaryAccommodationOfficer Create(QueryableTemporaryAccommodationOfficer TemporaryAccommodationOfficer)
        {
            return new TemporaryAccommodationOfficer(TemporaryAccommodationOfficer);
        }
        public TemporaryAccommodationOfficer()
        {

        }
        private TemporaryAccommodationOfficer(QueryableTemporaryAccommodationOfficer TAOfficer)
        {
            FirstName = TAOfficer?.FirstName;
            LastName = TAOfficer?.LastName;
            Email = TAOfficer?.Email;
        }
    }
}


