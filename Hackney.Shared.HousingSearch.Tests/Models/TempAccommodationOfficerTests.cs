using FluentAssertions;
using Xunit;
using AutoFixture;
using Hackney.Shared.HousingSearch.Gateways.Models.Tenures;
using Hackney.Shared.HousingSearch.Domain.Tenure;

namespace Hackney.Shared.HousingSearch.Tests
{
    public class TemporaryAccommodationOfficerTests
    {
        private Fixture _fixture = new Fixture();

        [Fact]
        public void DomainTAOfficerHasPropertiesSet()
        {
            //arrange    
            var aQueryableTAOfficer = _fixture.Create<QueryableTempAccommodationOfficer>();

            //act
            var createdDomaninTAOfficer = TempAccommodationOfficer.Create(aQueryableTAOfficer);

            //assert
            createdDomaninTAOfficer.Id.Should().Be(aQueryableTAOfficer.Id);
            createdDomaninTAOfficer.FirstName.Should().Be(aQueryableTAOfficer.FirstName);
            createdDomaninTAOfficer.LastName.Should().Be(aQueryableTAOfficer.LastName);
            createdDomaninTAOfficer.Email.Should().Be(aQueryableTAOfficer.Email);
        }
    }
}
