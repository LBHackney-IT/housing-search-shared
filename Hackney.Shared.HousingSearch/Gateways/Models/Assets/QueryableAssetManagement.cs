﻿using System;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Assets
{
    public class QueryableAssetManagement
    {
        public string Agent { get; set; }
        public string AreaOfficeName { get; set; }
        public bool IsCouncilProperty { get; set; }
        public string ManagingOrganisation { get; set; }
        public Guid ManagingOrganisationId { get; set; }
        public string Owner { get; set; }
        public bool IsTMOManaged { get; set; }
        public string PropertyOccupiedStatus { get; set; }
        public bool IsNoRepairsMaintenance { get; set; }
        public bool IsTemporaryAccomodation { get; set; }
        public bool? IsTemporaryAccommodationBlock { get; set; }
        public Guid? TemporaryAccommodationParentAssetId { get; set; }
        public bool? IsPartOfTemporaryAccommodationBlock { get; set; }
    }
}
