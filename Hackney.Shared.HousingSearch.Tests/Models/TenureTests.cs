using FluentAssertions;
using Xunit;
using AutoFixture;
using Hackney.Shared.HousingSearch.Gateways.Models.Tenures;

namespace Hackney.Shared.HousingSearch.Tests
{
    public class TenureTests
    {
        private Fixture _fixture = new Fixture();

        [Fact]
        public void DomainTenureHasPropertiesSet()
        {
            //arrange    
            var aQueryableTenure = _fixture.Create<QueryableTenure>();

            //act
            var createdDomainTenure = aQueryableTenure.Create();

            //assert
            createdDomainTenure.Id.Should().Be(aQueryableTenure.Id);
            createdDomainTenure.TempAccommodationInfo.BookingStatus.Should().Be(aQueryableTenure.TempAccommodationInfo.BookingStatus);
            createdDomainTenure.TenuredAsset.Should().BeEquivalentTo(aQueryableTenure.TenuredAsset);
            createdDomainTenure.PaymentReference.Should().BeEquivalentTo(aQueryableTenure.PaymentReference);
            createdDomainTenure.HouseholdMembers.Should().BeEquivalentTo(aQueryableTenure.HouseholdMembers);
            createdDomainTenure.StartOfTenureDate.Should().BeEquivalentTo(aQueryableTenure.StartOfTenureDate);
            createdDomainTenure.EndOfTenureDate.Should().BeEquivalentTo(aQueryableTenure.EndOfTenureDate);
            createdDomainTenure.TenureType.Should().BeEquivalentTo(aQueryableTenure.TenureType);
            createdDomainTenure.TempAccommodationInfo.Should().BeEquivalentTo(aQueryableTenure.TempAccommodationInfo);
        }
    }
}
