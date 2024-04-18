using System;
using Hackney.Shared.HousingSearch;

namespace Hackney.Shared.HousingSearch.Tests.Helper
{
    public static class Constants
    {
        public const string ID  = "15b191cb-7687-4d68-959e-40db05c27ec3";
        public const string STAROFTENURETDATE = "2023-03-20";
        public const string ENDOFTENUREDATE = "2024-03-20";
        public const string TASTATUS = "MATCHED";
        public static Domain.Tenure.Tenure ConstructTenureFromConstants()
        {
            var entity = new Domain.Tenure.Tenure();
            entity.Id = ID;
            entity.StartOfTenureDate = STAROFTENURETDATE;
            entity.EndOfTenureDate = ENDOFTENUREDATE;
            entity.TemporaryAccommodationInfo =
                new Domain.Tenure.TemporaryAccommodationInfo
                {
                    BookingStatus = TASTATUS
                };
            return entity;
        }
    }
}
