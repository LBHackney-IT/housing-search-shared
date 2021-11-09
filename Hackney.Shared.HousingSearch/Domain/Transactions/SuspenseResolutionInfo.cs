using System;

namespace Hackney.Shared.HousingSearch.Domain.Transactions
{
    public class SuspenseResolutionInfo
    {
        public bool IsResolve => IsConfirmed && IsApproved;

        public DateTime? ResolutionDate { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsApproved { get; set; }
        public string Note { get; set; }
    }
}
