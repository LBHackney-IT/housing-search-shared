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
            var createdDomaninTenure = aQueryableTenure.Create();

            //assert
            createdDomaninTenure.Id.Should().Be(aQueryableTenure.Id);
            createdDomaninTenure.TempAccommodationInfo.BookingStatus.Should().Be(aQueryableTenure.TempAccommodationInfo.BookingStatus);
            createdDomaninTenure.TenuredAsset.Should().BeEquivalentTo(aQueryableTenure.TenuredAsset);
            createdDomaninTenure.PaymentReference.Should().BeEquivalentTo(aQueryableTenure.PaymentReference);
            createdDomaninTenure.HouseholdMembers.Should().BeEquivalentTo(aQueryableTenure.HouseholdMembers);
            createdDomaninTenure.StartOfTenureDate.Should().BeEquivalentTo(aQueryableTenure.StartOfTenureDate);
            createdDomaninTenure.EndOfTenureDate.Should().BeEquivalentTo(aQueryableTenure.EndOfTenureDate);
            createdDomaninTenure.TenureType.Should().BeEquivalentTo(aQueryableTenure.TenureType);
            createdDomaninTenure.TempAccommodationInfo.Should().BeEquivalentTo(aQueryableTenure.TempAccommodationInfo);
        }
    }
}
