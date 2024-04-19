using FluentAssertions;
using Hackney.Shared.HousingSearch.Tests.Helper;
using Xunit;

namespace Hackney.Shared.HousingSearch.Tests
{
    public class TenureTests
    {

        [Fact]
        public void TenureHasPropertiesSet()
        {
            Domain.Tenure.Tenure thisTenure = Constants.ConstructTenureFromConstants();
            thisTenure.Id.ToString().Should().Be(Constants.ID);
            thisTenure.TemporaryAccommodationInfo.BookingStatus.Should().Be(Constants.TASTATUS);
        }
    }
}
