﻿using Hackney.Shared.HousingSearch.Gateways.Models.Tenures;

namespace Hackney.Shared.HousingSearch.Domain.Tenure
{
    public class TenuredAsset
    {
        public string FullAddress { get; set; }
        public string Uprn { get; set; }
        public string Id { get; set; }
        public string Type { get; set; }
        public bool? IsTemporaryAccommodation { get; set; }

        public static TenuredAsset Create(QueryableTenuredAsset tenuredAsset)
        {
            return new TenuredAsset(tenuredAsset);
        }

        public TenuredAsset()
        {

        }

        private TenuredAsset(QueryableTenuredAsset tenuredAsset)
        {
            FullAddress = tenuredAsset?.FullAddress;
            Uprn = tenuredAsset?.Uprn;
            Id = tenuredAsset?.Id;
            Type = tenuredAsset?.Type;
            IsTemporaryAccommodation = tenuredAsset?.IsTemporaryAccommodation;
        }
    }
}
