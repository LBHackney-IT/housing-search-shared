﻿using Hackney.Shared.HousingSearch.Gateways.Models.Tenures;

namespace Hackney.Shared.HousingSearch.Domain.Tenure
{
    public class HouseholdMember
    {
        public string FullName { get; set; }
        public bool IsResponsible { get; set; }
        public string DateOfBirth { get; set; }
        public string PersonTenureType { get; set; }
        public string Id { get; set; }
        public string Type { get; set; }

        public static HouseholdMember Create(QueryableHouseholdMember householdMember)
        {
            return new HouseholdMember(householdMember);
        }

        public HouseholdMember()
        {

        }

        private HouseholdMember(QueryableHouseholdMember householdMember)
        {
            FullName = householdMember.FullName;
            IsResponsible = householdMember.IsResponsible;
            DateOfBirth = householdMember.DateOfBirth;
            PersonTenureType = householdMember.PersonTenureType;
            Id = householdMember.Id;
            Type = householdMember.Type;
        }
    }
}
