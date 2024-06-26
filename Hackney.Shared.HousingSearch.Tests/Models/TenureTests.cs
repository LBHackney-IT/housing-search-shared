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
            createdDomainTenure.TenuredAsset.Should().BeEquivalentTo(aQueryableTenure.TenuredAsset);
            createdDomainTenure.PaymentReference.Should().BeEquivalentTo(aQueryableTenure.PaymentReference);
            createdDomainTenure.HouseholdMembers.Should().BeEquivalentTo(aQueryableTenure.HouseholdMembers);
            createdDomainTenure.StartOfTenureDate.Should().BeEquivalentTo(aQueryableTenure.StartOfTenureDate);
            createdDomainTenure.EndOfTenureDate.Should().BeEquivalentTo(aQueryableTenure.EndOfTenureDate);
            createdDomainTenure.TenureType.Should().BeEquivalentTo(aQueryableTenure.TenureType);
            createdDomainTenure.TempAccommodationInfo.Should().BeEquivalentTo(aQueryableTenure.TempAccommodationInfo);
        }

        [Fact]
        public void DomainTenureHasTempAccommodationInfoSetToNullWhenEntityTempAccommodationInfoIsNull()
        {
            var queryableTenure = _fixture.Create<QueryableTenure>();
            queryableTenure.TempAccommodationInfo = null;

            var domainTenure = queryableTenure.Create();

            domainTenure.TempAccommodationInfo.Should().BeNull();


        }
    }
}
