using System;

namespace Hackney.Shared.HousingSearch.Domain.Transactions
{
    public class SuspenseResolutionInfo
    {
        public static SuspenseResolutionInfo Create(DateTime? resolutionDate, bool isConfirmed, bool isApproved, string note)
            => new SuspenseResolutionInfo(resolutionDate, isConfirmed, isApproved, note);

        private SuspenseResolutionInfo(DateTime? resolutionDate, bool isConfirmed, bool isApproved, string note)
        {
            ResolutionDate = resolutionDate;
            IsConfirmed = isConfirmed;
            IsApproved = isApproved;
            Note = note;
        }

        public bool IsResolve => IsConfirmed && IsApproved;

        public DateTime? ResolutionDate { get; }
        public bool IsConfirmed { get; }
        public bool IsApproved { get; }
        public string Note { get; }
    }
}
