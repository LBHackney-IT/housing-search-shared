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
            createdDomaninTenure.TenuredAsset.Should().Be(aQueryableTenure.TenuredAsset);

        }
    }
}
