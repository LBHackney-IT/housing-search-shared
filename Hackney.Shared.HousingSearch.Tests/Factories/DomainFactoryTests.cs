using AutoFixture;
using FluentAssertions;
using Hackney.Shared.HousingSearch.Factories;
using Hackney.Shared.HousingSearch.Gateways.Models.Assets;
using Hackney.Shared.HousingSearch.Gateways.Models.Contract;
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

        [Fact]
        public void CanConvertQueryableAssetContractEntityToDomain()
        {
            var queryableAssetContract = _fixture.Create<QueryableAssetContract>();

            var domainContract = queryableAssetContract.ToDomain();

            domainContract.Id.Should().Be(queryableAssetContract.Id);
            domainContract.TargetId.Should().Be(queryableAssetContract.TargetId);
            domainContract.TargetType.Should().Be(queryableAssetContract.TargetType);
            domainContract.StartDate.Should().Be(queryableAssetContract.StartDate);
            domainContract.ApprovalDate.Should().Be(queryableAssetContract.ApprovalDate);
            domainContract.IsApproved.Should().Be(queryableAssetContract.IsApproved);
            domainContract.ApprovalStatus.Should().Be(queryableAssetContract.ApprovalStatus);
            domainContract.ApprovalStatusReason.Should().Be(queryableAssetContract.ApprovalStatusReason);
            domainContract.IsActive.Should().Be(queryableAssetContract.IsActive);
            domainContract.Charges.Should().BeEquivalentTo(queryableAssetContract.Charges);
            domainContract.RelatedPeople.Should().BeEquivalentTo(queryableAssetContract.RelatedPeople);
        }

        [Fact]
        public void CanConvertQueryableChargesEntityToDomain()
        {
            var queryableCharge = _fixture.Create<QueryableCharges>();

            var domainCharge = queryableCharge.ToDomain();

            domainCharge.Id.Should().Be(queryableCharge.Id);
            domainCharge.Type.Should().Be(queryableCharge.Type);
            domainCharge.SubType.Should().Be(queryableCharge.SubType);
            domainCharge.Frequency.Should().Be(queryableCharge.Frequency);
            domainCharge.Amount.Should().Be(queryableCharge.Amount);
        }

        [Fact]
        public void CanConvertQueryableRelatedPeopleEntityToDomain()
        {
            var queryableRelatedPerson = _fixture.Create<QueryableRelatedPeople>();

            var domainRelatedPerson = queryableRelatedPerson.ToDomain();

            domainRelatedPerson.Id.Should().Be(queryableRelatedPerson.Id);
            domainRelatedPerson.Type.Should().Be(queryableRelatedPerson.Type);
            domainRelatedPerson.SubType.Should().Be(queryableRelatedPerson.SubType);
            domainRelatedPerson.Name.Should().Be(queryableRelatedPerson.Name);
        }
    }
}