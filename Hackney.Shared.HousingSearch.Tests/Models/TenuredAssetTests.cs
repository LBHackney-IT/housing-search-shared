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
            var createdDomaninTenuredAsset = TenuredAsset.Create(aQueryableTenuredAsset);

            //assert
            createdDomaninTenuredAsset.FullAddress.Should().Be(aQueryableTenuredAsset.FullAddress);
            createdDomaninTenuredAsset.Uprn.Should().Be(aQueryableTenuredAsset.Uprn);
            createdDomaninTenuredAsset.Id.Should().Be(aQueryableTenuredAsset.Id);
            createdDomaninTenuredAsset.Type.Should().Be(aQueryableTenuredAsset.Type);
            createdDomaninTenuredAsset.IsTemporaryAccommodation.Should().Be(aQueryableTenuredAsset.IsTemporaryAccommodation);
        }
    }
}
