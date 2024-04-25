using FluentAssertions;
using Xunit;
using AutoFixture;
using Hackney.Shared.HousingSearch.Gateways.Models.Tenures;
using Hackney.Shared.HousingSearch.Domain.Tenure;

namespace Hackney.Shared.HousingSearch.Tests
{
    public class TenuredAssetTests
    {
        private Fixture _fixture = new Fixture();

        [Fact]
        public void DomainTenuredAssetHasPropertiesSet()
        {
            //arrange    
            var aQueryableTenuredAsset = _fixture.Create<QueryableTenuredAsset>();

            //act
            var createdDomainTenuredAsset = TenuredAsset.Create(aQueryableTenuredAsset);

            //assert
            createdDomainTenuredAsset.FullAddress.Should().Be(aQueryableTenuredAsset.FullAddress);
            createdDomainTenuredAsset.Uprn.Should().Be(aQueryableTenuredAsset.Uprn);
            createdDomainTenuredAsset.Id.Should().Be(aQueryableTenuredAsset.Id);
            createdDomainTenuredAsset.Type.Should().Be(aQueryableTenuredAsset.Type);
            createdDomainTenuredAsset.IsTemporaryAccommodation.Should().Be(aQueryableTenuredAsset.IsTemporaryAccommodation);
        }
    }
}
