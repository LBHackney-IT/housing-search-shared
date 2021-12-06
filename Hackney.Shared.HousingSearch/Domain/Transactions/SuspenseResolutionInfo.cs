using System;

namespace Hackney.Shared.HousingSearch.Domain.Transactions
{
    public class SuspenseResolutionInfo
    {
        public SuspenseResolutionInfo() { }
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

        public DateTime? ResolutionDate { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsApproved { get; set; }
        public string Note { get; set; }
    }
}
