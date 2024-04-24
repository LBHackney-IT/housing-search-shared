using FluentAssertions;
using Xunit;
using AutoFixture;
using Hackney.Shared.HousingSearch.Gateways.Models.Tenures;
using Hackney.Shared.HousingSearch.Domain.Tenure;

namespace Hackney.Shared.HousingSearch.Tests
{
    public class TempAccommodationInfoTests
    {
        private Fixture _fixture = new Fixture();

        [Fact]
        public void DomainTempAccommodationInfoHasPropertiesSet()
        {
            //arrange    
            var aQueryableTAInfo = _fixture.Create<QueryableTempAccommodationInfo>();

            //act
            var createdDomaninTAInfo = TempAccommodationInfo.Create(aQueryableTAInfo);

            //assert
            createdDomaninTAInfo.BookingStatus.Should().Be(aQueryableTAInfo.BookingStatus);
            createdDomaninTAInfo.AssignedOfficer.Should().Be(aQueryableTAInfo.AssignedOfficer);
        }
    }
}
