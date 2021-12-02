using Hackney.Shared.HousingSearch.Domain.Transactions;
using Nest;
using System;

namespace Hackney.Shared.HousingSearch.Gateways.Models.Transactions
{
    public class QueryableTransaction
    {
        public Transaction ToTransaction()
        {
            return Transaction.Create(Id, TargetId, TargetType, PeriodNo, FinancialYear, FinancialMonth,
                TransactionSource, TransactionType, TransactionDate, TransactionAmount, PaymentReference,
                BankAccountNumber, IsSuspense, SuspenseResolutionInfo?.ToSuspenseResolutionInfo(), PaidAmount, ChargedAmount,
                BalanceAmount, HousingBenefitAmount, Address, Sender?.ToSender(), Fund, CreatedAt, CreatedBy, LastUpdatedAt, LastUpdatedBy);
        }

        [Text(Name = "id")]
        public Guid Id { get; set; }

        [Text(Name = "targetId")]
        public Guid TargetId { get; set; }

        [Text(Name = "targetType")]
        public TargetType TargetType { get; set; }

        [Text(Name = "periodNo")]
        public short PeriodNo { get; set; }

        [Text(Name = "financialYear")]
        private short FinancialYear { get; set; }

        [Text(Name = "financialMonth")]
        public short FinancialMonth { get; set; }

        [Text(Name = "transactionSource")]
        public string TransactionSource { get; set; }

        [Text(Name = "transactionType")]
        public TransactionType TransactionType { get; set; }

        [Date(Name = "transactionDate")]
        public DateTime TransactionDate { get; set; }

        [Text(Name = "transactionAmount")]
        public decimal TransactionAmount { get; set; }

        [Text(Name = "paymentReference")]
        public string PaymentReference { get; set; }

        [Text(Name = "bankAccountNumber")]
        public string BankAccountNumber { get; set; }

        [Text(Name = "isSuspense")]
        public bool IsSuspense { get; set; }

        [Text(Name = "suspenseResolutionInfo")]
        public QueryableSuspenseResolutionInfo SuspenseResolutionInfo { get; set; }

        [Text(Name = "paidAmount")]
        public decimal PaidAmount { get; set; }

        [Text(Name = "chargedAmount")]
        public decimal ChargedAmount { get; set; }

        [Text(Name = "balanceAmount")]
        public decimal BalanceAmount { get; set; }

        [Text(Name = "housingBenefitAmount")]
        public decimal HousingBenefitAmount { get; set; }

        [Text(Name = "address")]
        public string Address { get; set; }

        [Text(Name = "sender")]
        public QueryableSender Sender { get; set; }

        [Text(Name = "fund")]
        public string Fund { get; set; }

        [Text(Name = "lastUpdatedBy")]
        public string LastUpdatedBy { get; set; }

        [Date(Name = "lastUpdatedAt")]
        public DateTime? LastUpdatedAt { get; set; }

        [Date(Name = "createdAt")]
        public DateTime CreatedAt { get; set; }

        [Text(Name = "createdBy")]
        public string CreatedBy { get; set; }
    }
}
