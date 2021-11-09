using System;
using Hackney.Shared.HousingSearch.Domain.Transactions;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Transactions
{
    public class QueryableSuspenseResolutionInfo
    {
        public SuspenseResolutionInfo Create()
        {
            return new SuspenseResolutionInfo
            {
                Note = Note,
                IsApproved = IsApproved,
                IsConfirmed = IsConfirmed,
                ResolutionDate = ResolutionDate,
            };
        }

        public DateTime? ResolutionDate { get; set; }

        public bool IsConfirmed { get; set; }

        public bool IsApproved { get; set; }

        public string Note { get; set; }
    }
}
