using System;
using Nest;
using Hackney.Shared.HousingSearch.Domain.Transactions;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Transactions
{
    public class QueryableSuspenseResolutionInfo
    {
        public SuspenseResolutionInfo Create()
        {
            return SuspenseResolutionInfo.Create(ResolutionDate, IsConfirmed, IsApproved, Note);
        }

        [Date(Name = "resolutionDate")]
        public DateTime? ResolutionDate { get; set; }

        [Boolean(Name = "isConfirmed")]
        public bool IsConfirmed { get; set; }

        [Boolean(Name = "isApproved")]
        public bool IsApproved { get; set; }

        [Text(Name = "note")]
        public string Note { get; set; }
    }
}
