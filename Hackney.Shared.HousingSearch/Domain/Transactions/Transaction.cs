using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Hackney.Shared.HousingSearch.Domain.Transactions
{
    public class Transaction
    {
        public static Transaction Create(Guid id, Guid targetId, TargetType targetType, short periodNo, short financialYear,
            short financialMonth,
            string transactionSource, TransactionType transactionType, DateTime transactionDate,
            decimal transactionAmount, string paymentReference,
            string bankAccountNumber, bool isSuspense, SuspenseResolutionInfo suspenseResolutionInfo,
            decimal paidAmount, decimal chargedAmount,
            decimal balanceAmount, decimal housingBenefitAmount, string address, Sender sender, string fund)
        {
            return new Transaction(id, targetId, targetType, periodNo, financialYear, financialMonth,
                transactionSource, transactionType, transactionDate, transactionAmount, paymentReference,
                bankAccountNumber, isSuspense, suspenseResolutionInfo, paidAmount, chargedAmount,
                balanceAmount, housingBenefitAmount, address, sender, fund);
        }

        private Transaction(Guid id, Guid targetId, TargetType targetType, short periodNo, short financialYear, short financialMonth,
            string transactionSource, TransactionType transactionType, DateTime transactionDate, decimal transactionAmount, string paymentReference,
            string bankAccountNumber, bool isSuspense, SuspenseResolutionInfo suspenseResolutionInfo, decimal paidAmount, decimal chargedAmount,
            decimal balanceAmount, decimal housingBenefitAmount, string address, Sender sender, string fund)
        {
            Id = id;
            TargetId = targetId;
            TargetType = targetType;
            PeriodNo = periodNo;
            FinancialYear = financialYear;
            FinancialMonth = financialMonth;
            TransactionSource = transactionSource;
            TransactionType = transactionType;
            TransactionDate = transactionDate;
            TransactionAmount = transactionAmount;
            PaymentReference = paymentReference;
            BankAccountNumber = bankAccountNumber;
            IsSuspense = isSuspense;
            SuspenseResolutionInfo = suspenseResolutionInfo;
            PaidAmount = paidAmount;
            ChargedAmount = chargedAmount;
            BalanceAmount = balanceAmount;
            HousingBenefitAmount = housingBenefitAmount;
            Address = address;
            Sender = sender;
            Fund = fund;
        }

        public Guid Id { get; }

        /// <summary>
        /// The guid of a tenancy/property
        /// </summary>
        public Guid TargetId { get; }

        /// <summary>
        ///     The target of provided id by target_id
        /// </summary>
        public TargetType TargetType { get; }

        /// <summary>
        /// Week number for Rent and Period number for LeaseHolders
        /// </summary>
        public short PeriodNo { get; }

        public short FinancialYear { get; }

        public short FinancialMonth { get; }

        public string TransactionSource { get; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TransactionType TransactionType { get; set; }

        public DateTime TransactionDate { get; }


        public decimal TransactionAmount { get; }

        /// <summary>
        /// Same as Rent Account Number
        /// </summary>
        public string PaymentReference { get; }

        /// <summary>
        /// Partially filled bank account number
        /// </summary>
        public string BankAccountNumber { get; }

        /// <summary>
        /// Is this account need to be in suspense
        /// </summary>
        public bool IsSuspense { get; }

        /// <summary>
        /// Information after this record ceases to be suspense
        /// </summary>
        public SuspenseResolutionInfo SuspenseResolutionInfo { get; }

        public decimal PaidAmount { get; }

        public decimal ChargedAmount { get; }

        public decimal BalanceAmount { get; }

        /// <summary>
        /// Housing Benefit Contribution
        /// </summary>
        public decimal HousingBenefitAmount { get; }

        public string Address { get; }

        /// <summary>
        /// Person, who paid for the transaction
        /// </summary>
        public Sender Sender { get; }

        public string Fund { get; }
    }
}
