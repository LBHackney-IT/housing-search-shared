using AutoFixture;
using FluentAssertions;
using Hackney.Shared.HousingSearch.Factories;
using Hackney.Shared.HousingSearch.Gateways.Models.Tenures;
using Xunit;

namespace Hackney.Shared.HousingSearch.Tests.Factories
{
    public class DomainFactoryTests
    {
        private readonly Fixture _fixture = new();

        [Fact]
        public void CanConvertQueryableTempAccommodationInfoEntityToDomain()
        {
            var queryableTAInfo = _fixture.Create<QueryableTempAccommodationInfo>();

            var domainTAInfo = queryableTAInfo.ToDomain();

            domainTAInfo.AssignedOfficer.Should().BeEquivalentTo(queryableTAInfo.AssignedOfficer.ToDomain());
            domainTAInfo.BookingStatus.Should().Be(queryableTAInfo.BookingStatus);
        }

        [Fact]
        public void CanConvertQueryableTempAccommodationInfoEntityToDomainWhenAssignedOfficerIsNull()
        {
            var queryableTaInfo = _fixture.Create<QueryableTempAccommodationInfo>();
            queryableTaInfo.AssignedOfficer = null;

            var domainTAInfo = queryableTaInfo.ToDomain();

            domainTAInfo.AssignedOfficer.Should().BeNull();
        }

        [Fact]
        public void CanConvertQueryableTempAccommodationOfficerEntityToDomain()
        {
            var queryableTAOfficer = _fixture.Create<QueryableTempAccommodationOfficer>();

            var domainTAOfficer = queryableTAOfficer.ToDomain();

            domainTAOfficer.Id.Should().Be(queryableTAOfficer.Id);
            domainTAOfficer.Email.Should().Be(queryableTAOfficer.Email);
            domainTAOfficer.FirstName.Should().Be(queryableTAOfficer.FirstName);
            domainTAOfficer.LastName.Should().Be(queryableTAOfficer.LastName);
        }
    }
}
