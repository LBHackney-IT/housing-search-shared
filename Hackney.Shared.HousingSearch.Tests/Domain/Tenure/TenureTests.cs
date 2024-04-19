using FluentAssertions;
using Hackney.Shared.HousingSearch.Tests.Helper;
using Xunit;
using DT = Hackney.Shared.HousingSearch.Domain.Tenure;

namespace Hackney.Shared.HousingSearch.Tests
{
    public class TenureTests
    {

        [Fact]
        public void TenureHasPropertiesSet()
        {
            DT.Tenure thisTenure = Constants.ConstructTenureFromConstants();
            thisTenure.Id.ToString().Should().Be(Constants.ID);
            thisTenure.TempAccommodationInfo.BookingStatus.Should().Be(Constants.TASTATUS);
        }
    }
}
